using shader_configurator.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shader_configurator.GUI
{
    public partial class ControlManagement : Form
    {
        Control myControl = new Control();

        public void InitializeControls()
        {
            //Initialize Controls
            foreach (KeybindEnum element in Enum.GetValues(typeof(KeybindEnum)))
            {
                comboBoxBinding1.Items.Add(element);
                comboBoxBinding2.Items.Add(element);
            }
            //-----
            comboBoxCommand.Enabled = false;
            //-----
            foreach (ShaderEnum element in Enum.GetValues(typeof(ShaderEnum)))
            {
                comboBoxShader.Items.Add(element);
            }
            //-----
            textBoxBindings.ReadOnly = true;
            textBoxPreview.ReadOnly = true;
            buttonUpdateProfile.Enabled = false;
            buttonDeleteProfile.Enabled = false;
            SetControlList();
            //Set Default Values
            comboBoxBinding1.SelectedIndex = 1;
            comboBoxBinding2.SelectedIndex = 2;
            textBoxBinding3.Text = "1";
            comboBoxCommand.Text = "Default";
            comboBoxShader.SelectedIndex = 0;
        }
        public void SetPreview()
        {
            textBoxPreview.Text = myControl.Output();
        }
        public void SetControls()
        {
            textBoxBindings.Text = "";
            listBoxShaders.Items.Clear();

            textBoxBindings.Text = myControl.keybind.Output();
            foreach(ShaderEnum element in myControl.command.values)
            {
                listBoxShaders.Items.Add(element);
            }
        }
        public void SetControlList()
        {
            listBoxControls.Items.Clear();
            foreach(Control element in shader_configurator.DAL.ControlManagement.GetControls())
            {
                listBoxControls.Items.Add(element);
            }
        }
        public ControlManagement()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void buttonSetBinding_Click(object sender, EventArgs e)
        {
            Keybind kb = new Keybind();
            try
            {
                kb.Keys[0] = comboBoxBinding1.SelectedItem.ToString();
                kb.Keys[1] = comboBoxBinding2.SelectedItem.ToString();
                kb.Keys[2] = textBoxBinding3.Text;
                foreach(string key in kb.Keys)
                {
                    if (String.IsNullOrEmpty(key))
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                }
            }
            catch(NullReferenceException nre)
            {
                MessageBox.Show("Missing Argument Detected. Please try again with the appropriate arguments.\n" + nre.Message, "Error");
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has occured while capturing binding. Please try again.\n" + ex.Message, "Error");
            }
            if(kb.Keys != new Keybind().Keys)
            {
                myControl.keybind = kb;
            }
            SetPreview();
            SetControls();
        }

        private void buttonUnsetBinding_Click(object sender, EventArgs e)
        {
            myControl.keybind.Keys = new string[] { "", "", "" };
            SetPreview();
            SetControls();
        }

        private void buttonSetShader_Click(object sender, EventArgs e)
        {
            myControl.command.values.Add((ShaderEnum)comboBoxShader.SelectedItem);
            SetPreview();
            SetControls();
        }

        private void buttonUnsetShader_Click(object sender, EventArgs e)
        {
            if(listBoxShaders.SelectedItem != null)
            {
                myControl.command.values.Remove((ShaderEnum)listBoxShaders.SelectedItem);
            }
            SetPreview();
            SetControls();
        }

        private void textBoxBindings_TextChanged(object sender, EventArgs e)
        {
        }

        private void listBoxShaders_ControlAdded(object sender, ControlEventArgs e)
        {
        }

        private void buttonClearShader_Click(object sender, EventArgs e)
        {
            myControl.command.values.Clear();
            SetPreview();
            SetControls();
        }

        private void buttonAddProfile_Click(object sender, EventArgs e)
        {
            if(myControl != null)
            {
                shader_configurator.DAL.ControlManagement.SetControl(myControl);
            }
            SetControlList();
        }

        private void buttonUpdateProfile_Click(object sender, EventArgs e)
        {
            Control oldControl = (Control)listBoxControls.SelectedItem;
            if(oldControl != null)
            {
                shader_configurator.DAL.ControlManagement.UpdateControl(oldControl, myControl);
                buttonUpdateProfile.Enabled = false;
                buttonDeleteProfile.Enabled = false;
            }
            SetControlList();
        }

        private void listBoxControls_SelectedIndexChanged(object sender, EventArgs e)
        {
            Control selectedControl = (Control)listBoxControls.SelectedItem;
            if(selectedControl != null)
            {
                myControl = new Control(selectedControl.Output());
                buttonUpdateProfile.Enabled = true;
                buttonDeleteProfile.Enabled = true;
            }
            else
            {
                buttonUpdateProfile.Enabled = false;
                buttonDeleteProfile.Enabled = false;
            }
            SetPreview();
            SetControls();

        }

        private void buttonDeleteProfile_Click(object sender, EventArgs e)
        {
            Control selectedControl = (Control)listBoxControls.SelectedItem;
            if (selectedControl != null)
            {
                shader_configurator.DAL.ControlManagement.DeleteControl(selectedControl);
                buttonUpdateProfile.Enabled = false;
                buttonDeleteProfile.Enabled = false;
            }
            SetControlList();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxShaderRootDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }
    }
}
