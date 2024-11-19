using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Berek
{
    internal class Dolgozok
    {
        public string Nev { get; set; }
        public string Neme { get; set; }
        public string Reszleg { get; set; }
        public int BelepEv { get; set; }
        public int Fizetes { get; set; }

        public Dolgozok(string sor)
        {
            var adat = sor.Split(';');
            Nev = adat[0];
            Neme = adat[1];
            Reszleg = adat[2];
            BelepEv = int.Parse(adat[3]);
            Fizetes = int.Parse(adat[4]);
        }

        public override string ToString()
        {
            return $"Nev:{Nev} \n "+
                   $"Neme:{Neme} \n "+
                   $"Részleg: {Reszleg}  \n "+
                   $"Belépés Éve: {BelepEv}  \n "+
                   $"Fizetése: {Fizetes} Ft \n";
        }
    }
}
