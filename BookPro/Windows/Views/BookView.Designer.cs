namespace BookPro.Windows.Views
{
  partial class BookView
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel7 = new System.Windows.Forms.Panel();
      this.btn_search = new System.Windows.Forms.Button();
      this.pnl_keyword = new System.Windows.Forms.Panel();
      this.tbox_keyword = new System.Windows.Forms.TextBox();
      this.pnl_category = new System.Windows.Forms.Panel();
      this.cbox_category = new System.Windows.Forms.ComboBox();
      this.panel4 = new System.Windows.Forms.Panel();
      this.btn_delete_book = new System.Windows.Forms.Button();
      this.btn_add_book = new System.Windows.Forms.Button();
      this.panel3 = new System.Windows.Forms.Panel();
      this.cbox_searchkind = new System.Windows.Forms.ComboBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.grid_book = new System.Windows.Forms.DataGridView();
      this.bkucodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bktitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bkwriterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bkpubsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bkpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bkpubyearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bkregdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.bkerasedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ctgucodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ctgnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
      this.Book = new System.Data.DataTable();
      this.dataColumn9 = new System.Data.DataColumn();
      this.dataColumn10 = new System.Data.DataColumn();
      this.dataColumn11 = new System.Data.DataColumn();
      this.dataColumn12 = new System.Data.DataColumn();
      this.dataColumn13 = new System.Data.DataColumn();
      this.dataColumn14 = new System.Data.DataColumn();
      this.dataColumn15 = new System.Data.DataColumn();
      this.dataColumn16 = new System.Data.DataColumn();
      this.dataColumn17 = new System.Data.DataColumn();
      this.dataColumn18 = new System.Data.DataColumn();
      this.panel1.SuspendLayout();
      this.panel7.SuspendLayout();
      this.pnl_keyword.SuspendLayout();
      this.pnl_category.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grid_book)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.DisplaySet)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Member)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.Book)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.panel7);
      this.panel1.Controls.Add(this.pnl_keyword);
      this.panel1.Controls.Add(this.pnl_category);
      this.panel1.Controls.Add(this.panel4);
      this.panel1.Controls.Add(this.panel3);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1048, 34);
      this.panel1.TabIndex = 0;
      // 
      // panel7
      // 
      this.panel7.Controls.Add(this.btn_search);
      this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel7.Location = new System.Drawing.Point(393, 0);
      this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel7.Name = "panel7";
      this.panel7.Size = new System.Drawing.Size(77, 34);
      this.panel7.TabIndex = 4;
      // 
      // btn_search
      // 
      this.btn_search.Location = new System.Drawing.Point(6, 4);
      this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btn_search.Name = "btn_search";
      this.btn_search.Size = new System.Drawing.Size(66, 23);
      this.btn_search.TabIndex = 0;
      this.btn_search.Text = "조회";
      this.btn_search.UseVisualStyleBackColor = true;
      this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
      // 
      // pnl_keyword
      // 
      this.pnl_keyword.Controls.Add(this.tbox_keyword);
      this.pnl_keyword.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnl_keyword.Location = new System.Drawing.Point(262, 0);
      this.pnl_keyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.pnl_keyword.Name = "pnl_keyword";
      this.pnl_keyword.Padding = new System.Windows.Forms.Padding(4);
      this.pnl_keyword.Size = new System.Drawing.Size(131, 34);
      this.pnl_keyword.TabIndex = 3;
      // 
      // tbox_keyword
      // 
      this.tbox_keyword.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbox_keyword.Location = new System.Drawing.Point(4, 4);
      this.tbox_keyword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tbox_keyword.Name = "tbox_keyword";
      this.tbox_keyword.Size = new System.Drawing.Size(123, 21);
      this.tbox_keyword.TabIndex = 0;
      // 
      // pnl_category
      // 
      this.pnl_category.Controls.Add(this.cbox_category);
      this.pnl_category.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnl_category.Location = new System.Drawing.Point(131, 0);
      this.pnl_category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.pnl_category.Name = "pnl_category";
      this.pnl_category.Padding = new System.Windows.Forms.Padding(4);
      this.pnl_category.Size = new System.Drawing.Size(131, 34);
      this.pnl_category.TabIndex = 2;
      // 
      // cbox_category
      // 
      this.cbox_category.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cbox_category.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.cbox_category.FormattingEnabled = true;
      this.cbox_category.Location = new System.Drawing.Point(4, 4);
      this.cbox_category.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.cbox_category.Name = "cbox_category";
      this.cbox_category.Size = new System.Drawing.Size(123, 22);
      this.cbox_category.TabIndex = 1;
      this.cbox_category.SelectedIndexChanged += new System.EventHandler(this.cbox_category_SelectedIndexChanged);
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.btn_delete_book);
      this.panel4.Controls.Add(this.btn_add_book);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel4.Location = new System.Drawing.Point(899, 0);
      this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(149, 34);
      this.panel4.TabIndex = 1;
      // 
      // btn_delete_book
      // 
      this.btn_delete_book.Location = new System.Drawing.Point(74, 4);
      this.btn_delete_book.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btn_delete_book.Name = "btn_delete_book";
      this.btn_delete_book.Size = new System.Drawing.Size(66, 23);
      this.btn_delete_book.TabIndex = 2;
      this.btn_delete_book.Text = "도서삭제";
      this.btn_delete_book.UseVisualStyleBackColor = true;
      this.btn_delete_book.Click += new System.EventHandler(this.btn_delete_book_Click);
      // 
      // btn_add_book
      // 
      this.btn_add_book.Location = new System.Drawing.Point(4, 4);
      this.btn_add_book.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btn_add_book.Name = "btn_add_book";
      this.btn_add_book.Size = new System.Drawing.Size(66, 23);
      this.btn_add_book.TabIndex = 1;
      this.btn_add_book.Text = "도서추가";
      this.btn_add_book.UseVisualStyleBackColor = true;
      this.btn_add_book.Click += new System.EventHandler(this.btn_add_book_Click);
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.cbox_searchkind);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel3.Location = new System.Drawing.Point(0, 0);
      this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel3.Name = "panel3";
      this.panel3.Padding = new System.Windows.Forms.Padding(4);
      this.panel3.Size = new System.Drawing.Size(131, 34);
      this.panel3.TabIndex = 0;
      // 
      // cbox_searchkind
      // 
      this.cbox_searchkind.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cbox_searchkind.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.cbox_searchkind.FormattingEnabled = true;
      this.cbox_searchkind.Items.AddRange(new object[] {
            "제목",
            "분류",
            "저자",
            "출판사"});
      this.cbox_searchkind.Location = new System.Drawing.Point(4, 4);
      this.cbox_searchkind.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.cbox_searchkind.Name = "cbox_searchkind";
      this.cbox_searchkind.Size = new System.Drawing.Size(123, 22);
      this.cbox_searchkind.TabIndex = 0;
      this.cbox_searchkind.SelectedIndexChanged += new System.EventHandler(this.cbox_searchkind_SelectedIndexChanged);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.groupBox1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 34);
      this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel2.Name = "panel2";
      this.panel2.Padding = new System.Windows.Forms.Padding(4);
      this.panel2.Size = new System.Drawing.Size(1048, 300);
      this.panel2.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.grid_book);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(4, 4);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
      this.groupBox1.Size = new System.Drawing.Size(1040, 292);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "도서목록";
      // 
      // grid_book
      // 
      this.grid_book.AllowUserToAddRows = false;
      this.grid_book.AllowUserToDeleteRows = false;
      this.grid_book.AutoGenerateColumns = false;
      this.grid_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grid_book.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bkucodeDataGridViewTextBoxColumn,
            this.bktitleDataGridViewTextBoxColumn,
            this.bkwriterDataGridViewTextBoxColumn,
            this.bkpubsDataGridViewTextBoxColumn,
            this.bkpriceDataGridViewTextBoxColumn,
            this.bkpubyearDataGridViewTextBoxColumn,
            this.bkregdateDataGridViewTextBoxColumn,
            this.bkerasedateDataGridViewTextBoxColumn,
            this.ctgucodeDataGridViewTextBoxColumn,
            this.ctgnameDataGridViewTextBoxColumn});
      this.grid_book.DataMember = "Book";
      this.grid_book.DataSource = this.DisplaySet;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle3.Format = "D";
      dataGridViewCellStyle3.NullValue = null;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.grid_book.DefaultCellStyle = dataGridViewCellStyle3;
      this.grid_book.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grid_book.Location = new System.Drawing.Point(4, 18);
      this.grid_book.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.grid_book.Name = "grid_book";
      this.grid_book.ReadOnly = true;
      this.grid_book.RowHeadersWidth = 25;
      this.grid_book.RowTemplate.Height = 27;
      this.grid_book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.grid_book.Size = new System.Drawing.Size(1032, 270);
      this.grid_book.TabIndex = 0;
      this.grid_book.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_book_CellContentClick);
      this.grid_book.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grid_book_MouseDoubleClick);
      // 
      // bkucodeDataGridViewTextBoxColumn
      // 
      this.bkucodeDataGridViewTextBoxColumn.DataPropertyName = "bk_ucode";
      this.bkucodeDataGridViewTextBoxColumn.HeaderText = "도서번호";
      this.bkucodeDataGridViewTextBoxColumn.Name = "bkucodeDataGridViewTextBoxColumn";
      this.bkucodeDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // bktitleDataGridViewTextBoxColumn
      // 
      this.bktitleDataGridViewTextBoxColumn.DataPropertyName = "bk_title";
      this.bktitleDataGridViewTextBoxColumn.HeaderText = "도서명";
      this.bktitleDataGridViewTextBoxColumn.Name = "bktitleDataGridViewTextBoxColumn";
      this.bktitleDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // bkwriterDataGridViewTextBoxColumn
      // 
      this.bkwriterDataGridViewTextBoxColumn.DataPropertyName = "bk_writer";
      this.bkwriterDataGridViewTextBoxColumn.HeaderText = "저자";
      this.bkwriterDataGridViewTextBoxColumn.Name = "bkwriterDataGridViewTextBoxColumn";
      this.bkwriterDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // bkpubsDataGridViewTextBoxColumn
      // 
      this.bkpubsDataGridViewTextBoxColumn.DataPropertyName = "bk_pubs";
      this.bkpubsDataGridViewTextBoxColumn.HeaderText = "출판사";
      this.bkpubsDataGridViewTextBoxColumn.Name = "bkpubsDataGridViewTextBoxColumn";
      this.bkpubsDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // bkpriceDataGridViewTextBoxColumn
      // 
      this.bkpriceDataGridViewTextBoxColumn.DataPropertyName = "bk_price";
      this.bkpriceDataGridViewTextBoxColumn.HeaderText = "가격";
      this.bkpriceDataGridViewTextBoxColumn.Name = "bkpriceDataGridViewTextBoxColumn";
      this.bkpriceDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // bkpubyearDataGridViewTextBoxColumn
      // 
      this.bkpubyearDataGridViewTextBoxColumn.DataPropertyName = "bk_pub_year";
      this.bkpubyearDataGridViewTextBoxColumn.HeaderText = "출판년도";
      this.bkpubyearDataGridViewTextBoxColumn.Name = "bkpubyearDataGridViewTextBoxColumn";
      this.bkpubyearDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // bkregdateDataGridViewTextBoxColumn
      // 
      this.bkregdateDataGridViewTextBoxColumn.DataPropertyName = "bk_regdate";
      dataGridViewCellStyle1.Format = "yyyy-MM-dd";
      dataGridViewCellStyle1.NullValue = null;
      this.bkregdateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
      this.bkregdateDataGridViewTextBoxColumn.HeaderText = "등록일";
      this.bkregdateDataGridViewTextBoxColumn.Name = "bkregdateDataGridViewTextBoxColumn";
      this.bkregdateDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // bkerasedateDataGridViewTextBoxColumn
      // 
      this.bkerasedateDataGridViewTextBoxColumn.DataPropertyName = "bk_erasedate";
      dataGridViewCellStyle2.Format = "yyyy-MM-dd";
      this.bkerasedateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
      this.bkerasedateDataGridViewTextBoxColumn.HeaderText = "말소일";
      this.bkerasedateDataGridViewTextBoxColumn.Name = "bkerasedateDataGridViewTextBoxColumn";
      this.bkerasedateDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // ctgucodeDataGridViewTextBoxColumn
      // 
      this.ctgucodeDataGridViewTextBoxColumn.DataPropertyName = "ctg_ucode";
      this.ctgucodeDataGridViewTextBoxColumn.HeaderText = "현재상태";
      this.ctgucodeDataGridViewTextBoxColumn.Name = "ctgucodeDataGridViewTextBoxColumn";
      this.ctgucodeDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // ctgnameDataGridViewTextBoxColumn
      // 
      this.ctgnameDataGridViewTextBoxColumn.DataPropertyName = "ctg_name";
      this.ctgnameDataGridViewTextBoxColumn.HeaderText = "장르";
      this.ctgnameDataGridViewTextBoxColumn.Name = "ctgnameDataGridViewTextBoxColumn";
      this.ctgnameDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // DisplaySet
      // 
      this.DisplaySet.DataSetName = "NewDataSet";
      this.DisplaySet.Tables.AddRange(new System.Data.DataTable[] {
            this.Member,
            this.Book});
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
      // Book
      // 
      this.Book.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn9,
            this.dataColumn10,
            this.dataColumn11,
            this.dataColumn12,
            this.dataColumn13,
            this.dataColumn14,
            this.dataColumn15,
            this.dataColumn16,
            this.dataColumn17,
            this.dataColumn18});
      this.Book.TableName = "Book";
      // 
      // dataColumn9
      // 
      this.dataColumn9.ColumnName = "bk_ucode";
      // 
      // dataColumn10
      // 
      this.dataColumn10.ColumnName = "bk_title";
      // 
      // dataColumn11
      // 
      this.dataColumn11.ColumnName = "bk_writer";
      // 
      // dataColumn12
      // 
      this.dataColumn12.ColumnName = "bk_pubs";
      // 
      // dataColumn13
      // 
      this.dataColumn13.ColumnName = "bk_price";
      // 
      // dataColumn14
      // 
      this.dataColumn14.ColumnName = "bk_pub_year";
      // 
      // dataColumn15
      // 
      this.dataColumn15.ColumnName = "bk_regdate";
      this.dataColumn15.DataType = typeof(System.DateTime);
      this.dataColumn15.DateTimeMode = System.Data.DataSetDateTime.Local;
      // 
      // dataColumn16
      // 
      this.dataColumn16.ColumnName = "bk_erasedate";
      this.dataColumn16.DataType = typeof(System.DateTime);
      // 
      // dataColumn17
      // 
      this.dataColumn17.ColumnName = "ctg_ucode";
      // 
      // dataColumn18
      // 
      this.dataColumn18.ColumnName = "ctg_name";
      // 
      // BookView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1048, 334);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "BookView";
      this.Text = "BookView";
      this.Load += new System.EventHandler(this.BookView_Load);
      this.panel1.ResumeLayout(false);
      this.panel7.ResumeLayout(false);
      this.pnl_keyword.ResumeLayout(false);
      this.pnl_keyword.PerformLayout();
      this.pnl_category.ResumeLayout(false);
      this.panel4.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.groupBox1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grid_book)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.DisplaySet)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Member)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.Book)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel7;
    private System.Windows.Forms.Button btn_search;
    private System.Windows.Forms.Panel pnl_keyword;
    private System.Windows.Forms.TextBox tbox_keyword;
    private System.Windows.Forms.Panel pnl_category;
    private System.Windows.Forms.ComboBox cbox_category;
    private System.Windows.Forms.Button btn_delete_book;
    private System.Windows.Forms.Button btn_add_book;
    private System.Windows.Forms.ComboBox cbox_searchkind;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.DataGridView grid_book;
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
		private System.Data.DataTable Book;
		private System.Data.DataColumn dataColumn9;
		private System.Data.DataColumn dataColumn10;
		private System.Data.DataColumn dataColumn11;
		private System.Data.DataColumn dataColumn12;
		private System.Data.DataColumn dataColumn13;
		private System.Data.DataColumn dataColumn14;
		private System.Data.DataColumn dataColumn15;
		private System.Data.DataColumn dataColumn16;
		private System.Data.DataColumn dataColumn17;
		private System.Data.DataColumn dataColumn18;
		private System.Windows.Forms.DataGridViewTextBoxColumn bkucodeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bktitleDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bkwriterDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bkpubsDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bkpriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bkpubyearDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bkregdateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bkerasedateDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ctgucodeDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn ctgnameDataGridViewTextBoxColumn;
	}
}