// Problem 1 :Initialize an array of integers
// int[] numbers = { 1, 2, 3, 4, 5 };

// int sum = 0;

// foreach (int number in numbers)
// {
//     sum += number;
// }

// Console.WriteLine("The sum of the array is:" + sum);

// // Problem 2 : Counting the number of Vowels in a string
// string text = "Hello World";
// int VowelCount = 0;

// foreach (char c in text.ToLower())
// {
//     //Check if the character is a vowel
//     if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
//     {
//         VowelCount++;
//     }
// }
// Console.WriteLine("The number of vowels in the string is: " + VowelCount);

// if-else statement
// int grade;

// Console.WriteLine("Enter the student's grade: ");
// grade = int.Parse(Console.ReadLine());

// if (grade >= 50)
// {
//     Console.WriteLine("Pass");
// }
// else
// {
//     Console.WriteLine("Fail");
// }

//Switch Statements
// int score;
// Console.WriteLine("Enter the student's score: ");

// score = int.Parse(Console.ReadLine());

// switch (score / 10)
// {
//     case 10:
//     case 9:
//         Console.WriteLine("A");
//         break;
//     case 8:
//         Console.WriteLine("B");
//         break;
//     case 7:
//         Console.WriteLine("C");
//         break;
//     case 6:
//         Console.WriteLine("D");
//         break;
//     default:
//         Console.WriteLine("Fail");
//         break;
// }

// If-else statement for Ticket Pricing

// int age;
// Console.WriteLine("Enter your age: ");
// age = int.Parse(Console.ReadLine());

// if (age < 12)
// {
//     Console.WriteLine("Half Price Ticket");
// }
// if (12 <= age && age <= 65)
// {
//     Console.WriteLine("Full Price Ticket");
// }
// else
// {
//     Console.WriteLine("Senior discount ticket");
// }

// using System;

// public class Program
// {
//     public static void Main()
//     {
//         // Prompt the user input 
//         Console.WriteLine("Enter your income: ");
//         double income = Convert.ToDouble(Console.ReadLine());

//         Console.WriteLine("Are you a resident? (yes/no): ");
//         string residentInput = Convert.ToString((Console.ReadLine()));
//         bool isResident = residentInput.ToLower() == "yes";

//         double TaxRate = 0;
//         double tax;

//         if (income < 50000)
//         {
//             if (isResident)
//             {
//                 TaxRate = 0.1;

//             }
//             else
//             {
//                 TaxRate = 0.15;
//             }
//         }
//         else if (income >= 50000 && income <= 10000)
//         {
//             if (isResident)
//             {
//                 TaxRate = 0.2;
//             }
//             else
//             {
//                 TaxRate = 0.25;
//             }
//         }
//         else
//         {
//             if (isResident)
//             {
//                 TaxRate = 0.3;
//             }
//             else
//             {
//                 TaxRate = 0.35;
//             }
//         }

//         tax = income * TaxRate;
//         Console.WriteLine("The tax is:" + tax);

//     }
// }

// Bank Account Management system

// using System;

// public class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("What type of account are you opening? (savings, checking, business) ");
//         string accountType = (Console.ReadLine() ?? "").ToLower();

//         double interestRate = 0;
//         int monthlyFee = 0;

//         switch (accountType)
//         {
//             case "savings":
//                 interestRate = 0.2;
//                 Console.WriteLine("Interst rate is 2%");
//                 break;

//             case "checking":
//                 monthlyFee = 10;
//                 Console.WriteLine("Monthly Fee is 10 dollar.");
//                 break;

//             case "business":
//                 interestRate = 0.2;
//                 monthlyFee = 20;
//                 Console.WriteLine("Interst rate is 2% and monthly fee is 20 dollar.");
//                 break;

//             default:
//                 Console.WriteLine("Invalid Account Type.");
//                 break;
//         }
//     }
// }


//While Loop Example
// int counter = 5;

// while (counter < 5)
// {
//     Console.WriteLine(counter);
//     counter++;
// }

// // using System.Diagnostics.Metrics;

// do
// {
//     Console.WriteLine(counter);
//     counter++;

// } while (counter < 5);

// string[] weatherForecasts = { "sunny and warm", "rainy with thunderstorms", "cloudy and cold" };

// for (int i = 0; i < weatherForecasts.Length; i++)
// {
//     switch (weatherForecasts[i])
//     {
//         case "sunny and warm":
//             Console.WriteLine("Today will be " + weatherForecasts[i]);
//             break;

//         case "rainy with thunderstorms":
//             Console.WriteLine("Today will be " + weatherForecasts[i]);
//             break;

//         case "cloudy and cold":
//             Console.WriteLine("Today will be " + weatherForecasts[i]);
//             break;
//     }
// }

