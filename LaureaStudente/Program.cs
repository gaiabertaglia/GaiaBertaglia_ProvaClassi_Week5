// PARTE TEORICA 

// 1. b,c
// 2. Le variabili di tipo string vengono memorizzate nell'heap, perchè sono reference type
// 3. a,b 


// See https://aka.ms/new-console-template for more information
using LaureaStudente;
using System;

Corso analisi1 = new Corso("Analisi1", 13);
Corso algebra = new Corso("Algebra", 9);

List<Corso> corsiMatematica = new List<Corso>();
corsiMatematica.Add(analisi1);
corsiMatematica.Add(algebra);

foreach (var item in corsiMatematica)
{
    Console.WriteLine(item.StampaCorso());
}


CorsoDiLaurea matematica = new(NomeCorsoLaurea.Matematica, 3, 150, corsiMatematica);


matematica.StampaCorsoLaurea();


Immatricolazione immatricolazione1 = new Immatricolazione(new DateTime (2019/09/09), matematica, true, 100);

Esame oraleAnalisi1 = new Esame(corsiMatematica[1], true);
Esame oraleAlgebra = new Esame(corsiMatematica[1], false);
Esame scrittoAlgebra = new Esame(corsiMatematica[1], true);
Esame scrittoAnalisi1 = new Esame(corsiMatematica[0], true);

oraleAnalisi1.StampaEsami();

//oraleAlgebra.GetInfo();

// Lista di esami già sostenuti del corso di Analisi1 appartenenti al CDL Matematica

List<Esame> esamiAnalisi = new List<Esame>();
esamiAnalisi.Add(oraleAnalisi1);
esamiAnalisi.Add(scrittoAnalisi1);

//foreach (var item in esamiAnalisi)
//{
//    Console.WriteLine(item.GetInfoEsame());
//}

List<Esame> esamiAlgebra = new List<Esame>();
esamiAlgebra.Add(scrittoAlgebra);
esamiAlgebra.Add(oraleAlgebra);

//immatricolazione1.StampaImmatricolazione();

Studente studenteGaia = new Studente("Gaia", "Bertaglia", 1997, immatricolazione1, esamiAnalisi, false);


bool continua = true;
while (continua)
{
    Menu();
    int scelta = Scegli();
    switch (scelta)
    {
        case 1:
            //NOTA: Uno studente può richiedere un esame solo se esso è presente nel Corso di Laurea associato
            //allo studente, se i CFU del corso associato all’esame non superino i CFU massimi del Corso di laurea
            //e se non ha il flag RichiestaLaurea assegnato a vero. Nel caso le condizioni siano verificate, lo
            //studente aggiunge l’esame alla lista Esami.

            Console.WriteLine("A quale esame desideri prenotarti?");
            // Mostro allo studente la lista degli esami a cui può prenotarsi, quindi quelli non passati

            studenteGaia.StampaStudente();
            break;
        case 2:
            //NOTA: Scrivere un metodo EsamePassato che, dato un esame, vada ad aggiornare i CFU
            //accumulati dallo studente, metta il flag Passato sull’esame e verifichi se con tale esame sono stati
            //raggiunti i CFU necessari per richiedere la laurea(e quindi metta il flag Richiestalaurea a true);

            break;        
        case 0:
            Console.WriteLine("Ciao Ciao");
            continua = false;
            break;
    }
}

void Menu()
{
    Console.WriteLine("---------Menu Registro------------");
    Console.WriteLine("1. Prenotati ad un esame");
    Console.WriteLine("2. Verbalizza un esame prenotato");
    Console.WriteLine("0. ESCI");
}

int Scegli()
{
    int scelta;
    do
    {
        Console.Write("Fai la tua scelta tra le possibili voci del menu: ");
    } while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta >= 0 && scelta <= 2));
    return scelta;
}

