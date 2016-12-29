using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net;

namespace NaverCafeEditor
{
	public partial class EditorForm : Form
	{
		string PostUrl;
		CookieCollection Cookies;

		public EditorForm(string postUrl, CookieCollection cookies)
		{
			InitializeComponent();
			
			PostUrl = postUrl;
			Cookies = cookies;
		}

		[DllImport("wininet.dll", CharSet = CharSet.Auto, SetLastError = true)]
		static extern bool InternetSetCookie(string lpszUrlName, string lpszCookieName, string lpszCookieData);

		private void WebBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
		{
			if (e.Url.AbsoluteUri == PostUrl)
			{
				HtmlDocument document = WebBrowser.Document;
				HtmlElement head = document.GetElementsByTagName("head")[0];
				HtmlElement script = document.CreateElement("script");
				script.SetAttribute("text",
					@"function redirectToEditor() { 
						document.getElementById('cafe_main').contentDocument.getElementById('modifyFormLink').click();
					}");
				head.AppendChild(script);
				document.InvokeScript("redirectToEditor");
				MessageBox.Show(WebBrowser.DocumentText);
				//WebBrowser.Document.Body.Style = "overflow:hidden";
			}
		}

		private void EditorForm_Load(object sender, EventArgs e)
		{
			string cafeUrl = PostUrl.Substring(0, PostUrl.LastIndexOf('/'));

			foreach (Cookie cookie in Cookies)
			{
				InternetSetCookie(cafeUrl, cookie.Name, cookie.Value);
			}

			WebBrowser.Navigate(cafeUrl);
			WebBrowser.Navigate(PostUrl);
		}

		private void EditorForm_Resize(object sender, EventArgs e)
		{
			System.Diagnostics.Debug.WriteLine(Size.ToString());
		}
	}
}
