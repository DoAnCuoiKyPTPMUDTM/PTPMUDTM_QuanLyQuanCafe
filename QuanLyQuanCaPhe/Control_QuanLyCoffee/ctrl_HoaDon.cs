using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_QuanLyCoffee
{
    public partial class ctrl_HoaDon : UserControl
    {
        public ctrl_HoaDon()
        {
            InitializeComponent();
        }

        public void insertData(string masp, string tensp, int soluong, int dongia)
        {
            lbMaSP.Text = masp;
            lbTenSP.Text = tensp;
            lbSoLuong.Text = soluong.ToString();
            lbDonGia.Text = convertGia(dongia);
            lbTongCong.Text = convertGia((soluong * dongia));
        }

        public string convertGia(int giasp)
        {
            string gia = giasp.ToString();
            string newgia = " đ";
            int count = 0;

            for (int i = gia.Length - 1; i >= 0; i--)
            {
                if (count == 3)
                {
                    newgia = String.Concat(",", newgia);
                    count = 0;
                }
                newgia = String.Concat(gia[i], newgia);
                count++;
            }
            return newgia;
        }
    }
}
