using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test1
{
    class Class1
    {

        static void Main()
        {
            Class1 instance = new Class1();
            string hoTen = "Phan Nhật Hoàng";
            string maNhanVien = instance.Check(hoTen);

            Console.WriteLine("Mã nhân viên: " + maNhanVien);
        }


        public string Check(string c)
        {
            string[] array = c.Split(" ");
            string auto = "";

            foreach (string cs in array)
            {
                if (!string.IsNullOrEmpty(cs))
                {
                    auto += cs[0] + "_";
                }
            }
            string ss = auto.TrimEnd('_');
            return ss;
        }
    }

}
