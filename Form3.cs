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
    
    public partial class Form3 : Form
    {
        public static FlowLayoutPanel flpnl = new FlowLayoutPanel();
        public static List<MenuControl> menuControls = new List<MenuControl>();
        public static List<MenuRightForm> menuRightForms = new List<MenuRightForm>();
        
        public Form3()
        {
            InitializeComponent();
            LoadFlowPanelLeft();
            LoadFlowPanelRight();
            flpnl = flowLayoutPanel2;

        }
        public void LoadFlowPanelLeft()
        {
            
            MenuControl[] menuControl = new MenuControl[10];
            for(int i = 0; i< 10; i++)
            {
                menuControl[i] = new MenuControl();
                menuControl[i].FoodName = "Chicken";
                menuControl[i].FoodPrice = "$4";
                menuControl[i].SizeMode = PictureBoxSizeMode.Zoom;
                menuControl[i].ImageLocation = "C:\\Users\\ADMIN\\source\\repos\\TestThreeLayerProject2\\Resources\\hamberger.jpg";
                menuControl[i].Margin = new System.Windows.Forms.Padding(0,10,20,20);
                menuControls.Add(menuControl[i]);
            }
            menuControls.ForEach(m =>
            {
                flowLayoutPanel1.Controls.Add(m);
            });
        }
        public void LoadFlowPanelRight()
        {
            if(menuRightForms.Count > 0)
            {
                menuRightForms.ForEach(m =>
                {
                    flowLayoutPanel2.Controls.Add(m);
                });
            }
        }
    }
}
