using BUSS;
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
    public partial class ResetPassword : Form
    {
        DangNhapBus dnbus = new DangNhapBus();
        public ResetPassword()
        {
            InitializeComponent();
        }

        private void ResetPwdBtn_Click(object sender, EventArgs e)
        {
            if(NewPasswordTxt.Text == ConfirmPassWordTxt.Text)
            {
                string password = NewPasswordTxt.Text;
                dnbus.ResetPassword(password, FormDangNhap.taikhoan);
            }
            else
            {
                MessageBox.Show("Mật khẩu không trùng khớp ");
            }
            
        }
    }
}
