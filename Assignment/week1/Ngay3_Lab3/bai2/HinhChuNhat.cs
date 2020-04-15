using System;

namespace bai2
{
    class HinhChuNhat:IHinh
    {
        private float mChieuDai;
        private float mChieuRong;

        public HinhChuNhat() {
            mChieuDai = 0;
            mChieuRong = 0;
        }

        public HinhChuNhat(float chieuDai, float chieuRong) {
            mChieuDai = chieuDai;
            mChieuRong = chieuRong;
        }

        public void setChieuDai(float chieuDai) {
            mChieuDai = chieuDai;
        }

        public float getChieuDai() {
            return mChieuDai;
        }
        public void setChieuRong(float chieuRong) {
            mChieuRong = chieuRong;
        }

        public float getChieuRong() {
            return mChieuRong;
        }

        public float TinhChuVi() {
            return (mChieuDai + mChieuRong) * 2;
        }

        public float TinhDienTich() {
            return mChieuRong * mChieuDai;
        }

        public void XemThongTin() {
            Console.WriteLine("------- **** -------");
            Console.WriteLine("Thong tin hinh chu nhat");
            Console.WriteLine("Chieu dai hinh chu nhat: {0}", mChieuDai);
            Console.WriteLine("Chieu rong hinh chu nhat: {0}", mChieuRong);
            Console.WriteLine("Chu vi hinh chu nhat: {0}", TinhChuVi());
            Console.WriteLine("Dien tich hinh chu nhat: {0}", TinhDienTich());

        }
    }
}
