using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore01.Models
{
    public class Authors
    {
        public int AuthorsID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Biography { get; set; }
        public DateOnly DOB { get; set; }

    }
}
