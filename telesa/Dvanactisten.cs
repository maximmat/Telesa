using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telesa
{
    public class Dvanactisten : Teleso
    {
        public Dvanactisten(double delkaHrany) : base(delkaHrany) { }

        protected override double Objem()
        {
            return ((15 + 7 * Math.Sqrt(5)) / 4) * Math.Pow(delkaHrany, 3);
        }

        protected override double Povrch
        {
            get { return 3 * Math.Sqrt(25 + 10 * Math.Sqrt(5)) * Math.Pow(delkaHrany, 2); }
        }

    }
}
