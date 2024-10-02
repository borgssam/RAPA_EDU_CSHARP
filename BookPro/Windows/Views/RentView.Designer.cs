namespace BookPro.Windows.Views
{
  partial class RentView
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
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel3 = new System.Windows.Forms.Panel();
      this.pnl_date = new System.Windows.Forms.Panel();
      this.pnl_rent_status = new System.Windows.Forms.Panel();
      this.pnl_keyword = new System.Windows.Forms.Panel();
      this.panel7 = new System.Windows.Forms.Panel();
      this.panel8 = new System.Windows.Forms.Panel();
      this.btn_search = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.cbox_searchkind = new System.Windows.Forms.ComboBox();
      this.tbox_keyword = new System.Windows.Forms.TextBox();
      this.date_begin = new System.Windows.Forms.DateTimePicker();
      this.date_end = new System.Windows.Forms.DateTimePicker();
      this.label1 = new System.Windows.Forms.Label();
      this.cbox_rent_status = new System.Windows.Forms.ComboBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.grid_rent = new System.Windows.Forms.DataGridView();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.panel3.SuspendLayout();
      this.pnl_date.SuspendLayout();
      this.pnl_rent_status.SuspendLayout();
      this.pnl_keyword.SuspendLayout();
      this.panel7.SuspendLayout();
      this.panel8.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grid_rent)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.panel8);
      this.panel1.Controls.Add(this.panel7);
      this.panel1.Controls.Add(this.pnl_keyword);
      this.panel1.Controls.Add(this.pnl_rent_status);
      this.panel1.Controls.Add(this.pnl_date);
      this.panel1.Controls.Add(this.panel3);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1158, 38);
      this.panel1.TabIndex = 0;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.groupBox1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 38);
      this.panel2.Name = "panel2";
      this.panel2.Padding = new System.Windows.Forms.Padding(5);
      this.panel2.Size = new System.Drawing.Size(1158, 505);
      this.panel2.TabIndex = 1;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.cbox_searchkind);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel3.Location = new System.Drawing.Point(0, 0);
      this.panel3.Name = "panel3";
      this.panel3.Padding = new System.Windows.Forms.Padding(5);
      this.panel3.Size = new System.Drawing.Size(160, 38);
      this.panel3.TabIndex = 0;
      // 
      // pnl_date
      // 
      this.pnl_date.Controls.Add(this.label1);
      this.pnl_date.Controls.Add(this.date_end);
      this.pnl_date.Controls.Add(this.date_begin);
      this.pnl_date.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnl_date.Location = new System.Drawing.Point(160, 0);
      this.pnl_date.Name = "pnl_date";
      this.pnl_date.Size = new System.Drawing.Size(429, 38);
      this.pnl_date.TabIndex = 1;
      // 
      // pnl_rent_status
      // 
      this.pnl_rent_status.Controls.Add(this.cbox_rent_status);
      this.pnl_rent_status.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnl_rent_status.Location = new System.Drawing.Point(589, 0);
      this.pnl_rent_status.Name = "pnl_rent_status";
      this.pnl_rent_status.Padding = new System.Windows.Forms.Padding(5);
      this.pnl_rent_status.Size = new System.Drawing.Size(155, 38);
      this.pnl_rent_status.TabIndex = 2;
      // 
      // pnl_keyword
      // 
      this.pnl_keyword.Controls.Add(this.tbox_keyword);
      this.pnl_keyword.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnl_keyword.Location = new System.Drawing.Point(744, 0);
      this.pnl_keyword.Name = "pnl_keyword";
      this.pnl_keyword.Padding = new System.Windows.Forms.Padding(5);
      this.pnl_keyword.Size = new System.Drawing.Size(173, 38);
      this.pnl_keyword.TabIndex = 3;
      // 
      // panel7
      // 
      this.panel7.Controls.Add(this.btn_search);
      this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel7.Location = new System.Drawing.Point(917, 0);
      this.panel7.Name = "panel7";
      this.panel7.Size = new System.Drawing.Size(82, 38);
      this.panel7.TabIndex = 4;
      // 
      // panel8
      // 
      this.panel8.Controls.Add(this.button3);
      this.panel8.Controls.Add(this.button2);
      this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel8.Location = new System.Drawing.Point(974, 0);
      this.panel8.Name = "panel8";
      this.panel8.Size = new System.Drawing.Size(184, 38);
      this.panel8.TabIndex = 5;
      // 
      // btn_search
      // 
      this.btn_search.Location = new System.Drawing.Point(6, 2);
      this.btn_search.Name = "btn_search";
      this.btn_search.Size = new System.Drawing.Size(72, 31);
      this.btn_search.TabIndex = 0;
      this.btn_search.Text = "조회";
      this.btn_search.UseVisualStyleBackColor = true;
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(3, 2);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(82, 31);
      this.button2.TabIndex = 0;
      this.button2.Text = "대출";
      this.button2.UseVisualStyleBackColor = true;
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(92, 2);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(82, 31);
      this.button3.TabIndex = 1;
      this.button3.Text = "반납";
      this.button3.UseVisualStyleBackColor = true;
      // 
      // cbox_searchkind
      // 
      this.cbox_searchkind.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cbox_searchkind.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.cbox_searchkind.FormattingEnabled = true;
      this.cbox_searchkind.Items.AddRange(new object[] {
            "대출일",
            "반납예정일",
            "반납일",
            "대여상태",
            "회원이름",
            "회원연락처"});
      this.cbox_searchkind.Location = new System.Drawing.Point(5, 5);
      this.cbox_searchkind.Name = "cbox_searchkind";
      this.cbox_searchkind.Size = new System.Drawing.Size(150, 25);
      this.cbox_searchkind.TabIndex = 0;
      // 
      // tbox_keyword
      // 
      this.tbox_keyword.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbox_keyword.Location = new System.Drawing.Point(5, 5);
      this.tbox_keyword.Name = "tbox_keyword";
      this.tbox_keyword.Size = new System.Drawing.Size(163, 25);
      this.tbox_keyword.TabIndex = 0;
      // 
      // date_begin
      // 
      this.date_begin.Location = new System.Drawing.Point(8, 6);
      this.date_begin.Name = "date_begin";
      this.date_begin.Size = new System.Drawing.Size(189, 25);
      this.date_begin.TabIndex = 0;
      // 
      // date_end
      // 
      this.date_end.Location = new System.Drawing.Point(220, 6);
      this.date_end.Name = "date_end";
      this.date_end.Size = new System.Drawing.Size(197, 25);
      this.date_end.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(204, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(10, 10);
      this.label1.TabIndex = 2;
      this.label1.Text = "~";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // cbox_rent_status
      // 
      this.cbox_rent_status.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cbox_rent_status.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.cbox_rent_status.FormattingEnabled = true;
      this.cbox_rent_status.Items.AddRange(new object[] {
            "대여중",
            "연체중"});
      this.cbox_rent_status.Location = new System.Drawing.Point(5, 5);
      this.cbox_rent_status.Name = "cbox_rent_status";
      this.cbox_rent_status.Size = new System.Drawing.Size(145, 25);
      this.cbox_rent_status.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.grid_rent);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(5, 5);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
      this.groupBox1.Size = new System.Drawing.Size(1148, 495);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "대여목록";
      // 
      // grid_rent
      // 
      this.grid_rent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grid_rent.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grid_rent.Location = new System.Drawing.Point(5, 23);
      this.grid_rent.Name = "grid_rent";
      this.grid_rent.RowHeadersWidth = 51;
      this.grid_rent.RowTemplate.Height = 27;
      this.grid_rent.Size = new System.Drawing.Size(1138, 467);
      this.grid_rent.TabIndex = 0;
      // 
      // RentView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1158, 543);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "RentView";
      this.Text = "RentView";
      this.Load += new System.EventHandler(this.RentView_Load);
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.pnl_date.ResumeLayout(false);
      this.pnl_rent_status.ResumeLayout(false);
      this.pnl_keyword.ResumeLayout(false);
      this.pnl_keyword.PerformLayout();
      this.panel7.ResumeLayout(false);
      this.panel8.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grid_rent)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel8;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Panel panel7;
    private System.Windows.Forms.Button btn_search;
    private System.Windows.Forms.Panel pnl_keyword;
    private System.Windows.Forms.Panel pnl_rent_status;
    private System.Windows.Forms.Panel pnl_date;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.ComboBox cbox_searchkind;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox tbox_keyword;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker date_end;
    private System.Windows.Forms.DateTimePicker date_begin;
    private System.Windows.Forms.ComboBox cbox_rent_status;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridView grid_rent;
  }
}