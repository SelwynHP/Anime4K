using shader_configurator.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace shader_configurator.VAL
{
    public static class Validation
    {
        public static string patternControl = @"^((?>CTRL|SHIFT|ALT|META)+\+[0-9|a-z])\s((?>no-osd\schange-list\sglsl-shaders\s(?>set|clr))\s(?>""(?>.+\.glsl)?""))(?>; show-text ""([^""""]*)"")?$";
        public static string patternKeybind = @"^(CTRL|ALT|SHIFT|META)\+([0-9a-z])$";
        public static string patternCommand = @"^(no-osd\schange-list\sglsl-shaders\s(?>set|clr))\s(?>""(.+\.glsl)?"")$";

        public static bool IsValidControlString(string v)
        {
            bool valid = false;
            string pattern = Validation.patternControl;
            if (Regex.IsMatch(v, pattern))
            {
                valid = true;
            }
            return valid;
        }
        public static bool IsValidKeybindString(string v)
        {
            bool valid = false;
            string pattern = patternKeybind;
            if (Regex.IsMatch(v,pattern))
            {
                valid = true;
            }
            return valid;
        }
        public static bool IsValidCommandString(string v)
        {
            bool valid = false;
            string pattern = patternCommand;
            if (Regex.IsMatch(v, pattern))
            {
                valid = true;
            }
            return valid;
        }
        public static bool IsDuplicateControl(Control control)
        {
            bool duplicate = false;
            if (ControlManagement.GetControls().Contains(control))
            {
                duplicate = true;
            }
            return duplicate;
        }
        public static bool IsDuplicateKeyBinding(Keybind keybind)
        {
            bool duplicate = false;
            foreach(Control element in ControlManagement.GetControls())
            {
                if (element.keybind.Equals(keybind))
                {
                    duplicate = true;
                }
            }
            return duplicate;
        }
    }
}
