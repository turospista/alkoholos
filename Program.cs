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

            if (pia == 1)
            {
                Console.WriteLine("A sör finom és kevés benne az alkohol.");
            }
            else if (pia == 2)
            {
                Console.WriteLine("A bor finom és nem olyan kevés benne az alkohol sem.");
            }
            else
            {
                Console.WriteLine("A pálinka ütős pia.");
            }
        }
            
            
    }
}
