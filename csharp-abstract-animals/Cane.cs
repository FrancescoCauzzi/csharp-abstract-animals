using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace csharp_abstract_animals
{
    public class Cane : Animal, ISwim
    {
        public override void CosaMangi()
        {
            WriteLine("un po' di tutto"); 
        }

        public override void Verso()
        {
            WriteLine("Woff woff");
        }

        public override string ToString(){
            return "Cane";
        }

        public void Nuota()
        {
            WriteLine("Sto nuotando!!!");
        }
    }
}
