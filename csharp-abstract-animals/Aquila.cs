using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace csharp_abstract_animals
{
    public class Aquila : Animal, IFly 
    {
        public override void CosaMangi()
        {
            WriteLine("topi, marmotte, lepri, conigli e talpe"); 
        }

        public override void Verso()
        {
            WriteLine("Aaaaaaaah");
        }

        public override string ToString(){
            return "Aquila";
        }

        public void Vola()
        {
            WriteLine("Sto volando!!!");
        }
    }
}
