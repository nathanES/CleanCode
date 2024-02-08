namespace _22___Template_Method.ExLivreDesignPatternCSharp;
//Classe concrète
public class CommandeLuxembourg : Commande
{
    protected override void calculeTva()
    {
        montantTva = montantHt * 0.17;
    }
}
