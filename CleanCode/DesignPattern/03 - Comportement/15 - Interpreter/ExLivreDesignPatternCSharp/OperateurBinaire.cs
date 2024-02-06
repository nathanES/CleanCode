namespace _15___Interpreter.ExLivreDesignPatternCSharp;
//Operateur Abstrait
public abstract class OperateurBinaire : Expression
{
    protected Expression operandeGauche, operandeDroite;
    public OperateurBinaire(Expression operandeGauche, Expression operandeDroite)
    {
        this.operandeGauche = operandeGauche;
        this.operandeDroite = operandeDroite;
    }
}
