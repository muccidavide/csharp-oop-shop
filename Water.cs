

using System.Runtime.CompilerServices;

public class Water : Food
{
    static decimal MaxLiters;
    public decimal Liters { get; set; }
    public decimal PH { get; private set; }
    public string Wellspring { get; private set; }

    protected static double converterUnit = 3.785;

    public Water(
        string name,
        string description,
        decimal price,
        string countryOfOrigin,
        DateOnly expirationDate,
        int weight,
        bool isFrozen,
        decimal Liters,
        decimal PH,
        string Wellspring
        ) :
        base(name, description, price, countryOfOrigin, weight, expirationDate, isFrozen)
    {
        this.Liters = Liters;
        MaxLiters = Liters;
        this.PH = PH;
        this.Wellspring = Wellspring;

    }

    // CONSOLE WRITELINE PER COMODITA QUI DA IMPLEMENTARE NELL'INTERFACCIA UTENTE

    public void drinkSome()
    {

        if (this.Liters >= 1)
        {
            Liters -= 1;
        }
        else
        {
            Console.WriteLine("L'acqua nella bottilgia è finita");
        }

    }

    public void Refill()
    {
        if (this.Liters < MaxLiters)
        {
            this.Liters = MaxLiters;
            Console.WriteLine("La bottiglia è stata riempita");
        }
        else
        {
            Console.WriteLine("La bottiglia è gia piena");
        }
    }

    public static double ConvertToGallons(decimal Liters)
    {
        double gallons = (double)Liters * converterUnit;

        return gallons;
    }


}
