using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaureaStudente
{
    internal class Studente
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int AnnoNascita { get; set; }
        public Immatricolazione Immatricolazione { get; set; } = new Immatricolazione();
        public List<Esame> Esami { get; set; } = new List<Esame>();
        public bool RichiestaLaurea { get; set; }

        

        public Studente(string nome, string cognome, int annoNascita, Immatricolazione immatricolazione, List<Esame> esame, bool richiestaLaurea)
        {
            Nome = nome;
            Cognome = cognome;
            AnnoNascita = annoNascita;
            Immatricolazione = immatricolazione;
            Esami = esame;
            RichiestaLaurea = richiestaLaurea;
        }
        
        public Studente()
        {

        }
        
        public void StampaStudente()
        {
            Console.WriteLine($"Nome: {Nome} \t Cognome: {Cognome}");
            foreach (var item in Esami)
            {
                Console.WriteLine(item.StampaEsami());
            }           

        }
    }
}
