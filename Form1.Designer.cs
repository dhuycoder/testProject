namespace TestThreeLayerProject2
{
    partial class FormDangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            taikhoanTxt = new TextBox();
            matkhauTxt = new TextBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // taikhoanTxt
            // 
            taikhoanTxt.Location = new Point(590, 144);
            taikhoanTxt.Name = "taikhoanTxt";
            taikhoanTxt.Size = new Size(232, 27);
            taikhoanTxt.TabIndex = 0;
            // 
            // matkhauTxt
            // 
            matkhauTxt.Location = new Point(590, 196);
            matkhauTxt.Name = "matkhauTxt";
            matkhauTxt.Size = new Size(232, 27);
            matkhauTxt.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(590, 278);
            button1.Name = "button1";
            button1.Size = new Size(232, 51);
            button1.TabIndex = 2;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(713, 238);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 3;
            label1.Text = "Quên mật khẩu";
            label1.Click += label1_Click;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(947, 450);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(matkhauTxt);
            Controls.Add(taikhoanTxt);
            Name = "FormDangNhap";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox taikhoanTxt;
        private TextBox matkhauTxt;
        private Button button1;
        private Label label1;
    }
}
