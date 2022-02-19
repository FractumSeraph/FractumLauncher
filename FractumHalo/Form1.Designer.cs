
namespace FractumHalo
{
    partial class Fractum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fractum));
            this.btnCheckFiles = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tbxInstallPath = new System.Windows.Forms.TextBox();
            this.lblInstallPath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.rtbMismatches = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCheckFiles
            // 
            this.btnCheckFiles.Enabled = false;
            this.btnCheckFiles.Location = new System.Drawing.Point(326, 183);
            this.btnCheckFiles.Name = "btnCheckFiles";
            this.btnCheckFiles.Size = new System.Drawing.Size(111, 23);
            this.btnCheckFiles.TabIndex = 0;
            this.btnCheckFiles.Text = "Check Files";
            this.btnCheckFiles.UseVisualStyleBackColor = true;
            this.btnCheckFiles.Click += new System.EventHandler(this.button1_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.SelectedPath = "C:\\Program Files (x86)\\Steam\\steamapps\\common\\Halo The Master Chief Collection";
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // tbxInstallPath
            // 
            this.tbxInstallPath.Enabled = false;
            this.tbxInstallPath.Location = new System.Drawing.Point(38, 94);
            this.tbxInstallPath.Name = "tbxInstallPath";
            this.tbxInstallPath.Size = new System.Drawing.Size(318, 22);
            this.tbxInstallPath.TabIndex = 1;
            this.tbxInstallPath.TextChanged += new System.EventHandler(this.tbxInstallPath_TextChanged);
            // 
            // lblInstallPath
            // 
            this.lblInstallPath.AutoSize = true;
            this.lblInstallPath.Location = new System.Drawing.Point(35, 74);
            this.lblInstallPath.Name = "lblInstallPath";
            this.lblInstallPath.Size = new System.Drawing.Size(186, 17);
            this.lblInstallPath.TabIndex = 2;
            this.lblInstallPath.Text = "Path where Halo is installed.";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(362, 94);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // rtbMismatches
            // 
            this.rtbMismatches.Enabled = false;
            this.rtbMismatches.Location = new System.Drawing.Point(38, 234);
            this.rtbMismatches.Name = "rtbMismatches";
            this.rtbMismatches.Size = new System.Drawing.Size(399, 204);
            this.rtbMismatches.TabIndex = 4;
            this.rtbMismatches.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hashes that do not match.";
            // 
            // Fractum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbMismatches);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.lblInstallPath);
            this.Controls.Add(this.tbxInstallPath);
            this.Controls.Add(this.btnCheckFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Fractum";
            this.Text = "Fractum Halo Client";
            this.Load += new System.EventHandler(this.Fractum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheckFiles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox tbxInstallPath;
        private System.Windows.Forms.Label lblInstallPath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.RichTextBox rtbMismatches;
        private System.Windows.Forms.Label label1;
    }
}

