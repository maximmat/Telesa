using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telesa
{
    public class Dvacetisten : Teleso
    {
        public Dvacetisten(double delkaHrany) : base(delkaHrany) { }

        protected override double Objem()
        {
            return (5 * (3 + Math.Sqrt(5)) / 12) * Math.Pow(delkaHrany, 3);
        }

        protected override double Povrch
        {
            get { return 5 * Math.Sqrt(3) * Math.Pow(delkaHrany, 2); }
        }
    }
}