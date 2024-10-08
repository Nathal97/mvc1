using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectionPersonnage
{
    class Militaire : Personnage
    {
        public Militaire()
        {
            this.Deplacement = new Courir();
            this.Attaque = new Fusil();
            this.Soin = new SoinDeBase();
        }
    }
}
