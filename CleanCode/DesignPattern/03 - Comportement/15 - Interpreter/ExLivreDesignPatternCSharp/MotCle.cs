namespace _15___Interpreter.ExLivreDesignPatternCSharp;
public class MotCle : Expression
{
    protected string motCle;
    public MotCle(string motCle)
    {
        this.motCle = motCle;
    }
    public override bool Evalue(string description)
    {
        return description.IndexOf(motCle) != -1;
    }
    //partie analyse syntaxique
    public static new Expression Parse()
    {
        Expression resultat;
        resultat = new MotCle(jeton);
        prochainJeton();
        return resultat;
    }
}
