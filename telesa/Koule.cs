using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telesa
{
    public class Koule : Teleso
    {
        public Koule(double polomer) : base(polomer) { }

        protected override double Objem()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(delkaHrany, 3);
        }

        protected override double Povrch
        {
            get { return 4.0 * Math.PI * Math.Pow(delkaHrany, 2);  }
        }
    }
}
