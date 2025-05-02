using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telesa
{
    public abstract class Teleso
    {
        protected double delkaHrany;

        protected Teleso(double delkaHrany)
        {
            if (delkaHrany <= 0)
                throw new ArgumentException("Délka hrany musí být většší než 0");

            this.delkaHrany = delkaHrany;
        }

        protected abstract double Objem();

        protected abstract double Povrch { get; }

        public override string ToString()
        {
            return $"Hrana: {delkaHrany}, Objem: {Objem()}, Povrch: {Povrch}";
        }
    }
}
