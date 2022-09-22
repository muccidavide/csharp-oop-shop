
/*
 Super-class : Prodotto (nome,prezzo,peso,paese di produzione,produttore, iva fissa)
Sotto-classi : Cibo(scadenza, quantità, biologico ), Elettrodomestico(classe energetica)
sotto-sotto-classi: [Cibo: Acqua, Sacchetto di frutta, Cibo in Scatola] , 
istanze: [Elettrodomestico:LAvatrice, Frigo], [Acqua: Bottiglia Rocchetta, mela, pera.....]


 */

Water acquaRocchettaSmall = new Water("Acqua minerale Rocchetta", "Bottiglia di acqua minerale Rocchetta da 1 L", 0.50m, "Italia" ,new DateOnly(2026, 1, 22),500, false, 1, 7, "Monte Bianco");
Water acquaRocchettaBig = new Water("Acqua minerale Rocchetta", "Bottiglia di acqua minerale Rocchetta da 2 L", 0.50m, "Italia", new DateOnly(2028, 3, 12), 1000,false, 3, 7, "Monte Rosa");

FruitBag meleRosse = new FruitBag("Mela Melina", "La mela melina è la piu buona", 0.23m, "Italia", new DateOnly(2022, 10, 13), 300 , false, 4);
FruitBag pere = new FruitBag("Pera Melina", "La pera perina è la piu buona", 0.33m, "Spagna", new DateOnly(2022, 10, 3),400, false, 8);

CannedFood tonnoRioMare = new CannedFood("Tonno in scatola Rio Mare", "Tonno in scatola RioMare", 2.33m, "Italia", new DateOnly(2026, 12, 3), 500, false, 3, "Alluminio", false);
CannedFood tonnoNostromo = new CannedFood("Tonno in scatola Nostromo", "Tonno in scatola Nostromo", 3.33m, "Italia", new DateOnly(2025, 2, 5), 1000, false, 3, "Vetro", true);

Appereance frigoAmico = new Appereance("Frigo Amico", "Frigo amico è il frigo che ti parla quando lo apri", 740, "Germania", 60000, "A1");
Appereance fornoNemico = new Appereance("Forno Nemico", "il Forno nemico è il forno che ti brucia quando lo apri", 1240, "Giappone", 30000, "A3");


Console.WriteLine(acquaRocchettaBig.getTotalPrice());
Console.WriteLine(acquaRocchettaBig.getLeftDays());

acquaRocchettaBig.Refill();
acquaRocchettaBig.drinkSome();
acquaRocchettaBig.Refill();

pere.EatAFruit();

pere.PrintInfo();
frigoAmico.PrintInfo();

Console.WriteLine(Water.ConvertToGallons(acquaRocchettaBig.Liters));










// Interazione Utente [ESERCIZIO PRECEDENTE!!]

void modifyProduct()
{
    Console.WriteLine("Cosa vuoi modificare?(nome,descrizione,prezzo)");
    string answer = Console.ReadLine();
    switch (answer)
    {
        case "nome":
            Console.WriteLine("Inserisci il nome");
            string nameInsert = Console.ReadLine();
           
            break;

        case "descrizione":
            Console.WriteLine("Inserisci la descrizione");
            string descriptionInsert = Console.ReadLine();
            
            break;

        case "prezzo":
            Console.WriteLine("Inserisci il prezzo");
            decimal prezzoInsert = Convert.ToDecimal(Console.ReadLine());
           
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
        // newProduct.GetAllInfo();
    }
}
