// using System.Drawing;
// using Pastel;

// Console.WriteLine("Hello, World!".Pastel(Color.Green));

//Calculating discounts
// using System;
// public class Program
// {
//     public static double ApplyDiscount(double price, double discountPercentage)
//     {
//         double discountAmount = price * (discountPercentage / 100);
//         return price - discountAmount;
//     }

//     public static void Main()
//     {
//         double finalPrice = ApplyDiscount(1000, 15);
//         Console.WriteLine(finalPrice);
//     }
// }


//Fixing the maximum number in the array
// using System;
// using System.ComponentModel.DataAnnotations;

// public class Program
// {
//     public static int FindMax(int[] numbers)
//     {
//         int max = int.MinValue;
//         for (int i = 0; i < numbers.Length; i++)
//         {
//             if (numbers[i] > max)
//             {
//                 max = numbers[i];
//             }
//         }
//         return max;
//     }

//     public static void Main()
//     {
//         int[] numbers = { -5, -10, -3, -8, -2 };
//         int maxNumber = FindMax(numbers);
//         Console.WriteLine("The maximum number is:" + maxNumber);
//     }
// }

//Method Example
// using System.Diagnostics;

// class Calculator
// {
//     public static int Add(int a, int b)
//     {
//         return a + b;
//     }

//     static void Main()
//     {
//         int num1 = 5;
//         int num2 = 10;
//         if (num1 > 0 && num2 > 0)
//         {
//             int result = Add(num1, num2);
//             Console.WriteLine("The sum is:" + result);
//         }
//     }
// }

// using System;

// class PrintNumber
// {
//     public static void PrintNumbers()
//     {
//         for (int i = 0; i < 10; i++)
//         {
//             Console.WriteLine(i);
//         }
//     }

//     static void Main()
//     {
//         PrintNumbers();
//     }
// }

// public class Animal
// {
//     public virtual void MakeSound() // virtual means method can be overriden in a derived (child) class.
//     {
//         Console.WriteLine("Some generic animal sound.");
//     }
// }

// public class Dog : Animal
// {
//     public override void MakeSound()
//     {
//         Console.WriteLine("Bark");
//     }
// }

// public class Cat : Animal
// {
//     public override void MakeSound()
//     {
//         Console.WriteLine("Meow");
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Dog myDog = new Dog();
//         Cat myCat = new Cat();

//         myDog.MakeSound();
//         myCat.MakeSound();
//     }
// }

// Implementing Interfaces
// public interface IAnimal
// {
//     void Eat();
// }

// public class Animal : IAnimal
// {
//     public virtual void MakeSound()
//     {
//         Console.WriteLine("Some generic animal sound");
//     }

//     public virtual void Eat()
//     {
//         Console.WriteLine("Some generic Aniaml food");
//     }
// }

// public class Dog : Animal
// {
//     public override void Eat()
//     {
//         Console.WriteLine("Kibble");
//     }
//     public override void MakeSound()
//     {
//         Console.WriteLine("Bark");
//     }
// }

// public class Cat : Animal
// {
//     public override void Eat()
//     {
//         Console.WriteLine("Tuna");
//     }
//     public override void MakeSound()
//     {
//         Console.WriteLine("Meow");
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Dog dog = new Dog();
//         Cat cat = new Cat();

//         dog.MakeSound();
//         dog.Eat();

//         cat.MakeSound();
//         cat.Eat();
//     }
// }

// public class Person
// {
//     //Define the name 
//     public string Name { get; set; }

//     //Define the age
//     public int Age { get; set; }

//     //Define greet method
//     public void Greet()
//     {
//         Console.WriteLine("Hello, My name is " + Name);
//     }
// }

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         // Create the first Person object
//         Person friend = new Person();
//         friend.Name = "John Doe";
//         friend.Age = 30;

//         // Create the second Person object
//         Person colleague = new Person();
//         colleague.Name = "Jane Smith";
//         colleague.Age = 25;

//         friend.Greet();
//         colleague.Greet();
//     }
// }

// public class Program
// {
//     public async Task DownloadDataAsync()
//     {
//         Console.WriteLine("Download started...");
//         await Task.Delay(3000);
//         Console.WriteLine("Download completed.");
//     }
//     public async Task DownloadDataAsync2()
//     {
//         Console.WriteLine("Download 2 started...");
//         await Task.Delay(2000);
//         Console.WriteLine("Download 2 completed.");
//     }

