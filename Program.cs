using System;

namespace CorrectionPersonnage
{
    class Program
    {
        static void Main(string[] args)
        {
            Roi roi = new Roi();
            Militaire militaire = new Militaire();
            Sorcier sorcier = new Sorcier();
            Pretre pretre = new Pretre();

            Console.WriteLine("Roi");
            roi.SePresenter();
            Console.WriteLine("militaire");
            militaire.SePresenter();
            Console.WriteLine("sorcier");
            sorcier.SePresenter();
            Console.WriteLine("pretre");
            pretre.SePresenter();

            sorcier.ChangerCapacite(roi);
            roi.SePresenter();

        }
    }
}
