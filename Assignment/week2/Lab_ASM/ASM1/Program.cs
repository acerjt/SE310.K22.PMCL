using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASM1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            List<SinhVien> danhSachSinhVien = new List<SinhVien>();
            while (flag)
            {

                Console.Out.WriteLine("1. Xem danh sach sinh vien");
                Console.Out.WriteLine("2. Them sinh vien");
                Console.Out.WriteLine("3. Tim sinh vien");
                Console.Out.WriteLine("4. Cap nhat thong tin sinh vien");
                Console.Out.WriteLine("5. Thoat");
                Console.Out.WriteLine("Lua chon cua ban: ");
                int luaChon = Convert.ToInt32(Console.ReadLine());
                if (luaChon > 0 && luaChon < 5)
                {
                    switch(luaChon)
                    {
                        case 1:
                            danhSachSinhVien.ForEach(delegate (SinhVien sv1) 
                            {
                                sv1.XemThongTin();
                            });
                            break;
                        case 2:
                            SinhVien sv = new SinhVien();
                            sv.NhapSinhVien();
                            if(danhSachSinhVien.Find(x => x.mMaSV == sv.mMaSV) == null)
                            {
                                danhSachSinhVien.Add(sv);
                            }
                            else
                            {
                                Console.WriteLine("Ma sinh vien da ton tai");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Nhap ma sinh vien: ");
                            string masv = Console.ReadLine();
                            SinhVien s;
                            if ((s = danhSachSinhVien.Find(x => x.mMaSV == masv)) == null)
                            {
                                Console.Out.WriteLine("Khong tim thay sinh vien co ma so {0}", masv);
                            }
                            else
                            {
                                s.XemThongTin();
                            }
                            break;
                        case 4:
                            Console.WriteLine("Nhap ma sinh vien: ");
                            string masosv = Console.ReadLine();
                            SinhVien svu;
                            if ((svu = danhSachSinhVien.Find(x => x.mMaSV == masosv)) == null)
                            {
                                Console.Out.WriteLine("Khong tim thay sinh vien co ma so {0}", masosv);
                            }
                            else
                            {
                                svu.CapNhatSinhVien();
                            }
                            break;
                        case 5:
                            flag = false;
                            break;
                    }
                }

            }

        }


    }
}
