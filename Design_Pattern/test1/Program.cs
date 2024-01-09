using System;

class Program
{
    static void Main()
    {
        string hoTen = "Phan Nhật Hoàng";
        string maNhanVien = ChuyenChuoi(hoTen);

        Console.WriteLine("Mã nhân viên: " + maNhanVien);
    }

    static string ChuyenChuoi(string ten)
    {
        string[] a = ten.Split(" ");
        string auto = null;
        foreach (string s in a)
        {
            if (!string.IsNullOrEmpty(s))
            {
                auto += s[0] + "_";
            }
            
        }
        ten = auto.TrimEnd('_');
        return ten;
    }
}
