using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace shader_configurator.DAL
{
    public static class ControlManagement
    {
        public static string filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\mpv\input.conf";
        public static List<Control> GetControls()
        {
            List<Control> cList = new List<Control>();
            using(StreamReader sr = new StreamReader(filepath))
            {
                string str = sr.ReadLine();
                while(str != null)
                {
                    
                }
            }
            return cList;
        }
        public static void SetControl(Control control)
        {
            if (File.Exists(filepath))
            {
                using (StreamWriter sw = new StreamWriter(filepath, true))
                {
                    sw.WriteLine(control.Output());
                }
            }
        }
        public static void DeleteControl(Control control)
        {
            if (File.Exists(filepath))
            {
                
            }
        }
    }
}
