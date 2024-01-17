namespace _07___Bridge.ExLivreDesignPatternCSharp;
//Classe concrète
public class FormulaireImmatriculationLux : FormulaireImmatriculation
{
    public FormulaireImmatriculationLux(IFormulaireImpl implantation) : base(implantation)
    {
    }
    protected override bool ControleSaisie(string plaque)
    {
        return plaque.Length == 5;
    }
}
