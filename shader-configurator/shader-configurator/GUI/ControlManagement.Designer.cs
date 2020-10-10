namespace shader_configurator.GUI
{
    partial class ControlManagement
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
            this.buttonUnsetComment = new System.Windows.Forms.Button();
            this.buttonSetComment = new System.Windows.Forms.Button();
            this.textBoxComment = new System.Windows.Forms.TextBox();
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
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(703, 368);
            this.tabControl1.TabIndex = 0;
            // 
            // TabPage1
            // 
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
            this.TabPage1.Location = new System.Drawing.Point(4, 22);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.TabPage1.Size = new System.Drawing.Size(695, 342);
            this.TabPage1.TabIndex = 0;
            this.TabPage1.Text = "Main";
            this.TabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteProfile
            // 
            this.buttonDeleteProfile.Location = new System.Drawing.Point(287, 85);
            this.buttonDeleteProfile.Name = "buttonDeleteProfile";
            this.buttonDeleteProfile.Size = new System.Drawing.Size(112, 23);
            this.buttonDeleteProfile.TabIndex = 21;
            this.buttonDeleteProfile.Text = "Delete Profile";
            this.buttonDeleteProfile.UseVisualStyleBackColor = true;
            this.buttonDeleteProfile.Click += new System.EventHandler(this.buttonDeleteProfile_Click);
            // 
            // buttonUpdateProfile
            // 
            this.buttonUpdateProfile.Location = new System.Drawing.Point(287, 112);
            this.buttonUpdateProfile.Name = "buttonUpdateProfile";
            this.buttonUpdateProfile.Size = new System.Drawing.Size(112, 23);
            this.buttonUpdateProfile.TabIndex = 20;
            this.buttonUpdateProfile.Text = "Update Profile";
            this.buttonUpdateProfile.UseVisualStyleBackColor = true;
            this.buttonUpdateProfile.Click += new System.EventHandler(this.buttonUpdateProfile_Click);
            // 
            // buttonAddProfile
            // 
            this.buttonAddProfile.Location = new System.Drawing.Point(287, 141);
            this.buttonAddProfile.Name = "buttonAddProfile";
            this.buttonAddProfile.Size = new System.Drawing.Size(112, 23);
            this.buttonAddProfile.TabIndex = 19;
            this.buttonAddProfile.Text = "Add Profile";
            this.buttonAddProfile.UseVisualStyleBackColor = true;
            this.buttonAddProfile.Click += new System.EventHandler(this.buttonAddProfile_Click);
            // 
            // buttonClearShader
            // 
            this.buttonClearShader.Location = new System.Drawing.Point(565, 58);
            this.buttonClearShader.Name = "buttonClearShader";
            this.buttonClearShader.Size = new System.Drawing.Size(73, 23);
            this.buttonClearShader.TabIndex = 18;
            this.buttonClearShader.Text = "Clear";
            this.buttonClearShader.UseVisualStyleBackColor = true;
            this.buttonClearShader.Click += new System.EventHandler(this.buttonClearShader_Click);
            // 
            // listBoxShaders
            // 
            this.listBoxShaders.FormattingEnabled = true;
            this.listBoxShaders.Location = new System.Drawing.Point(405, 82);
            this.listBoxShaders.Name = "listBoxShaders";
            this.listBoxShaders.Size = new System.Drawing.Size(233, 82);
            this.listBoxShaders.TabIndex = 17;
            this.listBoxShaders.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.listBoxShaders_ControlAdded);
            // 
            // textBoxBinding3
            // 
            this.textBoxBinding3.Location = new System.Drawing.Point(210, 32);
            this.textBoxBinding3.Name = "textBoxBinding3";
            this.textBoxBinding3.Size = new System.Drawing.Size(71, 20);
            this.textBoxBinding3.TabIndex = 16;
            // 
            // buttonUnsetShader
            // 
            this.buttonUnsetShader.Location = new System.Drawing.Point(479, 58);
            this.buttonUnsetShader.Name = "buttonUnsetShader";
            this.buttonUnsetShader.Size = new System.Drawing.Size(80, 23);
            this.buttonUnsetShader.TabIndex = 15;
            this.buttonUnsetShader.Text = "Unset Shader";
            this.buttonUnsetShader.UseVisualStyleBackColor = true;
            this.buttonUnsetShader.Click += new System.EventHandler(this.buttonUnsetShader_Click);
            // 
            // buttonSetShader
            // 
            this.buttonSetShader.Location = new System.Drawing.Point(405, 58);
            this.buttonSetShader.Name = "buttonSetShader";
            this.buttonSetShader.Size = new System.Drawing.Size(68, 23);
            this.buttonSetShader.TabIndex = 14;
            this.buttonSetShader.Text = "Set Shader";
            this.buttonSetShader.UseVisualStyleBackColor = true;
            this.buttonSetShader.Click += new System.EventHandler(this.buttonSetShader_Click);
            // 
            // buttonUnsetBinding
            // 
            this.buttonUnsetBinding.Location = new System.Drawing.Point(174, 58);
            this.buttonUnsetBinding.Name = "buttonUnsetBinding";
            this.buttonUnsetBinding.Size = new System.Drawing.Size(107, 23);
            this.buttonUnsetBinding.TabIndex = 13;
            this.buttonUnsetBinding.Text = "Unset Binding";
            this.buttonUnsetBinding.UseVisualStyleBackColor = true;
            this.buttonUnsetBinding.Click += new System.EventHandler(this.buttonUnsetBinding_Click);
            // 
            // textBoxPreview
            // 
            this.textBoxPreview.Location = new System.Drawing.Point(56, 170);
            this.textBoxPreview.Name = "textBoxPreview";
            this.textBoxPreview.Size = new System.Drawing.Size(582, 20);
            this.textBoxPreview.TabIndex = 12;
            // 
            // comboBoxShader
            // 
            this.comboBoxShader.FormattingEnabled = true;
            this.comboBoxShader.Location = new System.Drawing.Point(405, 31);
            this.comboBoxShader.Name = "comboBoxShader";
            this.comboBoxShader.Size = new System.Drawing.Size(233, 21);
            this.comboBoxShader.TabIndex = 9;
            // 
            // buttonSetBinding
            // 
            this.buttonSetBinding.Location = new System.Drawing.Point(56, 58);
            this.buttonSetBinding.Name = "buttonSetBinding";
            this.buttonSetBinding.Size = new System.Drawing.Size(107, 23);
            this.buttonSetBinding.TabIndex = 8;
            this.buttonSetBinding.Text = "Set Binding";
            this.buttonSetBinding.UseVisualStyleBackColor = true;
            this.buttonSetBinding.Click += new System.EventHandler(this.buttonSetBinding_Click);
            // 
            // textBoxBindings
            // 
            this.textBoxBindings.Location = new System.Drawing.Point(56, 87);
            this.textBoxBindings.Multiline = true;
            this.textBoxBindings.Name = "textBoxBindings";
            this.textBoxBindings.Size = new System.Drawing.Size(225, 21);
            this.textBoxBindings.TabIndex = 7;
            this.textBoxBindings.TextChanged += new System.EventHandler(this.textBoxBindings_TextChanged);
            // 
            // comboBoxCommand
            // 
            this.comboBoxCommand.FormattingEnabled = true;
            this.comboBoxCommand.Location = new System.Drawing.Point(287, 31);
            this.comboBoxCommand.Name = "comboBoxCommand";
            this.comboBoxCommand.Size = new System.Drawing.Size(112, 21);
            this.comboBoxCommand.TabIndex = 6;
            // 
            // listBoxControls
            // 
            this.listBoxControls.FormattingEnabled = true;
            this.listBoxControls.Location = new System.Drawing.Point(56, 195);
            this.listBoxControls.Name = "listBoxControls";
            this.listBoxControls.Size = new System.Drawing.Size(582, 121);
            this.listBoxControls.TabIndex = 3;
            this.listBoxControls.SelectedIndexChanged += new System.EventHandler(this.listBoxControls_SelectedIndexChanged);
            // 
            // comboBoxBinding1
            // 
            this.comboBoxBinding1.FormattingEnabled = true;
            this.comboBoxBinding1.Location = new System.Drawing.Point(56, 32);
            this.comboBoxBinding1.Name = "comboBoxBinding1";
            this.comboBoxBinding1.Size = new System.Drawing.Size(148, 21);
            this.comboBoxBinding1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonBrowse);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.buttonApply);
            this.tabPage2.Controls.Add(this.textBoxShaderRootDirectory);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(695, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Location = new System.Drawing.Point(500, 40);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(75, 20);
            this.buttonBrowse.TabIndex = 3;
            this.buttonBrowse.Text = "Browse";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shader Root Directory";
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(419, 271);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(75, 23);
            this.buttonApply.TabIndex = 1;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            // 
            // textBoxShaderRootDirectory
            // 
            this.textBoxShaderRootDirectory.Location = new System.Drawing.Point(97, 40);
            this.textBoxShaderRootDirectory.Name = "textBoxShaderRootDirectory";
            this.textBoxShaderRootDirectory.Size = new System.Drawing.Size(397, 20);
            this.textBoxShaderRootDirectory.TabIndex = 0;
            // 
            // buttonUnsetComment
            // 
            this.buttonUnsetComment.Location = new System.Drawing.Point(174, 141);
            this.buttonUnsetComment.Name = "buttonUnsetComment";
            this.buttonUnsetComment.Size = new System.Drawing.Size(107, 23);
            this.buttonUnsetComment.TabIndex = 23;
            this.buttonUnsetComment.Text = "Unset Comment";
            this.buttonUnsetComment.UseVisualStyleBackColor = true;
            this.buttonUnsetComment.Click += new System.EventHandler(this.buttonUnsetComment_Click);
            // 
            // buttonSetComment
            // 
            this.buttonSetComment.Location = new System.Drawing.Point(56, 141);
            this.buttonSetComment.Name = "buttonSetComment";
            this.buttonSetComment.Size = new System.Drawing.Size(107, 23);
            this.buttonSetComment.TabIndex = 22;
            this.buttonSetComment.Text = "Set Comment";
            this.buttonSetComment.UseVisualStyleBackColor = true;
            this.buttonSetComment.Click += new System.EventHandler(this.buttonSetComment_Click);
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(56, 114);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(225, 21);
            this.textBoxComment.TabIndex = 24;
            // 
            // ControlManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 367);
            this.Controls.Add(this.tabControl1);
            this.Name = "ControlManagement";
            this.Text = "ControlManagement";
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
    }
}