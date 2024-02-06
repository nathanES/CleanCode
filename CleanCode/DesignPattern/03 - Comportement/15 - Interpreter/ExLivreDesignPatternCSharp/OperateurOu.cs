namespace _15___Interpreter.ExLivreDesignPatternCSharp;
//Operateur concret 2
public class OperateurOu : OperateurBinaire
{
    public OperateurOu(Expression operandeGauche, Expression operandeDroite) : base(operandeGauche, operandeDroite)
    {
    }
    public override bool Evalue(string description)
    {
        return operandeGauche.Evalue(description) || operandeDroite.Evalue(description);
    }
    //partie analyse syntaxique
    public static new Expression Parse()
    {
        Expression resultatGauche, resultatDroit;
        resultatGauche = OperateurEt.Parse();
        while (jeton is not null and "ou")
        {
            prochainJeton();
            resultatDroit = OperateurEt.Parse();
            resultatGauche = new OperateurOu(resultatGauche, resultatDroit);
        }

        return resultatGauche;
    }
}
