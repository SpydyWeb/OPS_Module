using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DataLayer.TableClass
{
    public partial class OPS_Mst_Dept
    {[Key]
        public long DepartmentId { get; set; }
#nullable enable
        public string? DepartmentName { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? RecInTime { get; set; }
#nullable disable
    }
}
