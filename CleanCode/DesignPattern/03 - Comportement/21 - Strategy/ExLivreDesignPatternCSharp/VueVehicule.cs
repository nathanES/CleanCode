namespace _21___Strategy.ExLivreDesignPatternCSharp;
public class VueVehicule
{
    protected string description;
    public VueVehicule(string description)
    {
        this.description = description;
    }
    public void Dessine()
    {
        Console.Write(description);
    }
}
