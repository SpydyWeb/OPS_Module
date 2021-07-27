using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataLayer.TableClass
{
    public partial class OPS_Mst_Employee : IdentityUser
    {
        public string EmployeeName { get; set; }
        public string Address { get; set; }
        public string PanCard { get; set; }

#nullable enable

        public string? PancardImage { get; set; }
        public int? ApprovedBy { get; set; }
        public string? AdharcardImage { get; set; }
        public string? EmployeeImage { get; set; }
        public decimal? AnnualCTC { get; set; }
        public DateTime? RecInsTime { get; set; }
        public DateTime? JoiningDate { get; set; }
        public string? BankName { get; set; }
        public long? AccountNo { get; set; }
        public string? IFSCode { get; set; }
        public string? BeneficiaryName { get; set; }
        public bool? IsApproved { get; set; }
        public string? EmployeeRefNo { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public long? PinCode { get; set; }
        public string? State { get; set; }
        public int? DepartmentId { get; set; }
        public string? MasterAllowed { get; set; }
#nullable disable
    }
}
