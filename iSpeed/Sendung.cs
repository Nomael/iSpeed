using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace iSpeed
{
    public class Sendung

    {
          
        public double grundpauschale = 0.3;
        public double centprokm = 0.5;
        
       public Sendung() 
        { 
        
        }
       

        public virtual double Portoberechnung(double km)
        {
            double gebür = (grundpauschale + km * centprokm);
            return gebür;
        } 

    }
}
