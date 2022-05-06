using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace AssignmentTwo_ASP.NET_MVC.Models
{
    public class Account
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)] //Manual increment
        //[Range(1,long.MaxValue,ErrorMessage ="Account Number cannot be neagative or Zero")]//client-side validation

        //[Remote("CheckAccountNumber", "Home")]  //performing Remote Validation
        public int AccountNumber { get; set; }
        //[StringLength(byte.MaxValue, MinimumLength = 2, ErrorMessage = "Minimum length must be  5")]
        //[Required(ErrorMessage ="Name must be Specified")]
        public string Name { get; set; }

        //[Range(500, long.MaxValue, ErrorMessage = "Minimum balance must be 500")]
        public double CurrentBalance { get; set; }
    }
}