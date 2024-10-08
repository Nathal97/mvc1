using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnageIzy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Roi roi = new Roi();
            Militaire militaire = new Militaire();
            Pretre pretre = new Pretre();

            Console.WriteLine("Roi");
            roi.SePresenter();
            //roi.Deplacement.SeDplacer();
            Console.WriteLine("Militaire");
            militaire.SePresenter();
            Console.WriteLine("Pretre");
            pretre.SePresenter();
            pretre.ChangerCapaciter(roi);
            Console.WriteLine("Roi");
            roi.SePresenter();
            Console.ReadLine();

            // lasa misy miverimberina be la contenu an seDeplacer si Soigner donc mila mitadu fika hafa

        }
    }
}
