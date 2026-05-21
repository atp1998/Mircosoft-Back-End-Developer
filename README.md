# Mircosoft-Back-End-Developer

## Foundations of Coding

Implemened the first porject about Inventroy management system using C#.

Objective : To develop the application that allows users to efficiently track and manage a product inventroy. This project ensures accurate data handling so that product details and stock quantities reflect real-time user actions.

Requirements:

Add Products - The application must allow the user to create a new product entry by inputting product name, price and stock quantity.

Update Stock - The application must allow the user to modify the stock level; including stock increasing and stock decreasing.

View Inventroy - The application must display a list of products with their price and stock level.

Remove products - The application must allow the user to delete a specific product from the system.

<img width="636" height="343" alt="outline diagram" src="https://github.com/user-attachments/assets/5f04746c-33ef-4867-b069-a21e1608ad8b" />

## Introduction to programming with C#

Implemented the second project about Library Management System using C#.

Objective : To develop a console application that allows users to efficiently manage a small library collection. This project ensures accurate data handling so that book records, borrowing limits, and checkout status reflect real-time user actions.

Requirements:

Add Books - The application must allow the user to add a new book to the library by entering its title (up to 5 books can be stored).

Remove Books - The application must allow the user to delete a specific book from the collection by title.

Search Books - The application must allow the user to search the collection by title and indicate whether the book is available.

Borrow Books - The application must allow the user to borrow an existing book from the library, with a maximum borrowing limit of 3 books per user.

Return Books - The application must allow the user to return a borrowed book and update the borrowed count accordingly.

Checkout / Check-in - The application must allow the user to toggle the checkout status of a specific book and display its current state.

View Inventory - The application must display the full list of books along with their checkout status after every action.

<img width="900" height="520" alt="Library Management Flow Diagram" src="https://github.com/atp1998/Mircosoft-Back-End-Developer/blob/main/Introduction%20to%20programming%20with%20C%20%23/library_flow_diagram.png" />

### Key Code Snippets

**1. Adding a book into the first empty slot**

```csharp
if (action == "add")
{
    Console.WriteLine("Enter the title of the book to add:");
    string newBook = Console.ReadLine();

    if (string.IsNullOrEmpty(book1)) { book1 = newBook; }
    else if (string.IsNullOrEmpty(book2)) { book2 = newBook; }
    else if (string.IsNullOrEmpty(book3)) { book3 = newBook; }
    else if (string.IsNullOrEmpty(book4)) { book4 = newBook; }
    else if (string.IsNullOrEmpty(book5)) { book5 = newBook; }
    else
    {
        Console.WriteLine("The library is full. No more books can be added.");
    }
}
```

**2. Borrowing a book with a 3-book limit**

```csharp
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
```

**3. Toggling a book's checkout status**

```csharp
else if (action == "checkout")
{
    Console.WriteLine("Enter the title of the book to check out/in:");
    string checkoutBook = Console.ReadLine() ?? "";

    if (string.Equals(checkoutBook, book1, StringComparison.OrdinalIgnoreCase))
    {
        book1CheckedOut = !book1CheckedOut;
        Console.WriteLine("\"" + book1 + "\" is now " + (book1CheckedOut ? "checked out." : "checked in."));
    }
    // ... same pattern for book2 through book5
}
```

**4. Displaying the current inventory after every action**

```csharp
Console.WriteLine("Available books:");
if (!string.IsNullOrEmpty(book1)) Console.WriteLine(book1 + (book1CheckedOut ? " [Checked Out]" : ""));
if (!string.IsNullOrEmpty(book2)) Console.WriteLine(book2 + (book2CheckedOut ? " [Checked Out]" : ""));
if (!string.IsNullOrEmpty(book3)) Console.WriteLine(book3 + (book3CheckedOut ? " [Checked Out]" : ""));
if (!string.IsNullOrEmpty(book4)) Console.WriteLine(book4 + (book4CheckedOut ? " [Checked Out]" : ""));
if (!string.IsNullOrEmpty(book5)) Console.WriteLine(book5 + (book5CheckedOut ? " [Checked Out]" : ""));
```




