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
      this.panel1.SuspendLayout();
      this.panel7.SuspendLayout();
      this.pnl_keyword.SuspendLayout();
      this.pnl_category.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grid_book)).BeginInit();
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
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1000, 42);
      this.panel1.TabIndex = 0;
      // 
      // panel7
      // 
      this.panel7.Controls.Add(this.btn_search);
      this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel7.Location = new System.Drawing.Point(450, 0);
      this.panel7.Name = "panel7";
      this.panel7.Size = new System.Drawing.Size(88, 42);
      this.panel7.TabIndex = 4;
      // 
      // btn_search
      // 
      this.btn_search.Location = new System.Drawing.Point(7, 5);
      this.btn_search.Name = "btn_search";
      this.btn_search.Size = new System.Drawing.Size(76, 29);
      this.btn_search.TabIndex = 0;
      this.btn_search.Text = "조회";
      this.btn_search.UseVisualStyleBackColor = true;
      // 
      // pnl_keyword
      // 
      this.pnl_keyword.Controls.Add(this.tbox_keyword);
      this.pnl_keyword.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnl_keyword.Location = new System.Drawing.Point(300, 0);
      this.pnl_keyword.Name = "pnl_keyword";
      this.pnl_keyword.Padding = new System.Windows.Forms.Padding(5);
      this.pnl_keyword.Size = new System.Drawing.Size(150, 42);
      this.pnl_keyword.TabIndex = 3;
      // 
      // tbox_keyword
      // 
      this.tbox_keyword.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbox_keyword.Location = new System.Drawing.Point(5, 5);
      this.tbox_keyword.Name = "tbox_keyword";
      this.tbox_keyword.Size = new System.Drawing.Size(140, 25);
      this.tbox_keyword.TabIndex = 0;
      // 
      // pnl_category
      // 
      this.pnl_category.Controls.Add(this.cbox_category);
      this.pnl_category.Dock = System.Windows.Forms.DockStyle.Left;
      this.pnl_category.Location = new System.Drawing.Point(150, 0);
      this.pnl_category.Name = "pnl_category";
      this.pnl_category.Padding = new System.Windows.Forms.Padding(5);
      this.pnl_category.Size = new System.Drawing.Size(150, 42);
      this.pnl_category.TabIndex = 2;
      // 
      // cbox_category
      // 
      this.cbox_category.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cbox_category.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.cbox_category.FormattingEnabled = true;
      this.cbox_category.Location = new System.Drawing.Point(5, 5);
      this.cbox_category.Name = "cbox_category";
      this.cbox_category.Size = new System.Drawing.Size(140, 25);
      this.cbox_category.TabIndex = 1;
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.btn_delete_book);
      this.panel4.Controls.Add(this.btn_add_book);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel4.Location = new System.Drawing.Point(830, 0);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(170, 42);
      this.panel4.TabIndex = 1;
      // 
      // btn_delete_book
      // 
      this.btn_delete_book.Location = new System.Drawing.Point(84, 5);
      this.btn_delete_book.Name = "btn_delete_book";
      this.btn_delete_book.Size = new System.Drawing.Size(76, 29);
      this.btn_delete_book.TabIndex = 2;
      this.btn_delete_book.Text = "도서삭제";
      this.btn_delete_book.UseVisualStyleBackColor = true;
      // 
      // btn_add_book
      // 
      this.btn_add_book.Location = new System.Drawing.Point(4, 5);
      this.btn_add_book.Name = "btn_add_book";
      this.btn_add_book.Size = new System.Drawing.Size(76, 29);
      this.btn_add_book.TabIndex = 1;
      this.btn_add_book.Text = "도서추가";
      this.btn_add_book.UseVisualStyleBackColor = true;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.cbox_searchkind);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel3.Location = new System.Drawing.Point(0, 0);
      this.panel3.Name = "panel3";
      this.panel3.Padding = new System.Windows.Forms.Padding(5);
      this.panel3.Size = new System.Drawing.Size(150, 42);
      this.panel3.TabIndex = 0;
      // 
      // cbox_searchkind
      // 
      this.cbox_searchkind.Dock = System.Windows.Forms.DockStyle.Fill;
      this.cbox_searchkind.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.cbox_searchkind.FormattingEnabled = true;
      this.cbox_searchkind.Location = new System.Drawing.Point(5, 5);
      this.cbox_searchkind.Name = "cbox_searchkind";
      this.cbox_searchkind.Size = new System.Drawing.Size(140, 25);
      this.cbox_searchkind.TabIndex = 0;
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.groupBox1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 42);
      this.panel2.Name = "panel2";
      this.panel2.Padding = new System.Windows.Forms.Padding(5);
      this.panel2.Size = new System.Drawing.Size(1000, 375);
      this.panel2.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.grid_book);
      this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.groupBox1.Location = new System.Drawing.Point(6, 6);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
      this.groupBox1.Size = new System.Drawing.Size(1238, 456);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "도서목록";
      // 
      // grid_book
      // 
      this.grid_book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grid_book.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grid_book.Location = new System.Drawing.Point(6, 29);
      this.grid_book.Name = "grid_book";
      this.grid_book.RowHeadersWidth = 51;
      this.grid_book.RowTemplate.Height = 27;
      this.grid_book.Size = new System.Drawing.Size(1535, 535);
      this.grid_book.TabIndex = 0;
      // 
      // BookView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1000, 417);
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
  }
}