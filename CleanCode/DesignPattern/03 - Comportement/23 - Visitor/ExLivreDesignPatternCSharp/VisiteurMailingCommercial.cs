namespace _23___Visitor.ExLivreDesignPatternCSharp;
//Visiteur concret
public class VisiteurMailingCommercial : IVisiteur
{
    public void Visite(SocieteSansFiliale societe)
    {
        Console.WriteLine("Envoi d'un email à " +
        societe.Nom + " adresse : " + societe.Email
        + " Proposition commerciale pour votre société");
    }
    public void Visite(SocieteMere societe)
    {
        Console.WriteLine("Envoi d'un email à " +
        societe.Nom + " adresse : " + societe.Email
        + " Proposition commerciale pour votre groupe");

        Console.WriteLine("Impression d'un courrier à " +
        societe.Nom + " adresse : " + societe.Email
        + " Proposition commerciale pour votre groupe");
    }
}
