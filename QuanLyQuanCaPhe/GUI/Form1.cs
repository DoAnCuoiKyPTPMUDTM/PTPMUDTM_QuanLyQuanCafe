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
        SanPham_BLL_DAL bllsp = new SanPham_BLL_DAL();
        public Form1()
        {
            InitializeComponent();
            capnhapComboboxLoai();
        }
        public void HienThiSanPham(string maloai)
        {
            pnHienThiSanPham.Controls.Clear();
            // lấy danh sách sản phẩm theo loại
            List<QL_SanPham> lst = bllsp.laySanPham(maloai);

            int top = 0;
            int left = 0;
            int templeft = 0;
            int row = 0;
            ctrl_HienThiSanPham lasteditem = new ctrl_HienThiSanPham();

            for (int i = 0; i < lst.Count; i++)
            {                
                if(row == 10)
                {
                    templeft = lasteditem.Width;
                    row = 0;
                }
                ctrl_HienThiSanPham item = new ctrl_HienThiSanPham() { 
                    Location = new Point(templeft,top)
                };
                item.insertData(lst[i].TenSanPham,(int)lst[i].Gia,Image.FromFile(@"..\..\..\GUI\img\coffe.png"));

                row++;
                top += lasteditem.Height;
                pnHienThiSanPham.Controls.Add(item);

            }

            //for (int i = 1; i <= lst.Count; i += 2)
            //{
            //    templeft = left;
            //    for (int j = i; j <= i+1; j++)
            //    {
            //        // dieu chinh vi tri
            //        ctrl_HienThiSanPham item = new ctrl_HienThiSanPham() {
            //            Location = new Point(templeft, top)
            //        };
            //        lasteditem = item;
            //        templeft += item.Width; 

            //        // Insert Du Lieu
            //        string tensp = lst[j].TenSanPham;
            //        int gia = (int)lst[j].Gia;                    
            //        item.insertData(tensp,gia, Image.FromFile(@"..\..\..\GUI\img\coffe.png"));

            //        pnHienThiSanPham.Controls.Add(item);
                    
                    
            //    }
            //    templeft = left;
            //    top += lasteditem.Height;
                
            //}
            pnHienThiSanPham.AutoSize = true;
        }

        
        public void capnhapComboboxLoai()
        {
            comboBox1.DataSource = bllsp.layLoaiSanPham();
            comboBox1.DisplayMember = "TenLoai";
            comboBox1.ValueMember = "MaLoaiSP";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HienThiSanPham(comboBox1.SelectedValue.ToString());
        }
       
    }
}
