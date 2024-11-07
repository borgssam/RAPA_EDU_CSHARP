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
      this.mbrucodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.mbrnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.mbridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.mbrgenderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.mbrphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.mbraddrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.mbrstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DisplaySet = new System.Data.DataSet();
      this.Member = new System.Data.DataTable();
      this.dataColumn1 = new System.Data.DataColumn();
      this.dataColumn2 = new System.Data.DataColumn();
      this.dataColumn3 = new System.Data.DataColumn();
      this.dataColumn4 = new System.Data.DataColumn();
      this.dataColumn5 = new System.Data.DataColumn();
      this.dataColumn6 = new System.Data.DataColumn();
      this.dataColumn7 = new System.Data.DataColumn();
      this.dataColumn8 = new System.Data.DataColumn();
      this.panel1.SuspendLayout();
      this.panel7.SuspendLayout();
      this.panel6.SuspendLayout();
      this.pnl_keyword.SuspendLayout();
      this.pnl_rent_status.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grid_member)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DisplaySet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Member)).BeginInit();
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
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(977, 35);
      this.panel1.TabIndex = 0;
      // 
      // panel7
      // 
      this.panel7.Controls.Add(this.btn_delete_member);
      this.panel7.Controls.Add(this.btn_add_member);
      this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel7.Location = new System.Drawing.Point(769, 0);
      this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel7.Name = "panel7";
      this.panel7.Size = new System.Drawing.Size(208, 35);
      this.panel7.TabIndex = 4;
      // 
      // btn_delete_member
      // 
      this.btn_delete_member.Location = new System.Drawing.Point(103, 5);
      this.btn_delete_member.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btn_delete_member.Name = "btn_delete_member";
      this.btn_delete_member.Size = new System.Drawing.Size(96, 25);
      this.btn_delete_member.TabIndex = 2;
      this.btn_delete_member.Text = "회원탈퇴";
      this.btn_delete_member.UseVisualStyleBackColor = true;
      // 
      // btn_add_member
      // 
      this.btn_add_member.Location = new System.Drawing.Point(4, 5);
      this.btn_add_member.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btn_add_member.Name = "btn_add_member";
      this.btn_add_member.Size = new System.Drawing.Size(96, 25);
      this.btn_add_member.TabIndex = 1;
      this.btn_add_member.Text = "회원가입";
      this.btn_add_member.UseVisualStyleBackColor = true;
      this.btn_add_member.Click += new System.EventHandler(this.btn_add_member_Click);
      // 
      // panel6
      // 
      this.panel6.Controls.Add(this.btn_search);
      this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel6.Location = new System.Drawing.Point(423, 0);
      this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(112, 35);
      this.panel6.TabIndex = 3;
      // 
      // btn_search
      // 
      this.btn_search.Location = new System.Drawing.Point(7, 5);
      this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btn_search.Name = "btn_search";
      this.btn_search.Size = new System.Drawing.Size(96, 25);
      this.btn_search.TabIndex = 0;
      this.btn_search.Text = "조회";
      this.btn_search.UseVisualStyleBackColor = true;
      this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
      // 
      // pnl_keyword
      // 
      this.pnl_keyword.Controls.Add(this.tbox_keyword);
      this.pnl_keyword.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnl_keyword.Location = new System.Drawing.Point(282, 0);
      this.pnl_keyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.pnl_keyword.Name = "pnl_keyword";
      this.pnl_keyword.Padding = new System.Windows.Forms.Padding(4, 5, 4, 4);
      this.pnl_keyword.Size = new System.Drawing.Size(141, 35);
      this.pnl_keyword.TabIndex = 2;
      // 
      // tbox_keyword
      // 
      this.tbox_keyword.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbox_keyword.Location = new System.Drawing.Point(4, 5);
      this.tbox_keyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tbox_keyword.Name = "tbox_keyword";
      this.tbox_keyword.Size = new System.Drawing.Size(133, 21);
      this.tbox_keyword.TabIndex = 0;
      // 
      // pnl_rent_status
      // 
      this.pnl_rent_status.Controls.Add(this.cbox_rent_status);
      this.pnl_rent_status.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnl_rent_status.Location = new System.Drawing.Point(141, 0);
      this.pnl_rent_status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.pnl_rent_status.Name = "pnl_rent_status";
      this.pnl_rent_status.Padding = new System.Windows.Forms.Padding(4, 5, 4, 4);
      this.pnl_rent_status.Size = new System.Drawing.Size(141, 35);
      this.pnl_rent_status.TabIndex = 1;
      // 
      // cbox_rent_status
      // 
      this.cbox_rent_status.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cbox_rent_status.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.cbox_rent_status.FormattingEnabled = true;
      this.cbox_rent_status.Items.AddRange(new object[] {
            "대기중",
            "대여중",
            "연체중"});
      this.cbox_rent_status.Location = new System.Drawing.Point(4, 5);
      this.cbox_rent_status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.cbox_rent_status.Name = "cbox_rent_status";
      this.cbox_rent_status.Size = new System.Drawing.Size(133, 21);
      this.cbox_rent_status.TabIndex = 0;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.cbox_searchkind);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel3.Location = new System.Drawing.Point(0, 0);
      this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel3.Name = "panel3";
      this.panel3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 4);
      this.panel3.Size = new System.Drawing.Size(141, 35);
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
      this.cbox_searchkind.Location = new System.Drawing.Point(4, 5);
      this.cbox_searchkind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.cbox_searchkind.Name = "cbox_searchkind";
      this.cbox_searchkind.Size = new System.Drawing.Size(133, 21);
      this.cbox_searchkind.TabIndex = 0;
      this.cbox_searchkind.SelectedIndexChanged += new System.EventHandler(this.cbox_searchkind_SelectedIndexChanged);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.groupBox1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 35);
      this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel2.Name = "panel2";
      this.panel2.Padding = new System.Windows.Forms.Padding(4);
      this.panel2.Size = new System.Drawing.Size(977, 366);
      this.panel2.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.grid_member);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(4, 4);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox1.Size = new System.Drawing.Size(969, 358);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "회원목록";
      // 
      // grid_member
      // 
      this.grid_member.AllowUserToAddRows = false;
      this.grid_member.AllowUserToDeleteRows = false;
      this.grid_member.AllowUserToOrderColumns = true;
      this.grid_member.AllowUserToResizeColumns = false;
      this.grid_member.AllowUserToResizeRows = false;
      this.grid_member.AutoGenerateColumns = false;
      this.grid_member.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grid_member.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mbrucodeDataGridViewTextBoxColumn,
            this.mbrnameDataGridViewTextBoxColumn,
            this.mbridDataGridViewTextBoxColumn,
            this.mbrgenderDataGridViewTextBoxColumn,
            this.mbrphoneDataGridViewTextBoxColumn,
            this.mbraddrDataGridViewTextBoxColumn,
            this.mbrstatusDataGridViewTextBoxColumn});
      this.grid_member.DataMember = "Member";
      this.grid_member.DataSource = this.DisplaySet;
      this.grid_member.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grid_member.Location = new System.Drawing.Point(4, 18);
      this.grid_member.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.grid_member.Name = "grid_member";
      this.grid_member.ReadOnly = true;
      this.grid_member.RowHeadersWidth = 51;
      this.grid_member.RowTemplate.Height = 27;
      this.grid_member.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.grid_member.Size = new System.Drawing.Size(961, 336);
      this.grid_member.TabIndex = 0;
      this.grid_member.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grid_member_MouseDoubleClick);
      // 
      // mbrucodeDataGridViewTextBoxColumn
      // 
      this.mbrucodeDataGridViewTextBoxColumn.DataPropertyName = "mbr_ucode";
      this.mbrucodeDataGridViewTextBoxColumn.HeaderText = "회원번호";
      this.mbrucodeDataGridViewTextBoxColumn.Name = "mbrucodeDataGridViewTextBoxColumn";
      this.mbrucodeDataGridViewTextBoxColumn.ReadOnly = true;
      this.mbrucodeDataGridViewTextBoxColumn.Width = 80;
      // 
      // mbrnameDataGridViewTextBoxColumn
      // 
      this.mbrnameDataGridViewTextBoxColumn.DataPropertyName = "mbr_name";
      this.mbrnameDataGridViewTextBoxColumn.HeaderText = "회원명";
      this.mbrnameDataGridViewTextBoxColumn.Name = "mbrnameDataGridViewTextBoxColumn";
      this.mbrnameDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // mbridDataGridViewTextBoxColumn
      // 
      this.mbridDataGridViewTextBoxColumn.DataPropertyName = "mbr_id";
      this.mbridDataGridViewTextBoxColumn.HeaderText = "회원아이디";
      this.mbridDataGridViewTextBoxColumn.Name = "mbridDataGridViewTextBoxColumn";
      this.mbridDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // mbrgenderDataGridViewTextBoxColumn
      // 
      this.mbrgenderDataGridViewTextBoxColumn.DataPropertyName = "mbr_gender";
      this.mbrgenderDataGridViewTextBoxColumn.HeaderText = "회원성별";
      this.mbrgenderDataGridViewTextBoxColumn.Name = "mbrgenderDataGridViewTextBoxColumn";
      this.mbrgenderDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // mbrphoneDataGridViewTextBoxColumn
      // 
      this.mbrphoneDataGridViewTextBoxColumn.DataPropertyName = "mbr_phone";
      this.mbrphoneDataGridViewTextBoxColumn.HeaderText = "회원연락처";
      this.mbrphoneDataGridViewTextBoxColumn.Name = "mbrphoneDataGridViewTextBoxColumn";
      this.mbrphoneDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // mbraddrDataGridViewTextBoxColumn
      // 
      this.mbraddrDataGridViewTextBoxColumn.DataPropertyName = "mbr_addr";
      this.mbraddrDataGridViewTextBoxColumn.HeaderText = "회원주소";
      this.mbraddrDataGridViewTextBoxColumn.Name = "mbraddrDataGridViewTextBoxColumn";
      this.mbraddrDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // mbrstatusDataGridViewTextBoxColumn
      // 
      this.mbrstatusDataGridViewTextBoxColumn.DataPropertyName = "mbr_status";
      this.mbrstatusDataGridViewTextBoxColumn.HeaderText = "회원상태";
      this.mbrstatusDataGridViewTextBoxColumn.Name = "mbrstatusDataGridViewTextBoxColumn";
      this.mbrstatusDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // DisplaySet
      // 
      this.DisplaySet.DataSetName = "NewDataSet";
      this.DisplaySet.Tables.AddRange(new System.Data.DataTable[] {
            this.Member});
      // 
      // Member
      // 
      this.Member.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8});
      this.Member.TableName = "Member";
      // 
      // dataColumn1
      // 
      this.dataColumn1.ColumnName = "mbr_ucode";
      // 
      // dataColumn2
      // 
      this.dataColumn2.ColumnName = "mbr_name";
      // 
      // dataColumn3
      // 
      this.dataColumn3.ColumnName = "mbr_id";
      // 
      // dataColumn4
      // 
      this.dataColumn4.ColumnName = "mbr_pwd";
      // 
      // dataColumn5
      // 
      this.dataColumn5.ColumnName = "mbr_gender";
      // 
      // dataColumn6
      // 
      this.dataColumn6.ColumnName = "mbr_phone";
      // 
      // dataColumn7
      // 
      this.dataColumn7.ColumnName = "mbr_addr";
      // 
      // dataColumn8
      // 
      this.dataColumn8.ColumnName = "mbr_status";
      // 
      // MemberView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(977, 401);
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
      ((System.ComponentModel.ISupportInitialize)(this.DisplaySet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Member)).EndInit();
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
		private System.Data.DataSet DisplaySet;
		private System.Data.DataTable Member;
		private System.Data.DataColumn dataColumn1;
		private System.Data.DataColumn dataColumn2;
		private System.Data.DataColumn dataColumn3;
		private System.Data.DataColumn dataColumn4;
		private System.Data.DataColumn dataColumn5;
		private System.Data.DataColumn dataColumn6;
		private System.Data.DataColumn dataColumn7;
		private System.Data.DataColumn dataColumn8;
		private System.Windows.Forms.DataGridViewTextBoxColumn mbrucodeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn mbrnameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn mbridDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn mbrgenderDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn mbrphoneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn mbraddrDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn mbrstatusDataGridViewTextBoxColumn;
	}
}