//     public static async Task Main(string[] args)
//     {
//         Program program = new Program();
//         Task task1 = program.DownloadDataAsync();
//         Task task2 = program.DownloadDataAsync2();
//         await Task.WhenAll(task1, task2);
//         Console.WriteLine("All downloads completed.");
//     }
// }

//Fectching product data asynchroously

// using System.Dynamic;

// public class Product
// {
//     public string Name { get; set; }
//     public Product(string name)
//     {
//         Name = name;
//     }
// }

// public class Program
// {
//     public async Task<List<Product>> FetchProductsAsync()
//     {
//         await Task.Delay(2000);
//         return new List<Product>
//         {
//             new Product("Eco Bag"),
//             new Product("Resuable Straw")
//         };
//     }
//     public async Task DisplayProductsAsync()
//     {
//         List<Product> products = await FetchProductsAsync();
//         foreach (Product product in products)
//         {
//             Console.WriteLine(product.Name);
//         }
//     }
//     public static async Task Main()
//     {
//         // Calling the asynchronous method
//         Program program = new Program();
//         await program.DisplayProductsAsync();
//     }
// }

// public class Program
// {
//     public async Task ProcessDataChunkAsync(int chunkId)
//     {
//         Console.WriteLine($"Processing chunk {chunkId}...");
//         await Task.Delay(1000);
//         Console.WriteLine($"Chunk {chunkId} done.");
//     }

//     public async Task ProcessLargeDatasetAsync(int numberOfChunks)
//     {
//         var tasks = new List<Task>();

//         for (int i = 1; i <= numberOfChunks; i++)
//         {
//             tasks.Add(ProcessDataChunkAsync(i));
//         }

//         await Task.WhenAll(tasks);

//         Console.WriteLine("All data chunks processed.");
//     }

//     public static async Task Main()
//     {
//         Program program = new Program();
//         await program.ProcessLargeDatasetAsync(5);
//     }
// }

// public class Program
// {
//     public static async Task PerformLongOperationAsync()
//     {
//         Console.WriteLine("Operation started...");
//         await Task.Delay(3000);
//         Console.WriteLine("After awati..."); //simulate a breakpoint
//         Console.WriteLine("Operation Completed.");
//     }

//     public static void Main(string[] args)
//     {
//         Task.Run(async () => await PerformLongOperationAsync()).Wait();
//         Console.WriteLine("Main method completed.");
//     }
// }

