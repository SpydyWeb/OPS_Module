using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DataLinkLayer.Models
{
    public partial class Mst_Pincode
    {
        [Key]
        public long PinCodeId { get; set; }
        public int Pincode { get; set; }
        public int StateId { get; set; }
        public string PincodeArea { get; set; }
        public bool IsActive { get; set; }
        public DateTime? RecInsTime { get; set; }
    }
}
