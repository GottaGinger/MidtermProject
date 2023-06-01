using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sierra is super dupper cool
namespace Midterm
{
    internal class Book
    {

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
    }
}

