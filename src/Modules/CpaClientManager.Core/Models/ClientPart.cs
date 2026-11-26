using OrchardCore.ContentManagement;
namespace CpaClientManager.Core.Models;

public class ClientPart : ContentPart
{
    public string LegalName { get; set; } = string.Empty;
    public string TaxId { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}