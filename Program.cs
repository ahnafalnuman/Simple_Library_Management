namespace SimpleLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LibraryManager library = new LibraryManager();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Library Management System!");
                Console.WriteLine("1. Add Library Item");
                Console.WriteLine("2. View All Items");
                Console.WriteLine("3. Borrow an Item");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        library.AddItem();
                        break;
                    case 2:
                        library.ViewAllItems();
                        break;
                    case 3:
                        library.BorrowItem();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
