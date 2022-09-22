

public class Appereance : Product
{
    string energeticClass { get; set; }
    public Appereance(
        string name, 
        string description, 
        decimal price, 
        string countryOfOrigin, 
        int weight,
        string energeticClass ) : 

        base(name, description, price, countryOfOrigin, weight)
    {
        this.energeticClass = energeticClass;
    }

    // Se l'elttrodomestico è pesante è incluso il trasporto 
    public bool transportIncluded()
    {
        if(weight > 50000)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
