using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace telesa
{
    public static class TelesoFactory
    {
        public static Teleso MakeTeleso(string typ, double delkaHrany)
        {
            switch (typ) //z proměnné předané při volání TelesoFactory.MakeTeleso určení generovaného tvaru tělesa
            {
                case "krychle": return new Krychle(delkaHrany);
                case "dvanactisten": return new Dvanactisten(delkaHrany);
                case "dvacetisten": return new Dvacetisten(delkaHrany);
                case "koule": return new Koule(delkaHrany);
                default: throw new ArgumentException("Chyba při výběru tělesa"); //stav kdy se předá neznámě tělos, např když není vyvbrán ani jeden radioButton
            }
        }
    }
}
