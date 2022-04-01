using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaureaStudente
{
    internal class CorsoDiLaurea
    {
        public NomeCorsoLaurea NomeCorsoLaurea { get; set; }
        public int AnniDiCorso { get; set; }
        public int CFUPerLaurea { get; set; }
        public List<Corso> CorsiAssociati { get; set; } = new List<Corso>();

        public CorsoDiLaurea()
        {

        }

        public CorsoDiLaurea(NomeCorsoLaurea nomeCorsoLaurea, int anniDiCorso, int cfuPerLaurea, List<Corso> corsiAssociati)
        {
            NomeCorsoLaurea = nomeCorsoLaurea;
            AnniDiCorso = anniDiCorso;
            CFUPerLaurea = cfuPerLaurea;
            CorsiAssociati = corsiAssociati;
        }

        public void StampaCorsoLaurea()
        {
            Console.WriteLine($"Nome del corso di laurea: {NomeCorsoLaurea} \t Anni di corso: {AnniDiCorso} \t CFU richiesti per la laurea: {CFUPerLaurea}");
            Console.WriteLine($"Riepilogo corsi che appartengono a {NomeCorsoLaurea}");
            foreach (var item in CorsiAssociati)
            {
                Console.WriteLine(item.StampaCorso());
            }

        }
    }

    
    public enum NomeCorsoLaurea
    {
        Matematica = 1,
        Fisica,
        Informatica,
        Igegneria,
        Lettere
    }
}
