using CpaClientManager.Core.Models;
using CpaClientManager.Core.ViewModels;
using Microsoft.AspNetCore.Mvc;
using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Records;
using YesSql;

namespace CpaClientManager.Core.Controllers;

public sealed class ClientController : Controller
{
    private readonly ISession _session;

    public ClientController(ISession session)
    {
        _session = session;
    }

    [Route("clients")]
    public async Task<IActionResult> Index()
    {
        var contentItems = await _session
            .Query<ContentItem, ContentItemIndex>(index => index.ContentType == "Client" && index.Published)
            .ListAsync();

        var viewModels = contentItems.Select(item =>
        {
            var part = item.As<ClientPart>();
            return new ClientListItemViewModel
            {
                ContentItemId = item.ContentItemId,
                LegalName = part.LegalName,
                TaxId = part.TaxId,
                Email = part.Email
            };
        }).ToList();

        return View(viewModels);
    }
}