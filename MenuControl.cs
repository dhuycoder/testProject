﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestThreeLayerProject2
{
    public partial class MenuControl : UserControl
    {

        public MenuControl()
        {
            InitializeComponent();

        }
        private string imageLocation;
        private PictureBoxSizeMode sizeMode;
        private string foodPrice;
        private Image image;
        private string foodName;

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MenuRightForm rightForm = new MenuRightForm();
            rightForm.Width = Form3.flpnl.Width;
            rightForm.FoodName = foodNameTxt.Text;
            rightForm.FoodPrice = foodPriceLbl.Text;
            rightForm.ImageLocation = this.imageLocation;
            rightForm.SizeMode = PictureBoxSizeMode.Zoom;
            Form3.menuRightForms.Add(rightForm);
            Form3.flpnl.Controls.Add(rightForm);

        }

        [Category("Custom Props")]
        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; foodNameTxt.Text = value; }
        }
        public string FoodPrice
        {
            get { return foodPrice; }
            set { foodPrice = value; foodPriceLbl.Text = value; }
        }
        public Image Image
        {
            get { return image; }
            set { image = value; pictureBox1.Image = value; }
        }
        public PictureBoxSizeMode SizeMode
        {
            get { return sizeMode; }
            set { sizeMode = value; pictureBox1.SizeMode = value; }
        }
        public string ImageLocation
        {
            get { return imageLocation; }
            set { imageLocation = value; pictureBox1.ImageLocation = value; }
        }
    }
}
