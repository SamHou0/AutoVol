using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using AutoVol.Info;

namespace AutoVol.Tools
{
    internal static class AVFile
    {
        private static string directoryPath = Environment.GetFolderPath
            (Environment.SpecialFolder.ApplicationData) + "\\AutoVol";
        private static string appsPath = directoryPath + "\\SavedApps.xml";
        private static void InitDic()
        {
            Directory.CreateDirectory(directoryPath);
        }
        internal static void SaveApps(List<App> apps)
        {
            InitDic();
            using (StreamWriter sw = new(appsPath))
            {
                XmlSerializer serializer = new(typeof(List<App>));
                serializer.Serialize(sw, apps);
            }
        }
        /// <summary>
        /// Read Apps from local file
        /// </summary>
        /// <returns>The apps in file. Will return empty list when file not exist.</returns>
        internal static List<App> ReadApps()
        {
            InitDic();
            if (File.Exists(appsPath))
            {
                try
                {
                    using (StreamReader sr = new(appsPath))
                    {
                        XmlSerializer serializer = new(typeof(List<App>));
                        List<App> apps = (List<App>)serializer.Deserialize(sr);
                        if (apps != null)
                        {
                            return apps;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("File read error. Will delete saved apps and continue. Exception Message:"
                        + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    File.Delete(appsPath);
                }
            }
            return new List<App> { };
        }
    }
}
