namespace _12___Proxy.ExLivreDesignPatternCSharp;

//Informations : Design pattern Proxy
//Le but du pattern Proxy est la conception d'un objet qui
//  se substitue à un autre objet (le sujet) et qui en contrôle l'accès.
//L'objet qui effectue la substitution possède la même interface que le sujet, ce qui
//  rend cette substitution transparente vis à vis des clients.

//Les proxys sont très utilisés en programmation par objets.
//Il existe différents types de proxy, nous en illustrons trois :
//- Proxy virtuel : permet de créer un objet de taille importante au moment approprié.
//- Proxy remote : permet d'accéder à un objet s'exécutant dans un autre environnement.
//  Ce type de proxy est mis en oeuvre dans les systèmes d'objets distants (RPC, Java RMI).
//- Proxy de protection permet de sécuriser l'accès à un objet, par exemple par technique
//  d'authentification.
public class VueVehicule
{
    private static void Main()
    {
        IAnimation animation = new AnimationProxy();
        animation.Dessine();
        animation.Clic();
        animation.Dessine();
    }
    //Affichage de la photo
    //Chargement du film
    //Lecture du film
    //Affichage du film
}
