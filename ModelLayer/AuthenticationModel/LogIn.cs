using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ModelLayer.AuthenticationModel
{
   public class LogIn
    {
        [Key]
        public int LoginId { get; set; }
        [Required(ErrorMessage ="Please enter your email id")]
        [Display(Name ="Enter Your Email Id")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }
        [Required(ErrorMessage = "Please enter your password")]
        [Display(Name = "Enter Your Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
