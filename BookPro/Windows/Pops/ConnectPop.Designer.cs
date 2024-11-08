namespace BookPro.Windows.Pops
{
  partial class ConnectPop
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
      this.btn_connect = new System.Windows.Forms.Button();
      this.panel2 = new System.Windows.Forms.Panel();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.panel6 = new System.Windows.Forms.Panel();
      this.tbox_pwd = new System.Windows.Forms.TextBox();
      this.panel5 = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.panel3 = new System.Windows.Forms.Panel();
      this.tbox_id = new System.Windows.Forms.TextBox();
      this.panel4 = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.tableLayoutPanel1.SuspendLayout();
      this.panel6.SuspendLayout();
      this.panel5.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel4.SuspendLayout();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.btn_connect);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
      this.panel1.Location = new System.Drawing.Point(309, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel1.Name = "panel1";
      this.panel1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.panel1.Size = new System.Drawing.Size(114, 72);
      this.panel1.TabIndex = 0;
      // 
      // btn_connect
      // 
      this.btn_connect.Dock = System.Windows.Forms.DockStyle.Fill;
      this.btn_connect.Location = new System.Drawing.Point(5, 5);
      this.btn_connect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.btn_connect.Name = "btn_connect";
      this.btn_connect.Size = new System.Drawing.Size(104, 62);
      this.btn_connect.TabIndex = 0;
      this.btn_connect.Text = "접속";
      this.btn_connect.UseVisualStyleBackColor = true;
      this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.tableLayoutPanel1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel2.Location = new System.Drawing.Point(0, 0);
      this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel2.Name = "panel2";
      this.panel2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
      this.panel2.Size = new System.Drawing.Size(309, 72);
      this.panel2.TabIndex = 1;
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.panel6, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
      this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(299, 62);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // panel6
      // 
      this.panel6.Controls.Add(this.tbox_pwd);
      this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel6.Location = new System.Drawing.Point(123, 32);
      this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(173, 28);
      this.panel6.TabIndex = 5;
      // 
      // tbox_pwd
      // 
      this.tbox_pwd.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbox_pwd.Location = new System.Drawing.Point(0, 0);
      this.tbox_pwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tbox_pwd.Name = "tbox_pwd";
      this.tbox_pwd.PasswordChar = '*';
      this.tbox_pwd.Size = new System.Drawing.Size(173, 25);
      this.tbox_pwd.TabIndex = 1;
      this.tbox_pwd.Text = "1234";
      // 
      // panel5
      // 
      this.panel5.Controls.Add(this.label3);
      this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel5.Location = new System.Drawing.Point(3, 32);
      this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(114, 28);
      this.panel5.TabIndex = 4;
      // 
      // label3
      // 
      this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label3.Location = new System.Drawing.Point(0, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(114, 28);
      this.label3.TabIndex = 0;
      this.label3.Text = "비밀번호";
      this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // panel3
      // 
      this.panel3.Controls.Add(this.tbox_id);
      this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel3.Location = new System.Drawing.Point(123, 2);
      this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(173, 26);
      this.panel3.TabIndex = 3;
      // 
      // tbox_id
      // 
      this.tbox_id.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbox_id.Location = new System.Drawing.Point(0, 0);
      this.tbox_id.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.tbox_id.Name = "tbox_id";
      this.tbox_id.Size = new System.Drawing.Size(173, 25);
      this.tbox_id.TabIndex = 0;
      this.tbox_id.Text = "king";
      // 
      // panel4
      // 
      this.panel4.Controls.Add(this.label1);
      this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel4.Location = new System.Drawing.Point(3, 2);
      this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(114, 26);
      this.panel4.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(114, 26);
      this.label1.TabIndex = 0;
      this.label1.Text = "아이디";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // ConnectPop
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(423, 72);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "ConnectPop";
      this.Text = "로그인";
      this.Load += new System.EventHandler(this.ConnectPop_Load);
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.panel6.ResumeLayout(false);
      this.panel6.PerformLayout();
      this.panel5.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel3.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btn_connect;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.TextBox tbox_pwd;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.TextBox tbox_id;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.Label label1;
  }
}