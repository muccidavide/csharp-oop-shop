

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
        int  weight,
        bool isFrozen,
        int Liters,
        decimal PH,
        string Wellspring
        ) : 
        base(name, description, price, countryOfOrigin, weight, expirationDate, isFrozen)
    {
        this.Liters = Liters;
        this.PH = PH;
        this.Wellspring = Wellspring;

    }

    
}
