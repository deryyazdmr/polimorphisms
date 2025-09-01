namespace polimorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sepet sepet = new Sepet();
            while (true)
            {
                Urun urun = new Urun();
                Console.WriteLine("Almak istediğiniz ürünü giriniz. Çıkış için -1 e basınız. \n1-Tekstil \n2-Cep Telefonu \n3-Ekmek");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    urun = new Tekstil();
                }
                else if (secim == 2)
                {
                    urun = new CepTelefonu();
                }
                else if (secim == 3)
                {
                    urun = new Ekmek();
                }
                else if (secim == -1)
                {

                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama.Lütfen geçerli bir seçim yapınız.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }
                urun.OzellikYaz();
                sepet.SepeteEkle(urun);
            }
            sepet.SepetIceriği();
            Console.WriteLine("Sepet Toplam Tutar: " + sepet.ToplamTutar());
        }

    }
    class Urun
    {
        public string Tur { get; set; }
        public double Fiyat { get; set; }


        public virtual void OzellikYaz()
        {
            Console.WriteLine("Ürün adını giriniz.");
            Tur = Console.ReadLine();

            Console.WriteLine("Fiyatını giriniz.");
            Fiyat = Convert.ToDouble(Console.ReadLine());
        }

        public virtual double KdvUygula()
        {
            return Fiyat;
        }
    }

    class Tekstil : Urun
    {
        public string KumasTuru { get; set; }
        public string Beden { get; set; }
        public string UreticiFirma { get; set; }

        public override void OzellikYaz()
        {
            base.OzellikYaz();
            Console.WriteLine("Kumaş türünü belirtiniz.");
            KumasTuru = Console.ReadLine();
            Console.WriteLine("Beden giriniz.");
            Beden = Console.ReadLine();
            Console.WriteLine("Üretici firmayı belirtiniz.");
            UreticiFirma = Console.ReadLine();
        }
        public override double KdvUygula()
        {

            return Fiyat * 1.8;
        }

    }
    class CepTelefonu : Urun
    {
        public string Ozellik { get; set; }
        public string Marka { get; set; }

        public override void OzellikYaz()
        {
            base.OzellikYaz();
            Console.WriteLine("Ürünün özelliğini giriniz.");
            Ozellik = Console.ReadLine();
            Console.WriteLine("Markayı giriniz.");
            Marka = Console.ReadLine();
        }
        public override double KdvUygula()
        {

            return Fiyat * 2.2;
        }

    }
    class Ekmek : Urun
    {
        public double Gramaj { get; set; }

        public override void OzellikYaz()
        {
            base.OzellikYaz();
            Console.WriteLine("Gramajını belirtiniz.");
            Gramaj = Convert.ToDouble(Console.ReadLine());
        }
        public override double KdvUygula()
        {

            return Fiyat * 1.9;
        }
    }
    class Sepet
    {
        public List<Urun> Urunler = new List<Urun>();

        public void SepeteEkle(Urun urun)
        {
            Urunler.Add(urun);
        }

        public double ToplamTutar()
        {
            double toplam = 0;
            foreach (var item in Urunler)
            {
                toplam += item.KdvUygula();
            }
            return toplam;
        }
        public void SepetIceriği()
        {
            Console.WriteLine("***** Sepetinizdeki Ürünler *****");
            foreach (var item in Urunler)
            {
                Console.WriteLine($"Ürün adı: {item.Tur} \nÜrün fiyatı: {item.Fiyat} \nKdv'li fiyatı: {item.KdvUygula()}");
            }
            Sepet sepet = new Sepet();
            while (true)
            {
                Urun urun = new Urun();
                Console.WriteLine("Almak istediğiniz ürünü giriniz. Çıkış için -1 e basınız. \n1-Tekstil \n2-Cep Telefonu \n3-Ekmek");
                int secim = Convert.ToInt32(Console.ReadLine());

                if (secim == 1)
                {
                    urun = new Tekstil();
                }
                else if (secim == 2)
                {
                    urun = new CepTelefonu();
                }
                else if (secim == 3)
                {
                    urun = new Ekmek();
                }
                else if (secim == -1)
                {

                    break;
                }
                else
                {
                    Console.WriteLine("Hatalı tuşlama.Lütfen geçerli bir seçim yapınız.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    continue;
                }
                urun.OzellikYaz();
                sepet.SepeteEkle(urun);
            }
            sepet.SepetIceriği();
            Console.WriteLine("Sepet Toplam Tutar: " + sepet.ToplamTutar());
        }

    }
    class Urun
    {
        public string Tur { get; set; }
        public double Fiyat { get; set; }


        public virtual void OzellikYaz()
        {
            Console.WriteLine("Ürün adını giriniz.");
            Tur = Console.ReadLine();

            Console.WriteLine("Fiyatını giriniz.");
            Fiyat = Convert.ToDouble(Console.ReadLine());
        }

        public virtual double KdvUygula()
        {
            return Fiyat;
        }
    }

    class Tekstil : Urun
    {
        public string KumasTuru { get; set; }
        public string Beden { get; set; }
        public string UreticiFirma { get; set; }

        public override void OzellikYaz()
        {
            base.OzellikYaz();
            Console.WriteLine("Kumaş türünü belirtiniz.");
            KumasTuru = Console.ReadLine();
            Console.WriteLine("Beden giriniz.");
            Beden = Console.ReadLine();
            Console.WriteLine("Üretici firmayı belirtiniz.");
            UreticiFirma = Console.ReadLine();
        }
        public override double KdvUygula()
        {

            return Fiyat * 1.8;
        }

    }
    class CepTelefonu : Urun
    {
        public string Ozellik { get; set; }
        public string Marka { get; set; }

        public override void OzellikYaz()
        {
            base.OzellikYaz();
            Console.WriteLine("Ürünün özelliğini giriniz.");
            Ozellik = Console.ReadLine();
            Console.WriteLine("Markayı giriniz.");
            Marka = Console.ReadLine();
        }
        public override double KdvUygula()
        {

            return Fiyat * 2.2;
        }

    }
    class Ekmek : Urun
    {
        public double Gramaj { get; set; }

        public override void OzellikYaz()
        {
            base.OzellikYaz();
            Console.WriteLine("Gramajını belirtiniz.");
            Gramaj = Convert.ToDouble(Console.ReadLine());
        }
        public override double KdvUygula()
        {

            return Fiyat * 1.9;
        }
    }
    class Sepet
    {
        public List<Urun> Urunler = new List<Urun>();

        public void SepeteEkle(Urun urun)
        {
            Urunler.Add(urun);
        }

        public double ToplamTutar()
        {
            double toplam = 0;
            foreach (var item in Urunler)
            {
                toplam += item.KdvUygula();
            }
            return toplam;
        }
        public void SepetIceriği()
        {
            Console.WriteLine("***** Sepetinizdeki Ürünler *****");
            foreach (var item in Urunler)
            {
                Console.WriteLine($"Ürün adı: {item.Tur} \nÜrün fiyatı: {item.Fiyat} \nKdv'li fiyatı: {item.KdvUygula()}");
            }
        }
    }
}
