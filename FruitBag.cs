

public class FruitBag : Food
{
    int capacity;

    public FruitBag(
        string name,
        string description,
        decimal price,
        string countryOfOrigin,
        DateOnly expirationDate,
        int weight,
        bool isFrozen,
        int capacity) :
        base(name, description, price, countryOfOrigin, weight, expirationDate, isFrozen)
    {
        if (capacity > 5)
        {
            this.capacity = 5;
            Console.WriteLine("Quantità di frutta supera le dimensioni del sacchetto (max 5 frutti a sacchetto)"); // DA IMPLEMENTARE MEGLIO
        }
        else
        {
            this.capacity = capacity;
        }
    }

    public void EatAFruit()
    {
        --capacity;
    }
}
