using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore01.Models
{
    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string ISBNNumber { get; set; }
        public double Price { get; set; }
        public int Pages { get; set; }
        public int Year { get; set; }
        public bool IsInStock { get; set; }

    }
}
