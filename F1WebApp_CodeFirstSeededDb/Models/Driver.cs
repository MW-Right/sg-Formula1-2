using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace F1WebApp_CodeFirstSeededDb.Models
{
    public class Driver
    {
        [Key]
        public int DriverID { get; set; }
        [StringLength(50)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Range(0.0, 100)]
        public int Age { get; set; }
        public string Country { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DebutYear { get; set; }
        [DisplayFormat(NullDisplayText = "Still Driving")]
        public DateTime? LastYear { get; set; }
        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return FirstName + ' ' + LastName; }
        }
        //Adding foreign key constraints
        public virtual ICollection<Car> Cars { get; set; }
    }
}