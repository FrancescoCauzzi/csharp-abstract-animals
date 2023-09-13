using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using static System.Console;
namespace csharp_abstract_animals

{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Esercizio 1: Una volta create le classi, nel programma istanziare alcuni animali e utilizzare i metodi implementati.
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
                Write("Cosa sto facendo: ");
                // Check and Cast in One, The first syntax is more concise and efficient, as it combines type checking and casting into a single statement
                if(bestia is IFly fly)
                {
                    FaiVolare(fly);
                }else if(bestia is ISwim swim){
                    FaiNuotare(swim);
                }
                /*
                if(bestia is IFly)
                {
                    FaiVolare((IFly)bestia);
                }else if(bestia is ISwim){
                    FaiNuotare((ISwim)bestia);
                }
                */
                WriteLine();
            }

            // Esercizio 2
            // Hardcoded version
            WriteLine("Hardcoded version");
            FaiVolare(aquila1);
            FaiNuotare(delfino1);

            ReadKey();
            


            
        }

        public static void FaiVolare(IFly bestia){
            bestia.Vola();
        }

        public static void FaiNuotare(ISwim bestia){
            bestia.Nuota();
        }
    }
}


