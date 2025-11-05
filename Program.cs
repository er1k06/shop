namespace shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(">>>>>>>>>> Welcome to the Jembo's Shop! <<<<<<<<<<");
            Console.WriteLine($"Choose your product! :)");
            Methods methods = new Methods();
            methods.ShowProducts();
            Cart cart = new Cart();
            bool shopping = true;
            while (shopping)
            {
                Console.WriteLine("Enter the number of the product to add to your cart :");
               Console.WriteLine("Type 'view' to see your cart :");
                Console.WriteLine("Type 'total' to see the total amount :");
                Console.WriteLine("Type 'exit' to leave the shop :");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        
                        cart.AddToCart(new Products("Laptop", 949.99));
                        break;
                    case "2":
                        
                        cart.AddToCart(new Products("Smartphone", 499.99));
                        break;
                    case "3":
                       
                        cart.AddToCart(new Products("Tablet", 299.99));
                        break;
                    case "view":
                      Console.Clear();
                        cart.ViewCart();
                        break;
                    case "total":
                        Console.Clear();
                        cart.ViewCart2();
                        break;
                    case "exit":
                        shopping = false;
                        Console.Clear();
                        Console.WriteLine("Thank you for shopping at Jembo's Shop! Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }


        }

    }
}
