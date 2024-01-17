namespace _07___Bridge.ExLivreDesignPatternCSharp;
//Classe concrète
public class FormulaireImmatriculationFrance : FormulaireImmatriculation
{
    public FormulaireImmatriculationFrance(IFormulaireImpl implantation) : base(implantation)
    {
    }
    protected override bool ControleSaisie(string plaque)
    {
        return plaque.Length == 7;
    }
}
