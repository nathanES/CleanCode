namespace _15___Interpreter.ExLivreDesignPatternCSharp;
//Operateur concret 1
public class OperateurEt : OperateurBinaire
{
    public OperateurEt(Expression operandeGauche, Expression operandeDroite) : base(operandeGauche, operandeDroite)
    {
    }
    public override bool Evalue(string description)
    {
        return operandeGauche.Evalue(description) && operandeDroite.Evalue(description);
    }
    //partie analyse syntaxique
    public static new Expression Parse()
    {
        Expression resultatGauche, resultatDroit;
        resultatGauche = MotCle.Parse();
        while (jeton is not null and "et")
        {
            prochainJeton();
            resultatDroit = MotCle.Parse();
            resultatGauche = new OperateurEt(resultatGauche, resultatDroit);
        }

        return resultatGauche;
    }
}
