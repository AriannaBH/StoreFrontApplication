using System.ComponentModel.DataAnnotations;

namespace StoreFront.DATA.EF
{
    public class StoreMetadata
    {
        [Required]
        [Display(Name ="Store ID")]
        public int StoreID { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(2)]
        public string State { get; set; }

        [StringLength(6)]
        [Display(Name ="Postal Code")]
        public string ZipCode { get; set; }

        [StringLength(30)]
        public string Country { get; set; }

        [StringLength(20)]
        public string Phone { get; set; }
    }

    [MetadataType(typeof(StoreMetadata))]
    public partial class Store
    { }
}
