using System.Runtime.InteropServices;
using static System.Console;
namespace csharp_abstract_animals

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Una volta create le classi, nel programma istanziare alcuni animali e utilizzare i metodi implementati.
            Cane cane1 = new();            
            Passerotto passero1 = new();            
            Aquila aquila1 = new();
            Delfino delfino1 = new();
            List<Animal> listaDiBestie = new() {cane1, passero1, aquila1,delfino1};

            foreach(Animal bestia in listaDiBestie){
                WriteLine($"Io sono un {bestia}");      
                Write("Quando dormo faccio: ");                         
                bestia.Dormi();
                Write("Il mio verso è: ");                         
                bestia.Verso();
                Write("Mi nutro di: ");                         
                bestia.CosaMangi();
                WriteLine();
            }


            
        }
    }
}