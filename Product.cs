
public abstract class Product 
{
    int code;
    string name;
    string description;
    string countryOfOrigin;
    decimal price;
    decimal iva = 20;
    protected int weight;

    public Product(string name, string description, decimal price, string countryOfOrigin, int weight)
    {
        var random = new Random();
        code = random.Next(0, 100);
        this.name = name;
        this.description = description;
        this.price = price;
        this.countryOfOrigin = countryOfOrigin;
        this.weight = weight;
    }

    public decimal getTotalPrice()
    {
        decimal totalPrice = price + (price * iva / 100);
        return totalPrice;
    }

    public decimal fidelityCardDiscount()
    {
        decimal fidelityPrice = price - (price * 0.1m);
        return fidelityPrice;
    }
}
