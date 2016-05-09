using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiDuAn
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        DbThuHocPhiDataContext db = new DbThuHocPhiDataContext();
        private bool Login(string username, string password)
        {
            var res = db.users.Where(o => o.username == username && o.password == password);
            if (res.Count() > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(Login(txt_username.Text, txt_password.Text))
            {
                Main f = new Main();
                f.Show();
            }
            else
            {
                MessageBox.Show("Sai thông tin đăng nhập!");
            }
        }
    }
}
