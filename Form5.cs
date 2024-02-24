using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestThreeLayerProject2.Properties;

namespace TestThreeLayerProject2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public static String imageLocation = "";
        private void button1_Click(object sender, EventArgs e)
        {
           
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg) | *.jpg | PNG files(*.png)|*.png| All files(*.*)|*.*";
                if(dialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pictureBox1.ImageLocation = imageLocation;
                }

            }
            catch {
                MessageBox.Show("An Error Ocurred","error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MenuControl menuControl = new MenuControl();
            menuControl.ImageLocation = imageLocation;
            menuControl.FoodName = foodNameTxt.Text;
            menuControl.FoodPrice = foodPriceTxt.Text;
            menuControl.SizeMode = PictureBoxSizeMode.Zoom;
            menuControl.Margin = new Padding(0,10,20,20);   
            Form3.menuControls.Add(menuControl);

        }
    }
}
