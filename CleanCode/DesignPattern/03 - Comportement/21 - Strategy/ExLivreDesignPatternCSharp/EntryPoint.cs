namespace _21___Strategy.ExLivreDesignPatternCSharp;

//Informations : Design pattern Strategy
//Le but du pattern Strategy est d'adapter le comportement et les algorithmes d'un objet
//  en fonction d'un beson sans changer les interactions de cet objet avec les clients.
//Ce besoin peut relever de plusieurs aspects comme des aspects de présentation,
//  d'éfficacité en temps ou en mémoire, de choix algorithmique,
//  de représentation interne,etc. Mais évidemment, il ne s'agit pas d'un besoin fonctionnel
//  vis à vis des clients de l'objet car les interractions entre
//  l'objet et ses clients doivent rester inchangées.

//Le pattern est utilisé dans les cas suivants :
//- Le comportement d'une classe peut être implémenté par différents algorithmes
//  dont certains sont plus efficaces en temps d'exécution ou en consommation mémoire
//  ou encore contiennent des mécanismes de mise au point
//- L'implémentation du choix de l'algorithme par des instructions
//  conditionnelles est trop complexe
//- Un système possède de nombreuses classes identiques à l'exception
//  d'une partie de leur comportement.

//Dans ce cas, le pattern Strategy permet de regrouper ces classes en une seule,
//  ce qui simplifie l'interface pour les clients
public class EntryPoint
{
}
