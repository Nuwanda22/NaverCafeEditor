namespace NaverCafeEditor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.LoginButton = new System.Windows.Forms.Button();
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.UserDataGridView = new System.Windows.Forms.DataGridView();
			this.UserOnColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.IDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.PasswordColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.CafeDataGridView = new System.Windows.Forms.DataGridView();
			this.CafeOnColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LinkColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MenuStrip.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.CafeDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// LoginButton
			// 
			this.LoginButton.Location = new System.Drawing.Point(526, 100);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(75, 23);
			this.LoginButton.TabIndex = 0;
			this.LoginButton.Text = "글 수정";
			this.LoginButton.UseVisualStyleBackColor = true;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// MenuStrip
			// 
			this.MenuStrip.BackColor = System.Drawing.Color.White;
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Size = new System.Drawing.Size(671, 24);
			this.MenuStrip.TabIndex = 3;
			this.MenuStrip.Text = "MenuStrip";
			// 
			// FileToolStripMenuItem
			// 
			this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadToolStripMenuItem});
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.FileToolStripMenuItem.Text = "파일(&F)";
			// 
			// LoadToolStripMenuItem
			// 
			this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
			this.LoadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.LoadToolStripMenuItem.Text = "불러오기";
			this.LoadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
			// 
			// OpenFileDialog
			// 
			this.OpenFileDialog.Filter = "텍스트 파일 (*.txt)|*.txt|모든 파일 (*.*)|*.*";
			// 
			// UserDataGridView
			// 
			this.UserDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.UserDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.UserDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserOnColumn,
            this.IDColumn,
            this.PasswordColumn});
			this.UserDataGridView.EnableHeadersVisualStyles = false;
			this.UserDataGridView.Location = new System.Drawing.Point(12, 38);
			this.UserDataGridView.Name = "UserDataGridView";
			this.UserDataGridView.RowHeadersVisible = false;
			this.UserDataGridView.RowTemplate.Height = 23;
			this.UserDataGridView.Size = new System.Drawing.Size(465, 150);
			this.UserDataGridView.TabIndex = 7;
			this.UserDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
			// 
			// UserOnColumn
			// 
			this.UserOnColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.UserOnColumn.HeaderText = "ON";
			this.UserOnColumn.Name = "UserOnColumn";
			this.UserOnColumn.Width = 29;
			// 
			// IDColumn
			// 
			this.IDColumn.HeaderText = "아이디";
			this.IDColumn.Name = "IDColumn";
			// 
			// PasswordColumn
			// 
			this.PasswordColumn.HeaderText = "비밀번호";
			this.PasswordColumn.Name = "PasswordColumn";
			// 
			// CafeDataGridView
			// 
			this.CafeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.CafeDataGridView.BackgroundColor = System.Drawing.Color.White;
			this.CafeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CafeOnColumn,
            this.NameColumn,
            this.LinkColumn});
			this.CafeDataGridView.EnableHeadersVisualStyles = false;
			this.CafeDataGridView.Location = new System.Drawing.Point(12, 206);
			this.CafeDataGridView.Name = "CafeDataGridView";
			this.CafeDataGridView.RowHeadersVisible = false;
			this.CafeDataGridView.RowTemplate.Height = 23;
			this.CafeDataGridView.Size = new System.Drawing.Size(644, 195);
			this.CafeDataGridView.TabIndex = 8;
			this.CafeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
			// 
			// CafeOnColumn
			// 
			this.CafeOnColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.CafeOnColumn.HeaderText = "ON";
			this.CafeOnColumn.Name = "CafeOnColumn";
			this.CafeOnColumn.Width = 29;
			// 
			// NameColumn
			// 
			this.NameColumn.HeaderText = "카페 이름";
			this.NameColumn.Name = "NameColumn";
			// 
			// LinkColumn
			// 
			this.LinkColumn.HeaderText = "글 주소";
			this.LinkColumn.Name = "LinkColumn";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(671, 413);
			this.Controls.Add(this.LoginButton);
			this.Controls.Add(this.CafeDataGridView);
			this.Controls.Add(this.UserDataGridView);
			this.Controls.Add(this.MenuStrip);
			this.MainMenuStrip = this.MenuStrip;
			this.Name = "MainForm";
			this.Text = "네이버";
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.UserDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.CafeDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.MenuStrip MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog OpenFileDialog;
		private System.Windows.Forms.ToolStripMenuItem LoadToolStripMenuItem;
		private System.Windows.Forms.DataGridView UserDataGridView;
		private System.Windows.Forms.DataGridView CafeDataGridView;
		private System.Windows.Forms.DataGridViewCheckBoxColumn CafeOnColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn LinkColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn UserOnColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn IDColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn PasswordColumn;
	}
}