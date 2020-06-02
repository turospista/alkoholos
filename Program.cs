using System;

namespace pia
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Milyen piát ittál ma?\nÍrd be a kódját.");
            Console.WriteLine("1 - Sör\n2 - Bor\n3 - Pálinka");

            int pia = Convert.ToInt32(Console.ReadLine());
            int sör = 0;
            int bor = 0;
            int pálinka = 0;

            do
            {
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

                Console.WriteLine("Ittál még valamit?");

             

            } while (Console.ReadLine() != "q");

            Console.WriteLine("Ennyi sört ittál: " + sör);
            Console.WriteLine("Ennyi bort ittál: " + bor);
            Console.WriteLine("Ennyi pálinka ittál: " + pálinka);


        }          
    }
}
