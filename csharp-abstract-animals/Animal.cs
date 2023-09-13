using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace csharp_abstract_animals
{
    public abstract class Animal
    {
        // Creiamo quindi una classe astratta Animale
        // e delle classi che la estendono : Cane, Passerotto, Aquila, Delfino
        public void Dormi()
        {
            WriteLine("Zzz");            
        }

        public abstract void Verso();

        public abstract void CosaMangi();

        // Quali di questi metodi devono essere implementati nella classe astratta e quali devono
        // essere lasciati astratti e implementati dalle classi che la estendono?
        // il metodo dormi è uguale tutti gli animali, quindi lo implemento nella superclasse 
        // astratta, gli altri due metodi sono peculiari e diversi per ogni singolo animale quindi
        // devo implementarli in ogni singola classe derivata da Animal

    }
}
