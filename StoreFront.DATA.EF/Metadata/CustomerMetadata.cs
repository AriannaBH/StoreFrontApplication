using System.ComponentModel.DataAnnotations;

namespace StoreFront.DATA.EF
{
    public class CustomerMetadata
    {
        [Required]
        [Display(Name="Customer ID")]
        public int CustomerID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        [StringLength(30)]
        public string Country { get; set; }

        [StringLength(6)]
        [Display(Name="Postal Code")]
        public string ZipCode { get; set; }

    }

    [MetadataType(typeof(CustomerMetadata))]
    public partial class Customer
    { }
}
