using System.ComponentModel.DataAnnotations;
namespace CpaClientManager.Core.ViewModels;

public class ClientPartViewModel
{
    [Required]
    [Display(Name = "Legal Name")]
    public string LegalName { get; set; } = string.Empty;
    
    [Required]
    [Display(Name = "Tax Id")]
    public string TaxId { get; set; } = string.Empty;
    
    [Required]
    [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Please enter a valid email address.")]
    public string Email { get; set; } = string.Empty;
}