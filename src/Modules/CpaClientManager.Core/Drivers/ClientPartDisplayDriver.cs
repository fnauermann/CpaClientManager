using CpaClientManager.Core.Models;
using CpaClientManager.Core.ViewModels;
using OrchardCore.ContentManagement.Display.ContentDisplay;
using OrchardCore.ContentManagement.Display.Models;
using OrchardCore.DisplayManagement.Views;

namespace CpaClientManager.Core.Drivers;

public sealed class ClientPartDisplayDriver : ContentPartDisplayDriver<ClientPart>
{
    public override IDisplayResult Edit(ClientPart part, BuildPartEditorContext context)
    {
        return Initialize<ClientPartViewModel>(GetEditorShapeType(context), vm =>
        {
            vm.LegalName = part.LegalName;
            vm.TaxId = part.TaxId;
            vm.Email = part.Email;
        });
    }

    public override async Task<IDisplayResult> UpdateAsync(ClientPart part, UpdatePartEditorContext context)
    {
        var vm = new ClientPartViewModel();
        await context.Updater.TryUpdateModelAsync(vm, Prefix);
        
        part.LegalName = vm.LegalName;
        part.TaxId = vm.TaxId;
        part.Email = vm.Email;
        
        return Edit(part, context);
    }
}