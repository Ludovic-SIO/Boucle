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
            double TVA = 0.20;
            double TVAbis;
            double prix;

            Console.WriteLine("Saisir un prix HT ");
            double ht = Convert.ToDouble(Console.ReadLine());   
            Console.WriteLine("Le prix Hors taxe est de : {0} euros",ht);
            TVAbis=ht*TVA;
            Console.WriteLine("La Tva est de : {0} euros",TVAbis);
            prix = ht + TVAbis;
            Console.WriteLine("Le prix TTC est de {0}", prix);
            while (ht != 0);
            System.Console.WriteLine(ht);
        


        }
    }
}
