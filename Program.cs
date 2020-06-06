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
            Console.WriteLine("Sört, bort vagy pálinkát?");

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

            Console.WriteLine("Megérte??\nKilépéshez nyomj 'q' betűt.");

            while (Console.ReadKey().Key != ConsoleKey.Q) { }

        }          
    }
}
