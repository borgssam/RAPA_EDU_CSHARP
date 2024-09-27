namespace FirstApp
{
  partial class MainForm
  {
    /// <summary>
    /// 필수 디자이너 변수입니다.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 사용 중인 모든 리소스를 정리합니다.
    /// </summary>
    /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form 디자이너에서 생성한 코드

    /// <summary>
    /// 디자이너 지원에 필요한 메서드입니다. 
    /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
    /// </summary>
    private void InitializeComponent()
    {
      this.btn_confirm = new System.Windows.Forms.Button();
      this.tbox_message = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lbl_result = new System.Windows.Forms.Label();
      this.btn_color = new System.Windows.Forms.Button();
      this.btn_newdlg = new System.Windows.Forms.Button();
      this.btn_Docking = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btn_confirm
      // 
      this.btn_confirm.BackColor = System.Drawing.Color.Blue;
      this.btn_confirm.Cursor = System.Windows.Forms.Cursors.SizeAll;
      this.btn_confirm.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.btn_confirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
      this.btn_confirm.Location = new System.Drawing.Point(398, 12);
      this.btn_confirm.Name = "btn_confirm";
      this.btn_confirm.Size = new System.Drawing.Size(131, 42);
      this.btn_confirm.TabIndex = 0;
      this.btn_confirm.Text = "확인";
      this.btn_confirm.UseVisualStyleBackColor = false;
      this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
      // 
      // tbox_message
      // 
      this.tbox_message.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.tbox_message.Location = new System.Drawing.Point(122, 18);
      this.tbox_message.Name = "tbox_message";
      this.tbox_message.Size = new System.Drawing.Size(259, 30);
      this.tbox_message.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.label1.Location = new System.Drawing.Point(33, 28);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(72, 20);
      this.label1.TabIndex = 2;
      this.label1.Text = "메시지";
      // 
      // lbl_result
      // 
      this.lbl_result.AutoSize = true;
      this.lbl_result.Font = new System.Drawing.Font("굴림", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
      this.lbl_result.ForeColor = System.Drawing.Color.Red;
      this.lbl_result.Location = new System.Drawing.Point(32, 75);
      this.lbl_result.Name = "lbl_result";
      this.lbl_result.Size = new System.Drawing.Size(78, 27);
      this.lbl_result.TabIndex = 3;
      this.lbl_result.Text = "응답:";
      // 
      // btn_color
      // 
      this.btn_color.Location = new System.Drawing.Point(546, 12);
      this.btn_color.Name = "btn_color";
      this.btn_color.Size = new System.Drawing.Size(131, 42);
      this.btn_color.TabIndex = 4;
      this.btn_color.Text = "색상변경";
      this.btn_color.UseVisualStyleBackColor = true;
      this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
      // 
      // btn_newdlg
      // 
      this.btn_newdlg.Location = new System.Drawing.Point(694, 12);
      this.btn_newdlg.Name = "btn_newdlg";
      this.btn_newdlg.Size = new System.Drawing.Size(92, 42);
      this.btn_newdlg.TabIndex = 5;
      this.btn_newdlg.Text = "새창열기";
      this.btn_newdlg.UseVisualStyleBackColor = true;
      this.btn_newdlg.Click += new System.EventHandler(this.btn_newdlg_Click);
      // 
      // btn_Docking
      // 
      this.btn_Docking.Location = new System.Drawing.Point(694, 73);
      this.btn_Docking.Name = "btn_Docking";
      this.btn_Docking.Size = new System.Drawing.Size(92, 42);
      this.btn_Docking.TabIndex = 6;
      this.btn_Docking.Text = "도킹창";
      this.btn_Docking.UseVisualStyleBackColor = true;
      this.btn_Docking.Click += new System.EventHandler(this.btn_Docking_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btn_Docking);
      this.Controls.Add(this.btn_newdlg);
      this.Controls.Add(this.btn_color);
      this.Controls.Add(this.lbl_result);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.tbox_message);
      this.Controls.Add(this.btn_confirm);
      this.Name = "MainForm";
      this.Text = "메인창입니다.";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button btn_confirm;
    private System.Windows.Forms.TextBox tbox_message;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lbl_result;
    private System.Windows.Forms.Button btn_color;
    private System.Windows.Forms.Button btn_newdlg;
    private System.Windows.Forms.Button btn_Docking;
  }
}

