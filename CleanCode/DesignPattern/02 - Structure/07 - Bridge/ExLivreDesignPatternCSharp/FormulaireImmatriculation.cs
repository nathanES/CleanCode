namespace _07___Bridge.ExLivreDesignPatternCSharp;
//Classe abstraite
public abstract class FormulaireImmatriculation
{
    protected IFormulaireImpl implantation;
    protected string contenu;
    public FormulaireImmatriculation(IFormulaireImpl implantation)
    {
        this.implantation = implantation;
    }
    public void Affiche()
    {
        implantation.DessineTexte("Numéro de la plaque d'immatriculation : ");
    }
    public void GenereDocument()
    {
        implantation.DessineTexte("Demande d'immatriculation");
        implantation.DessineTexte($"Numéro de la plaque d'immatriculation : {contenu}");
    }
    public bool GereSaisie()
    {
        contenu = implantation.GereZoneSaisie();
        return ControleSaisie(contenu);
    }
    protected abstract bool ControleSaisie(string plaque);

}
