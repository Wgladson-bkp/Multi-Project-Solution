using Multi_Project_Solution.Common;
using System;

namespace Multi_Project_Solution.Models
{
    public class Application : ITemplateBase
    {
        public Application(string version)
        {
            ProjectFolder = Path.Combine(App.BaseFolder, "Application");
            ProjectName = "App";
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

    <!-- App root -->
    <Folder Include=""App\Models\"" />
    <Folder Include=""App\DTOs\"" />
    <Folder Include=""App\Interfaces\"" />
    <Folder Include=""App\UseCases\"" />
    <Folder Include=""App\Validators\"" />
    <Folder Include=""App\Mappers\"" />
    <Folder Include=""App\Services\"" />
    <Folder Include=""App\Handlers\"" />

    <!-- Items -->
    <Folder Include=""App\Items\Media\"" />
    <Folder Include=""App\Items\Functions\"" />
    <Folder Include=""App\Items\Resources\"" />

    <!-- Data -->
    <Folder Include=""App\Data\Exceptions\"" />
    <Folder Include=""App\Data\Enums\"" />
    <Folder Include=""App\Data\Logs\"" />
    <Folder Include=""App\Data\Reports\"" />

  </ItemGroup>

</Project>";
    }
}
