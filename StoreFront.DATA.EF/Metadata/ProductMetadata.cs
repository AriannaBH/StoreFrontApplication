using System;
using System.ComponentModel.DataAnnotations;

namespace StoreFront.DATA.EF
{
    public class ProductMetadata
    {
        [Required]
        [Display(Name = "Product ID")]
        public int ProductID { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Product Name")]
        public string Name { get; set; }

        [UIHint("MultilineText")]
        public string Description { get; set; }

        public Nullable<int> Quantity { get; set; }

        public Nullable<decimal> Price { get; set; }

        [Required]
        public int CategoryID { get; set; }

        [Required]
        [Display(Name="Stock Status ID")]
        public int StockStatusID { get; set; }

        [Display(Name ="Product Image")]
        public byte[] Image { get; set; }

    }
    [MetadataType(typeof(ProductMetadata))]
    public partial class Product
    { }
}