//Libray Management System
class LibrayManager
{
    static void Main()
    {
        string book1 = "";
        string book2 = "";
        string book3 = "";
        string book4 = "";
        string book5 = "";

        bool book1CheckedOut = false;
        bool book2CheckedOut = false;
        bool book3CheckedOut = false;
        bool book4CheckedOut = false;
        bool book5CheckedOut = false;

        int borrowedCount = 0;

        while (true)
        {
            Console.WriteLine("Would you like to add or remove a book? (add/ remove/ search/ borrow/ return/ checkout/ exit)");
            string action = Console.ReadLine();

            if (action == "add")
            {
                Console.WriteLine("Enter the title of the book to add:");
                string newBook = Console.ReadLine();

                if (string.IsNullOrEmpty(book1))
                {
                    book1 = newBook;
                }
                else if (string.IsNullOrEmpty(book2))
                {
                    book2 = newBook;
                }
                else if (string.IsNullOrEmpty(book3))
                {
                    book3 = newBook;
                }
                else if (string.IsNullOrEmpty(book4))
                {
                    book4 = newBook;
                }
                else if (string.IsNullOrEmpty(book5))
                {
                    book5 = newBook;
                }
                else
                {
                    Console.WriteLine("The library is full. No more books can be added.");
                }
            }
            else if (action == "remove")
            {
                Console.WriteLine("Enter the title of the book to remove:");
                string removeBook = Console.ReadLine();

                if (removeBook == book1)
                {
                    book1 = "";
                }
                else if (removeBook == book2)
                {
                    book2 = "";
                }
                else if (removeBook == book3)
                {
                    book3 = "";
                }
                else if (removeBook == book4)
                {
                    book4 = "";
                }
                else if (removeBook == book5)
                {
                    book5 = "";
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }

            }
            else if (action == "borrow")
            {
                if (borrowedCount >= 3)
                {
                    Console.WriteLine("You have reached the borrowing limit of 3 books.");
                }
                else
                {
                    Console.WriteLine("Enter the title of the book to borrow:");
                    string borrowBook = Console.ReadLine() ?? "";

                    if (string.Equals(borrowBook, book1, StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(borrowBook, book2, StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(borrowBook, book3, StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(borrowBook, book4, StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(borrowBook, book5, StringComparison.OrdinalIgnoreCase))
                    {
                        borrowedCount++;
                        Console.WriteLine("\"" + borrowBook + "\" has been borrowed. You have borrowed " + borrowedCount + " book(s).");
                    }
                    else
                    {
                        Console.WriteLine("Book not found in the library.");
                    }
                }
            }
            else if (action == "return")
            {
                if (borrowedCount == 0)
                {
                    Console.WriteLine("You have no borrowed books to return.");
                }
                else
                {
                    borrowedCount--;
                    Console.WriteLine("Book returned. You now have " + borrowedCount + " book(s) borrowed.");
                }
            }
            else if (action == "checkout")
            {
                Console.WriteLine("Enter the title of the book to check out/in:");
                string checkoutBook = Console.ReadLine() ?? "";

                if (string.Equals(checkoutBook, book1, StringComparison.OrdinalIgnoreCase))
                {
                    book1CheckedOut = !book1CheckedOut;
                    Console.WriteLine("\"" + book1 + "\" is now " + (book1CheckedOut ? "checked out." : "checked in."));
                }
                else if (string.Equals(checkoutBook, book2, StringComparison.OrdinalIgnoreCase))
                {
                    book2CheckedOut = !book2CheckedOut;
                    Console.WriteLine("\"" + book2 + "\" is now " + (book2CheckedOut ? "checked out." : "checked in."));
                }
                else if (string.Equals(checkoutBook, book3, StringComparison.OrdinalIgnoreCase))
                {
                    book3CheckedOut = !book3CheckedOut;
                    Console.WriteLine("\"" + book3 + "\" is now " + (book3CheckedOut ? "checked out." : "checked in."));
                }
                else if (string.Equals(checkoutBook, book4, StringComparison.OrdinalIgnoreCase))
                {
                    book4CheckedOut = !book4CheckedOut;
                    Console.WriteLine("\"" + book4 + "\" is now " + (book4CheckedOut ? "checked out." : "checked in."));
                }
                else if (string.Equals(checkoutBook, book5, StringComparison.OrdinalIgnoreCase))
                {
                    book5CheckedOut = !book5CheckedOut;
                    Console.WriteLine("\"" + book5 + "\" is now " + (book5CheckedOut ? "checked out." : "checked in."));
                }
                else
                {
                    Console.WriteLine("Book not found in the library.");
                }
            }
            else if (action == "search")
            {
                Console.WriteLine("Enter the title of the book to search for:");
                string searchBook = Console.ReadLine() ?? "";

                if (string.Equals(searchBook, book1, StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(searchBook, book2, StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(searchBook, book3, StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(searchBook, book4, StringComparison.OrdinalIgnoreCase) ||
                    string.Equals(searchBook, book5, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("\"" + searchBook + "\" is available in the library.");
                }
                else
                {
                    Console.WriteLine("\"" + searchBook + "\" is not in the collection.");
                }
            }
            else if (action == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid action.");
            }
            //Display the list of books
            Console.WriteLine("Available books:");
            if (!string.IsNullOrEmpty(book1)) Console.WriteLine(book1 + (book1CheckedOut ? " [Checked Out]" : ""));
            if (!string.IsNullOrEmpty(book2)) Console.WriteLine(book2 + (book2CheckedOut ? " [Checked Out]" : ""));
            if (!string.IsNullOrEmpty(book3)) Console.WriteLine(book3 + (book3CheckedOut ? " [Checked Out]" : ""));
            if (!string.IsNullOrEmpty(book4)) Console.WriteLine(book4 + (book4CheckedOut ? " [Checked Out]" : ""));
            if (!string.IsNullOrEmpty(book5)) Console.WriteLine(book5 + (book5CheckedOut ? " [Checked Out]" : ""));
        }
    }
}
