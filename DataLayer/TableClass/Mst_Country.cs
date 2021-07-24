using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DataLinkLayer.Models
{
    public partial class Mst_Country
    {[Key]
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public bool IsActive { get; set; }
        public DateTime? RecInsTime { get; set; }
    }
}
