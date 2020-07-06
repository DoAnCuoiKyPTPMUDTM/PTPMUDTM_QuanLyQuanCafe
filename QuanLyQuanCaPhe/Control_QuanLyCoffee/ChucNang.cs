using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_QuanLyCoffee
{
    public class ChucNang
    {
        public ChucNang()
        {

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
