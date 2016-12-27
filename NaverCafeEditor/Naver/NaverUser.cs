using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text;
using Noesis.Javascript;
using CsQuery;

namespace Naver
{
	class NaverUser
	{
		Dictionary<string, string> dic; // 카페 이름, 카페 주소
		CookieCollection Cookies;

		public bool Login(string id, string password)
        {
            // make key
            List<string> keys = new List<string>();
            using (WebClient webClient = new WebClient())
            {
                string key = webClient.DownloadString("http://static.nid.naver.com/enclogin/keys.nhn");
                keys.AddRange(key.Split(','));
            }

            // make request
            HttpWebRequest request = WebRequest.Create("https://nid.naver.com/nidlogin.login") as HttpWebRequest;
            request.CookieContainer = new CookieContainer();
            request.Method = "POST";
            request.Referer = "http://static.nid.naver.com/login.nhn?svc=wme&amp;url=http%3A%2F%2Fwww.naver.com&amp;t=20120425";
            request.UserAgent = "Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; Trident/6.0)";
            request.ContentType = "application/x-www-form-urlencoded";

            using (Stream stream = request.GetRequestStream())
            {
                using (StreamWriter writer = new StreamWriter(stream))
                {
                    writer.Write($"enctp=1&encpw={ CreateRSA(id, password, keys) }&encnm={ keys[1] }&svctype=0&id=&pw=&x=35&y=14");
                    writer.Flush();
                }
                stream.Flush();
            }

            // get resposce 
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    string result = reader.ReadToEnd();

                    if (result.Contains("해외 IP 차단 기능을 사용중입니다."))
                    {
                        throw new WebException("해외 IP 차단 기능을 사용중입니다. 해외 VPN을 사용중인지 확인해주세요.");
                    }

                    if (result.Contains("location.replace"))
                    {
						Cookies = response.Cookies;
						return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

		public async Task<Dictionary<string, string>> LoadCafeList()
		{
			if(IsLoggedin)
			{
				return await Task.Run(() =>
				{
					if (dic == null)
					{
						dic = new Dictionary<string, string>();

						for (int i = 1; i <= CafePaginate; i++)
						{
							FindJoinedCafe($"http://section.cafe.naver.com/JoinCafeList.nhn?search.groupid=0&search.sortby=clubname&search.page={i}", dic);
						}
					}
					return dic;
				});
			}
			else
			{
				return null;
			}
		}

		private Stream GetHtmlStream(string url)
		{
			HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
			request.CookieContainer = new CookieContainer();
			request.CookieContainer.Add(Cookies);

			HttpWebResponse response = request.GetResponse() as HttpWebResponse;
			return response.GetResponseStream();
		}

		private int CafePaginate
		{
			get
			{
				using (Stream stream = GetHtmlStream("http://section.cafe.naver.com/JoinCafeList.nhn?search.sortby=clubname"))
				{
					var document = CQ.Create(stream, Encoding.UTF8);
					return document.Find(".paginate")[0].ChildElements.Count();
				}
			}
		}

		private bool IsLoggedin
		{
			get
			{
				return Cookies != null;
			}
		}

		private void FindJoinedCafe(string url, Dictionary<string, string> dic)
		{
			using (Stream stream = GetHtmlStream(url))
			{
				// HTML 
				var document = CQ.Create(stream, Encoding.UTF8);
				var table = document.Find("table tbody")[0];
				
				foreach (var item in table.ChildElements)
				{
					var temp = item.Cq().Find("a")[0];
					dic.Add(temp["title"], temp["href"]);
				}
			}
		}

		private string CreateRSA(string id, string password, List<string> keys)
        {
            using (JavascriptContext context = new JavascriptContext())
            {
                // set parameters
                context.SetParameter("vvv_id", id);
                context.SetParameter("vvv_pw", password);
                for (int i = 0; i < 4; i++)
                {
                    context.SetParameter("vvv_" + i, keys[i]);
                }
                context.SetParameter("vvv_Resu", string.Empty);

                // make script
                string script = NaverCafeEditor.Properties.Resources.RSAJS;
                script += "\n\nvvv_Resu = createRsaKey(vvv_id,vvv_pw,vvv_0,vvv_1,vvv_2,vvv_3);";

                // run
                try
                {
                    context.Run(script);
                }
                catch (JavascriptException) { }

                // return rsa
                return context.GetParameter("vvv_Resu") as string;
            }
        }
	}
}
