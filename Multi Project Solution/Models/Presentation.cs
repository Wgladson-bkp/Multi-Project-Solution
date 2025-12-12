using Multi_Project_Solution.Common;
using System;

namespace Multi_Project_Solution.Models
{
    public class Presentation : ITemplateBase
    {
        public Presentation(string version)
        {
            ProjectFolder = Path.Combine(App.BaseFolder, "Presentation");
            ProjectName = "UI";
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

    <!-- Views -->
    <Folder Include=""Views\Screens\"" />
    <Folder Include=""Views\Components\"" />

    <!-- ViewModels -->
    <Folder Include=""ViewModels\Screens\"" />
    <Folder Include=""ViewModels\Components\"" />

    <!-- Controls -->
    <Folder Include=""Controls\UserControls\"" />
    <Folder Include=""Controls\UserControls\"" />

    <!-- Resources -->
    <Folder Include=""Resources\Themes\"" />
    <Folder Include=""Resources\Styles\"" />
    <Folder Include=""Resources\Assets\"" />
    <Folder Include=""Resources\Assets\Images"" />
    <Folder Include=""Resources\Assets\Icons"" />
    <Folder Include=""Resources\Assets\Fonts"" />


    <!-- Application -->
    <Folder Include=""Application\Services\"" />
    <Folder Include=""Application\Interfaces\"" />
    <Folder Include=""Application\Messages\"" />
    <Folder Include=""Application\Configuration\"" />
    <Folder Include=""Application\Exceptions\"" />
    <Folder Include=""Application\Behaviors\"" />
    <Folder Include=""Application\Converters\"" />
    <Folder Include=""Application\Commands\"" />



  </ItemGroup>

</Project>";
    }
}
