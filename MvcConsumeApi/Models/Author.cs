using System;
using System.Collections.Generic;

namespace MvcConsumeApi.Models
{
    public class Author
    {
     

        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CountryOfResidence { get; set; }
        public string HomeTel { get; set; }
        public Nullable<int> PaymentMethod { get; set; }
        public string TownOfResidence { get; set; }

        public List<Title> Titles { get; set; }

    }
}