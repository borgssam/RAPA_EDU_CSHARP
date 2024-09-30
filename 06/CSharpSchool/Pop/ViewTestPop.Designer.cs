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
      this.btn_member = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.btn_rent = new System.Windows.Forms.Button();
      this.btn_book = new System.Windows.Forms.Button();
      this.view_space = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // btn_member
      // 
      this.btn_member.Location = new System.Drawing.Point(31, 21);
      this.btn_member.Name = "btn_member";
      this.btn_member.Size = new System.Drawing.Size(75, 23);
      this.btn_member.TabIndex = 0;
      this.btn_member.Text = "회원창";
      this.btn_member.UseVisualStyleBackColor = true;
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
      this.panel1.Size = new System.Drawing.Size(1002, 59);
      this.panel1.TabIndex = 1;
      // 
      // btn_rent
      // 
      this.btn_rent.Location = new System.Drawing.Point(242, 21);
      this.btn_rent.Name = "btn_rent";
      this.btn_rent.Size = new System.Drawing.Size(75, 23);
      this.btn_rent.TabIndex = 2;
      this.btn_rent.Text = "대여창";
      this.btn_rent.UseVisualStyleBackColor = true;
      this.btn_rent.Click += new System.EventHandler(this.btn_rent_Click);
      // 
      // btn_book
      // 
      this.btn_book.Location = new System.Drawing.Point(133, 21);
      this.btn_book.Name = "btn_book";
      this.btn_book.Size = new System.Drawing.Size(75, 23);
      this.btn_book.TabIndex = 1;
      this.btn_book.Text = "도서창";
      this.btn_book.UseVisualStyleBackColor = true;
      this.btn_book.Click += new System.EventHandler(this.btn_book_Click);
      // 
      // view_space
      // 
      this.view_space.BackColor = System.Drawing.SystemColors.ControlDark;
      this.view_space.Dock = System.Windows.Forms.DockStyle.Fill;
      this.view_space.Location = new System.Drawing.Point(0, 0);
      this.view_space.Name = "view_space";
      this.view_space.Size = new System.Drawing.Size(1564, 715);
      this.view_space.TabIndex = 2;
      // 
      // panel2
      // 
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel2.Controls.Add(this.view_space);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 74);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(1253, 574);
      this.panel2.TabIndex = 3;
      // 
      // ViewTestPop
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1002, 518);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Name = "ViewTestPop";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "TestPop";
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btn_member;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btn_rent;
    private System.Windows.Forms.Button btn_book;
    private System.Windows.Forms.Panel view_space;
    private System.Windows.Forms.Panel panel2;
  }
}