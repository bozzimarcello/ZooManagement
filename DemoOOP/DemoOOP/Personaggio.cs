using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOOP
{
    internal class Personaggio
    {
        public string? Razza { get; set; }
        public string? Nome { get; set; }
        public int PuntiVita { get; set; }
        public int PuntiEsperienza { get; set; }
        public int PuntiDestrezza { get; set; }

        public virtual void Stampa()
        {
            Console.WriteLine(
                "Nome: " + Nome +
                "\nRazza: " + Razza +
                "\nPunti vita:" + PuntiVita);
        }
    }
}
