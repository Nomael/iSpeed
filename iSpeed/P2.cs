using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSpeed
{
    internal class P2 : Sendung
    {

        double auffschlag = 10.0;


        public P2()
        {

        }

        public override double Portoberechnung(double km)
        {
            return base.Portoberechnung(km) + auffschlag;
        }


    }
}