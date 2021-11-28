class ClassIntro
{
    public static string BuyukHarf(string metin)
    {
        try
        {
            return char.ToUpper(metin[0]) + metin.Substring(1);
        }
        catch (Exception)
        {
            return metin;
        }
    }
    public static void Run(List<Musteri> KayitliMusteriler)
    {
        Console.WriteLine("1 - Yeni müşteri kaydet\n2 - Mevcut müşterileri göster\n99 - Çıkış Yap");
        Musteri musteri = new Musteri();
        Console.Write("Seçiniz >");
        switch (Console.ReadLine())
        {
            case "1":
                try
                {
                    Console.WriteLine();
                    Console.Write("Ad giriniz >");
                    musteri.Ad = BuyukHarf(Console.ReadLine());
                    Console.Write("Soyad giriniz >");
                    musteri.Soyad = BuyukHarf(Console.ReadLine());
                    Console.Write("Yaş giriniz >");
                    musteri.Yas = int.Parse(Console.ReadLine());
                    Console.Write("Doğum yeri giriniz >");
                    musteri.DogumYeri = BuyukHarf(Console.ReadLine());
                    Console.Write("Telefon giriniz > +90 ");
                    musteri.Telefon = "+90"+long.Parse(Console.ReadLine());
                    while (musteri.Telefon.Length != 13)
                    {
                        Console.WriteLine("Telefon numarası boşluk içermemeli ve başında 0 olmadan yazılmalıdır!");
                        Console.Write("Telefon giriniz > +90 ");
                        musteri.Telefon = "+90"+long.Parse(Console.ReadLine());
                    }
                    Console.WriteLine("Müşteri Kaydedildi");
                    KayitliMusteriler.Add(musteri);
                }
                catch (Exception err)
                {
                    Console.WriteLine("Bir hata ile karşılaştık! Hata mesajı: " + err.Message);
                }
                break;
            case "2":
                foreach (var musteriIndex in KayitliMusteriler)
                {
                    Console.WriteLine();
                    Console.WriteLine("ID           :  " + musteriIndex.Id);
                    Console.WriteLine("AD           :  " + musteriIndex.Ad);
                    Console.WriteLine("SOYAD        :  " + musteriIndex.Soyad);
                    Console.WriteLine("YAŞ          :  " + musteriIndex.Yas);
                    Console.WriteLine("DOĞUM YERİ   :  " + musteriIndex.DogumYeri);
                    Console.WriteLine("TELEFON      :  " + musteriIndex.Telefon);
                }
                Console.WriteLine();
                break;
            case "99":
                return;
                break;
            default:
                Console.WriteLine("Hatalı giriş!");
                Run(KayitliMusteriler);
                break;
        }
        Run(KayitliMusteriler);
        
    }
    public static void Main(string[] args)
    {
        Run(new List<Musteri>());
    }
}
class Musteri
{
    public int Id { get; set; }
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int Yas { get; set; }
    public string DogumYeri { get; set; }
    public string Telefon { get; set; }
}