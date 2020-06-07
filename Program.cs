using System;
using System.IO;
using System.Numerics;

namespace pia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Mit ittál ma?");
            Console.WriteLine("Sört (5%, 5 dl), bort (8%, 3 dl) vagy pálinkát (48%, 0,4 dl)?");

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

            



        }
    }
}
