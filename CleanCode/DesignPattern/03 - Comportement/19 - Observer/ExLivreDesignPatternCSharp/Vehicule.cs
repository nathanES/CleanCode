using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19___Observer.ExLivreDesignPatternCSharp;
//Sujet concret
public class Vehicule : Sujet
{
    private string _description;
    private double _prix;

    public string Description
    {
        get { return _description; }
        set
        {
            _description = value;
            Notifie();
        }
    }

    public double Prix
    {
        get { return _prix; }
        set
        {
            _prix = value;
            Notifie();
        }
    }
}
