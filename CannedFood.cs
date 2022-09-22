

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
        int weight,
        bool isFrozen, 
        int quantity,
        string boxMaterial,
        bool isVacuumPacked) : 
        base(name, description, price, countryOfOrigin,weight, expirationDate, isFrozen)
    {
        this.boxMaterial = boxMaterial;
        this.isVacuumPacked = isVacuumPacked;
    }
}