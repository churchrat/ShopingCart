namespace LInkedListProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================================================");
            Console.WriteLine("To add a product : ADD ");
            Console.WriteLine("To delete a producr : REM");
            Console.WriteLine("To print all the products with their place : PAP");
            Console.WriteLine("To find a product and its place : FND ");
            Console.WriteLine("To replace a product : RPL ");
            Console.WriteLine("To end the product : END or 6");
            LinkedList<string> shoppingCart = new LinkedList<string>();
            string choice = null;
            while (choice != "END" || choice != "6")
            {
                Console.Write("Your choice: ");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "ADD":
                        AddProduct(shoppingCart);
                        break;
                    case "REM":
                        RemoveProduct(shoppingCart);
                        break;
                    case "PAP":
                        Print(shoppingCart);
                        break;
                    case "FND":
                        FindProduct(shoppingCart);
                        break;
                    case "RPL":
                        ReplaceProduct(shoppingCart);
                        break;
                    default:
                        Console.Write("Invalid choice!!! CHOOSE AGAIN!");
                        break;
                }
                Console.WriteLine("========================================================");
            }
        }
        static void AddProduct(LinkedList<string> shoppingList)
        {
            Console.Write("Enter a product: ");
            shoppingList.AddLast(Console.ReadLine());
        }
        static void RemoveProduct(LinkedList<string> shoppingList)
        {
            if (shoppingList.Count > 0)
            {
                Console.WriteLine($"Removed product : {shoppingList.First.Value}");
                shoppingList.RemoveFirst();
            }
            else
            {
                Console.WriteLine("Your cart is empthy");
            }
        }
        static void Print(LinkedList<string> shoppingList)
        {
            if (shoppingList.Count > 0)
            {
                int index = 0;
                foreach (string product in shoppingList)
                {
                    index++;
                    Console.WriteLine($"{index}:{product}");
                }
            }
            else
            {
                Console.WriteLine("Your cart is empthy");
            }
        }
        static void FindProduct(LinkedList<string> shoppingList)
        {
            Console.Write("Which product would you like to find: ");
            string search = Console.ReadLine();
            int index = 1;
            foreach (string product in shoppingList)
            {
                if (product == search)
                {
                    Console.WriteLine($"The products place is {index}");
                    return;
                }
                index++;
            }
            Console.WriteLine($" There isnt a product such as {search}");
        }
        static void ReplaceProduct(LinkedList<string> shoppingList)
        {
            Console.Write("Product you want to replace: ");
            string oldProduct = Console.ReadLine();
            Console.Write("A product to replace it with: ");
            string newProduct = Console.ReadLine();
            LinkedListNode<string> firstNode = shoppingList.First;
            while (firstNode != null)
            {
                if (firstNode.Value == oldProduct)
                {
                    firstNode.Value = newProduct;
                    return;
                }
                firstNode = firstNode.Next;
            }
            Console.WriteLine($"There isnt a product such as {oldProduct}");
        }
    }
}

