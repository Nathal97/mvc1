using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnageIzy
{
    internal class Militaire : Personnage
    {
        //public Courir Deplacement { get; set; } = new Courir();

        /*public override void SeDeplacer()
        {
            Console.WriteLine("je marche");
        }

        public override void Attaquer()
        {
            Console.WriteLine("J'attaque");
        }

        public override void Soigner()
        {
            Console.WriteLine("pas de soin");
        }*/

        public Militaire()
        {
            //zay miova
            this.Deplacement = new Courir();
        }
    }
}
