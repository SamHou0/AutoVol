using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using NAudio.CoreAudioApi;

namespace AutoVol.Tools
{
    public static class Api
    {
        [DllImport("user32.dll")]
        public static extern IntPtr GetForegroundWindow();
        public static void SetVol(int volumePercentage)
        {
            var enumerator = new MMDeviceEnumerator();
            IEnumerable<MMDevice> speakDevices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active).ToArray();
            if (speakDevices.Count() > 0)
            {
                foreach (MMDevice device in speakDevices)
                {
                    device.AudioEndpointVolume.MasterVolumeLevelScalar = volumePercentage / 100.0f;
                }
            }
        }
    }
}
