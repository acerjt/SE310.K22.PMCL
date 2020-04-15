using System;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Milk milk = new Milk("MVN-330F7", "Sua tuoi khong duong", 33200, 5, DateTime.Today,DateTime.Today.AddMonths(6));
            milk.XemChiTiet();
            Socola socola = new Socola("Den","Goi","SCL-D3UK", "Socola Den My", 23500, 3);
            socola.XemChiTiet();
        }
    }
}
