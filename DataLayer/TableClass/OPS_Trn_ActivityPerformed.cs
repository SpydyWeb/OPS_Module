using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace DataLayer.TableClass
{
    public partial class OPS_Trn_ActivityPerformed
    {
        [Key]
        public long ActivityPid { get; set; }
#nullable enable
        public string? MerchantId { get; set; }
        public long? EmployeeId { get; set; }
        public long? ActivityId { get; set; }
        public string? Status { get; set; }
        public string? Remark { get; set; }
        public DateTime? RecInTime { get; set; }
        public string? VoiceRecording { get; set; }
        public string? TradeName { get; set; }
        public DateTime? FollowUpdate { get; set; }
#nullable disable
    }
}
