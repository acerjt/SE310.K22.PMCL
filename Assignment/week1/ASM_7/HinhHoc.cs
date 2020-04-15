using System;

namespace ASM_7
{
    public class HinhHoc
    {
        protected float mChuvi;
        protected float mDientich;

        public virtual void XemChuViDienTich() {
            Console.WriteLine("Chu vi = {0}, Dien tich = {1}", mChuvi, mDientich);
        }
    }
}
