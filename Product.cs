// See https://aka.ms/new-console-template for more information
/*Creare una classe Prodotto che gestisce i prodotti dello shop.
Un prodotto è caratterizzato da:
codice(numero intero)
nome
descrizione
prezzo
iva
Usate opportunamente i livelli di accesso (public, private):
i costruttori,
i metodi getter e setter
eventuali altri metodi di “utilità” per fare in modo che:
alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
Il codice prodotto sia accessibile solo in lettura
Gli altri attributi siano accessibili sia in lettura che in scrittura
Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
Nella vostro programma principale, testate tutte le funzionalità della classe Prodotto.
BONUS: create un metodo che restituisca il codice con un pad left di 0 per arrivare a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
Buon lavoro!*/


using System.Diagnostics;

class Product
{
    int code;
    string name;
    string description;
    decimal price;
    decimal iva = 20;

    public Product(string name, string description, decimal price)
    {
        var random = new Random();
        code = random.Next(0, 100);
        this.name = name;
        this.description = description;
        this.price = price;

    }

    //GETTERS
    public int GetCode()
    {
        return code;
    }

    public string GetFullCode()
    {
        string fullCode = code.ToString().PadLeft(10, '0');
        return fullCode;
    }

    public string GetName()
    {
        return name;
    }

    public string GetFullName()
    {
        string fullName = code + " - " + name;
        return fullName;
    }



    public string GetDescription()
    {
        return description;
    }

    public decimal GetPrice()
    {
        return price;
    }

    public decimal GetFullPrice()
    {
        decimal totalPrice = price + (price * iva / 100);
        return totalPrice;

    }
    public void GetAllInfo()
    {
        price = GetPrice();

        Console.WriteLine("Il Prodotto inserito ha le seguenti caratteristiche:");
        Console.WriteLine($"Nome: {GetName()}");
        Console.WriteLine($"Full name: {GetFullName()}");
        Console.WriteLine($"Descrizione: {GetDescription()}");
        Console.WriteLine($"Prezzo: {GetPrice()}");
        Console.WriteLine($"Prezzo con IVA: {GetFullPrice()}");
        Console.WriteLine($"Full code: {GetFullCode()}");

    }

    // SETTERS
    public void SetName(string name)
    {
        this.name = name;

    }

    public void SetDescription(string description)
    {

        this.description = description;

    }

    public decimal SetPrice(decimal price)
    {
        this.price = price;
        return price;
    }

}