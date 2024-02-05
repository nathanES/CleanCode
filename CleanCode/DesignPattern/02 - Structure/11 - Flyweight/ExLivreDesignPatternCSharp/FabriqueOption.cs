namespace _11___Flyweight.ExLivreDesignPatternCSharp;
//Fabbrique flyweight
public class FabriqueOption
{
    protected Dictionary<string, OptionVehicule> options = [];

    public OptionVehicule GetOption(string nom)
    {
        OptionVehicule resultat;
        if (options.ContainsKey(nom))
        {
            resultat = options[nom];
        }
        else
        {
            resultat = new OptionVehicule(nom);
            options.Add(nom, resultat);
        }
        return resultat;
    }
}
