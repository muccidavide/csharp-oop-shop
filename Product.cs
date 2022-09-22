
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

    protected abstract int setQuantity();


}

public abstract class Food : Product
{
    DateOnly expirationDate { get; set; }
    int quantity;
    bool isFrozen;

    public Food(
        string name, 
        string description, 
        decimal price,
        string countryOfOrigin,
        DateOnly expirationDate, 
        bool isFrozen) : 

        base(name, description, price,countryOfOrigin)
    {
        expirationDate = this.expirationDate;
        this.isFrozen = isFrozen;
    }

    protected override int setQuantity()
    {
        throw new NotImplementedException();
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

    protected override int setQuantity()
    {
        throw new NotImplementedException();
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
        int Liters,
        decimal PH,
        string Wellspring) : 
        base(name, description, price, countryOfOrigin, expirationDate, isFrozen)
    {
        this.Liters = Liters;
        this.PH = PH;
        this.Wellspring = Wellspring;

    }

    
}