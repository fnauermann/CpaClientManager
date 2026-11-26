using CpaClientManager.Core.Models;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Handlers;

namespace CpaClientManager.Core.Handlers;

public sealed class ClientPartHandler : ContentPartHandler<ClientPart>
{
    public override Task UpdatedAsync(UpdateContentContext context, ClientPart part)
    {
        // Changes DisplayText to LegalName property (instead of TitlePart)
        part.ContentItem.DisplayText = part.LegalName;

        part.Apply();
        return Task.CompletedTask;
    }
}