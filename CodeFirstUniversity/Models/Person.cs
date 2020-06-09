using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CodeFirstUniversity.Models
{
    public abstract class Person
    {
        public int ID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name="Last Name")]

        public string LastName { get; set; }
        [Required]
        [StringLength(50,ErrorMessage ="First name cannot be longer than 50 character .")]
        [Column("FisrtName")]
        [Display(Name ="Fisrt Name")]

        public string FirstMidName { get; set; }
        [Display(Name ="Full Name")]

        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }

        public Boolean Activo { get; set; } = true;
    }
}