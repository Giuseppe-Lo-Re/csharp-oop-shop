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
Prodotto Monitor = new Prodotto("BenQ-Mobius", "Monitor 27 pollici HD", 199.00);

//Stampo a video
Console.WriteLine("Codice articolo: " + Monitor.GetCodice());
Console.WriteLine("Prezzo senza iva articolo: " + Monitor.PrezzoBase());
Console.WriteLine("Prezzo ivato articolo: " + Monitor.GetPrezzoIvato());
Console.WriteLine("Nome esteso Articolo: " + Monitor.GetNomeEsteso());
Console.WriteLine("Codice pad left articolo: " + Monitor.PadLeftCodice());
public class Prodotto
{
    // Definisco le variabili
    private int codice;
    public string nome;
    public string descrizione;
    public double prezzo;
    public int iva;

    // Definisco il costruttore
    public Prodotto(string nome, string descrizione, double prezzo)
    {
        codice = new Random().Next(1, 1001);
        this.nome = nome;
        this.descrizione = descrizione;
        this.prezzo = prezzo;
        this.iva = 22;
    }

    // Definisco i metodi:
    // Metodo che restituisce il codice
    public int GetCodice()
    {
        return this.codice;
    }

    // Metodo che restituisce il prezzo base
    public double PrezzoBase()
    {
        return this.prezzo;
    }

    // Metodo che permette di settare il prezzo base
    public void SetPrezzo(double prezzo)
    {
        this.prezzo = prezzo;
    }

    // Metodo che restituisce il prezzo ivato
    public double GetPrezzoIvato()
    {
        double prezzoIvato = (this.prezzo * this.iva) / 100;
        prezzoIvato = Math.Round(prezzoIvato, 2);
        return prezzoIvato;
    }

    // Metodo che restituisce il nome esteso
    public string GetNomeEsteso()
    {
        return this.nome + this.codice;
    }

    // Bonus: metodo che restituisce il codice con un pad left di 0 per arrivare a 8 caratteri
    public string PadLeftCodice()
    {
        // Converto il codice in stringa
        string PadLeftCodice = codice.ToString();

        // Creo un ciclo for che itererà 8 volte, pari ai caratteri richiesti
        for (int i = 0; PadLeftCodice.Length < 8; i++)
        {
            PadLeftCodice = "0" + PadLeftCodice;
        }
        return PadLeftCodice;
    }
}


