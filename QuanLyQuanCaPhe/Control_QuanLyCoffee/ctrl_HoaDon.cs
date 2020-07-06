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
        #region properties
        private int soluong;

        public int SoLuong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        private int dongia;

        public int Dongia
        {
            get { return dongia; }
            set { dongia = value; }
        }

        private int tongTien;

        public int TongTien
        {
            get { return tongTien; }
            set { tongTien = value; }
        }
        
        private ChucNang cn = new ChucNang();
        #endregion

        #region Initial
        
        #endregion
        

        #region method
        
        #endregion
        public ctrl_HoaDon()
        {
            InitializeComponent();
        }


        public void plusMore()
        {
            soluong++;
            lbSoLuong.Text = soluong.ToString();
            lbTongCong.Text = cn.convertGia(soluong * dongia);
            this.TongTien = soluong * dongia;
        }

        public void insertData(string masp, string tensp, int soluong, int dongia)
        {
            this.soluong = soluong;
            this.dongia = dongia;
            this.TongTien = soluong * dongia;
            lbMaSP.Text = masp;
            lbTenSP.Text = tensp;
            lbSoLuong.Text = soluong.ToString();
            lbDonGia.Text = "x" + cn.convertGia(dongia);
            lbTongCong.Text = cn.convertGia(tongTien);
        }

 
    }
}
