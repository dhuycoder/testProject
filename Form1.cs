using BUSS;
using System.Net.Mail;

namespace TestThreeLayerProject2
{
    public partial class FormDangNhap : Form
    {
        public static string taikhoan;
        public static FormDangNhap DangNhap;
        DangNhapBus dnbus = new DangNhapBus();
        public FormDangNhap()
        {
            
            DangNhap = this;
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tk = taikhoanTxt.Text;
            taikhoan = tk;
            String mk = matkhauTxt.Text;

            if (dnbus.checkLogin(tk, mk))
            {
                MessageBox.Show("dang nhap thanh cong");
                Form fom2 = new Form2();
                this.Hide();
                fom2.Show();

            }
            else
            {

                MessageBox.Show("dang nhap that bai");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

            this.Hide();
            taikhoan = taikhoanTxt.Text.Trim();
            SendEmail form = new SendEmail();
            form.Show();

        }

        
    }
}
