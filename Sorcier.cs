using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectionPersonnage
{
    class Sorcier : Personnage
    {
        public Sorcier()
        {
            this.Deplacement = new Voler();
            this.Attaque = new Sort();
        }

        public void ChangerCapacite(Personnage pers)
        {
            pers.Attaque = new Sort();
        }
    }
}
