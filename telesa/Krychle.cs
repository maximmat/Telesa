using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telesa
{
    public class Krychle : Teleso
    {
        public Krychle(double delkaHrany) : base(delkaHrany) { } //za pomoci base předání parametru delkaHrany rodičkovské třídě teleso

        protected override double Objem()
        {
            return Math.Pow(delkaHrany, 3);
        }
        protected override double Povrch
        {
            get { return 6 * Math.Pow(delkaHrany, 2); }
        }
    }
}