// using System;

// public class Program
// {
//     public static void Main()
//     {
//         int number = 10;
//         int factorial = 1;

//         while (number > 0)
//         {
//             {
//                 factorial *= number;
//                 number--;
//             }
//         }
//         Console.WriteLine("Factorials " + factorial);
//     }
// }

// Pass or Fail using if-else statement
// int[] grades = { 85, 92, 55, 75, 64 };

// for (int i = 0; i < grades.Length; i++)
// {
//     int grade = grades[i];
//     string result;

//     if (grade >= 65)
//     {
//         result = "Pass";
//     }
//     else
//     {
//         result = "Fail";
//     }
//     Console.WriteLine(result);
// }

// Processing order by status
// using System.Collections;

// string[] orderStatus = { "Pending", "Shipped", "Delivered", "Cancelled" };

// for (int i = 0; i < orderStatus.Length; i++)
// {
//     string status = orderStatus[i];
//     switch (status)
//     {
//         case "Pending":
//             Console.WriteLine("Order is pending.");
//             break;
//         case "Shipped":
//             Console.WriteLine("Ordered is shipped.");
//             break;
//         case "Delivered":
//             Console.WriteLine("Order is delivered.");
//             break;
//         case "Cancelled":
//             Console.WriteLine("Order is cancelled.");
//             break;
//     }
// }


// int[] grades = { 95, 82, 75, 63, 58 };

// for (int i = 0; i < grades.Length; i++)
// {
//     int grade = grades[i];
//     switch (grade)
//     {
//         case int n when (n >= 90):
//             Console.WriteLine("Grade A");
//             break;
//         case int n when (n >= 70):
//             Console.WriteLine("Grade B");
//             break;
//         default:
//             Console.WriteLine("Grade C");
//             break;
//     }
// }

//Writing function to calculate the area of the rectangle

// using System;

// class Program
// {
//     static double CalculateRectangleArea(double length, double width)
//     {
//         return length * width;
//     }

//     static void Main(string[] args)
//     {
//         Console.WriteLine("Enter the length of rectangle:");
//         double length = Convert.ToDouble((Console.ReadLine()));

//         Console.WriteLine("Enter the width of the rectangle:");
//         double width = Convert.ToDouble(Console.ReadLine());

//         double area = CalculateRectangleArea(length, width);

//         Console.WriteLine(area);
//     }
// }

//area of the circle

// using System;
// using System.Formats.Asn1;

// public class Program
// {
//     static double CalculateCircleArea(double radius)
//     {
//         return Math.PI * radius * radisus;
//     }

//     public static void Main()
//     {
//         Console.WriteLine("Enter the radius of the circle:");
//         double radius = Convert.ToDouble(Console.ReadLine());

//         double area = CalculateCircleArea(radius);

//         Console.WriteLine(area);
//     }
// }

//Defining a method to add Two Numbers

// using System;

// public class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("Enter the first number:");
//         int num1 = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Enter the second number:");
//         int num2 = Convert.ToInt32(Console.ReadLine());

//         int result = AddNumbers(num1, num2);

//         Console.WriteLine(result);

//     }
//     static int AddNumbers(int a, int b)
//     {
//         return a + b;
//     }
// }

// using System;

// public class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("Enter the original price:");
//         decimal originalPrice = Convert.ToDecimal(Console.ReadLine());

//         Console.WriteLine("Discount rate:");
//         decimal discountRate = Convert.ToDecimal(Console.ReadLine());

//         decimal finalPrice = CalculateDiscount(originalPrice, discountRate);
//         Console.WriteLine(finalPrice);
//     }
//     static decimal CalculateDiscount(decimal originalPrice, decimal discountRate)
//     {
//         return originalPrice * discountRate;
//     }
// }

// Trapezoid Area Calculations

// using System;

// public class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("Enter the length of the first parallel side:");
//         decimal a = Convert.ToDecimal(Console.ReadLine());

//         Console.WriteLine("Enter the length of second parallel side:");
//         decimal b = Convert.ToDecimal(Console.ReadLine());

//         Console.WriteLine("Enter the height:");
//         decimal height = Convert.ToDecimal(Console.ReadLine());

//         decimal area = CalculateTrapArea(a, b, height);

//         Console.WriteLine(area);
//     }
//     static decimal CalculateTrapArea(decimal a, decimal b, decimal height)
//     {
//         return (a + b) / 2 * height;
//     }
// }

// using System;

// public class Program
// {
//     public static void Main()
//     {
//         Console.WriteLine("Enter your age:");
//         int age = Convert.ToInt32(Console.ReadLine());

