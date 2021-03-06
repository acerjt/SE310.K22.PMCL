using System;

namespace bai1
{
    public class Milk:MatHang
    {
        private DateTime mNgaySanXuat;
        private DateTime mHanSuDung;
        private string mDonViTinh;

        public Milk() {
            mMaHang = "";
            mTenHang = "";
            mDonGia = 0;
            mSoLuong = 0;
            mNgaySanXuat = DateTime.Today;
            mHanSuDung =  mNgaySanXuat.AddMonths(3);
            mDonViTinh = "";
        }

        public Milk(string maHang, string tenHang, float donGia, int soLuong, DateTime ngaySanXuat, DateTime hanSuDung, string donViTinh = "Thung" ) {
            mMaHang = maHang;
            mTenHang = tenHang;
            mDonGia = donGia;
            mSoLuong = soLuong;
            mNgaySanXuat = ngaySanXuat;
            mHanSuDung = hanSuDung;
            mDonViTinh = donViTinh;
        }

        public void setNgaySanXuat(DateTime ngaySanXuat) {
            mNgaySanXuat = ngaySanXuat;
        }

        public DateTime getNgaySanXuat() {
            return mNgaySanXuat;
        }

        public void setHanSuDUng(DateTime hanSuDung) {
            mHanSuDung = hanSuDung;
        }

        public DateTime getHanSuDung() {
            return mHanSuDung;
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
            Console.WriteLine("Ngay san xuat: {0}", mNgaySanXuat);
            Console.WriteLine("Han su dung: {0}", mHanSuDung);
            Console.WriteLine("Don vi tinh: {0}", mDonViTinh);
            Console.WriteLine("Thanh tien: {0}", ThanhTien());
        }
    }
}
