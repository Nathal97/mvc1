using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectionPersonnage
{
    class PasAttaque : IAttaque
    {
        public void Attaquer()
        {
            Console.WriteLine("Pas d'attaque");
        }
    }
}
