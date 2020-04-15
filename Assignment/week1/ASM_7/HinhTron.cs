using System;

namespace ASM_7
{
    public class HinhTron:HinhHoc
    {
       
       private float mBanKinh;

       public HinhTron() {
           mBanKinh = 0;
       }

       public HinhTron(float banKinh) {
           mBanKinh = banKinh;
       }

       public void TinhChuVi_DienTich() {
           mChuvi = 2 * (float)Math.PI * mBanKinh;
           mDientich = (float)Math.PI * mBanKinh * mBanKinh;
       }

       public override void XemChuViDienTich() {
           Console.WriteLine("Thong tin Hinh Tron");
           Console.WriteLine("Chu vi = {0}, Dien tich = {1}", mChuvi, mDientich);
       }
    }
}
