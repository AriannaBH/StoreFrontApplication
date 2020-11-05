using System.ComponentModel.DataAnnotations;

namespace StoreFront.DATA.EF
{
    public class CategoryMetadata
    {
        [Required]
        [Display(Name="Category ID")]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name="Category Name")]
        public string Name { get; set; }
    }

    [MetadataType(typeof(CategoryMetadata))]
    public partial class Category
    { }

}
