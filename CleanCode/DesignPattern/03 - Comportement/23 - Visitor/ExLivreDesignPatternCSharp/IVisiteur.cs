namespace _23___Visitor.ExLivreDesignPatternCSharp;
//Visiteur
public interface IVisiteur
{
    void Visite(SocieteSansFiliale societe);
    void Visite(SocieteMere societe);
}
