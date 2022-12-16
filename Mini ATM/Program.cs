using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int secim;
            Console.WriteLine("---- MİNİ ATM UYGULAMASINA HOŞ GELDİNİZ ----");
            Console.WriteLine("");
            Console.WriteLine("1- Bakiye Sorgulama");
            Console.WriteLine("2- Para Yatırma");
            Console.WriteLine("3- Para Çekme");
            int bakiye = 1000;
            int yatirilicakpara;
            int cekilicekpara;
            while (true)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
                secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                    
                    Console.WriteLine("Mevcut bakiyeniz " +bakiye+ " dolardır");
                }
                else if (secim == 2)
                {
                    
                    Console.WriteLine("Yatırılıcak miktarı giriniz: ");
                    yatirilicakpara = Convert.ToInt32(Console.ReadLine());
                    bakiye += yatirilicakpara;
                    

                }
                else if(secim==3)
                {
                    Console.WriteLine("Çekilecek miktarı girin: ");
                    cekilicekpara = Convert.ToInt32(Console.ReadLine());
                    if(cekilicekpara>bakiye)
                    {
                        int onay;
                        Console.WriteLine("Çektiğiniz para miktarı sonucunda hesabınız borca girecektir");
                        Console.WriteLine("Bu para çekimini onaylıyor musunuz (1- evet, 2- hayır) : ");
                        onay = Convert.ToInt32(Console.ReadLine());
                        if (onay==1)
                        {
                            bakiye -= cekilicekpara;
                            Console.WriteLine("İşleminiz tamamlandı...");
                        }
                        else if(onay==2)
                        {
                            Console.WriteLine("İşleminizi onaylamadınız...");
                            
                        }

                    }                    
                                       
                }
                else
                {
                    Console.WriteLine("Lütfen geçerli bir seçenek giriniz: ");
                    continue;
                }
            }
            
        }
        
    }
}
