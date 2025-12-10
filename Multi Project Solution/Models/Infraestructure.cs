using Multi_Project_Solution.Common;

namespace Multi_Project_Solution.Models
{
    public class Infraestructure : ITemplateBase
    {
        public Infraestructure(string version)
        {
            ProjectFolder = Path.Combine(App.BaseFolder, "Infrastructure");
            ProjectName = "Interop";
            FrameworkVersion = version;
        }

        public string ProjectFolder { get; private set; }

        public string ProjectName { get; private set; }

        public string FrameworkVersion { get; private set; }

        public string FolderSchemaBase(string fwrkVersion) =>
            $@"<Project Sdk=""Microsoft.NET.Sdk"">

  <PropertyGroup>
    <TargetFramework>{fwrkVersion}</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>
    <Folder Include=""Persistence\Contexts\"" />
    <Folder Include=""Persistence\Repositories\"" />
    <Folder Include=""Persistence\Configurations\"" />
    <Folder Include=""Persistence\Migrations\"" />

    <Folder Include=""Configuration\Options\"" />
    <Folder Include=""Configuration\Bindings\"" />
    <Folder Include=""Configuration\Settings\"" />

    <Folder Include=""Logging\Providers\"" />
    <Folder Include=""Logging\Extensions\"" />

    <Folder Include=""Networking\Clients\"" />
    <Folder Include=""Networking\Handlers\"" />

    <Folder Include=""Messaging\Producers\"" />
    <Folder Include=""Messaging\Consumers\"" />

    <Folder Include=""Security\Encryption\"" />
    <Folder Include=""Security\Hashing\"" />
    <Folder Include=""Security\Tokens\"" />
    <Folder Include=""Security\Certificates\"" />

    <Folder Include=""Services\External\"" />
    <Folder Include=""Services\Notifications\"" />
    <Folder Include=""Services\Internal\"" />
    <Folder Include=""Services\Providers\"" />

    <Folder Include=""Storage\Files\"" />
    <Folder Include=""Storage\Local\"" />
    <Folder Include=""Storage\Remote\"" />

    <Folder Include=""Caching\Providers\"" />
    <Folder Include=""Caching\Extensions\"" />

    <Folder Include=""Common\Extensions\"" />
    <Folder Include=""Common\Helpers\"" />
    <Folder Include=""Common\Utils\"" />

    <Folder Include=""DependencyInjection\Modules\"" />
  </ItemGroup>

</Project>";
    }
}
