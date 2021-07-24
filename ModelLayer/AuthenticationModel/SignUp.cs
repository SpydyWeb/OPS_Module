﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.AuthenticationModel
{
  public  class SignUp
    {
        [Key]
        public long EmployeeId { get; set; }
        public string EmployeeRefNo { get; set; }
        [Display(Name ="Enter Your Name")]
        [Required(ErrorMessage ="Please Enter your name")]
        public string EmployeeName { get; set; }
        [Display(Name = "Enter Your Email Id")]
        [Required(ErrorMessage = "Please Enter your email")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }
        [Display(Name = "Enter Your Mobile No.")]
        [Required(ErrorMessage = "Please Enter your mobile no.")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNo { get; set; }
        [Display(Name = "Enter Your Date Of Birth")]
        [Required(ErrorMessage = "Please Enter your date of birth")]
        [DataType(DataType.Date)]
        public DateTime? DateOfBirth { get; set; }
        [Display(Name = "Enter Your Address")]
        [Required(ErrorMessage = "Please Enter your address")]
        public string Address { get; set; }
        [Display(Name = "Enter Your PinCode")]
        [Required(ErrorMessage = "Please Enter your pincode")]
        public long? PinCode { get; set; }  
        
        public string State { get; set; }        
        public bool IsApproved { get; set; }
        public DateTime? RecInsTime { get; set; }
        public int? ApprovedBy { get; set; }
        [Display(Name = "Upload Your Pan Card")]
        [Required(ErrorMessage = "Please Upload your pan card")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.jpeg|.pdf)$", ErrorMessage = "Only Image and Pdf files allowed.")]
        public string PancardImage { get; set; }
        [Display(Name = "Upload Your Adhaar Card")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.jpeg|.pdf)$", ErrorMessage = "Only Image and Pdf files allowed.")]
        public string? AdharcardImage { get; set; }
        [Display(Name = "Upload Your Photo")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.jpeg)$", ErrorMessage = "Only Image files allowed.")]
        public string? EmployeeImage { get; set; }
        public int LoginId { get; set; }
        [Display(Name ="Enter New Password")]
        [Required(ErrorMessage ="Please enter password")]
        [DataType(DataType.Password)]
        [RegularExpression("^((?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])|(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[^a-zA-Z0-9])|(?=.*?[A-Z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])|(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^a-zA-Z0-9])).{8,}$", ErrorMessage = "Passwords must be at least 8 characters and contain at 3 of 4 of the following: upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)")]
        public string Password { get; set; }
        [Display(Name = "Enter Confirmed Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter confirmed password")]
        [Compare("Password",ErrorMessage ="Password doesn't matched")]
        public string ConfirmedPassword { get; set; }
    }
}