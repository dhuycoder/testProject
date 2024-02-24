namespace TestThreeLayerProject2
{
    partial class MenuControl
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
            foodPriceLbl = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Location = new Point(13, 63);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(380, 148);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // foodNameTxt
            // 
            foodNameTxt.AutoSize = true;
            foodNameTxt.Location = new Point(29, 231);
            foodNameTxt.Name = "foodNameTxt";
            foodNameTxt.Size = new Size(50, 20);
            foodNameTxt.TabIndex = 1;
            foodNameTxt.Text = "label1";
            // 
            // foodPriceLbl
            // 
            foodPriceLbl.AutoSize = true;
            foodPriceLbl.Location = new Point(320, 231);
            foodPriceLbl.Name = "foodPriceLbl";
            foodPriceLbl.Size = new Size(50, 20);
            foodPriceLbl.TabIndex = 2;
            foodPriceLbl.Text = "label2";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.DarkRed;
            iconButton1.BackgroundImageLayout = ImageLayout.None;
            iconButton1.FlatStyle = FlatStyle.Popup;
            iconButton1.ForeColor = SystemColors.ControlText;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(324, 15);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(5, 5, 0, 0);
            iconButton1.Size = new Size(69, 42);
            iconButton1.TabIndex = 3;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // MenuControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(iconButton1);
            Controls.Add(foodPriceLbl);
            Controls.Add(foodNameTxt);
            Controls.Add(pictureBox1);
            Name = "MenuControl";
            Size = new Size(411, 270);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label foodNameTxt;
        private Label foodPriceLbl;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
