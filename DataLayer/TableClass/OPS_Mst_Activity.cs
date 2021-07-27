using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DataLayer.TableClass
{
    public partial class Ops_Mst_Activity
    {
        [Key]
        public int ActivityId { get; set; }
        public string ActivityName { get; set; }
        public bool IsActive { get; set; }
        public DateTime? RecInTime { get; set; }
    }
}
