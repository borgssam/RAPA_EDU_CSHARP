namespace CSharpSchool.Pop
{
  partial class ViewTestPop
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTestPop));
      this.btn_member = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btn_rent = new System.Windows.Forms.Button();
      this.btn_book = new System.Windows.Forms.Button();
      this.main_menu = new System.Windows.Forms.MenuStrip();
      this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.새파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.파일읽기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.파일저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.다른이름으로저장ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.편집ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.되돌리기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.다시실행ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
      this.복사ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.잘라내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.붙여넣기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.삭제ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mbtn_member = new System.Windows.Forms.ToolStripMenuItem();
      this.mbtn_rent = new System.Windows.Forms.ToolStripMenuItem();
      this.mbtn_book = new System.Windows.Forms.ToolStripMenuItem();
      this.도구ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.도우ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.main_toolbar = new System.Windows.Forms.ToolStrip();
      this.tbtn_member = new System.Windows.Forms.ToolStripButton();
      this.tbtn_book = new System.Windows.Forms.ToolStripButton();
      this.tbtn_rent = new System.Windows.Forms.ToolStripButton();
      this.panel3 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.view_space = new System.Windows.Forms.Panel();
      this.main_status = new System.Windows.Forms.StatusStrip();
      this.label_user = new System.Windows.Forms.ToolStripStatusLabel();
      this.label_time = new System.Windows.Forms.ToolStripStatusLabel();
      this.main_timer = new System.Windows.Forms.Timer(this.components);
      this.panel1.SuspendLayout();
      this.main_menu.SuspendLayout();
      this.main_toolbar.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.main_status.SuspendLayout();
      this.SuspendLayout();
      // 
      // btn_member
      // 
      this.btn_member.BackColor = System.Drawing.SystemColors.Control;
      this.btn_member.Location = new System.Drawing.Point(31, 10);
      this.btn_member.Name = "btn_member";
      this.btn_member.Size = new System.Drawing.Size(75, 23);
      this.btn_member.TabIndex = 0;
      this.btn_member.Text = "회원창";
      this.btn_member.UseVisualStyleBackColor = false;
      this.btn_member.Click += new System.EventHandler(this.btn_member_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btn_rent);
      this.panel1.Controls.Add(this.btn_book);
      this.panel1.Controls.Add(this.btn_member);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(801, 51);
      this.panel1.TabIndex = 1;
      // 
      // btn_rent
      // 
      this.btn_rent.Location = new System.Drawing.Point(202, 10);
      this.btn_rent.Name = "btn_rent";
      this.btn_rent.Size = new System.Drawing.Size(75, 23);
      this.btn_rent.TabIndex = 2;
      this.btn_rent.Text = "대여창";
      this.btn_rent.UseVisualStyleBackColor = true;
      this.btn_rent.Click += new System.EventHandler(this.btn_rent_Click);
      // 
      // btn_book
      // 
      this.btn_book.Location = new System.Drawing.Point(112, 10);
      this.btn_book.Name = "btn_book";
      this.btn_book.Size = new System.Drawing.Size(75, 23);
      this.btn_book.TabIndex = 1;
      this.btn_book.Text = "도서창";
      this.btn_book.UseVisualStyleBackColor = true;
      this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
      // 
      // main_menu
      // 
      this.main_menu.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.main_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.편집ToolStripMenuItem,
            this.보기ToolStripMenuItem,
            this.도구ToolStripMenuItem,
            this.도우ToolStripMenuItem});
      this.main_menu.Location = new System.Drawing.Point(0, 0);
      this.main_menu.Name = "main_menu";
      this.main_menu.Size = new System.Drawing.Size(801, 28);
      this.main_menu.TabIndex = 4;
      this.main_menu.Text = "menuStrip1";
      // 
      // 파일ToolStripMenuItem
      // 
      this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.새파일ToolStripMenuItem,
            this.파일읽기ToolStripMenuItem,
            this.파일저장ToolStripMenuItem,
            this.다른이름으로저장ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.종료ToolStripMenuItem});
      this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
      this.파일ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
      this.파일ToolStripMenuItem.Text = "파일";
      // 
      // 새파일ToolStripMenuItem
      // 
      this.새파일ToolStripMenuItem.Name = "새파일ToolStripMenuItem";
      this.새파일ToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
      this.새파일ToolStripMenuItem.Text = "새파일";
      // 
      // 파일읽기ToolStripMenuItem
      // 
      this.파일읽기ToolStripMenuItem.Checked = true;
      this.파일읽기ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.파일읽기ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("파일읽기ToolStripMenuItem.Image")));
      this.파일읽기ToolStripMenuItem.Name = "파일읽기ToolStripMenuItem";
      this.파일읽기ToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
      this.파일읽기ToolStripMenuItem.Text = "파일읽기";
      // 
      // 파일저장ToolStripMenuItem
      // 
      this.파일저장ToolStripMenuItem.Checked = true;
      this.파일저장ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.파일저장ToolStripMenuItem.Name = "파일저장ToolStripMenuItem";
      this.파일저장ToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
      this.파일저장ToolStripMenuItem.Text = "파일저장";
      // 
      // 다른이름으로저장ToolStripMenuItem
      // 
      this.다른이름으로저장ToolStripMenuItem.Name = "다른이름으로저장ToolStripMenuItem";
      this.다른이름으로저장ToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
      this.다른이름으로저장ToolStripMenuItem.Text = "다른이름으로 저장";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(214, 6);
      // 
      // 종료ToolStripMenuItem
      // 
      this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
      this.종료ToolStripMenuItem.Size = new System.Drawing.Size(217, 26);
      this.종료ToolStripMenuItem.Text = "종료";
      // 
      // 편집ToolStripMenuItem
      // 
      this.편집ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.되돌리기ToolStripMenuItem,
            this.다시실행ToolStripMenuItem,
            this.toolStripMenuItem3,
            this.복사ToolStripMenuItem,
            this.잘라내기ToolStripMenuItem,
            this.붙여넣기ToolStripMenuItem,
            this.삭제ToolStripMenuItem});
      this.편집ToolStripMenuItem.Name = "편집ToolStripMenuItem";
      this.편집ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
      this.편집ToolStripMenuItem.Text = "편집";
      // 
      // 되돌리기ToolStripMenuItem
      // 
      this.되돌리기ToolStripMenuItem.Name = "되돌리기ToolStripMenuItem";
      this.되돌리기ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
      this.되돌리기ToolStripMenuItem.Text = "되돌리기";
      // 
      // 다시실행ToolStripMenuItem
      // 
      this.다시실행ToolStripMenuItem.Name = "다시실행ToolStripMenuItem";
      this.다시실행ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
      this.다시실행ToolStripMenuItem.Text = "다시실행";
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(149, 6);
      // 
      // 복사ToolStripMenuItem
      // 
      this.복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
      this.복사ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
      this.복사ToolStripMenuItem.Text = "복사";
      // 
      // 잘라내기ToolStripMenuItem
      // 
      this.잘라내기ToolStripMenuItem.Name = "잘라내기ToolStripMenuItem";
      this.잘라내기ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
      this.잘라내기ToolStripMenuItem.Text = "잘라내기";
      // 
      // 붙여넣기ToolStripMenuItem
      // 
      this.붙여넣기ToolStripMenuItem.Name = "붙여넣기ToolStripMenuItem";
      this.붙여넣기ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
      this.붙여넣기ToolStripMenuItem.Text = "붙여넣기";
      // 
      // 삭제ToolStripMenuItem
      // 
      this.삭제ToolStripMenuItem.Name = "삭제ToolStripMenuItem";
      this.삭제ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
      this.삭제ToolStripMenuItem.Text = "삭제";
      // 
      // 보기ToolStripMenuItem
      // 
      this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mbtn_member,
            this.mbtn_rent,
            this.mbtn_book});
      this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
      this.보기ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
      this.보기ToolStripMenuItem.Text = "보기";
      // 
      // mbtn_member
      // 
      this.mbtn_member.Name = "mbtn_member";
      this.mbtn_member.Size = new System.Drawing.Size(137, 26);
      this.mbtn_member.Text = "회원창";
      this.mbtn_member.Click += new System.EventHandler(this.mbtn_member_Click);
      // 
      // mbtn_rent
      // 
      this.mbtn_rent.Name = "mbtn_rent";
      this.mbtn_rent.Size = new System.Drawing.Size(137, 26);
      this.mbtn_rent.Text = "대여창";
      this.mbtn_rent.Click += new System.EventHandler(this.mbtn_rent_Click);
      // 
      // mbtn_book
      // 
      this.mbtn_book.Name = "mbtn_book";
      this.mbtn_book.Size = new System.Drawing.Size(137, 26);
      this.mbtn_book.Text = "도서창";
      this.mbtn_book.Click += new System.EventHandler(this.mbtn_book_Click);
      // 
      // 도구ToolStripMenuItem
      // 
      this.도구ToolStripMenuItem.Name = "도구ToolStripMenuItem";
      this.도구ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
      this.도구ToolStripMenuItem.Text = "도구";
      // 
      // 도우ToolStripMenuItem
      // 
      this.도우ToolStripMenuItem.Name = "도우ToolStripMenuItem";
      this.도우ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
      this.도우ToolStripMenuItem.Text = "도움말";
      // 
      // main_toolbar
      // 
      this.main_toolbar.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.main_toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtn_member,
            this.tbtn_book,
            this.tbtn_rent});
      this.main_toolbar.Location = new System.Drawing.Point(0, 28);
      this.main_toolbar.Name = "main_toolbar";
      this.main_toolbar.Size = new System.Drawing.Size(801, 27);
      this.main_toolbar.TabIndex = 5;
      this.main_toolbar.Text = "toolStrip1";
      // 
      // tbtn_member
      // 
      this.tbtn_member.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tbtn_member.Image = ((System.Drawing.Image)(resources.GetObject("tbtn_member.Image")));
      this.tbtn_member.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbtn_member.Name = "tbtn_member";
      this.tbtn_member.Size = new System.Drawing.Size(29, 24);
      this.tbtn_member.Text = "toolStripButton1";
      this.tbtn_member.ToolTipText = "회원창";
      this.tbtn_member.Click += new System.EventHandler(this.tbtn_member_Click);
      // 
      // tbtn_book
      // 
      this.tbtn_book.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tbtn_book.Image = ((System.Drawing.Image)(resources.GetObject("tbtn_book.Image")));
      this.tbtn_book.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbtn_book.Name = "tbtn_book";
      this.tbtn_book.Size = new System.Drawing.Size(29, 24);
      this.tbtn_book.Text = "toolStripButton2";
      this.tbtn_book.ToolTipText = "도서창";
      this.tbtn_book.Click += new System.EventHandler(this.tbtn_book_Click);
      // 
      // tbtn_rent
      // 
      this.tbtn_rent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.tbtn_rent.Image = ((System.Drawing.Image)(resources.GetObject("tbtn_rent.Image")));
      this.tbtn_rent.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tbtn_rent.Name = "tbtn_rent";
      this.tbtn_rent.Size = new System.Drawing.Size(29, 24);
      this.tbtn_rent.Text = "toolStripButton3";
      this.tbtn_rent.ToolTipText = "대여창";
      this.tbtn_rent.Click += new System.EventHandler(this.tbtn_rent_Click);
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.panel2);
      this.panel3.Controls.Add(this.panel1);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel3.Location = new System.Drawing.Point(0, 55);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(801, 359);
      this.panel3.TabIndex = 6;
      // 
      // panel2
      // 
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel2.Controls.Add(this.view_space);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 51);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(801, 308);
      this.panel2.TabIndex = 4;
      // 
      // view_space
      // 
      this.view_space.BackColor = System.Drawing.SystemColors.ControlDark;
      this.view_space.Dock = System.Windows.Forms.DockStyle.Fill;
      this.view_space.Location = new System.Drawing.Point(0, 0);
      this.view_space.Name = "view_space";
      this.view_space.Size = new System.Drawing.Size(799, 306);
      this.view_space.TabIndex = 2;
      // 
      // main_status
      // 
      this.main_status.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.main_status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.label_user,
            this.label_time});
      this.main_status.Location = new System.Drawing.Point(0, 388);
      this.main_status.Name = "main_status";
      this.main_status.Size = new System.Drawing.Size(801, 26);
      this.main_status.TabIndex = 7;
      this.main_status.Text = "statusStrip1";
      // 
      // label_user
      // 
      this.label_user.Name = "label_user";
      this.label_user.Size = new System.Drawing.Size(117, 20);
      this.label_user.Text = "사용자 :  김상목";
      // 
      // label_time
      // 
      this.label_time.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner;
      this.label_time.Name = "label_time";
      this.label_time.Size = new System.Drawing.Size(144, 20);
      this.label_time.Text = "2024-10-01 12:00:00";
      // 
      // main_timer
      // 
      this.main_timer.Enabled = true;
      this.main_timer.Interval = 1000;
      this.main_timer.Tick += new System.EventHandler(this.main_timer_Tick);
      // 
      // ViewTestPop
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(801, 414);
      this.Controls.Add(this.main_status);
      this.Controls.Add(this.panel3);
      this.Controls.Add(this.main_toolbar);
      this.Controls.Add(this.main_menu);
      this.MainMenuStrip = this.main_menu;
      this.Name = "ViewTestPop";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "TestPop";
      this.panel1.ResumeLayout(false);
      this.main_menu.ResumeLayout(false);
      this.main_menu.PerformLayout();
      this.main_toolbar.ResumeLayout(false);
      this.main_toolbar.PerformLayout();
      this.panel3.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.main_status.ResumeLayout(false);
      this.main_status.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btn_member;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btn_rent;
    private System.Windows.Forms.Button btn_book;
    private System.Windows.Forms.MenuStrip main_menu;
    private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 도구ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 도우ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 새파일ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 파일읽기ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 파일저장ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 다른이름으로저장ToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 편집ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 되돌리기ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 다시실행ToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem 복사ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 잘라내기ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 붙여넣기ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem 삭제ToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mbtn_member;
    private System.Windows.Forms.ToolStripMenuItem mbtn_rent;
    private System.Windows.Forms.ToolStripMenuItem mbtn_book;
    private System.Windows.Forms.ToolStrip main_toolbar;
    private System.Windows.Forms.ToolStripButton tbtn_member;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.ToolStripButton tbtn_book;
    private System.Windows.Forms.ToolStripButton tbtn_rent;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel view_space;
    private System.Windows.Forms.StatusStrip main_status;
    private System.Windows.Forms.ToolStripStatusLabel label_user;
    private System.Windows.Forms.ToolStripStatusLabel label_time;
    private System.Windows.Forms.Timer main_timer;
  }
}