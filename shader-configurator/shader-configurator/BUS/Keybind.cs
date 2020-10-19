using shader_configurator.VAL;
using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace shader_configurator
{
    public enum KeybindEnum
    {
        EMPTY,
        CTRL,
        SHIFT,
        ALT,
        META
    }
    public class Keybind
    {
        public KeybindEnum firstKey;
        public string secondKey;

        public Keybind()
        {
            this.firstKey = KeybindEnum.EMPTY;
            this.secondKey = "";
        }
        public Keybind(string kb) : this()
        {
            if (Validation.IsValidKeybindString(kb))
            {
                string pattern = Validation.patternKeybind;
                Match match = Regex.Match(kb, pattern);
                if(match.Success)
                {
                    firstKey = (KeybindEnum)Enum.Parse(typeof(KeybindEnum), match.Groups[1].Value);
                    secondKey = match.Groups[2].Value;
                }
            }
        }
        public string Output()
        {
            return OutputRemoveNullEmpty(firstKey.ToString() + "+" + secondKey);
        }
        public string OutputRemoveNullEmpty(string v)
        {
            v = v.Replace("EMPTY+", "");
            v = v.Replace("++","+");
            v = v.Trim('+');
            return v;
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            Keybind c = obj as Keybind;
            if (c == null)
            {
                return false;
            }
            if (this.firstKey == c.firstKey && this.secondKey == c.secondKey)
            {
                return true;
            }
            return false;
        }
    }
}