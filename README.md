# Automaty.Generators.EFCoreRepositories

[![Build status](https://ci.appveyor.com/api/projects/status/xvjjn0mc3jhq15kw?svg=true)](https://ci.appveyor.com/project/Dresel/automaty-generators-efcorerepositories)

Automaty.Generators.EFCoreRepositories is an [Automaty](https://github.com/Dresel/Automaty) based generator for Entity Framework Core repositories. Creates strongly typed repositories based on the IModel of your context.

See the aggregated [MusicRepository](https://github.com/Dresel/Automaty.Generators.EFCoreRepositories/blob/master/MusicRepository.md) to get a clue what can be generated.

Work in progress. Criticism, comments and or suggestions are welcome.

## Getting started

For more info see the [sample project](https://github.com/Dresel/Automaty.Generators.EFCoreRepositories/tree/master/samples/Automaty.Generators.EFCoreRepositories.Sample).

Edit your project file and add Automaty.Generators.EFCoreRepositories and the DotNetCli tool as references to your project:

```xml
<ItemGroup>
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="1.1.2" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.SQLite" Version="1.1.2" />
    <PackageReference Include="Automaty.Generators.EFCoreRepositories" Version="1.0.0-alpha1" />
    <DotNetCliToolReference Include="Automaty.DotNetCli" Version="1.0.0-alpha6" />
</ItemGroup>
```

Create the Automaty host and inherit from `Host` (don't forget to add referenced [files](https://github.com/Dresel/Automaty/blob/master/README.md#including-additional-folders-and-files)):

```cs
namespace MyProject
{
    // Automaty IncludeFiles MyContext.cs; IUnitOfWork.cs
    // Automaty IncludeDirectory ./Entities
    public class RepositoriesHost : Host<MyContext>
    {
    }
}
```

Run Automaty via command line:

```bash
dotnet automaty run Repositories.cs --project MyProject.csproj
```

Automaty.Generators.EFCoreRepositories will then create an in-memory context instance, retrieve the `IModel` and generate repositories.
