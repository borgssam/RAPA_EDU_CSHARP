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
      this.panel2 = new System.Windows.Forms.Panel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.grid_rent = new System.Windows.Forms.DataGridView();
      this.rntucodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bk_title = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rnt_rent_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rntstateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.mbrnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.mbr_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rnt_scheduled_return_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.rntreturndateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.DisplaySet = new System.Data.DataSet();
      this.dataTable1 = new System.Data.DataTable();
      this.dataColumn1 = new System.Data.DataColumn();
      this.dataColumn2 = new System.Data.DataColumn();
      this.dataColumn3 = new System.Data.DataColumn();
      this.dataColumn4 = new System.Data.DataColumn();
      this.dataColumn5 = new System.Data.DataColumn();
      this.dataColumn6 = new System.Data.DataColumn();
      this.dataColumn7 = new System.Data.DataColumn();
      this.dataColumn8 = new System.Data.DataColumn();
      this.dataColumn9 = new System.Data.DataColumn();
      this.dataColumn10 = new System.Data.DataColumn();
      this.dataColumn11 = new System.Data.DataColumn();
      this.dataColumn12 = new System.Data.DataColumn();
      this.dataColumn13 = new System.Data.DataColumn();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel8 = new System.Windows.Forms.Panel();
      this.btn_rental = new System.Windows.Forms.Button();
      this.panel7 = new System.Windows.Forms.Panel();
      this.btn_search = new System.Windows.Forms.Button();
      this.pnl_keyword = new System.Windows.Forms.Panel();
      this.tbox_keyword = new System.Windows.Forms.TextBox();
      this.pnl_rent_status = new System.Windows.Forms.Panel();
      this.cbox_rent_state = new System.Windows.Forms.ComboBox();
      this.pnl_date = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.date_end = new System.Windows.Forms.DateTimePicker();
      this.date_begin = new System.Windows.Forms.DateTimePicker();
      this.panel3 = new System.Windows.Forms.Panel();
      this.cbox_searchkind = new System.Windows.Forms.ComboBox();
      this.panel2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grid_rent)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DisplaySet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
      this.panel1.SuspendLayout();
      this.panel8.SuspendLayout();
      this.panel7.SuspendLayout();
      this.pnl_keyword.SuspendLayout();
      this.pnl_rent_status.SuspendLayout();
      this.pnl_date.SuspendLayout();
      this.panel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.groupBox1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 38);
      this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel2.Name = "panel2";
      this.panel2.Padding = new System.Windows.Forms.Padding(5);
      this.panel2.Size = new System.Drawing.Size(1158, 380);
      this.panel2.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.grid_rent);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(5, 5);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
      this.groupBox1.Size = new System.Drawing.Size(1148, 370);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "대여목록";
      // 
      // grid_rent
      // 
      this.grid_rent.AllowUserToAddRows = false;
      this.grid_rent.AllowUserToDeleteRows = false;
      this.grid_rent.AutoGenerateColumns = false;
      this.grid_rent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grid_rent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rntucodeDataGridViewTextBoxColumn,
            this.bk_title,
            this.rnt_rent_date,
            this.rntstateDataGridViewTextBoxColumn,
            this.mbrnameDataGridViewTextBoxColumn,
            this.mbr_phone,
            this.rnt_scheduled_return_date,
            this.rntreturndateDataGridViewTextBoxColumn});
      this.grid_rent.DataMember = "Rent";
      this.grid_rent.DataSource = this.DisplaySet;
      this.grid_rent.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grid_rent.Location = new System.Drawing.Point(5, 23);
      this.grid_rent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.grid_rent.Name = "grid_rent";
      this.grid_rent.ReadOnly = true;
      this.grid_rent.RowHeadersWidth = 30;
      this.grid_rent.RowTemplate.Height = 23;
      this.grid_rent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.grid_rent.Size = new System.Drawing.Size(1138, 342);
      this.grid_rent.TabIndex = 1;
      // 
      // rntucodeDataGridViewTextBoxColumn
      // 
      this.rntucodeDataGridViewTextBoxColumn.DataPropertyName = "rnt_ucode";
      this.rntucodeDataGridViewTextBoxColumn.HeaderText = "대여번호";
      this.rntucodeDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.rntucodeDataGridViewTextBoxColumn.Name = "rntucodeDataGridViewTextBoxColumn";
      this.rntucodeDataGridViewTextBoxColumn.ReadOnly = true;
      this.rntucodeDataGridViewTextBoxColumn.Width = 150;
      // 
      // bk_title
      // 
      this.bk_title.DataPropertyName = "bk_title";
      this.bk_title.HeaderText = "제목";
      this.bk_title.Name = "bk_title";
      this.bk_title.ReadOnly = true;
      // 
      // rnt_rent_date
      // 
      this.rnt_rent_date.DataPropertyName = "rnt_rent_date";
      this.rnt_rent_date.HeaderText = "대여일";
      this.rnt_rent_date.MinimumWidth = 8;
      this.rnt_rent_date.Name = "rnt_rent_date";
      this.rnt_rent_date.ReadOnly = true;
      this.rnt_rent_date.Width = 150;
      // 
      // rntstateDataGridViewTextBoxColumn
      // 
      this.rntstateDataGridViewTextBoxColumn.DataPropertyName = "rnt_state";
      this.rntstateDataGridViewTextBoxColumn.HeaderText = "대여상태";
      this.rntstateDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.rntstateDataGridViewTextBoxColumn.Name = "rntstateDataGridViewTextBoxColumn";
      this.rntstateDataGridViewTextBoxColumn.ReadOnly = true;
      this.rntstateDataGridViewTextBoxColumn.Width = 150;
      // 
      // mbrnameDataGridViewTextBoxColumn
      // 
      this.mbrnameDataGridViewTextBoxColumn.DataPropertyName = "mbr_name";
      this.mbrnameDataGridViewTextBoxColumn.HeaderText = "회원이름";
      this.mbrnameDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.mbrnameDataGridViewTextBoxColumn.Name = "mbrnameDataGridViewTextBoxColumn";
      this.mbrnameDataGridViewTextBoxColumn.ReadOnly = true;
      this.mbrnameDataGridViewTextBoxColumn.Width = 150;
      // 
      // mbr_phone
      // 
      this.mbr_phone.DataPropertyName = "mbr_phone";
      this.mbr_phone.HeaderText = "회원연락처";
      this.mbr_phone.MinimumWidth = 8;
      this.mbr_phone.Name = "mbr_phone";
      this.mbr_phone.ReadOnly = true;
      this.mbr_phone.Width = 150;
      // 
      // rnt_scheduled_return_date
      // 
      this.rnt_scheduled_return_date.DataPropertyName = "rnt_limit_date";
      this.rnt_scheduled_return_date.HeaderText = "반납예정일";
      this.rnt_scheduled_return_date.MinimumWidth = 8;
      this.rnt_scheduled_return_date.Name = "rnt_scheduled_return_date";
      this.rnt_scheduled_return_date.ReadOnly = true;
      this.rnt_scheduled_return_date.Width = 150;
      // 
      // rntreturndateDataGridViewTextBoxColumn
      // 
      this.rntreturndateDataGridViewTextBoxColumn.DataPropertyName = "rnt_return_date";
      this.rntreturndateDataGridViewTextBoxColumn.HeaderText = "반납일";
      this.rntreturndateDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.rntreturndateDataGridViewTextBoxColumn.Name = "rntreturndateDataGridViewTextBoxColumn";
      this.rntreturndateDataGridViewTextBoxColumn.ReadOnly = true;
      this.rntreturndateDataGridViewTextBoxColumn.Width = 150;
      // 
      // DisplaySet
      // 
      this.DisplaySet.DataSetName = "NewDataSet";
      this.DisplaySet.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
      // 
      // dataTable1
      // 
      this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3,
            this.dataColumn4,
            this.dataColumn5,
            this.dataColumn6,
            this.dataColumn7,
            this.dataColumn8,
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13});
      this.dataTable1.TableName = "Rent";
      // 
      // dataColumn1
      // 
      this.dataColumn1.ColumnName = "rnt_ucode";
      this.dataColumn1.DataType = typeof(int);
      // 
      // dataColumn2
      // 
      this.dataColumn2.ColumnName = "rnt_rent_date";
      this.dataColumn2.DataType = typeof(System.DateTime);
      this.dataColumn2.DateTimeMode = System.Data.DataSetDateTime.Local;
      // 
      // dataColumn3
      // 
      this.dataColumn3.ColumnName = "rnt_return_date";
      this.dataColumn3.DataType = typeof(System.DateTime);
      this.dataColumn3.DateTimeMode = System.Data.DataSetDateTime.Local;
      // 
      // dataColumn4
      // 
      this.dataColumn4.ColumnName = "rnt_state";
      // 
      // dataColumn5
      // 
      this.dataColumn5.ColumnName = "bk_ucode";
      this.dataColumn5.DataType = typeof(int);
      // 
      // dataColumn6
      // 
      this.dataColumn6.ColumnName = "bk_title";
      // 
      // dataColumn7
      // 
      this.dataColumn7.ColumnName = "mbr_ucode";
      this.dataColumn7.DataType = typeof(int);
      // 
      // dataColumn8
      // 
      this.dataColumn8.ColumnName = "mbr_name";
      // 
      // dataColumn9
      // 
      this.dataColumn9.ColumnName = "rnt_scheduled_return_date";
      this.dataColumn9.DataType = typeof(System.DateTime);
      this.dataColumn9.DateTimeMode = System.Data.DataSetDateTime.Local;
      // 
      // dataColumn10
      // 
      this.dataColumn10.ColumnName = "mbr_phone";
      // 
      // dataColumn11
      // 
      this.dataColumn11.ColumnName = "rnt_limit_date";
      // 
      // dataColumn12
      // 
      this.dataColumn12.ColumnName = "stf_reg_id";
      // 
      // dataColumn13
      // 
      this.dataColumn13.ColumnName = "stf_return_id";
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
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1158, 38);
      this.panel1.TabIndex = 0;
      // 
      // panel8
      // 
      this.panel8.Controls.Add(this.btn_rental);
      this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel8.Location = new System.Drawing.Point(1020, 0);
      this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel8.Name = "panel8";
      this.panel8.Size = new System.Drawing.Size(138, 38);
      this.panel8.TabIndex = 5;
      // 
      // btn_rental
      // 
      this.btn_rental.Location = new System.Drawing.Point(3, 2);
      this.btn_rental.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btn_rental.Name = "btn_rental";
      this.btn_rental.Size = new System.Drawing.Size(126, 31);
      this.btn_rental.TabIndex = 0;
      this.btn_rental.Text = "대여 && 반납";
      this.btn_rental.UseVisualStyleBackColor = true;
      this.btn_rental.Click += new System.EventHandler(this.btn_rental_Click);
      // 
      // panel7
      // 
      this.panel7.Controls.Add(this.btn_search);
      this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel7.Location = new System.Drawing.Point(917, 0);
      this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel7.Name = "panel7";
      this.panel7.Size = new System.Drawing.Size(82, 38);
      this.panel7.TabIndex = 4;
      // 
      // btn_search
      // 
      this.btn_search.Location = new System.Drawing.Point(6, 2);
      this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btn_search.Name = "btn_search";
      this.btn_search.Size = new System.Drawing.Size(72, 31);
      this.btn_search.TabIndex = 0;
      this.btn_search.Text = "조회";
      this.btn_search.UseVisualStyleBackColor = true;
      this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
      // 
      // pnl_keyword
      // 
      this.pnl_keyword.Controls.Add(this.tbox_keyword);
      this.pnl_keyword.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnl_keyword.Location = new System.Drawing.Point(744, 0);
      this.pnl_keyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.pnl_keyword.Name = "pnl_keyword";
      this.pnl_keyword.Padding = new System.Windows.Forms.Padding(5);
      this.pnl_keyword.Size = new System.Drawing.Size(173, 38);
      this.pnl_keyword.TabIndex = 3;
      // 
      // tbox_keyword
      // 
      this.tbox_keyword.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbox_keyword.Location = new System.Drawing.Point(5, 5);
      this.tbox_keyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tbox_keyword.Name = "tbox_keyword";
      this.tbox_keyword.Size = new System.Drawing.Size(163, 25);
      this.tbox_keyword.TabIndex = 0;
      // 
      // pnl_rent_status
      // 
      this.pnl_rent_status.Controls.Add(this.cbox_rent_state);
      this.pnl_rent_status.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnl_rent_status.Location = new System.Drawing.Point(589, 0);
      this.pnl_rent_status.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.pnl_rent_status.Name = "pnl_rent_status";
      this.pnl_rent_status.Padding = new System.Windows.Forms.Padding(5);
      this.pnl_rent_status.Size = new System.Drawing.Size(155, 38);
      this.pnl_rent_status.TabIndex = 2;
      // 
      // cbox_rent_state
      // 
      this.cbox_rent_state.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cbox_rent_state.Font = new System.Drawing.Font("굴림", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.cbox_rent_state.FormattingEnabled = true;
      this.cbox_rent_state.Items.AddRange(new object[] {
            "대여중",
            "연체중"});
      this.cbox_rent_state.Location = new System.Drawing.Point(5, 5);
      this.cbox_rent_state.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.cbox_rent_state.Name = "cbox_rent_state";
      this.cbox_rent_state.Size = new System.Drawing.Size(145, 21);
      this.cbox_rent_state.TabIndex = 1;
      // 
      // pnl_date
      // 
      this.pnl_date.Controls.Add(this.label1);
      this.pnl_date.Controls.Add(this.date_end);
      this.pnl_date.Controls.Add(this.date_begin);
      this.pnl_date.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnl_date.Location = new System.Drawing.Point(160, 0);
      this.pnl_date.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.pnl_date.Name = "pnl_date";
      this.pnl_date.Size = new System.Drawing.Size(429, 38);
      this.pnl_date.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(203, 10);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(10, 10);
      this.label1.TabIndex = 2;
      this.label1.Text = "~";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // date_end
      // 
      this.date_end.Location = new System.Drawing.Point(219, 6);
      this.date_end.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.date_end.Name = "date_end";
      this.date_end.Size = new System.Drawing.Size(197, 25);
      this.date_end.TabIndex = 1;
      // 
      // date_begin
      // 
      this.date_begin.Location = new System.Drawing.Point(8, 6);
      this.date_begin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.date_begin.Name = "date_begin";
      this.date_begin.Size = new System.Drawing.Size(189, 25);
      this.date_begin.TabIndex = 0;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.cbox_searchkind);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel3.Location = new System.Drawing.Point(0, 0);
      this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel3.Name = "panel3";
      this.panel3.Padding = new System.Windows.Forms.Padding(5);
      this.panel3.Size = new System.Drawing.Size(160, 38);
      this.panel3.TabIndex = 0;
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
      this.cbox_searchkind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.cbox_searchkind.Name = "cbox_searchkind";
      this.cbox_searchkind.Size = new System.Drawing.Size(150, 21);
      this.cbox_searchkind.TabIndex = 0;
      this.cbox_searchkind.SelectedIndexChanged += new System.EventHandler(this.cbox_searchkind_SelectedIndexChanged);
      // 
      // RentView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1158, 418);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "RentView";
      this.Text = "RentView";
      this.Load += new System.EventHandler(this.RentView_Load);
      this.panel2.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grid_rent)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DisplaySet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel8.ResumeLayout(false);
      this.panel7.ResumeLayout(false);
      this.pnl_keyword.ResumeLayout(false);
      this.pnl_keyword.PerformLayout();
      this.pnl_rent_status.ResumeLayout(false);
      this.pnl_date.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel8;
    private System.Windows.Forms.Button btn_rental;
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
    private System.Windows.Forms.ComboBox cbox_rent_state;
    private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView grid_rent;
		private System.Data.DataSet DisplaySet;
		private System.Data.DataTable dataTable1;
		private System.Data.DataColumn dataColumn1;
		private System.Data.DataColumn dataColumn2;
		private System.Data.DataColumn dataColumn3;
		private System.Data.DataColumn dataColumn4;
		private System.Data.DataColumn dataColumn5;
		private System.Data.DataColumn dataColumn6;
		private System.Data.DataColumn dataColumn7;
		private System.Data.DataColumn dataColumn8;
		private System.Data.DataColumn dataColumn9;
		private System.Data.DataColumn dataColumn10;
		private System.Data.DataColumn dataColumn11;
		private System.Data.DataColumn dataColumn12;
		private System.Data.DataColumn dataColumn13;
    private System.Windows.Forms.DataGridViewTextBoxColumn rntucodeDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn bk_title;
    private System.Windows.Forms.DataGridViewTextBoxColumn rnt_rent_date;
    private System.Windows.Forms.DataGridViewTextBoxColumn rntstateDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn mbrnameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn mbr_phone;
    private System.Windows.Forms.DataGridViewTextBoxColumn rnt_scheduled_return_date;
    private System.Windows.Forms.DataGridViewTextBoxColumn rntreturndateDataGridViewTextBoxColumn;
  }
}