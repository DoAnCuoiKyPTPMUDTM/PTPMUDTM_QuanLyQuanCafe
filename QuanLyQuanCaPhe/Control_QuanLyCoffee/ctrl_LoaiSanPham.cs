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
    public partial class ctrl_LoaiSanPham : UserControl
    {
        #region Properties
        public string maloai;
  
        
        #endregion
        public ctrl_LoaiSanPham()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            lbLoaiSP.BackColor = Color.Aqua;
            setEvent();

        }

        public void insertData(string maloai, string tenloai)
        {
            lbLoaiSP.Text = tenloai;
            this.maloai = maloai;

        }

        public void setEvent()
        {
            lbLoaiSP.Click += lbLoaiSP_Click;
            

        }

        void lbLoaiSP_Click(object sender, EventArgs e)
        {
                     
        }

        
        
        public void turnNormal()
        {
            this.BackColor = Color.White;            
            this.Font = new Font(Label.DefaultFont, FontStyle.Regular);

        }

    }
}
