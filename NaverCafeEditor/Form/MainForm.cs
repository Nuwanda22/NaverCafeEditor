using System;
using System.Net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Naver;

namespace NaverCafeEditor
{
    public partial class MainForm : Form
    {
		bool LoginSucceeded;
		NaverUser User;
		Dictionary<string, string> Cafe;

		public MainForm()
        {
            InitializeComponent();
			User = new NaverUser();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
			if (LoginSucceeded = User.Login(IDTextBox.Text, PasswordTextBox.Text))
			{
				MessageBox.Show("성공");
			}
			else
			{
				MessageBox.Show("다시 로그인해주세요");
				PasswordTextBox.Text = string.Empty;
			}
        }

		private async void OKButton_Click(object sender, EventArgs e)
		{
			if (Cafe == null) Cafe = await User.LoadCafeList();
			
			MessageBox.Show(isMember(LinkTextBox.Text).ToString());
		}

		private bool isMember(string cafeUrl)
		{
			bool isMember = false;
			foreach (var item in Cafe)
			{
				if (cafeUrl.Contains(item.Value))
				{
					isMember = true;
					break;
				}
			}

			return isMember;
		}
	}
}