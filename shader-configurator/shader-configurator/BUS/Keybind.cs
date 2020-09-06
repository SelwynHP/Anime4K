using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace shader_configurator
{
    public class Keybind
    {
        public string[] Keys{ get; set; }

        public Keybind()
        {
            this.Keys = new string[3] { "CTRL", "ALT", "1" };
        }

        public Keybind(string kb)
        {
        }

        public string Output()
        {
            return String.Join("+", this.Keys);
        }
    }
}