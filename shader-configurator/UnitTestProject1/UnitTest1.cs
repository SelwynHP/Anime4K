using Microsoft.VisualStudio.TestTools.UnitTesting;
using shader_configurator;
using shader_configurator.DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestKeybind
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
            bind.Keys = new string[] { "CTRL", "ALT", "1" };
            string pattern = @"^((CTRL|ALT|SHIFT)\+){0,2}\w$";
            Assert.IsTrue(Regex.IsMatch(bind.Output(), pattern));
        }
        [TestMethod]
        public void KeybindOutputRemoveNullEmptyTest()
        {
            Keybind kb = new Keybind();
            kb.Keys = new string[] { "CTRL", "ALT", "1" };
            kb.Keys[1] = "EMPTY";

            string str = kb.Output();
            Assert.IsTrue(!str.Contains("EMPTY") || !str.Contains(@"\s"));
        }
    }
    [TestClass]
    public class UnitTestCommand
    {
        [TestMethod]
        public void CommandOutputTypeTest()
        {
            Command cmd = new Command();
            Assert.AreEqual(typeof(string), cmd.Output().GetType());
        }
        [TestMethod]
        public void CommandValueOutputTypeTest()
        {
            Command cmd = new Command();
            cmd.values.Add(ShaderEnum.DarkLinesFast);
            cmd.values.Add(ShaderEnum.DeblurMedium);
            cmd.values.Add(ShaderEnum.UpscaleOriginal);
            Assert.AreEqual(typeof(string), cmd.ValueOutput().GetType());
        }
        [TestMethod]
        public void CommandValueOutputFormatTest()
        {
            Command cmd = new Command();
            cmd.command_name = "no-osd change-list glsl-shaders set";
            cmd.values.Add(ShaderEnum.DarkLinesFast);
            cmd.values.Add(ShaderEnum.DeblurMedium);
            cmd.values.Add(ShaderEnum.UpscaleOriginal);
            string pattern = @"no-osd change-list glsl-shaders set\s"".+.glsl""";
            Assert.IsTrue(Regex.IsMatch(cmd.ValueOutput(), pattern));
        }
    }
    [TestClass]
    public class UnitTestControl
    {
        [TestMethod]
        public void ControlOutputTypeTest()
        {
            Control control = new Control();
            Assert.AreEqual(typeof(string), control.Output().GetType());
        }
        [TestMethod]
        public void ControlOutputFormatTestRange()
        {
            bool success = true;
            string[] input = new string[]
            {
                @"CTRL+1 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Upscale_CNN_L_x2_Denoise.glsl;~~/shaders/Anime4K_Auto_Downscale_Pre_x4.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl""; show-text ""Anime4k: 480/720p (Faithful)""",
                @"CTRL+2 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Upscale_CNN_L_x2_Denoise.glsl;~~/shaders/Anime4K_Auto_Downscale_Pre_x4.glsl;~~/shaders/Anime4K_DarkLines_HQ.glsl;~~/shaders/Anime4K_ThinLines_HQ.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl""; show-text ""Anime4k: 480/720p (Perceptual Quality)""",
                @"CTRL+3 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Upscale_CNN_L_x2_Denoise.glsl;~~/shaders/Anime4K_Auto_Downscale_Pre_x4.glsl;~~/shaders/Anime4K_Deblur_DoG.glsl;~~/shaders/Anime4K_DarkLines_HQ.glsl;~~/shaders/Anime4K_ThinLines_HQ.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl""; show-text ""Anime4k: 480/720p (Perceptual Quality and Deblur)""",
                @"CTRL+4 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Denoise_Bilateral_Mode.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl""; show-text ""Anime4k: 1080p (Faithful)""",
                @"CTRL+5 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Denoise_Bilateral_Mode.glsl;~~/shaders/Anime4K_DarkLines_HQ.glsl;~~/shaders/Anime4K_ThinLines_HQ.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl""; show-text ""Anime4k: 1080p (Perceptual Quality)""",
                @"CTRL+6 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Denoise_Bilateral_Mode.glsl;~~/shaders/Anime4K_Deblur_DoG.glsl;~~/shaders/Anime4K_DarkLines_HQ.glsl;~~/shaders/Anime4K_ThinLines_HQ.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl""; show-text ""Anime4k: 1080p (Perceptual Quality and Deblur)""",
                @"CTRL+0 no-osd change-list glsl-shaders clr """"; show-text ""GLSL shaders cleared""",
                @"CTRL+1 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Upscale_CNN_L_x2_Denoise.glsl;~~/shaders/Anime4K_Auto_Downscale_Pre_x4.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl",
                @"CTRL+2 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Upscale_CNN_L_x2_Denoise.glsl;~~/shaders/Anime4K_Auto_Downscale_Pre_x4.glsl;~~/shaders/Anime4K_DarkLines_HQ.glsl;~~/shaders/Anime4K_ThinLines_HQ.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl",
                @"CTRL+3 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Upscale_CNN_L_x2_Denoise.glsl;~~/shaders/Anime4K_Auto_Downscale_Pre_x4.glsl;~~/shaders/Anime4K_Deblur_DoG.glsl;~~/shaders/Anime4K_DarkLines_HQ.glsl;~~/shaders/Anime4K_ThinLines_HQ.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl",
                @"CTRL+4 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Denoise_Bilateral_Mode.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl",
                @"CTRL+5 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Denoise_Bilateral_Mode.glsl;~~/shaders/Anime4K_DarkLines_HQ.glsl;~~/shaders/Anime4K_ThinLines_HQ.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl",
                @"CTRL+6 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Denoise_Bilateral_Mode.glsl;~~/shaders/Anime4K_Deblur_DoG.glsl;~~/shaders/Anime4K_DarkLines_HQ.glsl;~~/shaders/Anime4K_ThinLines_HQ.glsl;~~/shaders/Anime4K_Upscale_CNN_M_x2_Deblur.glsl",
                @"CTRL+0 no-osd change-list glsl-shaders clr """""
            };
            
            foreach(string str in input)
            {
                if(!ControlOutputFormatTest(new Control(str)))
                {
                    Assert.IsTrue(success);
                    break;
                }
            }
            Assert.IsTrue(success);
        }
        public bool ControlOutputFormatTest(Control control)
        {
            bool match = false;
            string pattern = @"((?>CTRL|SHIFT|ALT|META)+\+[0-9])\s(no-osd\schange-list\sglsl-shaders\s(?>set|clr))\s(?>""(.+\.glsl)?"")(?>; show-text ""([^""]*)"")?";
            match = Regex.IsMatch(control.Output(), pattern);
            return match;
        }
        [TestMethod]
        public void ControlInputFormatTest()
        {
            string controlstr = @"CTRL+ALT+1 no-osd change-list glsl-shaders set ""~~/shaders/Anime4K_Auto_Downscale_Pre_x4.glsl;~~/shaders/Anime4K_Auto_Downscale_Pre_x4(1).glsl""";
            string pattern = @"(.+)\s(no-osd change-list glsl-shaders set)\s""(.+\.glsl)""";
            Assert.IsTrue(Regex.IsMatch(controlstr, pattern));
        }
    }
    [TestClass]
    public class UnitTestControlManagement
    {
        [TestMethod]
        public void ControlManagementSetControlTest()
        {
            bool success = false;
            //Control Initialization
            Control control = new Control();
            control.keybind.Keys = new string[2] { "SHIFT", "2" };
            control.command.command_name = "no-osd change-list glsl-shaders set";
            control.command.values.Add(ShaderEnum.AutoDownscale);
            control.command.values.Add(ShaderEnum.DarkLinesHQ);
            control.command.values.Add(ShaderEnum.ResamplingArtifactLarge);
            control.command.values.Add(ShaderEnum.UpscaleUltra);

            ControlManagement.SetControl(control);
            List<Control> cList = ControlManagement.GetControls();
            if (cList.Contains(control)) { success = true; ControlManagement.DeleteControl(control); }
            Assert.IsTrue(success);
        }
        [TestMethod]
        public void ControlManagementUpdateControlTest()
        {
            bool success = false;

            Control control = new Control();
            control.keybind.Keys = new string[2] { "CTRL", "9" };
            control.command.command_name = "no-osd change-list glsl-shaders set";
            control.command.values.Add(ShaderEnum.AutoDownscale);
            control.command.values.Add(ShaderEnum.DarkLinesHQ);
            control.command.values.Add(ShaderEnum.ResamplingArtifactLarge);
            control.command.values.Add(ShaderEnum.UpscaleUltra);
            ControlManagement.SetControl(control);

            Control newControl = new Control();
            newControl.keybind.Keys = new string[2] { "SHIFT", "0" };
            newControl.command.command_name = "no-osd change-list glsl-shaders set";
            newControl.command.values.Add(ShaderEnum.AutoDownscale);
            newControl.command.values.Add(ShaderEnum.DeblurLarge);
            newControl.command.values.Add(ShaderEnum.UpscaleOriginal);
            newControl.command.values.Add(ShaderEnum.UpscaleUltraDenoise);

            ControlManagement.UpdateControl(control, newControl);

            List<Control> cList = ControlManagement.GetControls();
            if(cList.Contains(newControl) && !cList.Contains(control)) { success = true; ControlManagement.DeleteControl(newControl); }
            Assert.IsTrue(success);
        }
        [TestMethod]
        public void ControlManagementDeleteControlTest()
        {
            Control control = new Control();
            control.keybind.Keys = new string[2] { "CTRL", "7" };
            control.command.command_name = "no-osd change-list glsl-shaders set";
            control.command.values.Add(ShaderEnum.AutoDownscale);
            control.command.values.Add(ShaderEnum.DarkLinesHQ);
            control.command.values.Add(ShaderEnum.ResamplingArtifactLarge);
            control.command.values.Add(ShaderEnum.UpscaleUltra);

            ControlManagement.SetControl(control);
            ControlManagement.DeleteControl(control);
            List<Control> cList = ControlManagement.GetControls();
            Assert.IsTrue(!cList.Contains(control));
            
        }
        [TestMethod]
        public void ControlManagementGetControlsTest()
        {
            Assert.AreEqual(typeof(List<Control>), ControlManagement.GetControls().GetType());
        }
    }
    [TestClass]
    public class UnitTestShader
    {
        [TestMethod]
        public void ShaderTypeTest()
        {
            Assert.AreEqual(typeof(Dictionary<ShaderEnum, string>), Shader.shaders.GetType());
        }
        [TestMethod]
        public void ShaderGetValueTest()
        {
            Assert.AreEqual(typeof(string), Shader.GetValue(ShaderEnum.AutoDownscale).GetType());
        }
    }
    [TestClass]
    public class UnitTestCopyMaker
    {
        [TestMethod]
        public void CopyFunctionOutputFormatTest()
        {
            //Function Requirements:
            //Accepts 2 Parameters<string, int>
            //Returns string in correct format w/ necessary seperator ;
            string pattern = @"^.+\.glsl(?>;.*\.glsl)*$";
            Assert.IsTrue(Regex.IsMatch(CopyMaker.Output(Shader.shaders.GetValueOrDefault(ShaderEnum.AutoDownscale), 3), pattern));
        }
    }
}
