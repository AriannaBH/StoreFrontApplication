using System.ComponentModel.DataAnnotations;

namespace StoreFront.DATA.EF
{
    public class TransactionMetadata
    {
        [Required]
        [Display(Name = "Order ID")]
        public int OrderID { get; set; }

        [Required]
        [Display(Name = "Customer ID")]
        public int CustomerID { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [Display(Name = "Transaction Date")]
        public System.DateTime TransactionDate { get; set; }

        [Required]
        [Display(Name = "Payment Method ID")]
        public int PaymentMethodID { get; set; }

        [Required]
        [Display(Name = "Product ID")]
        public int ProductID { get; set; }

        [Required]
        public int Quantity { get; set; }
    }

    [MetadataType(typeof(TransactionMetadata))]
    public partial class Transaction
    { }
}
