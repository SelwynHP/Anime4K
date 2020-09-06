using System;
using System.Text.RegularExpressions;

namespace shader_configurator
{
    public class Control
    {
        public Keybind keybind;
        public Command command;

        public Control()
        {
            Initialize();
        }

        public Control(string v)
        {
            if (IsValidControlString(v))
            {
                string kb;
                string cmd;
                string pattern = @"(.+)\s(no-osd change-list glsl-shaders set)\s("".+\.glsl"")";
                Match match = Regex.Match(v, pattern);
                if (match.Success)
                {
                    kb = match.Captures[0].ToString();
                    cmd = match.Captures[2].ToString();

                    this.keybind = new Keybind(kb);
                    this.command = new Command(cmd);
                }
                else
                {
                    Initialize();
                }
            }
        }
        public void Initialize()
        {
            this.keybind = new Keybind();
            this.command = new Command();
        }
        public bool IsValidControlString(string v)
        {
            bool success = false;
            string pattern = @"(.+)\s(no-osd change-list glsl-shaders set)\s("".+\.glsl"")";
            if (Regex.IsMatch(v, pattern))
            {
                success = true;
            }
            return success;
        }

        public string Output()
        {
            return keybind.Output() + " " + command.command_name + @" """ + command.ValueOutput() + @"""";
        }
    }
}