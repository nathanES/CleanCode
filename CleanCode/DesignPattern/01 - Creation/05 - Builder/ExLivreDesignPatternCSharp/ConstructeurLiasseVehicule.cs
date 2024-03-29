﻿namespace _05___Builder.ExLivreDesignPatternCSharp;
//Constructeur abstrait
public abstract class ConstructeurLiasseVehicule
{
    protected Liasse? liasse;
    public abstract void ConstruitBonDeCommande(string nomClient);
    public abstract void ConstruitDemandeImmatriculation(string nomDemandeur);
    public Liasse Resultat()
    {
        return liasse;
    }
}
