namespace Multi_Project_Solution.Common
{
    public static class Messages
    {
        public static void ConsoleLogCreateSolution(string solutionName, string outputPath)
        {
            Console.WriteLine($"Criando solution {solutionName} em: {outputPath}");
        }
        public static void ConsoleLogCreatingProject(string projectFolder, string projectName)
        {
            Console.WriteLine($"Criando pasta {projectFolder} | Projeto: {projectName}");
        }

        public static void ConsoleLogCreatingEmptyProject()
        {
            Console.WriteLine($"Listas de projetos não pode estar vazia");
        }
    }
}
