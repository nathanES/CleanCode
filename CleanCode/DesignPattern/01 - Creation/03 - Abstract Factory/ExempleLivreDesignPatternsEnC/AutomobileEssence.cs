namespace _03___Abstract_Factory.ExempleLivreDesignPatternsEnC;
public class AutomobileEssence : Automobile
{
  public AutomobileEssence(string modele, string couleur, int puissance, double espace) : base(modele, couleur, puissance, espace)
  {

  }
  public override void AfficheCaracteristiques()
  {
    Console.WriteLine($"Automobile à essence de modèle : {modele} de couleur : {couleur} de puissance : {puissance} d'espace : {espace}");
  }
}
