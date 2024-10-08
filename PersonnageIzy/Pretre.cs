using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonnageIzy
{
    internal class Pretre : Personnage
    {
        //public Voler Deplacement { get; set; } = new Voler();
        //raha atao atram lay soin sy attaque dia mbola lasa mivemberina be ihany 
        // eto zao seDeplacer

        /*public override void SeDeplacer()
        {
            Console.WriteLine("je marche");
        }

        public override void Attaquer()
        {
            Console.WriteLine("pas d'attaque");
        }

        public override void Soigner()
        {
            Console.WriteLine("pas de soin");
        }*/

        public Pretre()
        {
            //exemple tyh ah
            this.Deplacement = new Voler();
        }

        public void ChangerCapaciter(Personnage pers)
        {
            pers.Deplacement = new Voler();//omeny pretre capacite hanidina zay olona tia hanidina
        }
    }
}
