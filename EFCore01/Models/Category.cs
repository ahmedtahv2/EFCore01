using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore01.Models
{
    public class Category
    {
        public int CategoryID { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
