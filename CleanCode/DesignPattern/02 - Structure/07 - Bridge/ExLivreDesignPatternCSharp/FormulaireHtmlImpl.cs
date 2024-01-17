namespace _07___Bridge.ExLivreDesignPatternCSharp;
//Implantation
public class FormulaireHtmlImpl : IFormulaireImpl
{
    public void DessineTexte(string texte)
    {
        Console.WriteLine($"HTML: {texte}");
    }
    public string GereZoneSaisie()
    {
        return Console.ReadLine();
    }
}
