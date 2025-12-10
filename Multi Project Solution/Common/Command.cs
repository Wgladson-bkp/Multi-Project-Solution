using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_Project_Solution.Common
{

    public static class Command
    {
        public static string CreateSolutionCommand(string solutionName, string outputPath)
        {
            return $"dotnet new sln -n {solutionName} -o {outputPath}";
        }

        public static string CreateProjectCommand(string name, string version, string folder)
        {
            return $"dotnet new classlib -n {name} -f {version} -o {folder}";
        }

        public static string AddProjectToSolution(string output, string solutionName, string proj)
        {
            return $"dotnet sln {Path.Combine(output, solutionName + ".sln")} add {proj}";
        }
    }
}