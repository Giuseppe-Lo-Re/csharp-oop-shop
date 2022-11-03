//Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop. Un prodotto è caratterizzato da:
//codice(numero intero)
//nome
//descrizione
//prezzo
//iva
//Usate opportunamente i livelli di accesso (public, private), i costruttori, i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
//Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto.
//BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)

using Microsoft.Win32;
using System.Runtime.ConstrainedExecution;

//Testo le funzionalità istanziando un nuovo prodotto
Prodotto monitor = new Prodotto("BenQ-Mobius", "Monitor 27 pollici HD", 199.00);

//Stampo a video
Console.WriteLine("Codice articolo: " + monitor.Codice);
Console.WriteLine("Prezzo senza iva articolo: " + monitor.Prezzo);
Console.WriteLine("Prezzo ivato articolo: " + monitor.GetPrezzoIvato());
Console.WriteLine("Nome esteso Articolo: " + monitor.GetNomeEsteso());
Console.WriteLine("Codice pad left articolo: " + monitor.PadLeftCodice());
public class Prodotto
{
    // Definisco le Properties
    public int Codice { get; private set; }
    public string Nome { get; set; }
    public string Descrizione { get; set; }
    public double Prezzo { get; set; }
    public int Iva { get; set; }

    // Definisco il costruttore
    public Prodotto(string nome, string descrizione, double prezzo)
    {
        Codice = new Random().Next(1, 1001);
        Nome = nome;
        Descrizione = descrizione;
        Prezzo = prezzo;
        Iva = 22;
    }

    // Definisco i metodi:
    // Metodo che restituisce il prezzo ivato
    public double GetPrezzoIvato()
    {
        double prezzoIvato = (Prezzo * Iva) / 100;
        prezzoIvato = Math.Round(prezzoIvato, 2);
        return prezzoIvato;
    }

    // Metodo che restituisce il nome esteso
    public string GetNomeEsteso()
    {
        return Nome + Codice;
    }

    // Bonus: metodo che restituisce il codice con un pad left di 0 per arrivare a 8 caratteri
    public string PadLeftCodice()
    {
        // Converto il codice in stringa
        string PadLeftCodice = Codice.ToString();

        // Creo un ciclo for che itererà 8 volte, pari ai caratteri richiesti
        for (int i = 0; PadLeftCodice.Length < 8; i++)
        {
            PadLeftCodice = "0" + PadLeftCodice;
        }

        return PadLeftCodice;
    }
}


