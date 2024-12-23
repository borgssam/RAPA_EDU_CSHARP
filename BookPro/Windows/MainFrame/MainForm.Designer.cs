﻿namespace BookPro
{
  partial class MainForm
  {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.MainMenubar = new System.Windows.Forms.MenuStrip();
			this.mbtn_file = new System.Windows.Forms.ToolStripMenuItem();
			this.mbtn_login = new System.Windows.Forms.ToolStripMenuItem();
			this.mbtn_logout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.mbtn_exit = new System.Windows.Forms.ToolStripMenuItem();
			this.mbtn_work = new System.Windows.Forms.ToolStripMenuItem();
			this.mbtn_staff = new System.Windows.Forms.ToolStripMenuItem();
			this.mbtn_member = new System.Windows.Forms.ToolStripMenuItem();
			this.mbtn_book = new System.Windows.Forms.ToolStripMenuItem();
			this.mbtn_rent = new System.Windows.Forms.ToolStripMenuItem();
			this.mbtn_tool = new System.Windows.Forms.ToolStripMenuItem();
			this.mbtn_setting = new System.Windows.Forms.ToolStripMenuItem();
			this.MainToolbar = new System.Windows.Forms.ToolStrip();
			this.tbtn_exit = new System.Windows.Forms.ToolStripButton();
			this.tbtn_book = new System.Windows.Forms.ToolStripButton();
			this.tbtn_member = new System.Windows.Forms.ToolStripButton();
			this.tbtn_rent = new System.Windows.Forms.ToolStripButton();
			this.MainStatusbar = new System.Windows.Forms.StatusStrip();
			this.panel1 = new System.Windows.Forms.Panel();
			this.work_space = new System.Windows.Forms.Panel();
			this.MainMenubar.SuspendLayout();
			this.MainToolbar.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// MainMenubar
			// 
			this.MainMenubar.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MainMenubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtn_file,
            this.mbtn_work,
            this.mbtn_tool});
			this.MainMenubar.Location = new System.Drawing.Point(0, 0);
			this.MainMenubar.Name = "MainMenubar";
			this.MainMenubar.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
			this.MainMenubar.Size = new System.Drawing.Size(1199, 24);
			this.MainMenubar.TabIndex = 0;
			this.MainMenubar.Text = "menuStrip1";
			// 
			// mbtn_file
			// 
			this.mbtn_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtn_login,
            this.mbtn_logout,
            this.toolStripMenuItem1,
            this.mbtn_exit});
			this.mbtn_file.Name = "mbtn_file";
			this.mbtn_file.Size = new System.Drawing.Size(43, 20);
			this.mbtn_file.Text = "파일";
			// 
			// mbtn_login
			// 
			this.mbtn_login.Name = "mbtn_login";
			this.mbtn_login.Size = new System.Drawing.Size(122, 22);
			this.mbtn_login.Text = "로그인";
			this.mbtn_login.Click += new System.EventHandler(this.mbtn_login_Click);
			// 
			// mbtn_logout
			// 
			this.mbtn_logout.Name = "mbtn_logout";
			this.mbtn_logout.Size = new System.Drawing.Size(122, 22);
			this.mbtn_logout.Text = "로그아웃";
			this.mbtn_logout.Click += new System.EventHandler(this.mbtn_logout_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(119, 6);
			// 
			// mbtn_exit
			// 
			this.mbtn_exit.Name = "mbtn_exit";
			this.mbtn_exit.Size = new System.Drawing.Size(122, 22);
			this.mbtn_exit.Text = "종료";
			this.mbtn_exit.Click += new System.EventHandler(this.mbtn_exit_Click);
			// 
			// mbtn_work
			// 
			this.mbtn_work.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtn_staff,
            this.mbtn_member,
            this.mbtn_book,
            this.mbtn_rent});
			this.mbtn_work.Name = "mbtn_work";
			this.mbtn_work.Size = new System.Drawing.Size(43, 20);
			this.mbtn_work.Text = "작업";
			// 
			// mbtn_staff
			// 
			this.mbtn_staff.Name = "mbtn_staff";
			this.mbtn_staff.Size = new System.Drawing.Size(122, 22);
			this.mbtn_staff.Text = "사원관리";
			this.mbtn_staff.Click += new System.EventHandler(this.mbtn_staff_Click);
			// 
			// mbtn_member
			// 
			this.mbtn_member.Name = "mbtn_member";
			this.mbtn_member.Size = new System.Drawing.Size(122, 22);
			this.mbtn_member.Text = "회원관리";
			this.mbtn_member.Click += new System.EventHandler(this.mbtn_member_Click);
			// 
			// mbtn_book
			// 
			this.mbtn_book.Name = "mbtn_book";
			this.mbtn_book.Size = new System.Drawing.Size(122, 22);
			this.mbtn_book.Text = "도서관리";
			this.mbtn_book.Click += new System.EventHandler(this.mbtn_book_Click);
			// 
			// mbtn_rent
			// 
			this.mbtn_rent.Name = "mbtn_rent";
			this.mbtn_rent.Size = new System.Drawing.Size(122, 22);
			this.mbtn_rent.Text = "대여관리";
			this.mbtn_rent.Click += new System.EventHandler(this.mbtn_rent_Click);
			// 
			// mbtn_tool
			// 
			this.mbtn_tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtn_setting});
			this.mbtn_tool.Name = "mbtn_tool";
			this.mbtn_tool.Size = new System.Drawing.Size(43, 20);
			this.mbtn_tool.Text = "도구";
			this.mbtn_tool.Click += new System.EventHandler(this.mbtn_tool_Click);
			// 
			// mbtn_setting
			// 
			this.mbtn_setting.Name = "mbtn_setting";
			this.mbtn_setting.Size = new System.Drawing.Size(122, 22);
			this.mbtn_setting.Text = "환경설정";
			this.mbtn_setting.Click += new System.EventHandler(this.mbtn_setting_Click);
			// 
			// MainToolbar
			// 
			this.MainToolbar.AutoSize = false;
			this.MainToolbar.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MainToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtn_exit,
            this.tbtn_book,
            this.tbtn_member,
            this.tbtn_rent});
			this.MainToolbar.Location = new System.Drawing.Point(0, 24);
			this.MainToolbar.Name = "MainToolbar";
			this.MainToolbar.Size = new System.Drawing.Size(1199, 41);
			this.MainToolbar.TabIndex = 1;
			this.MainToolbar.Text = "toolStrip1";
			// 
			// tbtn_exit
			// 
			this.tbtn_exit.AutoSize = false;
			this.tbtn_exit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbtn_exit.Image = ((System.Drawing.Image)(resources.GetObject("tbtn_exit.Image")));
			this.tbtn_exit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbtn_exit.Name = "tbtn_exit";
			this.tbtn_exit.Size = new System.Drawing.Size(39, 39);
			this.tbtn_exit.Text = "종료";
			this.tbtn_exit.Click += new System.EventHandler(this.tbtn_exit_Click);
			// 
			// tbtn_book
			// 
			this.tbtn_book.AutoSize = false;
			this.tbtn_book.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbtn_book.Image = ((System.Drawing.Image)(resources.GetObject("tbtn_book.Image")));
			this.tbtn_book.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbtn_book.Name = "tbtn_book";
			this.tbtn_book.Size = new System.Drawing.Size(39, 39);
			this.tbtn_book.Text = "도서관리";
			this.tbtn_book.Click += new System.EventHandler(this.tbtn_book_Click);
			// 
			// tbtn_member
			// 
			this.tbtn_member.AutoSize = false;
			this.tbtn_member.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbtn_member.Image = ((System.Drawing.Image)(resources.GetObject("tbtn_member.Image")));
			this.tbtn_member.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbtn_member.Name = "tbtn_member";
			this.tbtn_member.Size = new System.Drawing.Size(39, 39);
			this.tbtn_member.Text = "회원관리";
			this.tbtn_member.Click += new System.EventHandler(this.tbtn_member_Click);
			// 
			// tbtn_rent
			// 
			this.tbtn_rent.AutoSize = false;
			this.tbtn_rent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tbtn_rent.Image = ((System.Drawing.Image)(resources.GetObject("tbtn_rent.Image")));
			this.tbtn_rent.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tbtn_rent.Name = "tbtn_rent";
			this.tbtn_rent.Size = new System.Drawing.Size(39, 39);
			this.tbtn_rent.Text = "대여관리";
			this.tbtn_rent.Click += new System.EventHandler(this.tbtn_rent_Click);
			// 
			// MainStatusbar
			// 
			this.MainStatusbar.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.MainStatusbar.Location = new System.Drawing.Point(0, 483);
			this.MainStatusbar.Name = "MainStatusbar";
			this.MainStatusbar.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
			this.MainStatusbar.Size = new System.Drawing.Size(1199, 22);
			this.MainStatusbar.TabIndex = 2;
			this.MainStatusbar.Text = "statusStrip1";
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.work_space);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 65);
			this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1199, 418);
			this.panel1.TabIndex = 3;
			// 
			// work_space
			// 
			this.work_space.BackColor = System.Drawing.SystemColors.ControlDark;
			this.work_space.Dock = System.Windows.Forms.DockStyle.Fill;
			this.work_space.Location = new System.Drawing.Point(0, 0);
			this.work_space.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.work_space.Name = "work_space";
			this.work_space.Size = new System.Drawing.Size(1197, 416);
			this.work_space.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1199, 505);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.MainStatusbar);
			this.Controls.Add(this.MainToolbar);
			this.Controls.Add(this.MainMenubar);
			this.MainMenuStrip = this.MainMenubar;
			this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "도서대여관리프로그램";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.MainMenubar.ResumeLayout(false);
			this.MainMenubar.PerformLayout();
			this.MainToolbar.ResumeLayout(false);
			this.MainToolbar.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip MainMenubar;
    private System.Windows.Forms.ToolStrip MainToolbar;
    private System.Windows.Forms.StatusStrip MainStatusbar;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel work_space;
    private System.Windows.Forms.ToolStripMenuItem mbtn_file;
    private System.Windows.Forms.ToolStripMenuItem mbtn_login;
    private System.Windows.Forms.ToolStripMenuItem mbtn_logout;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem mbtn_exit;
    private System.Windows.Forms.ToolStripMenuItem mbtn_work;
    private System.Windows.Forms.ToolStripMenuItem mbtn_staff;
    private System.Windows.Forms.ToolStripMenuItem mbtn_member;
    private System.Windows.Forms.ToolStripMenuItem mbtn_book;
    private System.Windows.Forms.ToolStripMenuItem mbtn_rent;
    private System.Windows.Forms.ToolStripMenuItem mbtn_tool;
    private System.Windows.Forms.ToolStripMenuItem mbtn_setting;
    private System.Windows.Forms.ToolStripButton tbtn_exit;
    private System.Windows.Forms.ToolStripButton tbtn_rent;
    private System.Windows.Forms.ToolStripButton tbtn_book;
    private System.Windows.Forms.ToolStripButton tbtn_member;
  }
}

