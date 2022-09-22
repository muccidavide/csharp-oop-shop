
public abstract class Product 
{
    int code;
    string name;
    string description;
    string countryOfOrigin;
    decimal price;
    decimal iva = 20;

    public Product(string name, string description, decimal price, string countryOfOrigin)
    {
        var random = new Random();
        code = random.Next(0, 100);
        this.name = name;
        this.description = description;
        this.price = price;
        this.countryOfOrigin = countryOfOrigin;
    }

}

public abstract class Food : Product
{
    DateOnly expirationDate { get; set; }
    bool isFrozen;
    protected int quantity;

    public Food(
        string name, 
        string description, 
        decimal price,
        string countryOfOrigin,
        DateOnly expirationDate, 
        bool isFrozen, int quantity) : 

        base(name, description, price,countryOfOrigin)
    {
        expirationDate = this.expirationDate;
        this.isFrozen = isFrozen;
        this.quantity = quantity;
    }

}

 public class Appereance : Product
{
    string energeticClass { get; set; }
    public Appereance(
        string name, 
        string description, 
        decimal price, 
        string countryOfOrigin, 
        string energeticClass ) : 

        base(name, description, price, countryOfOrigin)
    {
        this.energeticClass = energeticClass;
    }
}

public class Water : Food
{
    public int Liters { get; set; }
    public decimal PH { get; set; }
    public string Wellspring { get; set; }

    public Water(
        string name, 
        string description, 
        decimal price, 
        string countryOfOrigin, 
        DateOnly expirationDate, 
        bool isFrozen,
        int quantity,
        int Liters,
        decimal PH,
        string Wellspring
        ) : 
        base(name, description, price, countryOfOrigin, expirationDate, isFrozen,quantity)
    {
        this.Liters = Liters;
        this.PH = PH;
        this.Wellspring = Wellspring;

    }

    
}

public class FruitBag : Food
{

    public FruitBag(
        string name, 
        string description, 
        decimal price, 
        string countryOfOrigin, 
        DateOnly expirationDate, 
        bool isFrozen, 
        int quantity) :
        base(name, description, price, countryOfOrigin, expirationDate, isFrozen, quantity)
    {
        if(quantity > 5)
        {
            base.quantity = 5;
            Console.WriteLine("Quantità di frutta supera le dimensioni del sacchetto (max 5 frutti a sacchetto)");
        }
        else
        {
            base.quantity = quantity;
        }

    }

}

public class CannedFood : Food
{
    string boxMaterial;
    bool isVacuumPacked;

    public CannedFood(
        string name, 
        string description, 
        decimal price, 
        string countryOfOrigin, 
        DateOnly expirationDate, 
        bool isFrozen, 
        int quantity,
        string boxMaterial,
        bool isVacuumPacked) : 
        base(name, description, price, countryOfOrigin, expirationDate, isFrozen, quantity)
    {
        this.boxMaterial = boxMaterial;
        this.isVacuumPacked = isVacuumPacked;

    }
}