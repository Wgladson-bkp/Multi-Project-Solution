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
    <Folder Include=""{ProjectName}\Models\"" />
    <Folder Include=""{ProjectName}\DTOs\"" />
    <Folder Include=""{ProjectName}\Interfaces\"" />
    <Folder Include=""{ProjectName}\UseCases\"" />
    <Folder Include=""{ProjectName}\Validators\"" />
    <Folder Include=""{ProjectName}\Mappers\"" />
    <Folder Include=""{ProjectName}\Services\"" />
    <Folder Include=""{ProjectName}\Handlers\"" />

    <!-- Items -->
    <Folder Include=""{ProjectName}\Items\Media\"" />
    <Folder Include=""{ProjectName}\Items\Functions\"" />
    <Folder Include=""{ProjectName}\Items\Resources\"" />

    <!-- Data -->
    <Folder Include=""{ProjectName}\Data\Exceptions\"" />
    <Folder Include=""{ProjectName}\Data\Enums\"" />
    <Folder Include=""{ProjectName}\Data\Logs\"" />
    <Folder Include=""{ProjectName}\Data\Reports\"" />

  </ItemGroup>

</Project>";
    }
}
