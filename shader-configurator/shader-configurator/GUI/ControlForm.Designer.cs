namespace shader_configurator.GUI
{
    partial class ControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabPage1 = new System.Windows.Forms.TabPage();
            this.labelPreview = new System.Windows.Forms.Label();
            this.labelShaders = new System.Windows.Forms.Label();
            this.labelCommand = new System.Windows.Forms.Label();
            this.labelBindings = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonUnsetComment = new System.Windows.Forms.Button();
            this.buttonSetComment = new System.Windows.Forms.Button();
            this.buttonDeleteProfile = new System.Windows.Forms.Button();
            this.buttonUpdateProfile = new System.Windows.Forms.Button();
            this.buttonAddProfile = new System.Windows.Forms.Button();
            this.buttonClearShader = new System.Windows.Forms.Button();
            this.listBoxShaders = new System.Windows.Forms.ListBox();
            this.textBoxBinding3 = new System.Windows.Forms.TextBox();
            this.buttonUnsetShader = new System.Windows.Forms.Button();
            this.buttonSetShader = new System.Windows.Forms.Button();
            this.buttonUnsetBinding = new System.Windows.Forms.Button();
            this.textBoxPreview = new System.Windows.Forms.TextBox();
            this.comboBoxShader = new System.Windows.Forms.ComboBox();
            this.buttonSetBinding = new System.Windows.Forms.Button();
            this.textBoxBindings = new System.Windows.Forms.TextBox();
            this.comboBoxCommand = new System.Windows.Forms.ComboBox();
            this.listBoxControls = new System.Windows.Forms.ListBox();
            this.comboBoxBinding1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.textBoxShaderRootDirectory = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonReset = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1875, 940);
            this.tabControl1.TabIndex = 0;
            // 
            // TabPage1
            // 
            this.TabPage1.Controls.Add(this.buttonReset);
            this.TabPage1.Controls.Add(this.labelPreview);
            this.TabPage1.Controls.Add(this.labelShaders);
            this.TabPage1.Controls.Add(this.labelCommand);
            this.TabPage1.Controls.Add(this.labelBindings);
            this.TabPage1.Controls.Add(this.textBoxComment);
            this.TabPage1.Controls.Add(this.buttonUnsetComment);
            this.TabPage1.Controls.Add(this.buttonSetComment);
            this.TabPage1.Controls.Add(this.buttonDeleteProfile);
            this.TabPage1.Controls.Add(this.buttonUpdateProfile);
            this.TabPage1.Controls.Add(this.buttonAddProfile);
            this.TabPage1.Controls.Add(this.buttonClearShader);
            this.TabPage1.Controls.Add(this.listBoxShaders);
            this.TabPage1.Controls.Add(this.textBoxBinding3);
            this.TabPage1.Controls.Add(this.buttonUnsetShader);
            this.TabPage1.Controls.Add(this.buttonSetShader);
            this.TabPage1.Controls.Add(this.buttonUnsetBinding);
            this.TabPage1.Controls.Add(this.textBoxPreview);
            this.TabPage1.Controls.Add(this.comboBoxShader);
            this.TabPage1.Controls.Add(this.buttonSetBinding);
            this.TabPage1.Controls.Add(this.textBoxBindings);
            this.TabPage1.Controls.Add(this.comboBoxCommand);
            this.TabPage1.Controls.Add(this.listBoxControls);
            this.TabPage1.Controls.Add(this.comboBoxBinding1);
            this.TabPage1.Location = new System.Drawing.Point(4, 40);
            this.TabPage1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.TabPage1.Size = new System.Drawing.Size(1867, 896);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Main";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // labelPreview
            // 
            this.labelPreview.AutoSize = true;
            this.labelPreview.Location = new System.Drawing.Point(141, 448);
            this.labelPreview.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.labelPreview.Name = "labelPreview";
            this.labelPreview.Size = new System.Drawing.Size(129, 31);
            this.labelPreview.TabIndex = 27;
            this.labelPreview.Text = "(Preview)";
            // 
            // labelShaders
            // 
            this.labelShaders.AutoSize = true;
            this.labelShaders.Location = new System.Drawing.Point(1075, 38);
            this.labelShaders.Name = "labelShaders";
            this.labelShaders.Size = new System.Drawing.Size(133, 31);
            this.labelShaders.TabIndex = 26;
            this.labelShaders.Text = "(Shaders)";
            // 
            // labelCommand
            // 
            this.labelCommand.AutoSize = true;
            this.labelCommand.Location = new System.Drawing.Point(760, 38);
            this.labelCommand.Name = "labelCommand";
            this.labelCommand.Size = new System.Drawing.Size(156, 31);
            this.labelCommand.TabIndex = 25;
            this.labelCommand.Text = "(Command)";
            // 
            // labelBindings
            // 
            this.labelBindings.AutoSize = true;
            this.labelBindings.Location = new System.Drawing.Point(144, 38);
            this.labelBindings.Name = "labelBindings";
            this.labelBindings.Size = new System.Drawing.Size(136, 31);
            this.labelBindings.TabIndex = 1;
            this.labelBindings.Text = "(Bindings)";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(149, 274);
            this.textBoxComment.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(593, 45);
            this.textBoxComment.TabIndex = 24;
            // 
            // buttonUnsetComment
            // 
            this.buttonUnsetComment.Location = new System.Drawing.Point(464, 339);
            this.buttonUnsetComment.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonUnsetComment.Name = "buttonUnsetComment";
            this.buttonUnsetComment.Size = new System.Drawing.Size(285, 55);
            this.buttonUnsetComment.TabIndex = 23;
            this.buttonUnsetComment.Text = "Unset Comment";
            this.buttonUnsetComment.UseVisualStyleBackColor = true;
            this.buttonUnsetComment.Click += new System.EventHandler(this.buttonUnsetComment_Click);
            // 
            // buttonSetComment
            // 
            this.buttonSetComment.Location = new System.Drawing.Point(149, 339);
            this.buttonSetComment.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonSetComment.Name = "buttonSetComment";
            this.buttonSetComment.Size = new System.Drawing.Size(285, 55);
            this.buttonSetComment.TabIndex = 22;
            this.buttonSetComment.Text = "Set Comment";
            this.buttonSetComment.UseVisualStyleBackColor = true;
            this.buttonSetComment.Click += new System.EventHandler(this.buttonSetComment_Click);
            // 
            // buttonDeleteProfile
            // 
            this.buttonDeleteProfile.Location = new System.Drawing.Point(765, 205);
            this.buttonDeleteProfile.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonDeleteProfile.Name = "buttonDeleteProfile";
            this.buttonDeleteProfile.Size = new System.Drawing.Size(299, 55);
            this.buttonDeleteProfile.TabIndex = 21;
            this.buttonDeleteProfile.Text = "Delete Profile";
            this.buttonDeleteProfile.UseVisualStyleBackColor = true;
            this.buttonDeleteProfile.Click += new System.EventHandler(this.buttonDeleteProfile_Click);
            // 
            // buttonUpdateProfile
            // 
            this.buttonUpdateProfile.Location = new System.Drawing.Point(765, 269);
            this.buttonUpdateProfile.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonUpdateProfile.Name = "buttonUpdateProfile";
            this.buttonUpdateProfile.Size = new System.Drawing.Size(299, 55);
            this.buttonUpdateProfile.TabIndex = 20;
            this.buttonUpdateProfile.Text = "Update Profile";
            this.buttonUpdateProfile.UseVisualStyleBackColor = true;
            this.buttonUpdateProfile.Click += new System.EventHandler(this.buttonUpdateProfile_Click);
            // 
            // buttonAddProfile
            // 
            this.buttonAddProfile.Location = new System.Drawing.Point(765, 339);
            this.buttonAddProfile.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonAddProfile.Name = "buttonAddProfile";
            this.buttonAddProfile.Size = new System.Drawing.Size(299, 55);
            this.buttonAddProfile.TabIndex = 19;
            this.buttonAddProfile.Text = "Add Profile";
            this.buttonAddProfile.UseVisualStyleBackColor = true;
            this.buttonAddProfile.Click += new System.EventHandler(this.buttonAddProfile_Click);
            // 
            // buttonClearShader
            // 
            this.buttonClearShader.Location = new System.Drawing.Point(1507, 138);
            this.buttonClearShader.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonClearShader.Name = "buttonClearShader";
            this.buttonClearShader.Size = new System.Drawing.Size(195, 55);
            this.buttonClearShader.TabIndex = 18;
            this.buttonClearShader.Text = "Clear";
            this.buttonClearShader.UseVisualStyleBackColor = true;
            this.buttonClearShader.Click += new System.EventHandler(this.buttonClearShader_Click);
            // 
            // listBoxShaders
            // 
            this.listBoxShaders.FormattingEnabled = true;
            this.listBoxShaders.ItemHeight = 31;
            this.listBoxShaders.Location = new System.Drawing.Point(1080, 198);
            this.listBoxShaders.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listBoxShaders.Name = "listBoxShaders";
            this.listBoxShaders.Size = new System.Drawing.Size(615, 190);
            this.listBoxShaders.TabIndex = 17;
            this.listBoxShaders.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.listBoxShaders_ControlAdded);
            // 
            // textBoxBinding3
            // 
            this.textBoxBinding3.Location = new System.Drawing.Point(560, 76);
            this.textBoxBinding3.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxBinding3.Name = "textBoxBinding3";
            this.textBoxBinding3.Size = new System.Drawing.Size(183, 38);
            this.textBoxBinding3.TabIndex = 16;
            // 
            // buttonUnsetShader
            // 
            this.buttonUnsetShader.Location = new System.Drawing.Point(1277, 138);
            this.buttonUnsetShader.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonUnsetShader.Name = "buttonUnsetShader";
            this.buttonUnsetShader.Size = new System.Drawing.Size(213, 55);
            this.buttonUnsetShader.TabIndex = 15;
            this.buttonUnsetShader.Text = "Unset Shader";
            this.buttonUnsetShader.UseVisualStyleBackColor = true;
            this.buttonUnsetShader.Click += new System.EventHandler(this.buttonUnsetShader_Click);
            // 
            // buttonSetShader
            // 
            this.buttonSetShader.Location = new System.Drawing.Point(1080, 141);
            this.buttonSetShader.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonSetShader.Name = "buttonSetShader";
            this.buttonSetShader.Size = new System.Drawing.Size(181, 55);
            this.buttonSetShader.TabIndex = 14;
            this.buttonSetShader.Text = "Set Shader";
            this.buttonSetShader.UseVisualStyleBackColor = true;
            this.buttonSetShader.Click += new System.EventHandler(this.buttonSetShader_Click);
            // 
            // buttonUnsetBinding
            // 
            this.buttonUnsetBinding.Location = new System.Drawing.Point(464, 138);
            this.buttonUnsetBinding.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonUnsetBinding.Name = "buttonUnsetBinding";
            this.buttonUnsetBinding.Size = new System.Drawing.Size(285, 55);
            this.buttonUnsetBinding.TabIndex = 13;
            this.buttonUnsetBinding.Text = "Unset Binding";
            this.buttonUnsetBinding.UseVisualStyleBackColor = true;
            this.buttonUnsetBinding.Click += new System.EventHandler(this.buttonUnsetBinding_Click);
            // 
            // textBoxPreview
            // 
            this.textBoxPreview.Location = new System.Drawing.Point(147, 486);
            this.textBoxPreview.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxPreview.Name = "textBoxPreview";
            this.textBoxPreview.Size = new System.Drawing.Size(1545, 38);
            this.textBoxPreview.TabIndex = 12;
            // 
            // comboBoxShader
            // 
            this.comboBoxShader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShader.FormattingEnabled = true;
            this.comboBoxShader.Location = new System.Drawing.Point(1080, 74);
            this.comboBoxShader.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxShader.Name = "comboBoxShader";
            this.comboBoxShader.Size = new System.Drawing.Size(615, 39);
            this.comboBoxShader.TabIndex = 9;
            // 
            // buttonSetBinding
            // 
            this.buttonSetBinding.Location = new System.Drawing.Point(149, 141);
            this.buttonSetBinding.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonSetBinding.Name = "buttonSetBinding";
            this.buttonSetBinding.Size = new System.Drawing.Size(285, 55);
            this.buttonSetBinding.TabIndex = 8;
            this.buttonSetBinding.Text = "Set Binding";
            this.buttonSetBinding.UseVisualStyleBackColor = true;
            this.buttonSetBinding.Click += new System.EventHandler(this.buttonSetBinding_Click);
            // 
            // textBoxBindings
            // 
            this.textBoxBindings.Location = new System.Drawing.Point(149, 210);
            this.textBoxBindings.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxBindings.Multiline = true;
            this.textBoxBindings.Name = "textBoxBindings";
            this.textBoxBindings.Size = new System.Drawing.Size(593, 45);
            this.textBoxBindings.TabIndex = 7;
            this.textBoxBindings.TextChanged += new System.EventHandler(this.textBoxBindings_TextChanged);
            // 
            // comboBoxCommand
            // 
            this.comboBoxCommand.FormattingEnabled = true;
            this.comboBoxCommand.Location = new System.Drawing.Point(765, 74);
            this.comboBoxCommand.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxCommand.Name = "comboBoxCommand";
            this.comboBoxCommand.Size = new System.Drawing.Size(292, 39);
            this.comboBoxCommand.TabIndex = 6;
            // 
            // listBoxControls
            // 
            this.listBoxControls.FormattingEnabled = true;
            this.listBoxControls.ItemHeight = 31;
            this.listBoxControls.Location = new System.Drawing.Point(147, 546);
            this.listBoxControls.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.listBoxControls.Name = "listBoxControls";
            this.listBoxControls.Size = new System.Drawing.Size(1545, 283);
            this.listBoxControls.TabIndex = 3;
            this.listBoxControls.SelectedIndexChanged += new System.EventHandler(this.listBoxControls_SelectedIndexChanged);
            // 
            // comboBoxBinding1
            // 
            this.comboBoxBinding1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBinding1.FormattingEnabled = true;
            this.comboBoxBinding1.Location = new System.Drawing.Point(149, 76);
            this.comboBoxBinding1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBoxBinding1.Name = "comboBoxBinding1";
            this.comboBoxBinding1.Size = new System.Drawing.Size(388, 39);
            this.comboBoxBinding1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonBrowse);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.buttonApply);
            this.tabPage2.Controls.Add(this.textBoxShaderRootDirectory);
            this.tabPage2.Location = new System.Drawing.Point(4, 40);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tabPage2.Size = new System.Drawing.Size(1867, 896);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(1333, 95);
            this.buttonBrowse.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(200, 48);
            this.buttonBrowse.TabIndex = 3;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shader Root Directory";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(1117, 646);
            this.buttonApply.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(200, 55);
            this.buttonApply.TabIndex = 1;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // textBoxShaderRootDirectory
            // 
            this.textBoxShaderRootDirectory.Location = new System.Drawing.Point(259, 95);
            this.textBoxShaderRootDirectory.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.textBoxShaderRootDirectory.Name = "textBoxShaderRootDirectory";
            this.textBoxShaderRootDirectory.Size = new System.Drawing.Size(1052, 38);
            this.textBoxShaderRootDirectory.TabIndex = 0;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(765, 141);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(299, 55);
            this.buttonReset.TabIndex = 28;
            this.buttonReset.Text = "Default Profiles";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // ControlForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1867, 930);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ControlForm";
            this.Text = "shader-configurator";
            this.tabControl1.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.TabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonUnsetShader;
        private System.Windows.Forms.Button buttonSetShader;
        private System.Windows.Forms.Button buttonUnsetBinding;
        private System.Windows.Forms.TextBox textBoxPreview;
        private System.Windows.Forms.ComboBox comboBoxShader;
        private System.Windows.Forms.Button buttonSetBinding;
        private System.Windows.Forms.TextBox textBoxBindings;
        private System.Windows.Forms.ComboBox comboBoxCommand;
        private System.Windows.Forms.ListBox listBoxControls;
        private System.Windows.Forms.ComboBox comboBoxBinding1;
        private System.Windows.Forms.TextBox textBoxBinding3;
        private System.Windows.Forms.ListBox listBoxShaders;
        private System.Windows.Forms.Button buttonClearShader;
        private System.Windows.Forms.Button buttonAddProfile;
        private System.Windows.Forms.Button buttonDeleteProfile;
        private System.Windows.Forms.Button buttonUpdateProfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.TextBox textBoxShaderRootDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button buttonUnsetComment;
        private System.Windows.Forms.Button buttonSetComment;
        private System.Windows.Forms.Label labelShaders;
        private System.Windows.Forms.Label labelCommand;
        private System.Windows.Forms.Label labelBindings;
        private System.Windows.Forms.Label labelPreview;
        private System.Windows.Forms.Button buttonReset;
    }
}