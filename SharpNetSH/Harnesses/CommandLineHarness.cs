using System.Collections.Generic;
using System.Diagnostics;

namespace SharpNetSH
{
    /// <summary>
    /// A harness that executes actions using the command line
    /// </summary>
    public class CommandLineHarness : IExecutionHarness, IExecutionAdministratorHarness
    {
        /// <summary>
        /// Executes command
        /// </summary>
        /// <param name="action"></param>
        /// <param name="exitCode"></param>
        /// <returns></returns>
        public IEnumerable<string> Execute(string action, out int exitCode)
        {
            var process = CreateProcess(action);

            return RunProcess(out exitCode, process);
        }

        private static IEnumerable<string> RunProcess(out int exitCode, Process process)
        {
            process.Start();

            var lines = new List<string>();
            if (process.StartInfo.RedirectStandardOutput)
                while (!process.StandardOutput.EndOfStream)
                    lines.Add(process.StandardOutput.ReadLine());

            process.WaitForExit();

            exitCode = process.ExitCode;

            return lines;
        }

        private static Process CreateProcess(string action)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    CreateNoWindow = true,
                    FileName = "cmd.exe",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    Arguments = "/c " + action
                }
            };
            return process;
        }

        /// <summary>
        /// Executes command using runas verb
        /// </summary>
        /// <param name="action"></param>
        /// <param name="exitCode"></param>
        /// <returns></returns>
        public IEnumerable<string> ExecuteAsAdministrator(string action, out int exitCode)
        {
            var process = CreateProcess(action);

            process.StartInfo.Verb = "runas";
            process.StartInfo.RedirectStandardOutput = false;
            process.StartInfo.UseShellExecute = true;

            return RunProcess(out exitCode, process);
        }
    }
}