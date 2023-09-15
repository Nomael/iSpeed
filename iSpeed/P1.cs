using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSpeed
{
    internal class P1:Sendung
    {

        double auffschlag = 3.0;


        public P1 () 
        { 
        
        }

        public override double Portoberechnung(double km)
        {
            return base.Portoberechnung(km) + auffschlag;
        }


    }
}
