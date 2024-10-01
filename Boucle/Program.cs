using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace Boucle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            double note;
            double moyenne;
            double total= 0;

            Console.WriteLine("Saisir le nombre d'élèves");
            int nbEleve=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Il y a {0} élèves ",nbEleve);
           
            
            for (i = 0; i < nbEleve; i++)
            {
                Console.WriteLine("Saisir une note par élèves");
                note = Convert.ToDouble(Console.ReadLine());
                total = total + note;

            }
            moyenne = total / nbEleve;
            Console.WriteLine("La moyenne de  l'élève est égale à {0}", moyenne);

            Console.ReadKey();  
           
        


        }
    }
}
