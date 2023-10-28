using _04___Prototype;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___Prototype
{
    #region Methode 1 en utilisant les classes
    public abstract class EtreVivant
    {
        public string Nom { get; set; } = "";
        public abstract EtreVivant Clone(bool deapClone = false);
    }
    public class Chien : EtreVivant
    {
        public Chien(string nom, Personne proprietaire)
        {
            Nom = nom;
            Proprietaire = proprietaire;
        }
        public Personne Proprietaire { get; private set; }

        public override EtreVivant Clone(bool deapClone = false)
        {
            if (deapClone)
            {
                var chien = (Chien)MemberwiseClone();
                chien.Proprietaire = (Personne)Proprietaire.Clone(true);
                return chien;
            }
            return (EtreVivant)MemberwiseClone();
        }
    }
    public class Personne : EtreVivant
    {
        public Personne(string nom)
        {
            Nom = nom;
        }
        public override EtreVivant Clone(bool deapClone = false)
        {

            return (EtreVivant)MemberwiseClone();
            //Renvoie une shallow copy
            //une Shallow copy : c'est une copie superficiel, les types primitifs vont être copier
            //mais les objets complexes vont être copier par rapport à leur références
        }
    }
    #endregion
    #region Option 2 avec des records 
    public abstract record EtreVivant2
    {
        public string Nom { get; set; } = "";
    }
    public record Chien2 : EtreVivant2
    {
        public Chien2(string nom, Personne2 proprietaire)
        {
            Nom = nom;
            Proprietaire = proprietaire;
        }
        public Personne2 Proprietaire { get; private set; }

    }
    public record Personne2 : EtreVivant2
    {
        public Personne2(string nom)
        {
            Nom = nom;
        }
    }
    #endregion
}
