namespace _07___Bridge.ExLivreDesignPatternCSharp;
//Implantation
public class FormulaireAppletImpl : IFormulaireImpl
{
    public void DessineTexte(string texte)
    {
        Console.WriteLine("Applet : " + texte);
    }
    public string GereZoneSaisie()
    {
        return Console.ReadLine();
    }
}
