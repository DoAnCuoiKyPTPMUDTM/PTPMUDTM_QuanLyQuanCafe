using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_QuanLyCoffee;
using BLL_DAL;
namespace GUI
{
    public partial class Form1 : Form
    {
        #region Properties

          SanPham_BLL_DAL bllsp = new SanPham_BLL_DAL();
          ctrl_LoaiSanPham currentLoai = new ctrl_LoaiSanPham();
          List<QL_LoaiSanPham> lstLoai;
          List<QL_SanPham> lstsp;
          List<QL_ChiTietHoaDon> lstChitiet;
        #endregion
        
        public Form1()
        {
            InitializeComponent();
            hienthiLoaiSanPham();
            HienThiSanPham(lstLoai[0].MaLoaiSP);
            this.BackColor = Color.White;
           
        }
        public void HienThiSanPham(string maloai)
        {
            pnHienThiSanPham.Controls.Clear();
            // lấy danh sách sản phẩm theo loại
            lstsp = bllsp.laySanPham(maloai);

            int top = 0;
            int left = 0;
            int templeft = 0;
            int row = 0;
            ctrl_HienThiSanPham lasteditem = new ctrl_HienThiSanPham();

            for (int i = 0; i < lstsp.Count; i++)
            {
                if (row == 10)
                {
                    templeft = lasteditem.Width;
                    row = 0;
                }
                ctrl_HienThiSanPham item = new ctrl_HienThiSanPham()
                {
                    Location = new Point(templeft, top)
                };
                item.insertData(lstsp[i].TenSanPham, (int)lstsp[i].Gia, Image.FromFile(@"..\..\..\GUI\img\coffe.png"));
                item.masp = lstsp[i].MaSP;
                row++;
                top += lasteditem.Height;
                pnHienThiSanPham.Controls.Add(item);

            }

            pnHienThiSanPham.AutoSize = true;
        }
        //public void HienThiSanPham()
        //{
        //    pnHienThiSanPham.Controls.Clear();
        //    // lấy danh sách sản phẩm theo loại
          
        //    int top = 0;
        //    int left = 0;
        //    int templeft = 0;
        //    int row = 0;
        //    ctrl_HienThiSanPham lasteditem = new ctrl_HienThiSanPham();

        //    for (int i = 0; i < 20; i++)
        //    {
        //        if (row == 5)
        //        {
        //            templeft += lasteditem.Width;
        //            row = 0;
        //            top = 0;
        //        }
        //        ctrl_HienThiSanPham item = new ctrl_HienThiSanPham()
        //        {
        //            Location = new Point(templeft, top)
        //        };
        //        item.insertData("Sản Phẩm " + i, 10000000, Image.FromFile(@"..\..\..\GUI\img\coffe.png"));

        //        row++;
        //        top += lasteditem.Height;
        //        pnHienThiSanPham.Controls.Add(item);

        //    }

        //    pnHienThiSanPham.AutoSize = true;
        //}
        
     

        public void hienthiLoaiSanPham()
        {
            int top = 0;
            lstLoai = bllsp.LayLoaiSanPham();
            for (int i = 0; i < lstLoai.Count; i++)
            {
                ctrl_LoaiSanPham item = new ctrl_LoaiSanPham() { 
                   Location = new Point(0,top)
                
                };

                item.insertData(lstLoai[i].MaLoaiSP, lstLoai[i].TenLoai);
                item.Click += item_Click;
                
                
                top += item.Height;
                pnLoai.Controls.Add(item);
            }
            pnLoai.AutoSize = true;

        }

        void lbTenLoai_Click(object sender, EventArgs e)
        {
            Label lb = (Label)sender;
            currentLoai.BackColor = Color.Yellow;
            currentLoai.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            this.currentLoai.turnNormal();            
        }

        void item_Click(object sender, EventArgs e)
        {
            ctrl_LoaiSanPham item = (ctrl_LoaiSanPham)sender;            
            item.BackColor = Color.Aqua;
            item.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            this.currentLoai.turnNormal();
            this.currentLoai = item;
            HienThiSanPham(item.maloai);
        }


        public void insertHoaDon()
        {
            ctrl_HoaDon hd = new ctrl_HoaDon();
            

        }
       
       
    }
}
