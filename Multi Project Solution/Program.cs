using Multi_Project_Solution.Common;
using Multi_Project_Solution.Models;

namespace Multi_Project_Solution
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //if (args.Length == 0 || args[0] != "new")
            //{
            //    Console.WriteLine("Use: new -v <versao> -o <pasta> -p <projeto|all>");
            //    return;
            //}
            var version = string.Empty;

            var output = string.Empty;

            var projectName = string.Empty;

            var solutionName = string.Empty;

            var createAll = false;


            for (int i = 0; i < args.Length; i++)
            {
                if (args[i] == "-s" && i + 1 < args.Length)
                {
                    solutionName = args[i + 1];
                }

                if (args[i] == "-v" && i + 1 < args.Length)
                {
                    version = args[i + 1];
                }

                if (args[i] == "-o" && i + 1 < args.Length)
                {
                    output = args[i + 1];
                }

                if (args[i] == "-p" && i + 1 < args.Length)
                {
                    projectName = args[i + 1];
                    if (projectName == "all") createAll = true;
                }


            }
            App.Output = @"C:\Projetos\";
            App.SolutionName = "Teste";
            App.BaseFolder = Path.Combine(App.Output, App.SolutionName); ;

            App.ProjectVersion = "net8.0";

            Directory.CreateDirectory(App.BaseFolder);



            StartProcess.Execute(Command.CreateSolutionCommand(App.SolutionName, App.BaseFolder));

            if (!createAll)
            {
                var projList = new List<ITemplateBase>()
                {
                    new Application(App.ProjectVersion),
                    new Infraestructure(App.ProjectVersion),
                    new Domain(App.ProjectVersion)};


                //_ = new Application(App.ProjectVersion);
                //_ = new Infraestructure(App.ProjectVersion);

                // var app = new Application(App.ProjectVersion);
                var proj = new Project(projList);
                proj.CreateProject();
            }

            Messages.ConsoleLogCreateSolution(App.SolutionName, App.Output);

            foreach (var project in App.Projects)
            {
                StartProcess.Execute(Command.AddProjectToSolution(App.BaseFolder, App.SolutionName, project));
            }

            Console.WriteLine("\nProcesso finalizado!");

            Console.ReadKey();
        }
    }
}
