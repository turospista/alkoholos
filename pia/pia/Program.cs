using System;
using System.Collections.Generic;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace pia
{

    class Piák
    {
        public string Pianév;
        public double Alkoholmennyiség;
        public int Mennyiség = 0;
        public int ID;

        public string Piatípus()
        {
            string típus = $"{Pianév} {Alkoholmennyiség} %  --- Sorszám: {ID}";
            return típus;
        }

        public int Bekérés()
        {
            int bekértID = Convert.ToInt32(Console.ReadLine());
            return bekértID;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Szia. Hogy hívnak?");
            var nev = Console.ReadLine();
            var datum = DateTime.Now;
            Console.WriteLine($"Szervusz {nev}, {datum:d} {datum:t} -kor.");

            Console.WriteLine("---------------------------------------------");

            List<Piák> itallista = new List<Piák>();

            itallista.Add(new Piák() { Pianév = "Sör", Alkoholmennyiség = 4.8, ID = 10 });
            itallista.Add(new Piák() { Pianév = "Bor", Alkoholmennyiség = 8, ID = 11 });
            itallista.Add(new Piák() { Pianév = "Whisky", Alkoholmennyiség = 42, ID = 12 });
            itallista.Add(new Piák() { Pianév = "Pálinka", Alkoholmennyiség = 48, ID = 13 });
            itallista.Add(new Piák() { Pianév = "Gin", Alkoholmennyiség = 40, ID = 14 });
            itallista.Add(new Piák() { Pianév = "Semmit", ID = 15 });

            Listakiírás(itallista);
            Mitittál();
            Console.ReadKey();
        }

            static void Listakiírás(List<Piák> itallista)
            {
                foreach (var Piák in itallista)
                {
                    Console.WriteLine(Piák.Piatípus());
                }
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("Mit ittál ma? Add meg a sorszámát:");
            }

            static void Mitittál()
            {
                foreach (var Piák in itallista)
                {
                    if (itallista.Contains(Piák.Bekérés()))
                    {
                        Console.WriteLine("Az finom. Mennyit ittál belőle?");
                    }
                    else
                    {
                        Console.WriteLine("Ezt nem szerepel a listán.");
                    }
                }
            }


            static void Alkoholkalkulátor()
            {


            }

            /*
            int sör = 0;
            int bor = 0;
            int pálinka = 0;

            do
            {

                string pia = Console.ReadLine();

                if (pia != "sört" && pia != "bort" && pia != "pálinkát")
                {
                    Console.WriteLine("Ezt a piát nem ismerem, kérlek válassz a fentiek közül.");
                }


                if (pia == "sört")
                {
                    Console.WriteLine("A sör finom.");
                    sör++; 
                }


                if (pia == "bort")
                {
                    Console.WriteLine("A bor finom.");
                    bor++;
                }


                if (pia == "pálinkát")
                {
                    Console.WriteLine("A pálinka finom.");
                    pálinka++;
                }


                Console.WriteLine("Ittál még valamit? (igen/nem)");

            } while (Console.ReadLine() == "igen");

            Console.WriteLine("Ennyi sört ittál: " + sör);
            Console.WriteLine("Ennyi bort ittál: " + bor);
            Console.WriteLine("Ennyi pálinkát ittál: " + pálinka);

            double sormennyiseg = sör * 5; // dl
            double bormennyiseg = bor * 3; // dl
            double palinkamennyiseg = pálinka * 0.4; // dl


            // alkohol (g) = ital (dl) x V/V% (vol %) x 0,8
            // vérezrelék számítás: vérezrelék = alkohol (g) / Ts (kg)
            // Példával bemutatva. 5 dl, 4 V/V%-os sör elfogyasztása 5 x 4 x 0,8 = 16 g etil-alkoholnak felel meg.
            // Ha ezt a mennyiséget egy 70 kg - os ember fogyasztja el: 16 / 70 = 0,2 ezreléknek felel meg.
            // lebontás: 0,15 ‰ / óra

            Console.WriteLine("Hány kg vagy?");
            int testsuly = Convert.ToInt32(Console.ReadLine());

            double soralkoholmennyiseg = sormennyiseg * 5 * 0.8;
            double boralkoholmennyiseg = bormennyiseg * 8 * 0.8;
            double palinkaalkoholmennyiseg = palinkamennyiseg * 48 * 0.8;

            double osszalkoholmennyiseg = soralkoholmennyiseg + boralkoholmennyiseg + palinkaalkoholmennyiseg;

            double verezrelek = osszalkoholmennyiseg / testsuly;
            verezrelek = Math.Round(verezrelek, 2);

            Console.WriteLine("Az alkohol vérezrelék szinted: " + verezrelek + "‰");
            double lebontas = verezrelek / 0.15;
            lebontas = Math.Round(lebontas, 2);
            Console.WriteLine("Még " + lebontas + "óráig ne vezess.");

            Console.WriteLine("Kilépéshez nyomj 'q' betűt.");
            while (Console.ReadKey().Key != ConsoleKey.Q) { }

            
            */

    }
}
