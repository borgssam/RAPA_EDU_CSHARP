namespace BookPro
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
      this.MainToolbar = new System.Windows.Forms.ToolStrip();
      this.MainStatusbar = new System.Windows.Forms.StatusStrip();
      this.panel1 = new System.Windows.Forms.Panel();
      this.work_space = new System.Windows.Forms.Panel();
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
      this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
      this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
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
      this.MainMenubar.Size = new System.Drawing.Size(800, 38);
      this.MainMenubar.TabIndex = 0;
      this.MainMenubar.Text = "menuStrip1";
      // 
      // MainToolbar
      // 
      this.MainToolbar.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.MainToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
      this.MainToolbar.Location = new System.Drawing.Point(0, 48);
      this.MainToolbar.Name = "MainToolbar";
      this.MainToolbar.Size = new System.Drawing.Size(800, 39);
      this.MainToolbar.TabIndex = 1;
      this.MainToolbar.Text = "toolStrip1";
      // 
      // MainStatusbar
      // 
      this.MainStatusbar.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.MainStatusbar.Location = new System.Drawing.Point(0, 375);
      this.MainStatusbar.Name = "MainStatusbar";
      this.MainStatusbar.Size = new System.Drawing.Size(640, 22);
      this.MainStatusbar.TabIndex = 2;
      this.MainStatusbar.Text = "statusStrip1";
      // 
      // panel1
      // 
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.work_space);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 96);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(800, 373);
      this.panel1.TabIndex = 3;
      // 
      // work_space
      // 
      this.work_space.BackColor = System.Drawing.SystemColors.ControlDark;
      this.work_space.Dock = System.Windows.Forms.DockStyle.Fill;
      this.work_space.Location = new System.Drawing.Point(0, 0);
      this.work_space.Name = "work_space";
      this.work_space.Size = new System.Drawing.Size(798, 371);
      this.work_space.TabIndex = 0;
      // 
      // mbtn_file
      // 
      this.mbtn_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtn_login,
            this.mbtn_logout,
            this.toolStripMenuItem1,
            this.mbtn_exit});
      this.mbtn_file.Name = "mbtn_file";
      this.mbtn_file.Size = new System.Drawing.Size(53, 34);
      this.mbtn_file.Text = "파일";
      // 
      // mbtn_login
      // 
      this.mbtn_login.Name = "mbtn_login";
      this.mbtn_login.Size = new System.Drawing.Size(224, 26);
      this.mbtn_login.Text = "로그인";
      // 
      // mbtn_logout
      // 
      this.mbtn_logout.Name = "mbtn_logout";
      this.mbtn_logout.Size = new System.Drawing.Size(224, 26);
      this.mbtn_logout.Text = "로그아웃";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(221, 6);
      // 
      // mbtn_exit
      // 
      this.mbtn_exit.Name = "mbtn_exit";
      this.mbtn_exit.Size = new System.Drawing.Size(224, 26);
      this.mbtn_exit.Text = "종료";
      // 
      // mbtn_work
      // 
      this.mbtn_work.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtn_staff,
            this.mbtn_member,
            this.mbtn_book,
            this.mbtn_rent});
      this.mbtn_work.Name = "mbtn_work";
      this.mbtn_work.Size = new System.Drawing.Size(53, 34);
      this.mbtn_work.Text = "작업";
      // 
      // mbtn_staff
      // 
      this.mbtn_staff.Name = "mbtn_staff";
      this.mbtn_staff.Size = new System.Drawing.Size(224, 26);
      this.mbtn_staff.Text = "사원관리";
      // 
      // mbtn_member
      // 
      this.mbtn_member.Name = "mbtn_member";
      this.mbtn_member.Size = new System.Drawing.Size(224, 26);
      this.mbtn_member.Text = "회원관리";
      // 
      // mbtn_book
      // 
      this.mbtn_book.Name = "mbtn_book";
      this.mbtn_book.Size = new System.Drawing.Size(224, 26);
      this.mbtn_book.Text = "도서관리";
      // 
      // mbtn_rent
      // 
      this.mbtn_rent.Name = "mbtn_rent";
      this.mbtn_rent.Size = new System.Drawing.Size(224, 26);
      this.mbtn_rent.Text = "대여관리";
      // 
      // mbtn_tool
      // 
      this.mbtn_tool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtn_setting});
      this.mbtn_tool.Name = "mbtn_tool";
      this.mbtn_tool.Size = new System.Drawing.Size(53, 34);
      this.mbtn_tool.Text = "도구";
      // 
      // mbtn_setting
      // 
      this.mbtn_setting.Name = "mbtn_setting";
      this.mbtn_setting.Size = new System.Drawing.Size(224, 26);
      this.mbtn_setting.Text = "환경설정";
      // 
      // toolStripButton1
      // 
      this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
      this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton1.Name = "toolStripButton1";
      this.toolStripButton1.Size = new System.Drawing.Size(29, 36);
      this.toolStripButton1.Text = "종료";
      // 
      // toolStripButton2
      // 
      this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
      this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton2.Name = "toolStripButton2";
      this.toolStripButton2.Size = new System.Drawing.Size(29, 36);
      this.toolStripButton2.Text = "toolStripButton2";
      // 
      // toolStripButton3
      // 
      this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
      this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton3.Name = "toolStripButton3";
      this.toolStripButton3.Size = new System.Drawing.Size(29, 36);
      this.toolStripButton3.Text = "toolStripButton3";
      // 
      // toolStripButton4
      // 
      this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
      this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripButton4.Name = "toolStripButton4";
      this.toolStripButton4.Size = new System.Drawing.Size(29, 36);
      this.toolStripButton4.Text = "toolStripButton4";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(640, 397);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.MainStatusbar);
      this.Controls.Add(this.MainToolbar);
      this.Controls.Add(this.MainMenubar);
      this.MainMenuStrip = this.MainMenubar;
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "도서대여관리프로그램";
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
    private System.Windows.Forms.ToolStripButton toolStripButton1;
    private System.Windows.Forms.ToolStripButton toolStripButton2;
    private System.Windows.Forms.ToolStripButton toolStripButton3;
    private System.Windows.Forms.ToolStripButton toolStripButton4;
  }
}

