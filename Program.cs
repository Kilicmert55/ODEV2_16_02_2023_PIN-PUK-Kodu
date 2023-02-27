namespace ODEV2_16_02_2023
{
    internal class Program
    {
        #region PIN-PUK Kodu
        static void Main(string[] args)
        {

            int ReelPin = 1905, ReelPuk = 1905199455, Pin, YeniPin, Puk, PukHak = 10,
                PinBloke = 3, PukBloke = 10, OnayKodu = 0,
                MusteriTemsilcisiOnayKodu = 0123456789;

            Console.Write("Lütfen 4 Haneli Pin Kodunuzu Giriniz : ");
            Pin = Convert.ToInt32(Console.ReadLine());

            while (Pin != ReelPin)
            {
                for (int i = 0; i <= PinBloke; i++)
                {
                    PinBloke--;
                    Console.Clear();
                    Console.Write("Hatalı Pin Girişi Yaptınız!!!");
                    Console.WriteLine();
                    Console.WriteLine("\nKalan Hakkınız : " + PinBloke);
                    Console.WriteLine();
                    Console.Write("Lütfen Pin Kodunuzu Tekrar Giriniz : ");
                    Pin = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    if (Pin == ReelPin) break;

                    if (i == PinBloke)
                    {
                        Console.Clear();

                        Console.WriteLine("EYVAH!PİN KODUNUZ BLOKE OLDU...");
                        Console.WriteLine();
                        Console.Write("\n\nLütfen 10 Haneli Puk Kodunuzu Giriniz : ");
                        Puk = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();

                        for (int j = 9; j <= PukBloke; j--)
                        {
                            Console.WriteLine();
                            PukBloke--;
                            Console.Write("Hatalı Puk Girişi Yaptınız!!!");
                            Console.WriteLine();
                            Console.WriteLine("\n\nKalan Hakkınız :  " + j);
                            Console.WriteLine();
                            Console.Write("\n\nLütfen Puk Kodunuzu Tekrar Giriniz : ");
                            Puk = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();

                            if (j == 1)
                            {

                                Console.WriteLine("MAALESEF PUK KODUNUZ BLOKE OLDU!!!\n\n\nLütfen Müşteri Hizmetleri ile İletişime Geçiniz.");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.Write("Müşteri Temsilcisi Onay Kodu : ");
                                OnayKodu = Convert.ToInt32(Console.ReadLine());
                                Console.Clear();

                                if (OnayKodu != MusteriTemsilcisiOnayKodu)
                                {
                                    Console.WriteLine("HATTINIZ KALICI OLARAK KAPANMIŞTIR!!!");
                                    break;
                                    Console.Clear();
                                }
                                else Console.WriteLine("Tebrikler Doğru Giriş Yaptınız.TELEFONUNUZ AÇILIYOR...");
                            }


                            if (Puk == ReelPuk || OnayKodu == MusteriTemsilcisiOnayKodu)
                            {

                                ReelPin = 1905;
                                Console.Write("\n\n\nLütfen Yeni Pin Kodunuzu Giriniz : ");
                                ReelPin = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("\n\n\nLütfen Bekleyiniz.Telefonunuz Açılıyor...");
                                break;
                            }
                        }
                    }
                }
                break;
            }
        }
    }
}
#endregion