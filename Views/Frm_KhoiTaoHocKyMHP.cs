using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using QuanLyDuAn.Common;

namespace QuanLiDuAn.Views
{
    public partial class Frm_KhoiTaoHocKyMHP : Form
    {
        public static SqlConnection CON = new SqlConnection("Data Source=DESKTOP-GJ9RE6M\\SQLEXPRESS;Initial Catalog=ThuHocPhi;Integrated Security=True");
        public Frm_KhoiTaoHocKyMHP()
        {
            InitializeComponent();
        }


        private void Form101_Load(object sender, EventArgs e)
        {
            HienThi();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            TaoMoiHK t = new TaoMoiHK();
            t.ShowDialog();
            HienThi();
        }

  
        public void HienThi() {
            CON.Open();
            DataTable DT = new DataTable();
            SqlDataAdapter SDA = new SqlDataAdapter("select * from [ThuHocPHi].[dbo].[HocKy]", CON);
            SDA.Fill(DT);
            dataGridView1.DataSource = DT;
            CON.Close();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            CON.Open();
            SqlDataAdapter SDA = new SqlDataAdapter("delete from [ThuHocPHi].[dbo].[HocKy] where hockyID='" + dataGridView1.Rows[dong].Cells[0].Value.ToString() + "' ", CON);
            SDA.SelectCommand.ExecuteNonQuery();
            CON.Close();
            MessageBox.Show("Xoa thanh cong!!!!");
            HienThi();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CapNhatHK c = new CapNhatHK();
            c.ShowDialog();
            HienThi();
        }
        int dong;
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            FormFactory.hockyid = int.Parse(dataGridView1.Rows[dong].Cells[0].Value.ToString());
            FormFactory.hocky = dataGridView1.Rows[dong].Cells[1].Value.ToString();
            FormFactory.hocphi = double.Parse(dataGridView1.Rows[dong].Cells[2].Value.ToString());
            if ((bool)dataGridView1.Rows[dong].Cells[3].Value)
            {
                FormFactory.trangthai = true;
            }
            else
            {
                FormFactory.trangthai = false;
            }
        }
    }
}
