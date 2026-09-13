# NetCoreMultiDependencyHelloWorld

A Windows Forms and console sample targeting .NET 10. The active solution contains the Windows Forms app, console app, and two class libraries. The previous .NET Framework WinForms project has been retired.

## Prerequisites

- Windows with the .NET 10.0.401 SDK
- .NET 10 Windows Desktop Runtime for framework-dependent execution

The repository pins the SDK in `global.json`.

## Build and run

```powershell
dotnet restore HelloWorld.sln
dotnet build HelloWorld.sln -c Release --no-restore
dotnet run --project HelloWorld.ConsoleApp -c Release
```

Publish the Windows Forms application for `win-x64`:

```powershell
dotnet publish HelloWorld.FormsApp.Core -c Release -r win-x64 --self-contained false
```

The application expects the .NET 10 Windows Desktop Runtime on the target machine. Single-file and trimmed publishing are not currently supported deployment modes because the sample launches a companion executable and uses reflection-based serialization.

## Dependency security review

Restore before each audit, then review all direct and transitive packages for known vulnerabilities:

```powershell
dotnet restore HelloWorld.sln
dotnet package list --project HelloWorld.ConsoleApp/HelloWorld.ConsoleApp.csproj --vulnerable --include-transitive
dotnet package list --project HelloWorld.FormsApp.Core/HelloWorld.FormsApp.Core.csproj --vulnerable --include-transitive
dotnet package list --project HelloWorld.Library1/HelloWorld.Library1.csproj --vulnerable --include-transitive
dotnet package list --project HelloWorld.Library2/HelloWorld.Library2.csproj --vulnerable --include-transitive
```

Do not release while an unresolved vulnerable package remains. Update the direct dependency when possible and investigate the transitive dependency path when the package is supplied by another library.
