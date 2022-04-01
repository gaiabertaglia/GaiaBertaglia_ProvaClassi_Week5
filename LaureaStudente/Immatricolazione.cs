using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaureaStudente
{
    internal class Immatricolazione
    {
        public int Matricola { get { return Random(); } } // Autogenerata quindi al posto del set return (rand)    

        public DateTime DataInizio { get; set; } = new DateTime();
        public CorsoDiLaurea CorsoDiLaurea { get; set; } = new CorsoDiLaurea();
        public bool FuoriCorso { get; set; }
        public int CFUAccumulati { get; set; }

        private int Random()
        {
            Random rnd = new Random();
            return rnd.Next();
        }

        public Immatricolazione(DateTime dataInizio, CorsoDiLaurea corsoDiLaurea, bool fuoriCorso, int cfuAccumulati)
        {
            DataInizio = dataInizio;
            CorsoDiLaurea = corsoDiLaurea;
            FuoriCorso = fuoriCorso;
            CFUAccumulati = cfuAccumulati;

        }

        public void StampaImmatricolazione()
        {
            Console.WriteLine($"Matricola {Matricola}: \t data di inizio: {DataInizio} \t Fuoricorso: {FuoriCorso} \t CFU accumulati: {CFUAccumulati} ");
        }

        public Immatricolazione()
        {
        }
    }
}
