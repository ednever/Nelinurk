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
    }
}
