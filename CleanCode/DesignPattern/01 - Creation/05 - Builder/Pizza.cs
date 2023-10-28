using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05___Builder
{
    public class Pizza
    {
        public string Nom { get; set; }
        public List<string> Ingredients { get; set; }
        public Pizza(string nom)
        {
            Nom = nom;
            Ingredients = new List<string>();
        }
        public void AjouterIngredient(string ingredient)
        {
            Ingredients.Add(ingredient);
        }
        public override string ToString()
        {
            return $"Pizza {Nom}, ingrédients : {string.Join(",", Ingredients)}";
        }
    }
    public abstract class PizzaBuilder
    {
        public Pizza Pizza { get; private set; }
        public PizzaBuilder(string nom)
        {
            Pizza = new Pizza(nom);
        }
        public abstract void AjouterIngredients();
        public abstract void AjouterBase();
    }
    public class ChevreMielBuilder : PizzaBuilder
    {
        public ChevreMielBuilder(): base("Chèvre miel")
        {
            
        }
        public override void AjouterBase()
        {
            Pizza.AjouterIngredient("Crème fraiche");
        }

        public override void AjouterIngredients()
        {
            Pizza.AjouterIngredient("Fromage de chèvre");
            Pizza.AjouterIngredient("Miel");
            Pizza.AjouterIngredient("Olives");
        }
    }
    public class ReineBuilder : PizzaBuilder
    {
        public ReineBuilder() : base("Reine")
        {

        }
        public override void AjouterBase()
        {
            Pizza.AjouterIngredient("Sauce Tomate");
        }

        public override void AjouterIngredients()
        {
            Pizza.AjouterIngredient("Jambon");
            Pizza.AjouterIngredient("Champignons");
            Pizza.AjouterIngredient("Emental");
        }
    }
    public class BorneDeVente
    {
        public void PreparerPizza(PizzaBuilder builder)
        {
            builder.AjouterBase();
            builder.AjouterIngredients();
        }
    }
}
