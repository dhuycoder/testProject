using System;
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
    public partial class MenuRightForm : UserControl
    {
        public MenuRightForm()
        {
            InitializeComponent();
        }
        private string imageLocation;
        private PictureBoxSizeMode sizeMode;
        private string foodPrice;
        private string foodName;
        [Category("Custom Props")]
        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; foodNameTxt.Text = value; }
        }
        public string FoodPrice
        {
            get { return foodPrice; }
            set { foodPrice = value; foodPriceTxt.Text = value; }
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
