using CpaClientManager.Core.Drivers;
using CpaClientManager.Core.Handlers;
using CpaClientManager.Core.Models;
using Microsoft.Extensions.DependencyInjection;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.Data.Migration;
using OrchardCore.Modules;

namespace CpaClientManager.Core;

public sealed class Startup : StartupBase
{
    public override void ConfigureServices(IServiceCollection services)
    {
        // Makes the C#-class ClientPart known to Orchard as a content part
        services.AddContentPart<ClientPart>().UseDisplayDriver<ClientPartDisplayDriver>().AddHandler<ClientPartHandler>();

        // Registers the migration that creates the "Client" content type.
        services.AddDataMigration<Migrations>();
    }
}
