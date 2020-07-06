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
    public partial class GUI_POS : Form
    {
        #region Properties

          SanPham_BLL_DAL bllsp = new SanPham_BLL_DAL();
          ctrl_LoaiSanPham currentLoai = new ctrl_LoaiSanPham();
          ChucNang cn = new ChucNang();
          bool checkbtnHoaDon = true;
          List<QL_LoaiSanPham> lstLoai;
          List<QL_SanPham> lstsp ;
          List<QL_ChiTietHoaDon> lstChitiet = null;
        #endregion
        
        public GUI_POS()
        {
            InitializeComponent();
            hienthiLoaiSanPham();
            HienThiSanPham(lstLoai[0].MaLoaiSP);
            this.BackColor = Color.White;
            pnHienThiSanPham.BackColor = Color.Gray;
            pnHoaDon.BackColor = Color.Gold;
            pnButton.Width = btnThemHoaDon.Width;
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
                ctrl_HienThiSanPham itemsp = new ctrl_HienThiSanPham()
                {
                    Location = new Point(templeft, top)
                };
                itemsp.insertData(lstsp[i].TenSanPham, (int)lstsp[i].Gia, Image.FromFile(@"..\..\..\GUI\img\coffe.png"));
                itemsp.masp = lstsp[i].MaSP;
                itemsp.MouseClick += itemsp_MouseClick;
                

                row++;
                top += lasteditem.Height;
                pnHienThiSanPham.Controls.Add(itemsp);

            }

            pnHienThiSanPham.AutoSize = true;
        }

        void itemsp_MouseClick(object sender, MouseEventArgs e)
        {
            if(lstChitiet == null)
            {
                return;
            }

            ctrl_HienThiSanPham ctrsp = (ctrl_HienThiSanPham) sender;
            QL_SanPham sp = lstsp.SingleOrDefault(t => t.MaSP == ctrsp.masp);
            
            if(lstChitiet.Exists(t => t.MaSP == ctrsp.masp))
            {          
                    
                foreach (ctrl_HoaDon item in pnHoaDon.Controls)
                {
                    if(item.Name == sp.MaSP)
                    {
                        item.plusMore();
                    }
                }
                lstChitiet.SingleOrDefault(t => t.MaSP == ctrsp.masp).Soluong++;                
            }
            else
            {
                QL_ChiTietHoaDon hd = new QL_ChiTietHoaDon();
                hd.Soluong = 1;
                hd.MaSP = sp.MaSP;
                lstChitiet.Add(hd);

                ctrl_HoaDon ctrhoadon = new ctrl_HoaDon();
                ctrhoadon.insertData(sp.MaSP, sp.TenSanPham, 1,(int) sp.Gia);
                ctrhoadon.Name = sp.MaSP;
                pnHoaDon.Controls.Add(ctrhoadon);
                
            }
            capnhapTongCong();
            
            
        }

        public void capnhapTongCong()
        {
            int tong = 0;
            foreach (ctrl_HoaDon item in pnHoaDon.Controls)
            {
                tong += item.TongTien;
            }
            lbTongTien.Text ="Tổng tiền: " + cn.convertGia(tong);
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
                item.MouseClick += item_Click;
                
                
                top += item.Height;
                pnLoai.Controls.Add(item);
            }
            pnLoai.AutoSize = true;

        }



        void item_Click(object sender, EventArgs e)
        {
            
            ctrl_LoaiSanPham item = (ctrl_LoaiSanPham)sender;   
            item.BackColor = Color.Aqua;
            item.Font = new Font(Label.DefaultFont, FontStyle.Bold);
            if(item == currentLoai)
            {
                return;
            }
            this.currentLoai.turnNormal();
            this.currentLoai = item;
            HienThiSanPham(item.maloai);
        }


        public void insertHoaDon()
        {
            ctrl_HoaDon hd = new ctrl_HoaDon();
            

        }

        private void btnThemHoaDon_Click(object sender, EventArgs e)
        {
            if(checkbtnHoaDon == true)
            {
                checkbtnHoaDon = false;
                btnThemHoaDon.Text = "Hủy Hóa Đơn";
                lstChitiet = new List<QL_ChiTietHoaDon>();
            }
            else
            {
                checkbtnHoaDon = true;
                btnThemHoaDon.Text = "Thêm Hóa Đơn";
                lstChitiet = null;
                pnHoaDon.Controls.Clear();
            }
        }
       
       
    }
}
