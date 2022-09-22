
public abstract class Food : Product
{
    public DateOnly expirationDate { get; set; }
    bool isFrozen;

    public Food(
        string name , 
        string description, 
        decimal price,
        string countryOfOrigin,
        int weight,
        DateOnly expirationDate, 
        bool isFrozen) : 

        base(name, description, price,countryOfOrigin,weight)
    {
        
        this.expirationDate = expirationDate;
        this.isFrozen = isFrozen;
    }

    // Calcolo Scadenza cibi
    public int getLeftDays()
    {
        DateOnly currentDate = DateOnly.FromDateTime(DateTime.Now);
        if(expirationDate.DayNumber > currentDate.DayNumber)
        {
          int leftTime = expirationDate.DayNumber - currentDate.DayNumber;
            return leftTime;
        }
        else
        {
            Console.WriteLine("Il cibo è scaduto!"); // Da Implementare nell'interfaccia utente
            return 0;
            
        }
        
    }

    public override void PrintInfo()
    {
        Console.WriteLine("Nome: " + this.name);
        Console.WriteLine("Prezzo: " + this.getTotalPrice() + "euro");
        Console.WriteLine("Scadenza tra: " + getLeftDays() + " giorni" );
        Console.WriteLine();
    }
}
