using shader_configurator.VAL;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;

namespace shader_configurator
{
    public class Command
    {
        public string command_name;
        public List<ShaderEnum> values;
        public Command()
        {
            this.command_name = "";
            this.values = new List<ShaderEnum>();
        }

        public Command(string cmd) : this()
        {
            if (Validation.IsValidCommandString(cmd))
            {
                Match match = Regex.Match(cmd, Validation.patternCommand);
                if (match.Success)
                {
                    this.command_name = match.Groups[1].Value;
                    string[] line = match.Groups[2].Value.Replace(Shader.defaultShaderDirectory, "").Trim('"').Split(';');
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (!String.IsNullOrEmpty(line[i]))
                        {
                            values.Add(Shader.shaders.FirstOrDefault(x => x.Value == line[i]).Key);
                        }
                    }
                }
            }
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