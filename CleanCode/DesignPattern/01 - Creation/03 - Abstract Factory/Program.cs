namespace _03___Abstract_Factory
{
    internal class Program
    {
        //La différentce entre FactoryMethod et AbstractFactory, c'est que FactoryMethod gère
        //  un produit alors que AbstractFactory gère une famille de produit

        static void Main(string[] args)
        {
            var customer = new Customer();
            var customerVIP = new Customer { Orders = new int[50] };

            IVIPShoppingFactory factory1 = GetFactory(customer);
            IVIPShoppingFactory factory2 = GetFactory(customerVIP);


            var shoppingCart1 = new ShoppingCart(factory1);
            Console.WriteLine("Shopping Cart 1");
            shoppingCart1.PasserCommande();

            var shoppingCart2 = new ShoppingCart(factory2);
            Console.WriteLine("Shopping Cart 2");
            shoppingCart2.PasserCommande();

            IVIPShoppingFactory GetFactory(Customer c)
            {
                if (c.Orders.Length > 20) return new VIPShoppingFactory();
                else return new StandardShoppingFactory();
            }
        }
    }
}