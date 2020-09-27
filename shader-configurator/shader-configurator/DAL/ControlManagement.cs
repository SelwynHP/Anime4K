using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;

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
                while(!String.IsNullOrEmpty(str))
                {
                    Control control = new Control(str);
                    cList.Add(control);
                    str = sr.ReadLine();
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
                List<Control> cList = GetControls();
                //Control controlToDelete = new Control();
                //foreach(Control element in cList)
                //{
                //    if (element.Equals(control))
                //    {
                //        controlToDelete = element;
                //        break;
                //    }
                //}
                if (cList.Remove(control))
                {
                    using (StreamWriter sw = new StreamWriter(filepath, false))
                    {
                        foreach (Control element in cList)
                        {
                            sw.WriteLine(element.Output());
                        }
                    }
                }
            }
        }
        public static void UpdateControl(Control oldControl, Control newControl)
        {
            if (File.Exists(filepath))
            {
                List<Control> cList = GetControls();
                int i = -1;
                i = cList.IndexOf(oldControl);
                if(i != -1)
                {
                    cList.Insert(i, newControl);
                    cList.Remove(oldControl);

                    using (StreamWriter sw = new StreamWriter(filepath, false))
                    {
                        foreach (Control element in cList)
                        {
                            sw.WriteLine(element.Output());
                        }
                    }
                }
            }
        }
    }
}
