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
			this.IDTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.MenuStrip = new System.Windows.Forms.MenuStrip();
			this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.LoginPanel = new System.Windows.Forms.Panel();
			this.OKButton = new System.Windows.Forms.Button();
			this.LinkTextBox = new System.Windows.Forms.TextBox();
			this.MenuStrip.SuspendLayout();
			this.LoginPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// LoginButton
			// 
			this.LoginButton.Location = new System.Drawing.Point(123, 37);
			this.LoginButton.Name = "LoginButton";
			this.LoginButton.Size = new System.Drawing.Size(75, 23);
			this.LoginButton.TabIndex = 0;
			this.LoginButton.Text = "Login";
			this.LoginButton.UseVisualStyleBackColor = true;
			this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// IDTextBox
			// 
			this.IDTextBox.Location = new System.Drawing.Point(17, 27);
			this.IDTextBox.Name = "IDTextBox";
			this.IDTextBox.Size = new System.Drawing.Size(100, 21);
			this.IDTextBox.TabIndex = 1;
			this.IDTextBox.Text = "ko997ko";
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Location = new System.Drawing.Point(17, 54);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.PasswordChar = '*';
			this.PasswordTextBox.Size = new System.Drawing.Size(100, 21);
			this.PasswordTextBox.TabIndex = 2;
			this.PasswordTextBox.Text = "22fliris1869";
			// 
			// MenuStrip
			// 
			this.MenuStrip.BackColor = System.Drawing.Color.White;
			this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem});
			this.MenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip.Name = "MenuStrip";
			this.MenuStrip.Size = new System.Drawing.Size(696, 24);
			this.MenuStrip.TabIndex = 3;
			this.MenuStrip.Text = "MenuStrip";
			// 
			// FileToolStripMenuItem
			// 
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
			this.FileToolStripMenuItem.Text = "파일(&F)";
			// 
			// LoginPanel
			// 
			this.LoginPanel.Controls.Add(this.LoginButton);
			this.LoginPanel.Controls.Add(this.PasswordTextBox);
			this.LoginPanel.Controls.Add(this.IDTextBox);
			this.LoginPanel.Location = new System.Drawing.Point(12, 43);
			this.LoginPanel.Name = "LoginPanel";
			this.LoginPanel.Size = new System.Drawing.Size(210, 100);
			this.LoginPanel.TabIndex = 4;
			// 
			// OKButton
			// 
			this.OKButton.Location = new System.Drawing.Point(542, 80);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(75, 23);
			this.OKButton.TabIndex = 5;
			this.OKButton.Text = "OK";
			this.OKButton.UseVisualStyleBackColor = true;
			this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
			// 
			// LinkTextBox
			// 
			this.LinkTextBox.Location = new System.Drawing.Point(312, 82);
			this.LinkTextBox.Name = "LinkTextBox";
			this.LinkTextBox.Size = new System.Drawing.Size(224, 21);
			this.LinkTextBox.TabIndex = 6;
			this.LinkTextBox.Text = "http://cafe.naver.com/onlyonedsm";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(696, 298);
			this.Controls.Add(this.LinkTextBox);
			this.Controls.Add(this.OKButton);
			this.Controls.Add(this.LoginPanel);
			this.Controls.Add(this.MenuStrip);
			this.MainMenuStrip = this.MenuStrip;
			this.Name = "MainForm";
			this.Text = "네이버";
			this.MenuStrip.ResumeLayout(false);
			this.MenuStrip.PerformLayout();
			this.LoginPanel.ResumeLayout(false);
			this.LoginPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginButton;
		private System.Windows.Forms.TextBox IDTextBox;
		private System.Windows.Forms.TextBox PasswordTextBox;
		private System.Windows.Forms.MenuStrip MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
		private System.Windows.Forms.Panel LoginPanel;
		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.TextBox LinkTextBox;
	}
}