namespace TestThreeLayerProject2
{
    partial class Form5
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            foodNameTxt = new TextBox();
            foodPriceTxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(86, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(327, 221);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(213, 346);
            button1.Name = "button1";
            button1.Size = new Size(176, 56);
            button1.TabIndex = 1;
            button1.Text = "save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // foodNameTxt
            // 
            foodNameTxt.Location = new Point(539, 95);
            foodNameTxt.Name = "foodNameTxt";
            foodNameTxt.Size = new Size(188, 27);
            foodNameTxt.TabIndex = 2;
            // 
            // foodPriceTxt
            // 
            foodPriceTxt.Location = new Point(539, 159);
            foodPriceTxt.Name = "foodPriceTxt";
            foodPriceTxt.Size = new Size(188, 27);
            foodPriceTxt.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(448, 102);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 4;
            label1.Text = "food Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(448, 166);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 5;
            label2.Text = "food Price";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(foodPriceTxt);
            Controls.Add(foodNameTxt);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private TextBox foodNameTxt;
        private TextBox foodPriceTxt;
        private Label label1;
        private Label label2;
    }
}