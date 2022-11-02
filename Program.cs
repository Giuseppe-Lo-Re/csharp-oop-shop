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
        codice = new Random().Next(1, 10001);
        this.nome = nome;
        this.descrizione = descrizione;
        this.prezzo = prezzo;
        this.iva = 22;
    }

    // Definisco i metodi

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


}   