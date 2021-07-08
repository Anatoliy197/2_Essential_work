using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_t_002
{
    class Converter
    {
        double usd, eur;

        public Converter(double usd, double eur)
        {
            this.usd = usd;
            this.eur = eur;
        }

        public void Tousd(double Rubsum)
        {
            Console.WriteLine(Rubsum / usd);
        }
        public void Fromusd(double Usdsum)
        {
            Console.WriteLine(Usdsum * usd);
        }
        public void Toeur(double Rubsum)
        {
            Console.WriteLine(Rubsum / eur);
        }
        public void Fromeur(double Eursum)
        {
            Console.WriteLine(Eursum * eur);
        }
    }
}
