using Multi_Project_Solution.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Project_Solution.Models
{
    internal class Domain : ITemplateBase
    {
        public Domain(string version)
        {
            ProjectFolder = Path.Combine(App.BaseFolder,"Core");
            ProjectName = "Domain";
            FrameworkVersion = version;
        }
        public string ProjectFolder { get; private set; }

        public string ProjectName { get; private set; }

        public string FrameworkVersion { get; private set; }

        public string FolderSchemaBase(string fwrkVersion)=>
            $@"<Project Sdk=""Microsoft.NET.Sdk"">

  <PropertyGroup>
    <TargetFramework>{fwrkVersion}</TargetFramework>
    <ImplicitUsings>enable</ImplicitUsings>
    <Nullable>enable</Nullable>
  </PropertyGroup>

  <ItemGroup>

    <!-- root -->
  <Folder Include=""{ProjectName}\Entities\"" />
  <Folder Include=""{ProjectName}\ValueObjects\"" />
  <Folder Include=""{ProjectName}\Aggregates\"" />
  <Folder Include=""{ProjectName}\Specifications\"" />
  <Folder Include=""{ProjectName}\Services\"" />
  <Folder Include=""{ProjectName}\Events\"" />
  <Folder Include=""{ProjectName}\EventHandlers\"" />
  <Folder Include=""{ProjectName}\Repositories\"" />
  <Folder Include=""{ProjectName}\Factories\"" />
  <Folder Include=""{ProjectName}\Exceptions\"" />
  <Folder Include=""{ProjectName}\Enums\"" />
  <Folder Include=""{ProjectName}\Policies\"" />
  </ItemGroup>

</Project>";
    }
}
