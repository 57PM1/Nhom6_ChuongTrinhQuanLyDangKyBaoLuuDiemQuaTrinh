using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLiDuAn.Views;

namespace QuanLiDuAn
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void dữLiệuHọcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
           
        }

        private void thuHọcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void khởiTạoHọcKỳVàMứcHọcPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form101 f = new Form101();
            f.ShowDialog();
        }
    }
}
