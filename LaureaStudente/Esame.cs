using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaureaStudente
{
    internal class Esame
    {
        public Corso CorsoAppartenenza { get; set; } = new Corso();
        public bool Passato { get; set; }

        public Esame(Corso corsoAppartenenza, bool passato)
        {
            CorsoAppartenenza = corsoAppartenenza;
            Passato = passato;
            
        }

        public Esame()
        {

        }

        public string StampaEsami()
        {
            return $"\n{CorsoAppartenenza.StampaCorso()} \t ";
        }

    }
   
}
