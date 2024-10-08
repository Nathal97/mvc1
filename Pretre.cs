using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectionPersonnage
{
    class Pretre : Personnage
    {
        public Pretre()
        {
            this.Soin = new SuperSoin();
        }
    }
}
