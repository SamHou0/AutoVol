using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoVol.Info;
using AutoVol.Tools;

namespace AutoVol
{
    internal static class Core
    {
        private static IntPtr lastForegroundWindow = IntPtr.Zero;
        internal static void SetVolume(List<App> apps)
        {
            IntPtr foregroundWindow = Api.GetForegroundWindow();
            if (foregroundWindow != lastForegroundWindow)
            {

                lastForegroundWindow = foregroundWindow;
                foreach (App app in apps)
                {
                    Process[] processes = Process.GetProcessesByName(app.Name);
                    foreach (Process process in processes)
                    {
                        if (process.MainWindowHandle == foregroundWindow)
                        {
                            Api.SetVol(app.VolumePercentage);
                            return;
                        }
                    }
                }
            }
        }
    }
}
