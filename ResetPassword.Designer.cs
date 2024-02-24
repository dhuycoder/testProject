namespace TestThreeLayerProject2
{
    partial class ResetPassword
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
            NewPasswordTxt = new TextBox();
            ConfirmPassWordTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ResetPwdBtn = new Button();
            SuspendLayout();
            // 
            // NewPasswordTxt
            // 
            NewPasswordTxt.Location = new Point(202, 123);
            NewPasswordTxt.Name = "NewPasswordTxt";
            NewPasswordTxt.Size = new Size(278, 27);
            NewPasswordTxt.TabIndex = 0;
            // 
            // ConfirmPassWordTxt
            // 
            ConfirmPassWordTxt.Location = new Point(202, 210);
            ConfirmPassWordTxt.Name = "ConfirmPassWordTxt";
            ConfirmPassWordTxt.Size = new Size(278, 27);
            ConfirmPassWordTxt.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 126);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 2;
            label1.Text = "mật khẩu mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 217);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 3;
            label2.Text = "xác nhận mật khẩu mới";
            // 
            // ResetPwdBtn
            // 
            ResetPwdBtn.Location = new Point(386, 273);
            ResetPwdBtn.Name = "ResetPwdBtn";
            ResetPwdBtn.Size = new Size(94, 29);
            ResetPwdBtn.TabIndex = 4;
            ResetPwdBtn.Text = "Cập nhật";
            ResetPwdBtn.UseVisualStyleBackColor = true;
            ResetPwdBtn.Click += ResetPwdBtn_Click;
            // 
            // ResetPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 450);
            Controls.Add(ResetPwdBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ConfirmPassWordTxt);
            Controls.Add(NewPasswordTxt);
            Name = "ResetPassword";
            Text = "ResetPassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox NewPasswordTxt;
        private TextBox ConfirmPassWordTxt;
        private Label label1;
        private Label label2;
        private Button ResetPwdBtn;
    }
}