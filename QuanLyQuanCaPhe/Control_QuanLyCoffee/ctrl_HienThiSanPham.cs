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
    public partial class ctrl_HienThiSanPham : UserControl
    {
        public string masp;   
        public ctrl_HienThiSanPham()
        {
            InitializeComponent();
            setEvent();
        }

        public void setEvent()
        {
           
            this.MouseLeave += ctrl_HienThiSanPham_MouseLeave;
            this.MouseEnter += ctrl_HienThiSanPham_MouseEnter;
            lbGiaSanPham.MouseEnter += ctrl_HienThiSanPham_MouseEnter;
            lbGiaSanPham.MouseLeave += ctrl_HienThiSanPham_MouseLeave;
            lbTenSanPham.MouseEnter += ctrl_HienThiSanPham_MouseEnter;
            lbTenSanPham.MouseLeave += ctrl_HienThiSanPham_MouseLeave;
            pictureBox1.MouseEnter += ctrl_HienThiSanPham_MouseEnter;
            pictureBox1.MouseLeave += ctrl_HienThiSanPham_MouseLeave;
            this.BackColor = Color.FromArgb(204,0,0);
            
        }

        void ctrl_HienThiSanPham_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(242,242,242);
        }

        void ctrl_HienThiSanPham_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(204, 0, 0);
        }

        void ctrl_HienThiSanPham_MouseHover(object sender, EventArgs e)
        {           
            
        }
      

        public void insertData(string tensanpham, int giasp, Image Hinh)
        {
            lbTenSanPham.Text = tensanpham;
            lbGiaSanPham.Text = convertGia(giasp);
            pictureBox1.Image = Hinh;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public string convertGia(int giasp)
        {
            string gia = giasp.ToString();
            string newgia = " đ";
            int count = 0;
            
            for (int i = gia.Length - 1; i >= 0; i--)
            {
               if( count == 3)
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
