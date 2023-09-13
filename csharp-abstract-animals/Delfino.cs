using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace csharp_abstract_animals
{
    internal class Delfino : Animal, ISwim
    {
        public override void CosaMangi()
        {
            WriteLine("pesce"); 
        }

        public override void Verso()
        {
            WriteLine("Iiiiiiiiii");
        }

        public override string ToString(){
            return "Delfino";
        }

        public void Nuota()
        {
            WriteLine("Sto nuotando!!!");
        }
    }
}
