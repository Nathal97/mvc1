using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnageIzy
{
    abstract class Personnage
    {

        /* public abstract void SeDeplacer();
        public abstract void Attaquer();
        public abstract void Soigner();
        */
        public IDeplacement Deplacement { get; set; } = new Marcher(); // par defaut
        //atao ny soin sy attaque

        public void SePresenter()
        {
            Console.WriteLine("Je me presente: ");
            this.Deplacement.SeDeplacer();
        }
    }
}
