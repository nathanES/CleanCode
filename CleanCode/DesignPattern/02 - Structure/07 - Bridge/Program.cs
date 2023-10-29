//Bridge, Permet de faire le pont entre 2 abstractios sans que cela nuise à l'usage.
//Dans cette exemple entre l'abonnement et la réduction
//Permet principalement de pouvoir utiliser le principe O

using _07___Bridge;

//var pasDeReduc = new PasDeReduction();
var reducFaible = new ReductionFaible();
var reducForte = new ReductionForte();

//var abonnement = new AbonnementStandard(pasDeReduc);
//Console.WriteLine("Prix : " + abonnement.GetPrice());

var abonnementBF = new AbonnementPremium(reducForte);
Console.WriteLine("Prix : " + abonnementBF.GetPrice());

//Coter performance, faire des IReduction null (comme dans le code) est plus performant que
//de faire une classe pas de reduc et enlever les nullable