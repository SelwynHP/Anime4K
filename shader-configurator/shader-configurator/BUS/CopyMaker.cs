using System;
using System.Text;

namespace shader_configurator
{
    public static class CopyMaker
    {
        public static string Output(string str, int cpy)
        {
            StringBuilder sb = new StringBuilder();
            if(cpy <= 1)
            {
                return str;
            }
            else
            {
                sb.Append(str);
                string[] line;
                line = str.Split('.');
                for (int i = 1; i < cpy; i++)
                {
                    sb.Append(";");
                    sb.Append(line[0]);
                    sb.Append("(" + i + ")");
                    sb.Append(".");
                    sb.Append(line[1]);
                }
                return sb.ToString();
            }
        }
    }
}