//         bool canDrive = isOldEnough(age);
//         if (canDrive)
//         {
//             Console.WriteLine("You are old enough to drive.");
//         }
//         else
//         {
//             Console.WriteLine("You cannot drive.");
//         }

//         static bool isOldEnough(int age)
//         {
//             if (age >= 18)
//             {
//                 return true;
//             }
//             return false;
//         }
//     }
// }

// void GreetUser(string username)
// {
//     Console.WriteLine("Hello " + username + "!");
// }

// GreetUser("Alice");

// using System;

// public class Program
// {
//     public static int CalculateArea(int length, int width)
//     {
//         int area = length * width;
//         return area;
//     }

//     public static void Main()
//     {
//         Console.WriteLine("Enter the length of the rectangle:");
//         int length = Convert.ToInt32(Console.ReadLine());

//         Console.WriteLine("Enter the width of rectangle:");
//         int width = Convert.ToInt32(Console.ReadLine());

//         int area = CalculateArea(length, width);
//         Console.WriteLine(area);
//     }
// }

// using System;

// public class Program
// {
//     public static void Main(string[] args)
//     {
//         Program program = new Program();
//         program.PrintPassGrade();
//     }

//     public string CalculatePassFail(int studentScore)
//     {
//         if (studentScore >= 60)
//         {
//             return "Pass";
//         }
//         else
//         {
//             return "Fail";
//         }
//     }

//     public string CalculateGrade(int studentScore)
//     {
//         switch (studentScore / 10)
//         {
//             case 10:
//             case 9:
//                 return "A";
//             case 8:
//                 return "B";
//             case 7:
//                 return "C";
//             default:
//                 return "D";
//         }
//     }

//     public void PrintPassGrade()
//     {
//         for (int i = 55; i <= 95; i += 10)
//         {
//             string passFailResult = CalculatePassFail(i);
//             string grade = CalculateGrade(i);
//             Console.WriteLine($"Score {i}, Result : {passFailResult}, grade: {grade}");
//         }
//     }
// }

// using System;
// using System.Collections.Generic;

// class Program
// {
//     static void Main(string[] args)
//     {
//         List<string> tasks = new List<string>();
//         bool exit = false;

//         while (!exit)
//         {
//             Console.WriteLine("1. View Tasks.");
//             Console.WriteLine("2. Add Task.");
//             Console.WriteLine("3. Mark task completed.");
//             Console.WriteLine("4. Exit.");
//             Console.WriteLine("Enter your choice:");

//             int choice;
//             if (int.TryParse(Console.ReadLine(), out choice))
//             {
//                 exit = HandleChoice(tasks, choice);
//             }
//             else
//             {
//                 Console.WriteLine("Please enter a valid number.");
//             }
//         }
//     }

//     private static bool HandleChoice(List<string> tasks, int choice)
//     {
//         bool exit = false;

//         switch (choice)
//         {
//             case 1:
//                 if (tasks.Count == 0)
//                 {
//                     Console.WriteLine("No tasks available.");
//                 }
//                 else
//                 {
//                     for (int i = 0; i < tasks.Count; i++)
//                     {
//                         Console.WriteLine($"{i + 1}. {tasks[i]}");
//                     }
//                 }
//                 break;

//             case 2:
//                 Console.WriteLine("Enter the task:");
//                 string task = Console.ReadLine() ?? string.Empty;
//                 if (!string.IsNullOrWhiteSpace(task))
//                 {
//                     tasks.Add(task);
//                     Console.WriteLine("Task added.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Task cannot be empty.");
//                 }
//                 break;

//             case 3:
//                 Console.WriteLine("Enter the task number to mark complete: ");
//                 if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
//                 {
//                     tasks[taskNumber - 1] += " [Complete]";
//                     Console.WriteLine("Task marked as complete.");
//                 }
//                 else
//                 {
//                     Console.WriteLine("Invalid task number.");
//                 }
//                 break;

//             case 4:
//                 exit = true;
//                 break;

//             default:
//                 Console.WriteLine("Invalid option. Please try again.");
//                 break;
//         }

//         return exit;
//     }
// }


// using System;
// using System.Collections.Generic;  // Needed for List<T>
// partial class Program
// {
//     static void Main(string[] args)
//     {
//         List<string> tasks = new List<string>();
//         bool exit = false;

//         while (!exit)
//         {
//             Console.WriteLine("1. View Tasks");
//             Console.WriteLine("2. Add Task");
//             Console.WriteLine("3. Mark Task Complete");
//             Console.WriteLine("4. Exit");
//             Console.Write("Enter your choice: ");


