using OrchardCore.Modules.Manifest;

[assembly: Module(
    Name = "CpaClientManager.Core",
    Author = "Frieda Nauermann",
    Version = "0.0.1",
    Description = "CPA client management: the Client content type and related functionality.",
    Category = "Content Management",
    // Contents provides the content services (IContentDefinitionManager, admin content list),
    // Title provides the TitlePart that the Client content type uses.
    Dependencies = new[] { "OrchardCore.Contents", "OrchardCore.Title" }
)]
