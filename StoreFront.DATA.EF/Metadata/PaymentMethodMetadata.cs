using System.ComponentModel.DataAnnotations;

namespace StoreFront.DATA.EF
{
    public class PaymentMethodMetadata
    {
        [Required]
        [Display(Name ="Payment Method ID")]
        public int PaymentMethodID { get; set; }

        [Required]
        [StringLength(50)]
        public string Type { get; set; }
    }

    [MetadataType(typeof(PaymentMethodMetadata))]
    public partial class PaymentMethod
    { }
}
