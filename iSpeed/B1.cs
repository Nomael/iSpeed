using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSpeed
{
    internal class B1 : Sendung
    {
        public B1() { }

       

        public override double Portoberechnung(double km)
        {
            return base.Portoberechnung(km);
        }
    }
}
