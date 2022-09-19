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


using System.Diagnostics.Metrics;




Product newProduct = new Product("frigo", "frigo dotato di tutte le funzioinalità necessarie", 132);
newProduct.getAllInfo();

// Interazione Utente

Console.WriteLine("vuoi modificare il prodotto?[si/no]");
string choice = Console.ReadLine();

if (choice == "si")
{
    modifyProduct();
}
else
{
    newProduct.getAllInfo();
}

void modifyProduct()
{
    Console.WriteLine("Cosa vuoi modificare?(nome,descrizione,prezzo)");
    string answer = Console.ReadLine();
    switch (answer)
    {
        case "nome":
            Console.WriteLine("Inserisci il nome");
            string nameInsert = Console.ReadLine();
            newProduct.setName(nameInsert);
            newProduct.getAllInfo();
            break;

        case "descrizione":
            Console.WriteLine("Inserisci la descrizione");
            string descriptionInsert = Console.ReadLine();
            newProduct.setDescription(descriptionInsert);
            newProduct.getAllInfo();
            break;

        case "prezzo":
            Console.WriteLine("Inserisci il prezzo");
            decimal prezzoInsert = Convert.ToDecimal(Console.ReadLine());
            newProduct.setPrice(prezzoInsert);
            newProduct.getAllInfo();
            break;
    }

    Console.WriteLine("Vuoi modificare ancora?[si,no]");
    string modifyChoice = Console.ReadLine();
    if (modifyChoice == "si")
    {
        modifyProduct();
    }
    else
    {
        newProduct.getAllInfo();
    }
}
