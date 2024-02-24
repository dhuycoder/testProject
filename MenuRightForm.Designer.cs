namespace TestThreeLayerProject2
{
    partial class MenuRightForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            foodNameTxt = new Label();
            foodPriceTxt = new Label();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(19, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 92);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // foodNameTxt
            // 
            foodNameTxt.AutoSize = true;
            foodNameTxt.Location = new Point(209, 32);
            foodNameTxt.Name = "foodNameTxt";
            foodNameTxt.Size = new Size(50, 20);
            foodNameTxt.TabIndex = 1;
            foodNameTxt.Text = "label1";
            // 
            // foodPriceTxt
            // 
            foodPriceTxt.AutoSize = true;
            foodPriceTxt.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            foodPriceTxt.Location = new Point(550, 32);
            foodPriceTxt.Name = "foodPriceTxt";
            foodPriceTxt.Size = new Size(76, 31);
            foodPriceTxt.TabIndex = 2;
            foodPriceTxt.Text = "label2";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(209, 68);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(150, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FlatStyle = FlatStyle.Popup;
            comboBox1.ForeColor = SystemColors.InfoText;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "S", "M", "L" });
            comboBox1.Location = new Point(378, 69);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 4;
            // 
            // MenuRightForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(foodPriceTxt);
            Controls.Add(foodNameTxt);
            Controls.Add(pictureBox1);
            Name = "MenuRightForm";
            Size = new Size(664, 123);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label foodNameTxt;
        private Label foodPriceTxt;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
    }
}
