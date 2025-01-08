using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLibrary
{
    internal class LibraryManager
    {
        private List<LibraryItem> items = new List<LibraryItem>();

        public void AddItem()
        {
            Console.Clear();
            Console.WriteLine("Choose the type of item to add:");
            Console.WriteLine("1. Book");
            Console.WriteLine("2. Magazine");
            Console.WriteLine("3. DVD");
            Console.WriteLine("4. VideoGames");    

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter Title: ");
            string title = Console.ReadLine();

            Console.Write("Enter Year: YYYY-MM-DD :");
            DateOnly year = DateOnly.Parse(Console.ReadLine());  

            switch (choice)
            {
                case 1: // Book
                    Console.Write("Enter Author: ");
                    string author = Console.ReadLine();

                    Console.Write("Enter Genre: ");
                    string genre = Console.ReadLine();

                    Console.Write("Enter Pages: ");
                    int pages = int.Parse(Console.ReadLine());

                    items.Add(new Book(title, year, author, genre, pages));
                    Console.WriteLine("Book added successfully!");
                    break;

                case 2: // Magazine
                    Console.Write("Enter Publisher: ");
                    string publisher = Console.ReadLine();

                    Console.Write("Enter Issue Number: ");
                    int issue = int.Parse(Console.ReadLine());

                    items.Add(new Magazine(title, year, publisher, issue));
                    Console.WriteLine("Magazine added successfully!");
                    break;

                case 3: // DVD
                    Console.Write("Enter Director: ");
                    string director = Console.ReadLine();

                    Console.Write("Enter Duration (in minutes): ");
                    int duration = int.Parse(Console.ReadLine());

                    items.Add(new DVD(title, year, director, duration));
                    Console.WriteLine("DVD added successfully!");
                    break;

                case 4: // Video Games
                    Console.Write("Enter Publisher: ");
                    string Publisher = Console.ReadLine();

                    Console.Write("Enter Platform : ");
                    string Platform = Console.ReadLine();

                    items.Add(new VideoGames(title, year, Publisher, Platform));
                    Console.WriteLine("VideoGames added successfully!");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void ViewAllItems()
        {
            Console.Clear();
            if (items.Count == 0)
            {
                Console.WriteLine("No items in the library.");
            }
            else
            {
                Console.WriteLine("--- Library Items ---");
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {items[i].DisplayDetails()}");
                }
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void BorrowItem()
        {
            Console.Clear();
            ViewAllItems();
            Console.WriteLine("Enter the number of the item to borrow:");
            int number = int.Parse(Console.ReadLine());

            if (number > 0 && number <= items.Count)
            {
                LibraryItem item = items[number - 1]; 

                if (item.IsBorrowed) 
                {
                    Console.WriteLine("This item is already borrowed.");
                }
                else
                {
                    item.IsBorrowed = true;  
                    Console.WriteLine($"You borrowed: {item.Title}");
                }
            }
            else
            {
                Console.WriteLine("Invalid item number.");
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

    }

}