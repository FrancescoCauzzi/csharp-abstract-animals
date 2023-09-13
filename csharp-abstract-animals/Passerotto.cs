using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace csharp_abstract_animals
{
    public class Passerotto : Animal
    {
        public override void CosaMangi()
        {
            WriteLine("insetti e semi"); 
        }

        public override void Verso()
        {
            WriteLine("Chip chip");
        }
        public override string ToString(){
            return "Passerotto";
        }
    }
}
