using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiKiemTra03_03.Models
{
    public class Contract
    {
        [Key]
        public int Contract_Id { get; set; }
        [Required]
        public string Contract_name { get; set; }
        [Required]
        public DateTime Signing_Date { get; set; }
        [Required]
        public decimal Contract_Value { get; set; }
        [Required]
        public int CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        [ValidateNever]
        public Customer Customer { get; set; }
    }
}
