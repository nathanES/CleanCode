﻿namespace _14___Command.ExLivreDesignPatternCSharp;
//Commande Concret
public class CommandeSolder
{
    protected IList<Vehicule> vehiculesSoldes = new List<Vehicule>();
    protected long aujourdhui;
    protected long dureeStock;
    protected double tauxRemise;
    public CommandeSolder(long aujourdhui, long dureeStock, double tauxRemise)
    {
        this.aujourdhui = aujourdhui;
        this.dureeStock = dureeStock;
        this.tauxRemise = tauxRemise;
    }
    public void Solde(IList<Vehicule> vehicules)
    {
        vehiculesSoldes.Clear();
        foreach (Vehicule vehicule in vehicules)
        {
            if (vehicule.GetDuréeStockage(aujourdhui) >= dureeStock)
            {
                vehiculesSoldes.Add(vehicule);
            }
        }
        foreach (Vehicule vehicule in vehiculesSoldes)
        {
            vehicule.ModifiePrix(1.0 - tauxRemise);
        }
    }
    public void Annule()
    {
        foreach (Vehicule vehicule in vehiculesSoldes)
        {
            vehicule.ModifiePrix(1.0 / (1.0 - tauxRemise));
        }
    }
    public void Retablit()
    {
        foreach (Vehicule vehicule in vehiculesSoldes)
        {
            vehicule.ModifiePrix(1.0 - tauxRemise);
        }
    }
}
