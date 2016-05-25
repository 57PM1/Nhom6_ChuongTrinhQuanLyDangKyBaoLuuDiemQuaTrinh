using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyDuAn.Common
{
    public class FormFactory
    {
        public static int hockyid;
        public static int hocky;
        public static double hocphi;
        public static bool trangthai;
        public static Hocky getHocKy()
        {
            Hocky hk = new Hocky();
            hk.hockyID = hockyid;
            hk.hocky = hocky;
            hk.hocphi = hocphi;
            hk.trangthai = trangthai;
            return hk;
        }
    }
}
