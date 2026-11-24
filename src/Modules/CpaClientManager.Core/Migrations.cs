using CpaClientManager.Core.Models;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Settings;
using OrchardCore.Data.Migration;

namespace CpaClientManager.Core;

public sealed class Migrations : DataMigration
{
    private readonly IContentDefinitionManager _contentDefinitionManager;

    public Migrations(IContentDefinitionManager contentDefinitionManager)
    {
        _contentDefinitionManager = contentDefinitionManager;
    }

    // Runs once when the module feature is enabled and creates the "Client" content type
    public async Task<int> CreateAsync()
    {
        await _contentDefinitionManager.AlterTypeDefinitionAsync("Client", type => type
            .WithDisplayName("Client")
            .Creatable()
            .Listable()
            .Draftable()
            .WithPart("TitlePart", part => part.WithPosition("0")));

        return 1;
    }

    public async Task<int> UpdateFrom1Async()
    {
        await _contentDefinitionManager.AlterPartDefinitionAsync(nameof(ClientPart), part => part.Attachable());

        await _contentDefinitionManager.AlterTypeDefinitionAsync("Client", type => type.WithPart(nameof(ClientPart), part => part.WithPosition("1")));

        return 2;
    }
}
