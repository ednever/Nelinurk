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
            Console.WriteLine("Sisetage nelinurga kõrgus ja laius");
            Kujund.Korgus = double.Parse(Console.ReadLine());
            Kujund.Laius = double.Parse(Console.ReadLine());
            Kujund.Figura();            

            Console.ReadLine();
        }
    }
}
