using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Products.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        [BindProperty(BinderType = typeof(DecimalModelBinder))]
        public decimal Price { get; set; }
        [Required]
        public int StockQuantity { get; set; }
    }
}
