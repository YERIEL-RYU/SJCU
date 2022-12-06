using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManager
{
    internal class Book
    {
        public string? Author { get; set; }
        public string? Title { get; set; }
        public int Year { get; set; }

        public Book(string? author, string? title, int year)
        {
            Author = author; Title = title; Year = year;
        }
    }

}
