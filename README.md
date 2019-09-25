# NetCoreMultiDependencyHelloWorld
A hello world project for .NET Core 3.0 that puts a Windows forms app into .NET core referencing a chain of .NET standard libraries, using third-party dependencies that trigger a version downgrade error by default

Build using dotnet publish -r win-x64 -c Release /p:PublishSingleFile=true or dotnet publish -r win-x64 -c Release /p:PublishSingleFile=true /p:PublishTrimmed=true in HelloWorld.FormsApp.Core
