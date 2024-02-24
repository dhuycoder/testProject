using BUSS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestThreeLayerProject2
{
    public partial class SendEmail : Form
    {
        static SendEmail sendEmail = new SendEmail();
        DangNhapBus dnbus = new DangNhapBus();
        Random random = new Random();

        int randomNumber;
        int newNumber = 0;

        public SendEmail()
        {
            sendEmail = this;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string toEmail = textBox1.Text;
            randomNumber = random.Next(999999);
            try
            {
                if (dnbus.sendEmail(toEmail, randomNumber.ToString()))
                {
                    MessageBox.Show("gui email thanh cong");
                }
                else
                {
                    MessageBox.Show("gui email that bai");
                }
            }
            catch
            {
                MessageBox.Show("gui email khong hop le");
            }


        }

        private void SendEmail_Click(object sender, EventArgs e)
        {
            FormDangNhap.DangNhap.Close();
        }

        private void SendEmail_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormDangNhap.DangNhap.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == randomNumber.ToString())
            {
                MessageBox.Show("xac thuc thanh cong");
                
                ResetPassword resetPwdForm = new ResetPassword();
                resetPwdForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("xac thuc that bai");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sendEmail.Hide();
            FormDangNhap.DangNhap.Show();
        }
    }
}
