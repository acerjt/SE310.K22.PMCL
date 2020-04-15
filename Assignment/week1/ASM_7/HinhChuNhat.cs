using System;

namespace ASM_7
{
    public class HinhChuNhat:HinhHoc
    {
        private float mChieuDai;
        private float mChieuRong;

        public HinhChuNhat() {
            mChieuDai = 4;
            mChieuRong = 2;
        }

        public HinhChuNhat(float chieuDai, float chieuRong) {
            mChieuDai = chieuDai;
            mChieuRong = chieuRong;
        }

        public void TinhChuVi_DienTich() {
            mChuvi = (mChieuDai + mChieuRong) * 2;
            mDientich = mChieuDai * mChieuRong;
        }

        public override void XemChuViDienTich() {
            Console.WriteLine("Thong Tin Hinh Chu Nhat");
            Console.WriteLine("Chu vi = {0}, Dien tich = {1}", mChuvi, mDientich);
        }
    }
}
