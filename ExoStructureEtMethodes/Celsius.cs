using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExoStructureEtMethodes
{
    public struct Celsius
    {
        public double Temperature;

        public Fahrenheit Convert()
        {
            Fahrenheit fahrenheit = new Fahrenheit();
            fahrenheit.Temperature = (Temperature * 1.8) + 32;
            return fahrenheit;
        }
    }
}
