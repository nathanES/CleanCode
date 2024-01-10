﻿namespace _05___Builder.ExempleLivreDesignPatternsEnC;
public class Vendeur
{
    protected ConstructeurLiasseVehicule constructeur;

    public Vendeur(ConstructeurLiasseVehicule constructeur)
    {
        this.constructeur = constructeur;
    }

    public Liasse Construit(string nomClient)
    {
        constructeur.ConstruitBonDeCommande(nomClient);
        constructeur.ConstruitDemandeImmatriculation(nomClient);
        Liasse liasse = constructeur.Resultat();
        return liasse;
    }

    //public Liasse? Resultat()
    //{
    //    //Ou mettre le Construit en void et faire le retour ici
    //    return constructeur?.Resultat();
    //}
}
