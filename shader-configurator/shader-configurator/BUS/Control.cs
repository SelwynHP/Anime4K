using System;
using System.Collections.Generic;
using System.Linq;
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
            Initialize();

            string kb, cmd, pattern;
            Match match;
            switch (IsValidControlString(v))
            {
                case -1:
                    break;
                case 0:
                    pattern = @"(.+)\s(no-osd change-list glsl-shaders set)\s("".+\.glsl"")";
                    match = Regex.Match(v, pattern);
                    if (match.Success)
                    {
                        kb = match.Groups[1].ToString();
                        cmd = match.Groups[3].ToString();

                        this.keybind = new Keybind(kb);
                        this.command = new Command(cmd);
                    }
                    break;
                case 1:
                    pattern = @"(.+)\s(no-osd change-list glsl-shaders clr\s"""";(?>\s.+)?)";
                    match = Regex.Match(v, pattern);
                    if (match.Success)
                    {
                        kb = match.Groups[1].ToString();
                        cmd = match.Groups[2].ToString();

                        this.keybind = new Keybind(kb);
                        this.command.command_name = cmd;
                    }
                    break;
            }
        }
        public void Initialize()
        {
            this.keybind = new Keybind();
            this.command = new Command();
        }
        public int IsValidControlString(string v)
        {
            int result = -1;
            string pattern = @"(.+)\s(no-osd change-list glsl-shaders set)\s("".+\.glsl"")";
            string patternClear = @"(.+)\s(no-osd change-list glsl-shaders clr)\s("""");(?>\s.+)?";
            if (Regex.IsMatch(v, pattern))
            {
                result = 0;
            }
            else
            {
                if (Regex.IsMatch(v, patternClear))
                {
                    result = 1;
                }
            }
            return result;
        }

        public string Output()
        {
            return keybind.Output() + " " + command.ValueOutput();
        }
        static bool ArraysEqual<T>(T[] a1, T[] a2)
        {
            if (ReferenceEquals(a1, a2))
                return true;

            if (a1 == null || a2 == null)
                return false;

            if (a1.Length != a2.Length)
                return false;

            EqualityComparer<T> comparer = EqualityComparer<T>.Default;
            for (int i = 0; i < a1.Length; i++)
            {
                if (!comparer.Equals(a1[i], a2[i])) return false;
            }
            return true;
        }
        public static bool ScrambledEquals<T>(IEnumerable<T> list1, IEnumerable<T> list2)
        {
            var cnt = new Dictionary<T, int>();
            foreach (T s in list1)
            {
                if (cnt.ContainsKey(s))
                {
                    cnt[s]++;
                }
                else
                {
                    cnt.Add(s, 1);
                }
            }
            foreach (T s in list2)
            {
                if (cnt.ContainsKey(s))
                {
                    cnt[s]--;
                }
                else
                {
                    return false;
                }
            }
            return cnt.Values.All(c => c == 0);
        }
        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            Control c = obj as Control;
            if(c == null)
            {
                return false;
            }
            if (ArraysEqual(this.keybind.Keys, c.keybind.Keys)
                && this.command.command_name == c.command.command_name
                && ScrambledEquals(this.command.values, c.command.values))
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return this.Output();
        }
    }
}