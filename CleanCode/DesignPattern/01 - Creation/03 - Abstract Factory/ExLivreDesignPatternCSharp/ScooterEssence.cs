namespace _03___Abstract_Factory.ExLivreDesignPatternCSharp;
public class ScooterEssence : Scooter
{
    public ScooterEssence(string modele, string couleur, int puissance) : base(modele, couleur, puissance)
    {

    }
    public override void AfficheCaracteristiques()
    {
        Console.WriteLine($"Scooter essence de modèle : {modele} de couleur : {couleur} de puissance : {puissance}");
    }
}
