﻿namespace CSharpSchool.Views
{
  partial class TestPop
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
      this.button1 = new System.Windows.Forms.Button();
      this.tbox_1 = new System.Windows.Forms.TextBox();
      this.tbox_2 = new System.Windows.Forms.TextBox();
      this.tbox_3 = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label_display = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(256, 77);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(299, 154);
      this.button1.TabIndex = 0;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
      // 
      // tbox_1
      // 
      this.tbox_1.Location = new System.Drawing.Point(61, 67);
      this.tbox_1.Margin = new System.Windows.Forms.Padding(2);
      this.tbox_1.Name = "tbox_1";
      this.tbox_1.Size = new System.Drawing.Size(106, 25);
      this.tbox_1.TabIndex = 1;
      // 
      // tbox_2
      // 
      this.tbox_2.Location = new System.Drawing.Point(61, 108);
      this.tbox_2.Margin = new System.Windows.Forms.Padding(2);
      this.tbox_2.Name = "tbox_2";
      this.tbox_2.Size = new System.Drawing.Size(106, 25);
      this.tbox_2.TabIndex = 3;
      // 
      // tbox_3
      // 
      this.tbox_3.Location = new System.Drawing.Point(61, 160);
      this.tbox_3.Margin = new System.Windows.Forms.Padding(2);
      this.tbox_3.Name = "tbox_3";
      this.tbox_3.Size = new System.Drawing.Size(106, 25);
      this.tbox_3.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(12, 77);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(46, 19);
      this.label1.TabIndex = 5;
      this.label1.Text = "이름";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(11, 111);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(46, 19);
      this.label2.TabIndex = 6;
      this.label2.Text = "나이";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(11, 163);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(46, 19);
      this.label3.TabIndex = 7;
      this.label3.Text = "성별";
      // 
      // label_display
      // 
      this.label_display.AutoSize = true;
      this.label_display.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label_display.Location = new System.Drawing.Point(75, 293);
      this.label_display.Name = "label_display";
      this.label_display.Size = new System.Drawing.Size(104, 43);
      this.label_display.TabIndex = 8;
      this.label_display.Text = "좌표";
      // 
      // TestPop
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.label_display);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tbox_2);
      this.Controls.Add(this.tbox_3);
      this.Controls.Add(this.tbox_1);
      this.Controls.Add(this.button1);
      this.Name = "TestPop";
      this.Text = "TestPop";
      this.Load += new System.EventHandler(this.TestPop_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.TextBox tbox_1;
    private System.Windows.Forms.TextBox tbox_2;
    private System.Windows.Forms.TextBox tbox_3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label_display;
  }
}