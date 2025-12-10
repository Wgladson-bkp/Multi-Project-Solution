using Multi_Project_Solution.Common;
using System.Text.RegularExpressions;

namespace Multi_Project_Solution.Models
{
    internal class Project
    {
        public Project(ITemplateBase templateBase)
        {
            ItemplateBase = templateBase;
            TemplateBaseList.Add(templateBase);
        }

        public Project(IEnumerable<ITemplateBase> templateBaseList)
        {

            if (templateBaseList == null || templateBaseList?.Count() == 0)
            {
                Messages.ConsoleLogCreatingEmptyProject();
                return;
            }

            TemplateBaseList = templateBaseList.ToList();

        }

        private List<ITemplateBase> TemplateBaseList { get; set; } = new();
        private ITemplateBase ItemplateBase { get; set; }


        public void CreateProject()
        {
            foreach (var project in TemplateBaseList)
            {
                Messages.ConsoleLogCreatingProject(project.ProjectFolder, project.ProjectName);

                StartProcess.Execute(Command.CreateProjectCommand(project.ProjectName, project.FrameworkVersion, project.ProjectFolder));

                var schemaBase = project.FolderSchemaBase(project.FrameworkVersion);

                GenFolderSchemaBase(project.ProjectFolder, schemaBase);

                File.WriteAllText(Path.Combine(project.ProjectFolder, $"{project.ProjectName}.csproj"), schemaBase);

                App.Projects.Add(Path.Combine(project.ProjectFolder, $"{project.ProjectName}.csproj"));
            }
        }

        public static void GenFolderSchemaBase(string output, string schemaBase)
        {
            var pastas = new List<string>();

            var regex = new Regex(@"Include=\""([^\""]+)\""");

            var matches = regex.Matches(schemaBase);

            foreach (Match match in matches)
            {
                if (match.Groups.Count > 1)
                {
                    string pasta = match.Groups[1].Value;

                    pasta = pasta.TrimEnd('\\', '/');

                    pastas.Add(pasta);
                }
            }
            foreach (var pasta in pastas)
                Directory.CreateDirectory(Path.Combine(output, pasta));
        }
    }
}
