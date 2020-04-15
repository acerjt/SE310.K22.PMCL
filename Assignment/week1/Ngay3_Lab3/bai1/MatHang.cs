using System;

namespace bai1
{
    public abstract class MatHang
    {
      
      protected string mMaHang;
      protected string mTenHang;
      protected float mDonGia;
      protected int mSoLuong;

      public string getMaHang() {
          return mMaHang;
      }

      public void setMaHang(string maHang) {
          mMaHang = maHang;
      }

      
      public string getTenHang() {
          return mMaHang;
      }

      public void setTenHang(string tenHang) {
          mTenHang = tenHang;
      }

      
      public float getDonGia() {
          return mDonGia;
      }

      public void setDonGia(float donGia) {
          mDonGia = donGia;
      }

      
      public int getSoLuong() {
          return mSoLuong;
      }

      public void setSoLuong(int soLuong) {
          mSoLuong = soLuong;
      }

      public abstract float ThanhTien();

      public abstract void XemChiTiet();
    }
}
