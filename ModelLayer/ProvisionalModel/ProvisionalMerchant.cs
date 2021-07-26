using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer.ProvisionalModel
{
    public class ProvisionalMerchant
    {
        [Key]
        public long ProvMerchantId { get; set; }
        public string ProvMerchantRefNo { get; set; }
        [Display(Name = "Enter Trade Name")]
        [Required(ErrorMessage = "Please Enter Trade Name")]
        public string CompanyName { get; set; }
        [Display(Name = "Enter Contact Person Name")]
        [Required(ErrorMessage = "Please Enter Contact Person Name")]
        public string ContactPersonName { get; set; }
        [Display(Name = "Enter Email Id")]
        [Required(ErrorMessage = "Please Enter Email Id")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }
        [Display(Name = "Enter Mobile No.")]
        [Required(ErrorMessage = "Please Enter Mobile No.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNo { get; set; }
        [Display(Name = "Enter State")]
        [Required(ErrorMessage = "Please Enter State")]
        public string State { get; set; }
        [Display(Name = "Enter Pincode")]
        [Required(ErrorMessage = "Please Enter Pincode")]
        public int? Pin { get; set; }
        public long? ItemNo { get; set; }
        [Display(Name = "Enter Item Enquire For")]
        [Required(ErrorMessage = "Please Enter Item")]
        public string ItemEnquire { get; set; }
        [Display(Name = "Enter Remark")]
        [Required(ErrorMessage = "Please Enter Remark")]
        public string Remark { get; set; }
        [Display(Name = "Select whearther he is interested or not ?")]
        [Required(ErrorMessage = "Please Select interested")]
        public string Interested { get; set; }
        public int? CretedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
    }
}
