using System;
using System.ComponentModel.DataAnnotations;

namespace StoreFront.DATA.EF
{
    public class EmployeeMetadata
    {
        [Required]
        [Display(Name="Employee ID")]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Display(Name = "Title ID")]
        public Nullable<int> TitleID { get; set; }

        public decimal? Salary { get; set; }
        
        [Display(Name = "Store ID")]
        public Nullable<int> StoreID { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Direct Report ID")]
        public int DirectReportID { get; set; }

    }

    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    { }
}