//             int choice;
//             if (int.TryParse(Console.ReadLine(), out choice))
//             {
//                 switch (choice)
//                 {
//                     case 1:
//                         // Display tasks
//                         if (tasks.Count == 0)
//                         {
//                             Console.WriteLine("No tasks available.");
//                         }
//                         else
//                         {
//                             for (int i = 0; i < tasks.Count; i++)
//                             {
//                                 Console.WriteLine($"{i + 1}. {tasks[i]}");
//                             }
//                         }
//                         break;

//                     case 2:
//                         Console.Write("Enter the task: ");
//                         string task = Console.ReadLine() ?? string.Empty;

//                         // Ensure task is not empty
//                         if (!string.IsNullOrWhiteSpace(task))
//                         {
//                             tasks.Add(task);
//                             Console.WriteLine("Task added.");
//                         }
//                         else
//                         {
//                             Console.WriteLine("Task cannot be empty.");
//                         }
//                         break;

//                     case 3:
//                         Console.Write("Enter the task number to mark complete: ");
//                         int taskNumber;
//                         if (int.TryParse(Console.ReadLine(), out taskNumber) && taskNumber > 0 && taskNumber <= tasks.Count)
//                         {
//                             // Check if the task is already marked complete
//                             if (!tasks[taskNumber - 1].Contains("[Complete]"))
//                             {
//                                 tasks[taskNumber - 1] += " [Complete]";
//                                 Console.WriteLine("Task marked as complete.");
//                             }
//                             else
//                             {
//                                 Console.WriteLine("This task is already marked complete.");
//                             }
//                         }
//                         else
//                         {
//                             Console.WriteLine("Invalid task number.");
//                         }
//                         break;

//                     case 4:
//                         exit = true;
//                         break;

//                     default:
//                         Console.WriteLine("Invalid option, please try again.");
//                         break;
//                 }
//             }
//             else
//             {
//                 Console.WriteLine("Please enter a valid number.");
//             }
//         }
//     }
// }


// Final Project

using System;
using System.Collections.Generic;

namespace InventoryManagement
{
    class Program
    {
        // Data Structures 
        static List<string> productNames = new List<string>();
        static List<double> productPrices = new List<double>();
        static List<int> stockQuantities = new List<int>();

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.WriteLine("Welcome to Inventory Management System.");
                Console.WriteLine("1. Add Product.");
                Console.WriteLine("2. View Inventory.");
                Console.WriteLine("3. Update Stock.");
                Console.WriteLine("4. Remove Product.");
                Console.WriteLine("5. Exit.");
                Console.WriteLine("Select an option:");

                string choice = Console.ReadLine() ?? string.Empty;

                switch (choice)
                {
                    case "1":
                        AddProduct();
                        break;

                    case "2":
                        ViewInventory();
                        break;

                    case "3":
                        UpdateStock();
                        break;

                    case "4":
                        RemoveProduct();
                        break;

                    case "5":
                        running = false;
                        Console.WriteLine("Exit Program.");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice, please try again.");
                        break;
                }
            }
        }

        static void AddProduct()
        {
            Console.WriteLine("Enter product name: ");
            productNames.Add(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Enter product price: ");
            productPrices.Add(double.Parse(Console.ReadLine() ?? "0"));

            Console.WriteLine("Enter product quantity: ");
            stockQuantities.Add(int.Parse(Console.ReadLine() ?? "0"));

            Console.WriteLine("Product added.");
        }

        static void ViewInventory()
        {
            if (productNames.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
            }
            else
            {
                Console.WriteLine("Current Stock");
                for (int i = 0; i < productNames.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {productNames[i]} - Price: {productPrices[i]}, Quantity: {stockQuantities[i]}");
                }
            }
        }

        static void UpdateStock()
        {
            ViewInventory();
            if (productNames.Count == 0) return;


            Console.WriteLine("Enter the product number to update:");
            int index = int.Parse(Console.ReadLine() ?? "0") - 1;

            if (index >= 0 && index < productNames.Count)
            {
                Console.WriteLine("Enter new stock quantity:");
                stockQuantities[index] = int.Parse(Console.ReadLine() ?? "0");
                Console.WriteLine("Stock Updated.");

            }
            else
            {
                Console.WriteLine("Invalid product number");
            }
        }
        static void RemoveProduct()
        {
            ViewInventory();
            if (productNames.Count == 0) return;

            Console.Write("\nEnter the product number to remove: ");
            int index = int.Parse(Console.ReadLine() ?? "0") - 1;

            if (index >= 0 && index < productNames.Count)
            {
                productNames.RemoveAt(index);
                productPrices.RemoveAt(index);
                stockQuantities.RemoveAt(index);
                Console.WriteLine("Product removed from inventory.");
            }
            else
            {
                Console.WriteLine("Invalid product number.");
            }

        }
    }
}
