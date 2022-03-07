using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nelinurk
{
    public class Nelinurkk
    {
        double korgus, laius;
        Tyyp tyyp;

        public Nelinurkk() { }
        public Nelinurkk(double Korgus, double Laius, Tyyp tyyp)
        {
            korgus = Korgus;
            laius = Laius;
            this.tyyp = tyyp;
        }
        public Nelinurkk(Tyyp tyyp)
        {
            this.tyyp = tyyp;
        }
        public double Korgus
        {
            set { korgus = value; }
            get { return korgus; }
        }
        public double Laius
        {
            set { laius = value; }
            get { return laius; }
        }
        public Tyyp Tyyp
        {
            get { return tyyp; }
        }
        public double Pindala()
        {
            double pindala = korgus * laius;
            return pindala;
        }
        public double Perimetr()
        {
            double P = korgus * 2 + laius * 2;
            return P;
        }
        public void Figura()
        {
            Console.WriteLine("Ruut/1, ristkülik/2, romb/3, rööpkülik/4");
            string symbol = Console.ReadLine();
            if (symbol == "1")
            {
                Nelinurkk ruut = new Nelinurkk(korgus, laius, Tyyp.ruut);
                Console.WriteLine($"Nelinurga ümbermõõt - {ruut.Perimetr()} cm, pindala - {ruut.Pindala()} cm2 ja nelinurga tüüp on {Tyyp.ruut}");
            }
            else if (symbol == "2")
            {
                Nelinurkk ristkylik = new Nelinurkk(korgus, laius, Tyyp.ristkylik);
                Console.WriteLine($"Nelinurga ümbermõõt - {ristkylik.Perimetr()} cm, pindala - {ristkylik.Pindala()} cm2 ja nelinurga tüüp on {Tyyp.ristkylik}");
            }
            else if (symbol == "3")
            {
                Console.WriteLine("Palun kirjuta rombi pikkus - pindala leidmiseks");
                double pikkus = double.Parse(Console.ReadLine());
                Nelinurkk romb = new Nelinurkk(korgus, laius, Tyyp.romb);
                Console.WriteLine($"Nelinurga ümbermõõt - {romb.Perimetr()} cm, pindala - {pikkus * laius} cm2 ja nelinurga tüüp on {Tyyp.romb}");
            }
            else if (symbol == "4")
            {
                Console.WriteLine("Palun kirjuta rööpküliku pikkus - pindala leidmiseks");
                double pikkus = double.Parse(Console.ReadLine());
                Nelinurkk roopkylik = new Nelinurkk(korgus, laius, Tyyp.roopkylik);
                Console.WriteLine($"Nelinurga ümbermõõt - {roopkylik.Perimetr()} cm, pindala - {pikkus * laius} cm2 ja nelinurga tüüp on {Tyyp.roopkylik}");
            }
            else
            {
                Console.WriteLine("Vale andmetüüp");
            }
        }
    }
}
