using System.Diagnostics;

namespace Multi_Project_Solution.Common
{
    public class StartProcess
    {
        public static void Execute(string command)
        {
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "cmd.exe",
                    Arguments = "/c " + command,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            proc.Start();
            proc.WaitForExit();

            Console.Write(proc.StandardOutput.ReadToEnd());
            Console.Write(proc.StandardError.ReadToEnd());
        }
    }
}
