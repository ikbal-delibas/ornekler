using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri() { Adi = "İkbal", Soyadi = "Delibaş", Id = 1, MusteriNo = "12345", TcNo = "11112222333" };
            TuzelMusteri muster2 = new TuzelMusteri() { SirketAdi="Vulada",Id=2,MusteriNo="12111",VergiNo="12121"};
            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();



        }
    }
}
