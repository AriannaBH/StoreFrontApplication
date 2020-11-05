using System.ComponentModel.DataAnnotations;

namespace StoreFront.DATA.EF
{
    public class JobTitleMetadata
    {
        [Required]
        [Display(Name ="Job Title ID")]
        public int TitleID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name="Job Title Name")]
        public string Name { get; set; }
    }

    [MetadataType(typeof(JobTitleMetadata))]
    public partial class JobTitle
    { }
}
