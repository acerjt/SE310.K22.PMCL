using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM1
{
    public class SinhVien
    {
        public string mMaSV { get; set; }   
        private string HoTen { get; set; }   
        private DateTime NgaySinh { get; set; }   
        private string DiaChi { get; set; }   
        private string DienThoai { get; set; }   


        public SinhVien()
        {
            mMaSV = string.Empty;
            HoTen = string.Empty;
            NgaySinh = DateTime.Now;
            DiaChi = string.Empty;
            DienThoai= string.Empty;

        }

        public SinhVien(string maSinhVien, string hoTen, DateTime ngaySinh, string diaChi, string dienThoai)
        {
            mMaSV = maSinhVien;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            DiaChi = diaChi;
            DienThoai = dienThoai;
        }
        public void NhapSinhVien()
        {
            Console.Write("Nhap ma so sinh vien: ");
            mMaSV = Console.ReadLine();
            Console.Out.Write("Nhap ho ten sinh vien: ");
            HoTen = Console.ReadLine();
            Console.Out.Write("Nhap ngay sinh sinh vien: ");
            NgaySinh = DateTime.Parse(Console.ReadLine());
            Console.Out.Write("Nhap dia chi sinh vien: ");
            DiaChi =Console.ReadLine();
            Console.Out.Write("Nhap dien thoai sinh vien: ");
            DienThoai = Console.ReadLine();
        }
        public void CapNhatSinhVien()
        {
            Console.Out.Write("Nhap ho ten sinh vien: ");
            HoTen = Console.ReadLine();
            Console.Out.Write("Nhap ngay sinh sinh vien: ");
            NgaySinh = DateTime.Parse(Console.ReadLine());
            Console.Out.Write("Nhap dia chi sinh vien: ");
            DiaChi = Console.ReadLine();
            Console.Out.Write("Nhap dien thoai sinh vien: ");
            DienThoai = Console.ReadLine();
        }
        public void XemThongTin()
        {
            Console.Out.WriteLine("Ma so sinh vien: {0}", mMaSV);
            Console.Out.WriteLine("Ho ten sinh vien: {0}", HoTen);
            Console.Out.WriteLine("Ngay sinh sinh vien: {0}/{1}/{2}", NgaySinh.Day, NgaySinh.Month, NgaySinh.Year);
            Console.Out.WriteLine("Dia chi sinh vien: {0}", DiaChi);
            Console.Out.WriteLine("Dien thoai sinh vien: {0}", DienThoai);
        }
        
       
    }
}
