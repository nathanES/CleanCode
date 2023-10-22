namespace _02___FactoryMethod
{
    internal class Program
    {
        //C'est utilisé pour faire des instanciations complexes de classes
        //  qui répondent à des besoins métiers
        static void Main(string[] args)
        {
            Patient a = new Patient();
            Patient b = new Patient { NumeroMutuelle = "00300010101" };
            Patient c = new Patient { NumeroMutuelle = "00400010101" };
            var factory = new MutuelleFactory();
            Console.WriteLine($"Patient a = {factory.GetMutuelle(a).GetPourcentageRemboursementMedecinTraitant()}");
            Console.WriteLine($"Patient b = {factory.GetMutuelle(b).GetPourcentageRemboursementMedecinTraitant()}");
            Console.WriteLine($"Patient c = {factory.GetMutuelle(c).GetPourcentageRemboursementMedecinTraitant()}");

        }

    }
}