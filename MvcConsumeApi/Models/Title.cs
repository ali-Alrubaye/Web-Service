using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcConsumeApi.Models
{
    public class Title
    {
    
        [Key]
        public string ISBN { get; set; }
        public string Title1 { get; set; }
        public Nullable<int> EditionNumber { get; set; }
        public string Copyright { get; set; }
        public Nullable<bool> SuitableForEducation { get; set; }

      
        public List<Author> Authors { get; set; }

    }
}