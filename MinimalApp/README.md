# sf-orleans-examples - Minimal Application using nuget

https://dotnet.github.io/orleans/1.5/Tutorials/Minimal-Orleans-Application.html

### Projects
Create a blank solution called OrleansTest
- New .NET Core Console Application called Host
- New .NET Standard class library called GrainInterfaces
- New .NET Standard class library called GrainCollection

### nuget
install-package Microsoft.Orleans.OrleansCodeGenerator.Build -project GrainInterfaces

GrainCollection
install-package Microsoft.Orleans.OrleansCodeGenerator.Build

Host
install-package Microsoft.Orleans.OrleansRuntime

