using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using shader_configurator.VAL;
using System.Windows.Forms;

namespace shader_configurator.DAL
{
    public static class ControlManagement
    {
        public static readonly string filepath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\mpv\input.conf";
        public static readonly List<Control> defaultControls = new List<Control>()
            {
                new Control(@"CTRL+1 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Upscale_CNN_L_x2_Denoise.glsl;~~/shaders/Anime4K_Auto_Downscale_Pre_x4.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl""; show-text ""Anime4k: 480/720p (Faithful)"""),
                new Control(@"CTRL+2 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Upscale_CNN_L_x2_Denoise.glsl;~~/shaders/Anime4K_Auto_Downscale_Pre_x4.glsl;~~/shaders/Anime4K_DarkLines_HQ.glsl;~~/shaders/Anime4K_ThinLines_HQ.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl""; show-text ""Anime4k: 480/720p (Perceptual Quality)"""),
                new Control(@"CTRL+3 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Upscale_CNN_L_x2_Denoise.glsl;~~/shaders/Anime4K_Auto_Downscale_Pre_x4.glsl;~~/shaders/Anime4K_Deblur_DoG.glsl;~~/shaders/Anime4K_DarkLines_HQ.glsl;~~/shaders/Anime4K_ThinLines_HQ.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl""; show-text ""Anime4k: 480/720p (Perceptual Quality and Deblur)"""),
                new Control(@"CTRL+4 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Denoise_Bilateral_Mode.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl""; show-text ""Anime4k: 1080p (Faithful)"""),
                new Control(@"CTRL+5 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Denoise_Bilateral_Mode.glsl;~~/shaders/Anime4K_DarkLines_HQ.glsl;~~/shaders/Anime4K_ThinLines_HQ.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl""; show-text ""Anime4k: 1080p (Perceptual Quality)"""),
                new Control(@"CTRL+6 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Denoise_Bilateral_Mode.glsl;~~/shaders/Anime4K_Deblur_DoG.glsl;~~/shaders/Anime4K_DarkLines_HQ.glsl;~~/shaders/Anime4K_ThinLines_HQ.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl""; show-text ""Anime4k: 1080p (Perceptual Quality and Deblur)"""),
                new Control(@"CTRL+0 no-osd change-list glsl-shaders clr """"; show-text ""GLSL shaders cleared""")
            };
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
            cList = cList.OrderBy(x => x.keybind.Output()).ToList();
            return cList;
        }
        public static void SetControl(Control control)
        {
            if (File.Exists(filepath))
            {
                bool isDuplicateControl = Validation.IsDuplicateControl(control);
                bool isDuplicateKeyBinding = Validation.IsDuplicateKeyBinding(control.keybind);
                if(!isDuplicateControl && !isDuplicateKeyBinding)
                {
                    using (StreamWriter sw = new StreamWriter(filepath, true))
                    {
                        sw.WriteLine(control.Output());
                    }
                }
            }
        }
        public static void DeleteControl(Control control)
        {
            if (File.Exists(filepath))
            {
                List<Control> cList = GetControls();
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

        public static void SetControls()
        {
            File.WriteAllText(filepath, "");
            foreach(Control element in defaultControls)
            {
                SetControl(element);
            }
        }

        public static void SetControls(List<Control> controls)
        {
            File.WriteAllText(filepath, "");
            foreach(Control element in controls)
            {
                SetControl(element);
            }
        }
    }
}
