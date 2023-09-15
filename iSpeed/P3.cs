using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSpeed
{
    internal class P3 : Sendung
    {

        double auffschlag = 15.0;


        public P3()
        {

        }

        public override double Portoberechnung(double km)
        {
            return base.Portoberechnung(km) + auffschlag;
        }


    }
}
