# CpaClientManager

Client management for a CPA (certified public accountant) office, built with Orchard Core 3.0.1 on .NET 10
as a university project.

## Structure

| Project | Purpose |
|---|---|
| `src/CpaClientManager.Web` | Orchard Core host application |
| `src/Modules/CpaClientManager.Core` | Custom module |
| `src/Themes/CpaClientManager.Theme` | Custom theme |

## Run

```powershell
dotnet run --project src/CpaClientManager.Web
```