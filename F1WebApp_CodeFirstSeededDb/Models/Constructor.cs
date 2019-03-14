using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1WebApp_CodeFirstSeededDb.Models
{
    public class Constructor
    {
        [Key]
        public int ConstructorID { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public int Age { get; set; }

        //Adding foreign key constraints
        public virtual ICollection<Car> Cars { get; set; }
    }
}