# MSTest-4.0.2-Microsoft.CodeCoverage.Core-conflict

## Steps to reproduce

1. `cd TestProject1`
1. `dotnet run` - tests are executed successfully.
1. `dotnet publish --configuration Release`
1. `cd bin/Release/net10.0/publish`
1. `dotnet TestProject1.dll` - runtime exception.
