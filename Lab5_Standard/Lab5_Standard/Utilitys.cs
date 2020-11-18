using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Standard
{
    public static class Utilitys
    {
        public static string GetCurrentProjectDirectory()
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;
            return projectDirectory;
        }

        public static string GetPathTo(params string[] args)
        {
            string relativePath = string.Join("\\", args);
            return GetCurrentProjectDirectory() + "\\" + relativePath;
        }

    }
}
