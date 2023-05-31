using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sierra is super cool
namespace Midterm
{
    internal class Book
    {
       public List<Book> book = new List<Book>();

        public string Title { get; set; }
        public string Author { get; set; }
        public string Status { get; set; } = "On Shelf";

        
        public DateTime DueDate { get; set; } //if checked out

        public Book(string title, string author, string status, DateTime duedate) 
        {
            Title = title;
            Author = author;
            Status = status;
            DueDate = duedate;
        
        }
       public bool IsCheckedOut() //determine the status 
        {
            return true;
        }

        static void DisplayMenu()
        {
            Console.WriteLine("----- Library Catalog -----");
            Console.WriteLine("Title\t\tAuthor\t\tStatus\t\tDue Date");
            Console.WriteLine("----------------------------------------------");

            foreach (var book in book)
            {
                Console.WriteLine($"{book.Title}\t{book.Author}\t{book.Status}\t{book.DueDate.ToShortDateString()}");
            }
}








        static void CheckOutBook()
        {
            Console.Write("Enter the title of the book you want to check out: ");
            string title = Console.ReadLine();

            Book book = book.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (book != null)
            {
                if (book.Status == "On Shelf")
                {
                    book.Status = "Checked Out";
                    book.DueDate = DateTime.Today.AddDays(14);
                    Console.WriteLine($"\n{book.Title} by {book.Author} has been checked out to you.");
                 }
            }
        }



    }
}
