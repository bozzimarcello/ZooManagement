using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP
{
    internal class Mago : Personaggio
    {
        public int PuntiMagia { get; set; }

        public override void Stampa()
        {
            base.Stampa();
            Console.WriteLine(
                "Punti Magia: " + PuntiMagia);
        }
    }
}
