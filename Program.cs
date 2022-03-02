using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelinurk
{
    class Program
    {
        static void Main(string[] args)
        {
            Nelinurkk Kujund = new Nelinurkk();
            Console.WriteLine("Ruut/1, ristkülik/2, romb/3, rööpkülik/4");
            string symbol = Console.ReadLine();
            Console.WriteLine("Sisetage nelinurga kõrgus ja laius");
            Kujund.Korgus = double.Parse(Console.ReadLine());
            Kujund.Laius = double.Parse(Console.ReadLine());
            double P = Kujund.Perimetr();
            double pindala = Kujund.Pindala();
            if (symbol == "1")
            {
                Console.WriteLine("Nice");
            }
            else if (symbol == "2")
            {
                
                
            }
            else if (symbol == "3")
            {

            }
            else if (symbol == "4")
            {

            }
            else
            {
                Console.WriteLine("Vale andmetüüp");
            }
            Console.WriteLine($"Nelinurga ümbermõõt - {P} cm ja pindala - {pindala} cm2");


            Console.ReadLine();
        }
    }
}
