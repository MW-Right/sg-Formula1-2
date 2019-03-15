using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1WebApp_CodeFirstSeededDb.Models
{
    public class Car
    {
        [Key]
        public int CarID { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        [Range(0, 21)]
        public int Wins { get; set; }
        [Range(0, 42)]
        public int Podiums { get; set; }
        [Range(0, 21)]
        public int FastestLaps { get; set; }
        [Range(0, 21)]
        public int Poles { get; set; }

        //Adding foreign key constraints
        public int DriverID { get; set; }
        public virtual Driver Driver { get; set; }
        public int ConstructorID { get; set; }
        public virtual Constructor Constructor { get; set; }
    }
}