using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace shader_configurator
{
    public class Command
    {
        public string command_name;
        public List<ShaderEnum> values;
        public Command()
        {
            Initialize();
        }

        public Command(string cmd)
        {
            Initialize();
            this.command_name = "no-osd change-list glsl-shaders set";
            if (IsValidCommandString(cmd))
            {
                string[] line = cmd.Replace("~~/shaders/","").Trim('"').Split(';');
                for(int i = 0; i < line.Length; i++)
                {
                    values.Add(Shader.shaders.FirstOrDefault(x => x.Value == line[i]).Key);
                }
            }
        }

        public Command(string cmdName, string cmd) : this(cmd)
        {
            this.command_name = cmdName;
        }

        public bool IsValidCommandString(string v)
        {
            bool success = false;
            string pattern = @".+.glsl(?>;.+.glsl)*";
            if (Regex.IsMatch(v, pattern))
            {
                success = true;
            }
            return success;
        }
        public void Initialize()
        {
            this.command_name = "";
            this.values = new List<ShaderEnum>();
        }
        public string Output()
        {
            return String.Join("", values);
        }

        public string ValueOutput()
        {
            StringBuilder sb = new StringBuilder();
            foreach(ShaderEnum element in this.values)
            {
                sb.Append(Shader.GetValue(element));
                sb.Append(";");
            }
            string str = @"""" + sb.ToString().TrimEnd(';') + @"""";
            return this.command_name + " " + str;
        }
        public string ValueOutput(string shaderRootDirector)
        {
            StringBuilder sb = new StringBuilder();
            foreach (ShaderEnum element in this.values)
            {
                sb.Append(Shader.GetValue(element,shaderRootDirector));
                sb.Append(";");
            }
            string str = @"""" + sb.ToString().TrimEnd(';') + @"""";
            return this.command_name + " " + str;
        }
    }
}