using shader_configurator.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shader_configurator
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (String.IsNullOrEmpty(Properties.Settings.Default.ShaderRootDirectory))
            {
                Properties.Settings.Default.ShaderRootDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\mpv\\shaders";
                Properties.Settings.Default.Save();
            }
            Application.Run(new ControlForm());
        }
    }
}
