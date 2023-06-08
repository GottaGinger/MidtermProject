using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Midterm



{
    internal class BookTerminal : Book
    {

        public BookTerminal(string title, string author, string status, DateTime duedate) : base(title, author, status, duedate)
        {

        }
        static List<Book> books = new List<Book>();
        public static void AddBook(Book book)
        {
            books.Add(book);

        }

        public static void DisplayMenu()
        {
            Console.WriteLine("----- Library Catalog -----");
            Console.WriteLine("Title\t\tAuthor\t\tStatus\t");
            Console.WriteLine("------------------------------------");

            foreach (var book in books)
            {
                Console.WriteLine($"{book.Title}\t{book.Author}\t{book.Status}");
            }
        }


        public static void SearchByAuthor()
        {
            Console.WriteLine("What is the author name?");
            string author = Console.ReadLine();
            Console.WriteLine("\nSearch Results:");
            Console.WriteLine("Title\t\tAuthor\t\tStatus\t");
            Console.WriteLine("----------------------------------------------");

            foreach (var book in books)
            {
                if (book.Author.Contains(author, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{book.Title}\t{book.Author}\t{book.Status}");
                }
            }
        }

        public static void SearchByTitleKeyWord()
        {
            Console.WriteLine("Enter a title or keyword:");
            string titleKeyword = Console.ReadLine();

            Console.WriteLine("\nSearch Results:");
            Console.WriteLine("Title\t\tAuthor\t\tStatus\t");
            Console.WriteLine("----------------------------------------------");

            foreach (var book in books)
            {
                if (book.Title.Contains(titleKeyword, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{book.Title}\t{book.Author}\t{book.Status}");
                }
            }
        }

        public static void CheckOutBook()
        {
            Console.Write("Enter the title of the book you want to check out: ");
            string title = Console.ReadLine();

            Book book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (book != null)
            {
                if (book.Status == "On Shelf")
                {
                    book.Status = "Checked Out";
                    book.DueDate = DateTime.Today.AddDays(14);
                    Console.WriteLine($"\n{book.Title} by {book.Author} has been checked out to you. Your due date is {book.DueDate}");
                }
                else
                {
                    Console.WriteLine("This book has already been checked out.");
                }
            }
            else
            {
                Console.WriteLine($"\n{title} is not found in the list of books.");
            }
        }

        public static void ReturnBook()
        {
            Console.WriteLine("Enter the title of the book you want to return:");
            string title = Console.ReadLine();

            Book book = books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (book != null)
            {
                if (book.Status == "Checked Out")
                {
                    book.Status = "On Shelf";
                    book.DueDate = DateTime.MinValue;
                    Console.WriteLine($"\n{book.Title} by {book.Author} has been returned. Thank you!");
                }
                else
                {
                    Console.WriteLine($"\n{book.Title} by {book.Author} is already on the shelf.");
                }
            }
            else
            {
                Console.WriteLine($"\n{title} is not found in the list of books.");
            }
        }

        public static void SaveBooksToFile(string filePath)

        {
           

            using (StreamWriter writer = new StreamWriter(filePath))
            {

                foreach (var book in books)
                {
                    JsonSerializer serializer = new JsonSerializer();
                    string json = JsonConvert.SerializeObject(book);
                    writer.WriteLine(json);


                }
            }
        }

        public static void LoadBooksFromFile(string filePath)
        {
           
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                while ((line = reader.ReadLine()) != null) 
                {
                    if (File.Exists(filePath))
                    {
                       
                        books.Add(JsonConvert.DeserializeObject<Book>(line));
                       
                    }
                }
            }
        }
    }
}
    
        





