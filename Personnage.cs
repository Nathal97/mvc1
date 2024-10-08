using System;
using System.Collections.Generic;
using System.Text;

namespace CorrectionPersonnage
{
    abstract class Personnage
    {
        public IDeplacement Deplacement { get; set; } = new Marcher();
        public IAttaque Attaque { get; set; } = new PasAttaque();
        public ISoin Soin { get; set; } = new PasDeSoin();
        public void SePresenter()
        {
            Console.WriteLine("************");
            this.Deplacement.SeDeplacer();
            this.Attaque.Attaquer();
            this.Soin.Soigner();
            Console.WriteLine("************");
        }
    }
}
