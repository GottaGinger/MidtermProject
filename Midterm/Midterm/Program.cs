﻿
using Midterm;

Book book1 = new Book ("To Kill a Mockingbird", "Harper Lee", "Checked out", DateTime.Now); //due date is two weeks from the checkout date
Book book2 = new Book("1984", "George Orwell", "On Shelf ", DateTime.Now);
Book book3 = new Book("Pride and Prejudice", "Jane Austen", "On Shelf ", DateTime.Now);
Book book4 = new Book("The Catcher in the Rye", "J.D. Salinger", "On Shelf ", DateTime.Now);
Book book5 = new Book("The Alchemist", "Paulo Coelho", "On Shelf ", DateTime.Now);
Book book6 = new Book("The Book Thief", "Markus Zusak", "On Shelf ", DateTime.Now);
Book book7 = new Book("The Girl on the Train", "Paula Hawkins", "On Shelf ", DateTime.Now);
Book book8 = new Book("Gone Girl", "Gillian Flynn", "On Shelf ", DateTime.Now);
Book book9 = new Book("The Color Purple", "Alice Walker", "On Shelf ", DateTime.Now);
Book book10 = new Book("The Picture of Dorian Gray", "Oscar Wilde", "On Shelf ", DateTime.Now);
Book book11 = new Book("The Hobbit", "J.R.R. Tolkien", "Checked Out ", DateTime.Now);
Book book12 = new Book("The Handmaids Tale", "Margaret Atwood", "On Shelf ", DateTime.Now);

while (true)
{
    Console.WriteLine("Welcome to the Library!");
    Console.WriteLine("1. Display all books");
    Console.WriteLine("2. Search by author");
    Console.WriteLine("3. Search by title keyword");
    Console.WriteLine("4. Check out a book");
    Console.WriteLine("5. Return a book");
    Console.WriteLine("6. Exit");
    Console.Write("Please enter your choice: ");
    string choice = Console.ReadLine();

    Console.WriteLine();

    switch (choice)
    {
        case "1":
            BookTerminal.DisplayMenu();
            break;
        case "2":
            BookTerminal.SearchByAuthor();
            break;
        case "3":
            BookTerminal.SearchByTitleKeyWord();
            break;
        case "4":
            BookTerminal.CheckOutBook();
            break;
        case "5":
            BookTerminal.ReturnBook();
            break;
        case "6":
            Console.WriteLine("Thank you for using the Library. Goodbye!");
            return;
        default:
            Console.WriteLine("Invalid choice. Please try again.");
            break;
    }
}

