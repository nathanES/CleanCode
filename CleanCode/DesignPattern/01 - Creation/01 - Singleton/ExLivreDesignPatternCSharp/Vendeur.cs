namespace _01___Singleton.ExLivreDesignPatternCSharp;

public class Vendeur
{
    public string Nom { get; set; }
    public string Adresse { get; set; }
    public string Email { get; set; }

    private static Vendeur? _instance = null;
    private Vendeur()
    {

    }
    public static Vendeur Instance()
    {
        _instance ??= new Vendeur(); //Si _instance est null, on crée une nouvelle instance
        return _instance;
    }
    public void affiche()
    {
        Console.WriteLine("Nom : ", Nom);
        Console.WriteLine("Adresse : ", Adresse);
        Console.WriteLine("Email : ", Email);

    }
}
