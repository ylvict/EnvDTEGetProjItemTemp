using EnvDTE90;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnvDTEGetProjItemTemp
{
    class Program
    {
        static void Main(string[] args)
        {
            var dte = (EnvDTE.DTE)System.Runtime.InteropServices.Marshal.GetActiveObject("VisualStudio.DTE");
            var temps = ((Solution3)dte.Solution).GetProjectItemTemplates("FSharp", null);
            for (int i = 1; i <= temps.Count; i++)
            {
                Console.WriteLine(temps[i].Name);
            }
        }
    }
}
