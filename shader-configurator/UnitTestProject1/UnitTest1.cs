using Microsoft.VisualStudio.TestTools.UnitTesting;
using shader_configurator;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void KeybindOutputTypeTest()
        {
            Keybind bind = new Keybind();
            Assert.AreEqual(typeof(string), bind.Output().GetType());
        }
        [TestMethod]
        public void KeybindOutputFormatTest()
        {
            Keybind bind = new Keybind();
            string pattern = @"^((CTRL|ALT|SHIFT)\+){0,2}\w$";
            Assert.IsTrue(Regex.IsMatch(bind.Output(), pattern));
        }
        [TestMethod]
        public void ShaderTypeTest()
        {
            Assert.AreEqual(typeof(Dictionary<ShaderEnum, string>), Shader.shaders.GetType());
        }
        [TestMethod]
        public void CommandOutputTypeTest()
        {
            Command cmd = new Command();
            Assert.AreEqual(typeof(string), cmd.Output().GetType());
        }
        [TestMethod]
        public void ControlOutputTypeTest()
        {
            Control control = new Control();
            Assert.AreEqual(typeof(string), control.Output().GetType());
        }
        [TestMethod]
        public void ControlOutputFormatTest()
        {
            Control control = new Control();
            string pattern = @".+\sno-osd\schange-list\sglsl-shaders\sset\s"".+\.glsl""";
            Assert.IsTrue(Regex.IsMatch(control.Output(), pattern));
        }
        [TestMethod]
        public void CommandValueOutputTest()
        {
            Command cmd = new Command();
            Shader shader = new Shader();
            cmd.values.Add(ShaderEnum.DarkLinesFast);
            cmd.values.Add(ShaderEnum.DeblurMedium);
            cmd.values.Add(ShaderEnum.UpscaleOriginal);
            Assert.AreEqual(typeof(string), cmd.ValueOutput().GetType());
        }
        [TestMethod]
        public void CopyFunctionOutputFormatTest()
        {
            //Function Requirements:
            //Accepts 2 Parameters<string, int>
            //Returns string in correct format w/ necessary seperator ;
            string pattern = @"^.+\.glsl(?>;.*\.glsl)*$";
            Assert.IsTrue(Regex.IsMatch(CopyMaker.Output(Shader.shaders.GetValueOrDefault(ShaderEnum.AutoDownscale),3), pattern));
        }
        [TestMethod]
        public void ShaderGetValueTest()
        {
            Shader shader = new Shader();
            Assert.AreEqual(typeof(string), shader.GetValue(ShaderEnum.AutoDownscale).GetType());
        }
        [TestMethod]
        public void ControlInputFormatTest()
        {
            string controlstr = @"CTRL+ALT+1 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Auto_Downscale_Pre_x4.glsl;~~/shaders/Anime4K_Auto_Downscale_Pre_x4(1).glsl""";
            string pattern = @"(.+)\s(no-osd change-list glsl-shaders set)\s("".+\.glsl"")";
            Assert.IsTrue(Regex.IsMatch(controlstr, pattern));
        }
    }
}
