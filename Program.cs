using System;
using System.Numerics;

namespace pia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Milyen piát ittál ma?\nÍrd be a kódját.");
            Console.WriteLine("1 - Sör\n2 - Bor\n3 - Pálinka");

            int sör = 0;
            int bor = 0;
            int pálinka = 0;

            do
            {
                int pia = Convert.ToInt32(Console.ReadLine());

                if (pia == 1)
                {
                    Console.WriteLine("A sör finom és kevés benne az alkohol.");
                    sör++;
                }
                else if (pia == 2)
                {
                    Console.WriteLine("A bor finom és nem olyan kevés benne az alkohol sem.");
                    bor++;
                }
                else
                {
                    Console.WriteLine("A pálinka ütős pia. És finom is.");
                    pálinka++;
                }

                Console.WriteLine("Ittál még valamit? (igen/nem)");

            } while (Console.ReadLine() == "igen");

            Console.WriteLine("Ennyi sört ittál: " + sör);
            Console.WriteLine("Ennyi bort ittál: " + bor);
            Console.WriteLine("Ennyi pálinkát ittál: " + pálinka);

            Console.WriteLine("Megérte??\nKilépéshez nyomj 'Q' betűt.");

            while (Console.ReadKey().Key != ConsoleKey.Q) { }


        }          
    }
}
