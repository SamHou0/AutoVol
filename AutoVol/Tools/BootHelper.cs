using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using TaskScheduler;

namespace AutoVol.Tools
{
    internal static class BootHelper
    {
        public static void AddBoot()
        {
            try
            {
                TaskSchedulerClass ts = new();
                ts.Connect(null, null, null, null);
                //Basic settings
                ITaskDefinition taskDefinition = ts.NewTask(0);
                taskDefinition.RegistrationInfo.Description = "AutoVolBoot";
                taskDefinition.RegistrationInfo.Author = "AutoVol";
                //Trigger
                taskDefinition.Triggers.Create(_TASK_TRIGGER_TYPE2.TASK_TRIGGER_LOGON);
                //Execution
                IExecAction action =
                    (IExecAction)taskDefinition.Actions.Create
                    (_TASK_ACTION_TYPE.TASK_ACTION_EXEC);
                action.Path = AppDomain.CurrentDomain.BaseDirectory + "\\AutoVol.exe";
                //Limitation
                taskDefinition.Settings.ExecutionTimeLimit = "PT0S";
                taskDefinition.Settings.DisallowStartIfOnBatteries = false;
                taskDefinition.Settings.RunOnlyIfIdle = false;
                //Administrator
                taskDefinition.Principal.RunLevel = _TASK_RUNLEVEL.TASK_RUNLEVEL_HIGHEST;
                //Add
                ITaskFolder taskFolder = ts.GetFolder("\\");
                taskFolder.RegisterTaskDefinition("AutoVol", taskDefinition,
                    (int)_TASK_CREATION.TASK_CREATE_OR_UPDATE, null, null,
                    _TASK_LOGON_TYPE.TASK_LOGON_INTERACTIVE_TOKEN);

                MessageBox.Show("Task added!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    "TaskScheduler error. Operation failed. Message:"+
                    Environment.NewLine+ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void RemoveBoot()
        {
            try
            {
                TaskSchedulerClass ts = new TaskSchedulerClass();
                ts.Connect(null, null, null, null);
                ITaskFolder folder = ts.GetFolder("\\");
                folder.DeleteTask("AutoVol", 0);
                MessageBox.Show("Remove completed!");
            }
            catch (Exception err)
            {
                MessageBox.Show(
                    "Operation failed. Maybe you didn't add any Task before. Message:"
                    +Environment.NewLine+
                    err.Message.ToString(), "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
