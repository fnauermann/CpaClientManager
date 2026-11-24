using System.ComponentModel.DataAnnotations;
namespace CpaClientManager.Core.ViewModels;

public class ClientPartViewModel
{
    [Required]
    public string LegalName { get; set; } = string.Empty;
    
    [Required]
    public string TaxId { get; set; } = string.Empty;
    
    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
}