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
using shader_configurator.DAL;

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
        public void SetControlList()
        {
            foreach(Control element in shader_configurator.DAL.ControlManagement.GetControls())
            {
                listBoxControls.Items.Add(element.Output());
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
                textBoxBindings.Text = kb.Output();
            }
        }

        private void buttonUnsetBinding_Click(object sender, EventArgs e)
        {
            textBoxBindings.Text = "";
        }

        private void buttonSetShader_Click(object sender, EventArgs e)
        {
            listBoxShaders.Items.Add(comboBoxShader.SelectedItem);

            Command cmd = new Command();
            foreach (ShaderEnum element in listBoxShaders.Items)
            {
                cmd.values.Add(element);
            }

            myControl.command = cmd;
            SetPreview();
        }

        private void buttonUnsetShader_Click(object sender, EventArgs e)
        {
            int index = listBoxShaders.SelectedIndex;
            if(index > -1)
            {
                listBoxShaders.Items.RemoveAt(index);
            }

            Command cmd = new Command();
            foreach (ShaderEnum element in listBoxShaders.Items)
            {
                cmd.values.Add(element);
            }

            myControl.command = cmd;
            SetPreview();
        }

        private void textBoxBindings_TextChanged(object sender, EventArgs e)
        {
            Keybind kb = new Keybind(textBoxBindings.Text);
            myControl.keybind = kb;
            SetPreview();
        }

        private void listBoxShaders_ControlAdded(object sender, ControlEventArgs e)
        {
        }
    }
}
