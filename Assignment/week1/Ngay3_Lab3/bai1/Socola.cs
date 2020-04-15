using System;

namespace bai1
{
    class Socola:MatHang
    {
        private string mMauSac;
        private string mDonViTinh;

        public Socola() {
            mMauSac = "";
            mDonViTinh = "";
            mMaHang = "";
            mTenHang = "";
            mDonGia = 0;
            mSoLuong = 0;
        }

        public Socola(string mauSac, string donViTinh, string maHang, string tenHang, float donGia, int soLuong) {
            mMauSac = mauSac;
            mDonViTinh = donViTinh;
            mMaHang = maHang;
            mTenHang = tenHang;
            mDonGia = donGia;
            mSoLuong = soLuong;
        }

        public void setMauSac(string mauSac) {
            mMauSac = mauSac;
        }

        public string getMauSac() {
            return mMauSac;
        }

        public void setDonViTinh(string donViTinh) {
            mDonViTinh = donViTinh;
        }

        public string getDonViTinh() {
            return mDonViTinh;
        }

        public override float ThanhTien() {
            return mDonGia * mSoLuong;
        }

        public override void XemChiTiet() {
            Console.WriteLine("Thong tin mat hang socola");
            Console.WriteLine("Ma mat hang: {0}", mMaHang);
            Console.WriteLine("Ten mat hang: {0}", mTenHang);
            Console.WriteLine("Don gia: {0}", mDonGia);
            Console.WriteLine("So luong: {0}", mSoLuong);
            Console.WriteLine("Mau sac: {0}", mMauSac);
            Console.WriteLine("Don vi tinh: {0}", mDonViTinh);
            Console.WriteLine("Thanh tien: {0}", ThanhTien());
        }
    }
}
