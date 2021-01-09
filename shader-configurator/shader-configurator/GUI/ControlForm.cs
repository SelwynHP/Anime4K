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
using System.IO;

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
            comboBoxCopies.SelectedIndex = 0;
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
        public DialogResult GetTaskConfirmation(String str)
        {
            return MessageBox.Show("Are you sure you want to perform the following action?\n\t" + str, "Action Confirmation!",MessageBoxButtons.YesNo);
        }
        public ControlForm()
        {
            InitializeComponent();
            InitializeControls();
        }
        //########################## Main Tab ##########################
        private void buttonSetBinding_Click(object sender, EventArgs e)
        {
            Keybind kb = new Keybind();
            try
            {
                kb.FirstKey = (KeybindEnum)Enum.Parse(typeof(KeybindEnum), comboBoxBinding1.SelectedItem.ToString());
                kb.SecondKey = textBoxBinding3.Text;
            }
            catch (NullReferenceException nre)
            {
                MessageBox.Show("Missing Argument Detected. Please try again with the appropriate arguments.\n" + nre.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occured while capturing binding. Please try again.\n" + ex.Message, "Error");
            }
            if (kb != new Keybind())
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
            if (result == DialogResult.Yes)
            {
                ControlManagement.SetControls();
                MessageBox.Show("List of profiles were set to default");
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("No changes were made.");
            }

            SetPreview();
            SetControlList();
        }
        private void buttonDeleteProfile_Click(object sender, EventArgs e)
        {
            if(GetTaskConfirmation("Delete Control") == DialogResult.Yes)
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
        }
        private void buttonUpdateProfile_Click(object sender, EventArgs e)
        {
            if(GetTaskConfirmation("Update Control") == DialogResult.Yes)
            {
                Control oldControl = (Control)listBoxControls.SelectedItem;
                if (oldControl != null)
                {
                    shader_configurator.DAL.ControlManagement.UpdateControl(oldControl, myControl);
                    buttonUpdateProfile.Enabled = false;
                    buttonDeleteProfile.Enabled = false;
                }
                SetControlList();
            }
        }
        private void buttonAddProfile_Click(object sender, EventArgs e)
        {
            if(GetTaskConfirmation("Add Control") == DialogResult.Yes)
            {
                if (myControl != null)
                {
                    shader_configurator.DAL.ControlManagement.SetControl(myControl);
                }
                SetControlList();
            }
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
        private void buttonClearShader_Click(object sender, EventArgs e)
        {
            myControl.command.values.Clear();
            SetPreview();
            SetControls();
        }
        private void listBoxControls_SelectedIndexChanged(object sender, EventArgs e)
        {
            Control selectedControl = (Control)listBoxControls.SelectedItem;
            if (selectedControl != null)
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
        //########################## Settings Tab ##########################
        private void tabControlMain_Selected(object sender, TabControlEventArgs e)
        {
            textBoxShaderRootDirectory.Text = Properties.Settings.Default.ShaderRootDirectory;
            textBoxShaderCopyRootDirectory.Text = Properties.Settings.Default.ShaderCopyRootDirectory;
            comboBoxCopies.SelectedIndex = Properties.Settings.Default.NumberOfCopies;
        }
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxShaderRootDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void buttonBrowse2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBoxShaderCopyRootDirectory.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        private void buttonApply_Click(object sender, EventArgs e)
        {
            //Setting ShaderRootDirectory
            Properties.Settings.Default.ShaderRootDirectory = textBoxShaderRootDirectory.Text;
            //Setting ShaderCopyRootDirectory
            Properties.Settings.Default.ShaderCopyRootDirectory = textBoxShaderCopyRootDirectory.Text;
            //Setting NumberOfCopies
            Properties.Settings.Default.NumberOfCopies = Convert.ToInt32(comboBoxCopies.SelectedItem.ToString());
            //Saving changes to User Settings
            Properties.Settings.Default.Save();
            //Display confirmation
            MessageBox.Show("Settings Saved!", "Confirmation");
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            int copies = Convert.ToInt32(comboBoxCopies.SelectedItem);
            //Check if Copy Directory exists
            if (Directory.Exists(Shader.GetShaderCopyRootDirectory()))
            {
                DialogResult result = MessageBox.Show("All files in the following directory will be deleted:\n\t" + Shader.GetShaderCopyRootDirectory()
                     + "\n Do you wish to continue?", "Overwrite confirmation!", MessageBoxButtons.YesNoCancel);
                if(result == DialogResult.Yes)
                {
                    //Clear all the files of the directory
                    String[] filePaths = Directory.GetFiles(Shader.GetShaderCopyRootDirectory());
                    foreach (string file in filePaths)
                    {
                        File.Delete(file);
                    }
                    //Each File gets a new filename and is copied to the destination path
                    foreach (var shader in Shader.shaders)
                    {
                        for (int i = 1; i <= copies; i++)
                        {
                            String sourceFile = Path.Combine(Shader.GetShaderRootDirectory(), shader.Value);
                            //CopyMaker.Output add the number(i) to the filename and returns the string
                            String destFile = Path.Combine(Shader.GetShaderCopyRootDirectory(), CopyMaker.Output(shader.Value, i));
                            if (!File.Exists(destFile))
                            {
                                try
                                {
                                    File.Copy(sourceFile, destFile);
                                }
                                catch (IOException ex) { break; }
                            }
                        }
                    }
                    MessageBox.Show("Copy Completed");
                }//end second if
                else
                {
                    MessageBox.Show("Copy was aborted");
                }
            }//end first if
            else
            {
                //Missing Directory is created
                Directory.CreateDirectory(Shader.GetShaderCopyRootDirectory());
                MessageBox.Show("Directory " + Shader.GetShaderCopyRootDirectory() + " created!");
            }
        }
    }
}
