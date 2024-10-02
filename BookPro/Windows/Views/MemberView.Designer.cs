namespace BookPro.Windows.Views
{
  partial class MemberView
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel7 = new System.Windows.Forms.Panel();
      this.btn_delete_member = new System.Windows.Forms.Button();
      this.btn_add_member = new System.Windows.Forms.Button();
      this.panel6 = new System.Windows.Forms.Panel();
      this.btn_search = new System.Windows.Forms.Button();
      this.pnl_keyword = new System.Windows.Forms.Panel();
      this.tbox_keyword = new System.Windows.Forms.TextBox();
      this.pnl_rent_status = new System.Windows.Forms.Panel();
      this.cbox_rent_status = new System.Windows.Forms.ComboBox();
      this.panel3 = new System.Windows.Forms.Panel();
      this.cbox_searchkind = new System.Windows.Forms.ComboBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.grid_member = new System.Windows.Forms.DataGridView();
      this.panel1.SuspendLayout();
      this.panel7.SuspendLayout();
      this.panel6.SuspendLayout();
      this.pnl_keyword.SuspendLayout();
      this.pnl_rent_status.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grid_member)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.panel7);
      this.panel1.Controls.Add(this.panel6);
      this.panel1.Controls.Add(this.pnl_keyword);
      this.panel1.Controls.Add(this.pnl_rent_status);
      this.panel1.Controls.Add(this.panel3);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1117, 44);
      this.panel1.TabIndex = 0;
      // 
      // panel7
      // 
      this.panel7.Controls.Add(this.btn_delete_member);
      this.panel7.Controls.Add(this.btn_add_member);
      this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel7.Location = new System.Drawing.Point(879, 0);
      this.panel7.Name = "panel7";
      this.panel7.Size = new System.Drawing.Size(238, 44);
      this.panel7.TabIndex = 4;
      // 
      // btn_delete_member
      // 
      this.btn_delete_member.Location = new System.Drawing.Point(118, 6);
      this.btn_delete_member.Name = "btn_delete_member";
      this.btn_delete_member.Size = new System.Drawing.Size(110, 31);
      this.btn_delete_member.TabIndex = 2;
      this.btn_delete_member.Text = "회원탈퇴";
      this.btn_delete_member.UseVisualStyleBackColor = true;
      // 
      // btn_add_member
      // 
      this.btn_add_member.Location = new System.Drawing.Point(4, 6);
      this.btn_add_member.Name = "btn_add_member";
      this.btn_add_member.Size = new System.Drawing.Size(110, 31);
      this.btn_add_member.TabIndex = 1;
      this.btn_add_member.Text = "회원가입";
      this.btn_add_member.UseVisualStyleBackColor = true;
      // 
      // panel6
      // 
      this.panel6.Controls.Add(this.btn_search);
      this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel6.Location = new System.Drawing.Point(483, 0);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(128, 44);
      this.panel6.TabIndex = 3;
      // 
      // btn_search
      // 
      this.btn_search.Location = new System.Drawing.Point(8, 6);
      this.btn_search.Name = "btn_search";
      this.btn_search.Size = new System.Drawing.Size(110, 31);
      this.btn_search.TabIndex = 0;
      this.btn_search.Text = "조회";
      this.btn_search.UseVisualStyleBackColor = true;
      // 
      // pnl_keyword
      // 
      this.pnl_keyword.Controls.Add(this.tbox_keyword);
      this.pnl_keyword.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnl_keyword.Location = new System.Drawing.Point(322, 0);
      this.pnl_keyword.Name = "pnl_keyword";
      this.pnl_keyword.Padding = new System.Windows.Forms.Padding(5, 6, 5, 5);
      this.pnl_keyword.Size = new System.Drawing.Size(161, 44);
      this.pnl_keyword.TabIndex = 2;
      // 
      // tbox_keyword
      // 
      this.tbox_keyword.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbox_keyword.Location = new System.Drawing.Point(6, 8);
      this.tbox_keyword.Name = "tbox_keyword";
      this.tbox_keyword.Size = new System.Drawing.Size(151, 25);
      this.tbox_keyword.TabIndex = 0;
      // 
      // pnl_rent_status
      // 
      this.pnl_rent_status.Controls.Add(this.cbox_rent_status);
      this.pnl_rent_status.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnl_rent_status.Location = new System.Drawing.Point(161, 0);
      this.pnl_rent_status.Name = "pnl_rent_status";
      this.pnl_rent_status.Padding = new System.Windows.Forms.Padding(5, 6, 5, 5);
      this.pnl_rent_status.Size = new System.Drawing.Size(161, 44);
      this.pnl_rent_status.TabIndex = 1;
      // 
      // cbox_rent_status
      // 
      this.cbox_rent_status.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cbox_rent_status.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.cbox_rent_status.FormattingEnabled = true;
      this.cbox_rent_status.Items.AddRange(new object[] {
            "대여중",
            "연체중"});
      this.cbox_rent_status.Location = new System.Drawing.Point(6, 8);
      this.cbox_rent_status.Name = "cbox_rent_status";
      this.cbox_rent_status.Size = new System.Drawing.Size(151, 25);
      this.cbox_rent_status.TabIndex = 0;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.cbox_searchkind);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel3.Location = new System.Drawing.Point(0, 0);
      this.panel3.Name = "panel3";
      this.panel3.Padding = new System.Windows.Forms.Padding(5, 6, 5, 5);
      this.panel3.Size = new System.Drawing.Size(161, 44);
      this.panel3.TabIndex = 0;
      // 
      // cbox_searchkind
      // 
      this.cbox_searchkind.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cbox_searchkind.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.cbox_searchkind.FormattingEnabled = true;
      this.cbox_searchkind.Items.AddRange(new object[] {
            "이름",
            "연락처",
            "대출상태"});
      this.cbox_searchkind.Location = new System.Drawing.Point(6, 8);
      this.cbox_searchkind.Name = "cbox_searchkind";
      this.cbox_searchkind.Size = new System.Drawing.Size(151, 25);
      this.cbox_searchkind.TabIndex = 0;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.groupBox1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 44);
      this.panel2.Name = "panel2";
      this.panel2.Padding = new System.Windows.Forms.Padding(5);
      this.panel2.Size = new System.Drawing.Size(1117, 457);
      this.panel2.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.grid_member);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(6, 6);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
      this.groupBox1.Size = new System.Drawing.Size(1384, 559);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "회원목록";
      // 
      // grid_member
      // 
      this.grid_member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grid_member.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grid_member.Location = new System.Drawing.Point(6, 29);
      this.grid_member.Name = "grid_member";
      this.grid_member.RowHeadersWidth = 51;
      this.grid_member.RowTemplate.Height = 27;
      this.grid_member.Size = new System.Drawing.Size(1718, 664);
      this.grid_member.TabIndex = 0;
      // 
      // MemberView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1117, 501);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "MemberView";
      this.Text = "MemberView";
      this.Load += new System.EventHandler(this.MemberView_Load);
      this.panel1.ResumeLayout(false);
      this.panel7.ResumeLayout(false);
      this.panel6.ResumeLayout(false);
      this.pnl_keyword.ResumeLayout(false);
      this.pnl_keyword.PerformLayout();
      this.pnl_rent_status.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grid_member)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel7;
    private System.Windows.Forms.Button btn_delete_member;
    private System.Windows.Forms.Button btn_add_member;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.Button btn_search;
    private System.Windows.Forms.Panel pnl_keyword;
    private System.Windows.Forms.TextBox tbox_keyword;
    private System.Windows.Forms.Panel pnl_rent_status;
    private System.Windows.Forms.ComboBox cbox_rent_status;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.ComboBox cbox_searchkind;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridView grid_member;
  }
}