using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUSS;
using DAO;
namespace TestThreeLayerProject2
{
    public partial class Form2 : Form
    {
        SinhVienBUS svbus = new SinhVienBUS();
        public Form2()
        {
            InitializeComponent();
            LoadGridView();

        }
        public void LoadGridView()
        {
            sinhvienDgrd.DataSource = svbus.getDataSoucre();
        }
        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("cam on ban");
            FormDangNhap.DangNhap.Close();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string masv = msvTXT.Text;
            string Tensv = tenSVtxt.Text;
            string diaChi = diaChitxt.Text;
            svbus.ThemSinhVien(masv, Tensv, diaChi);
            LoadGridView();
        }

        private void button3_Click(object sender, EventArgs e)
        {
    
            Form3 form3 = new Form3();
            form3.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
        }
    }
}
