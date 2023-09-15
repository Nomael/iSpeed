using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSpeed
{
    internal class B2 : Sendung
    {
        public B2() { }

        double auffschlag_proz = 1.2;

        public override double Portoberechnung(double km)
        {
            return base.Portoberechnung(km) * auffschlag_proz;
        }
    }
}
