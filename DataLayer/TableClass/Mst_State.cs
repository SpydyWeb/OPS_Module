using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DataLinkLayer.Models
{
    public partial class Mst_State
    {
        [Key]
        public int StateId { get; set; }
        public int? CountryId { get; set; }
        public string StateName { get; set; }
        public bool IsActive { get; set; }
        public DateTime? RecInsTime { get; set; }
    }
}
