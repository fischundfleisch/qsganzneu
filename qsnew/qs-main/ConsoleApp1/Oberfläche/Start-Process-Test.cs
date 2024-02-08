using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Oberfläche
{
    internal class Start_Process_Test
    {
        public static int StartProcess(string processName)
        {
            // wir müssen hier einen Pfad, zwei Argumente, noch einen Pfad und noch einmal Startbedingungen übergeben
            var process = Process.Start(processName);
            return process.Id;

        }

        public static void StopProcess(int processID)
        {
            var process = Process.GetProcessById(processID);
            process.Kill();
        }
    }
    


}
