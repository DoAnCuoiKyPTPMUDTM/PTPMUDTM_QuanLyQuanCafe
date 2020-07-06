using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_DAL
{
    public class SanPham_BLL_DAL
    {
        qlcfDataContext qlcf = new qlcfDataContext();
        public SanPham_BLL_DAL()
        {

        }

        public List<QL_SanPham> layTatCaSanPham()
        {
            return qlcf.QL_SanPhams.Select(t => t).ToList<QL_SanPham>();
        }      

        public List<QL_SanPham> laySanPham(string maloai)
        {
            return qlcf.QL_SanPhams.Where(t => t.MaLoaiSP == maloai).ToList<QL_SanPham>();
        }        


        public List<QL_LoaiSanPham> LayLoaiSanPham()
        {
            return qlcf.QL_LoaiSanPhams.Select(t => t).ToList<QL_LoaiSanPham>();
        }
    }
}
