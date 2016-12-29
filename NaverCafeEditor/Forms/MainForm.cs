using System;
using System.Net;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
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

        private async void LoginButton_Click(object sender, EventArgs e)
        {
			// 선택된 로우들을 가져옴
			var selectedUser = UserDataGridView.GetSelectedRow();
			var selectedCafe = CafeDataGridView.GetSelectedRow();

			// 선택된 로우가 없을 경우 예외처리
			if (selectedUser == null) { MessageBox.Show("계정이 선택되지 않았습니다."); return; }
			else if(selectedCafe == null) { MessageBox.Show("카페 글이 선택되지 않았습니다."); return; }

			// 계정 로우를 통해 아이디와 비밀번호를 가져옴
			string id = selectedUser.Cells["IDColumn"].Value as string;
			string password = selectedUser.Cells["PasswordColumn"].Value as string;

			// 아이디와 비밀번호가 빈칸일 경우 예외처리
			if (string.IsNullOrWhiteSpace(id)) { MessageBox.Show("아이디를 입력해주세요."); return; }
			else if(string.IsNullOrWhiteSpace(password)) { MessageBox.Show("비밀번호를 입력해주세요."); return; }

			// 로그인
			if(Login(id, password))
			{
				// 성공했을 경우 접속할 글의 주소를 가져옴
				string url = selectedCafe.Cells["LinkColumn"].Value as string;

				// 카페에 가입되어 있지 않을 경우 예외처리
				if (Cafe == null) Cafe = await User.LoadCafeList();
				if (!isMember(url)) { MessageBox.Show("선택한 카페에 가입되어 있지 않습니다."); return; }

				// 에디터 창을 열음
				new EditorForm(url, User.Cookies).Show();
			}
			else
			{
				// 실패했을 경우 예외처리
				MessageBox.Show("아이디와 비밀번호가 올바른지 확인해주세요.", "로그인에 실패했습니다.");
			}
		}

		private bool Login(string id, string password)
		{
			bool isFirst = true;
		Second:
			if (LoginSucceeded = User.Login(id, password))
			{
				return true;
			}
			else
			{
				if (isFirst)
				{
					isFirst = false;
					goto Second;
				}
				else
				{
					return false;
				}
			}
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

		private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(OpenFileDialog.ShowDialog() == DialogResult.OK)
			{
				foreach (var item in File.ReadAllLines(OpenFileDialog.FileName, Encoding.Default))
				{
					var a = item.Split('\t');
					CafeDataGridView.Rows.Add(false, a[5], a[4]);
				}
			}
		}

		private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			var dataGridView = sender as DataGridView;

			if (e.ColumnIndex == 0)
			{
				int currentRow = e.RowIndex;

				foreach(DataGridViewRow row in dataGridView.Rows)
				{
					if (row.Cells[0].Value == null) continue;

					var cell = row.Cells[0] as DataGridViewCheckBoxCell;
					cell.Value = false;
				}

				dataGridView.Rows[currentRow].Cells[0].Value = true;
			}
		}
	}

	static partial class Extension
	{
		public static DataGridViewRow GetSelectedRow(this DataGridView dataGridView)
		{
			DataGridViewRow selectedRow = null;

			foreach (DataGridViewRow row in dataGridView.Rows)
			{
				if (row.Cells[0].Value == null) break;

				else if ((bool)row.Cells[0].Value)
				{
					selectedRow = row;
					break;
				}
			}

			return selectedRow;
		}
	}
}