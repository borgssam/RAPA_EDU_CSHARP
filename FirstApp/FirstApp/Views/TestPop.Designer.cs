namespace FirstApp.Views
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
      this.btn_addButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btn_addButton
      // 
      this.btn_addButton.Location = new System.Drawing.Point(243, 10);
      this.btn_addButton.Name = "btn_addButton";
      this.btn_addButton.Size = new System.Drawing.Size(75, 23);
      this.btn_addButton.TabIndex = 0;
      this.btn_addButton.Text = "버튼추가";
      this.btn_addButton.UseVisualStyleBackColor = true;
      this.btn_addButton.Click += new System.EventHandler(this.btn_addButton_Click);
      // 
      // TestPop
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(500, 357);
      this.Controls.Add(this.btn_addButton);
      this.Name = "TestPop";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "TestPop";
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btn_addButton;
  }
}