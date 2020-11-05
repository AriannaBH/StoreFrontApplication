using System.ComponentModel.DataAnnotations;

namespace StoreFront.DATA.EF
{
    public class StockStatusMetadata
    {
        [Required]
        [Display(Name="Stock Status ID")]
        public int StockStatusID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name ="Stock Status Name")]
        public string Name { get; set; }
    }

    [MetadataType(typeof(StockStatusMetadata))]
    public partial class StockStatus
    { }
}
