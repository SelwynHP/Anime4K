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
    public partial class ControlForm : Form
    {
        Control myControl = new Control();

        public void InitializeControls()
        {
            //Initialize Controls
            foreach (KeybindEnum element in Enum.GetValues(typeof(KeybindEnum)))
            {
                comboBoxBinding1.Items.Add(element);
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
            textBoxBinding3.Text = "1";
            comboBoxCommand.Text = "Default";
            comboBoxShader.SelectedIndex = 0;
            if(comboBoxCommand.Text == "Default") { myControl.command.command_name = "no-osd change-list glsl-shaders set"; }
        }
        public void SetPreview()
        {
            textBoxPreview.Text = myControl.Output();
        }
        public void SetControls()
        {
            textBoxBindings.Text = "";
            textBoxComment.Text = "";
            listBoxShaders.Items.Clear();

            comboBoxBinding1.SelectedItem = myControl.keybind.FirstKey;
            textBoxBindings.Text = myControl.keybind.Output();
            textBoxComment.Text = myControl.Comment;
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
        public ControlForm()
        {
            InitializeComponent();
            InitializeControls();
        }

        private void buttonSetBinding_Click(object sender, EventArgs e)
        {
            Keybind kb = new Keybind();
            try
            {
                kb.FirstKey = (KeybindEnum)Enum.Parse(typeof(KeybindEnum),comboBoxBinding1.SelectedItem.ToString());
                kb.SecondKey = textBoxBinding3.Text;
            }
            catch(NullReferenceException nre)
            {
                MessageBox.Show("Missing Argument Detected. Please try again with the appropriate arguments.\n" + nre.Message, "Error");
            }
            catch(Exception ex)
            {
                MessageBox.Show("An error has occured while capturing binding. Please try again.\n" + ex.Message, "Error");
            }
            if(kb != new Keybind())
            {
                myControl.keybind = kb;
            }
            SetPreview();
            SetControls();
        }

        private void buttonUnsetBinding_Click(object sender, EventArgs e)
        {
            myControl.keybind.FirstKey = KeybindEnum.EMPTY;
            myControl.keybind.SecondKey = "";
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

        private void buttonSetComment_Click(object sender, EventArgs e)
        {
            myControl.Comment = textBoxComment.Text;
            textBoxComment.ReadOnly = true;
            SetPreview();
            SetControls();
        }

        private void buttonUnsetComment_Click(object sender, EventArgs e)
        {
            myControl.Comment = "";
            textBoxComment.ReadOnly = false;
            SetPreview();
            SetControls();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Warning! This action will delete all of the currently saved profiles!\nAre you sure you would like to proceed", "Warning", MessageBoxButtons.YesNoCancel);
            if(result == DialogResult.Yes)
            {
                ControlManagement.SetControls();
                MessageBox.Show("List of profiles were set to default");
            }
            else if(result == DialogResult.No)
            {
                MessageBox.Show("No changes were made.");
            }

            SetPreview();
            SetControlList();
        }
    }
}
