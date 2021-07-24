using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace DataLayer.TableClass
{
    public partial class OPS_Mst_Employee
    {[Key]
        public long EmployeeId { get; set; }
        public string EmployeeRefNo { get; set; }
        [StringLength(150)]
        public string EmployeeName { get; set; }
        public DateTime? DateOfBirth { get; set; }
 
        [StringLength(300)]
        public string Address { get; set; }
        [DataType(DataType.PostalCode)]
        public long? PinCode { get; set; }
        [StringLength(150)]
        public string State { get; set; }
        public int? DepartmentId { get; set; }
       
        [StringLength(10)]
        public string PanCard { get; set; }
        [StringLength(250)]
        public string BankName { get; set; }
        [MaxLength(16)]
        [MinLength(11)]
        public long? AccountNo { get; set; }
        [StringLength(11)]
        public string IFSCode { get; set; }
        [StringLength(250)]
        public string BeneficiaryName { get; set; }
        public bool IsApproved { get; set; }
        public DateTime? RecInsTime { get; set; }
        public string MasterAllowed { get; set; }
        public int? ApprovedBy { get; set; }
        public string PancardImage { get; set; }
        public string? AdharcardImage { get; set; }
        public string? EmployeeImage { get; set; }
        [DataType(((decimal)DataType.Custom))]
        public decimal? AnnualCTC { get; set; }
        public DateTime? JoiningDate { get; set; }
        public int LoginId { get; set; }
    }
}
