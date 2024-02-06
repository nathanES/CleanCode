namespace _15___Interpreter.ExLivreDesignPatternCSharp;
public abstract class Expression
{
    public abstract bool Evalue(string description);
    //partie analyse syntaxique
    protected static string? source;
    protected static int index;
    protected static string? jeton;
    protected static void prochainJeton()
    {
        while (index < source.Length && source[index] == ' ')
        {
            index++;
        }
        if (index == source.Length)
        {
            jeton = null;
        }
        else if (source[index] is '(' or ')')
        {
            jeton = source[index].ToString();
            index++;
        }
        else
        {
            int debut = index;
            while (index < source.Length && source[index] != ' ' && source[index] != '(' && source[index] != ')')
            {
                index++;
            }
            jeton = source[debut..index];
        }
    }
    public static Expression Analyse(string source)
    {
        Expression.source = source;
        index = 0;
        prochainJeton();
        return OperateurOu.Parse();
    }
    public static Expression Parse()
    {
        Expression resultat;
        if (jeton == "(")
        {
            prochainJeton();
            resultat = OperateurOu.Parse();
            if (jeton == null)
                throw new Exception("Erreur de syntaxe");
            if (jeton != ")")
                throw new Exception("Erreur de syntaxe");

            prochainJeton();
        }
        else
        {
            resultat = MotCle.Parse();
        }
        return resultat;
    }
}
