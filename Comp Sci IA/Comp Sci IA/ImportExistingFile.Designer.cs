
namespace Comp_Sci_IA
{
    partial class ImportExistingFile
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblImportFile = new System.Windows.Forms.Label();
            this.lblAcceptableTypes = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.lblFile = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Location = new System.Drawing.Point(638, 367);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 48);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblImportFile
            // 
            this.lblImportFile.AutoSize = true;
            this.lblImportFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblImportFile.Location = new System.Drawing.Point(334, 24);
            this.lblImportFile.Name = "lblImportFile";
            this.lblImportFile.Size = new System.Drawing.Size(128, 29);
            this.lblImportFile.TabIndex = 4;
            this.lblImportFile.Text = "Import File";
            // 
            // lblAcceptableTypes
            // 
            this.lblAcceptableTypes.AutoSize = true;
            this.lblAcceptableTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAcceptableTypes.Location = new System.Drawing.Point(281, 87);
            this.lblAcceptableTypes.Name = "lblAcceptableTypes";
            this.lblAcceptableTypes.Size = new System.Drawing.Size(243, 20);
            this.lblAcceptableTypes.TabIndex = 8;
            this.lblAcceptableTypes.Text = "Acceptable File Types: pdf, txt, rtf";
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(38, 367);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(124, 48);
            this.btnImport.TabIndex = 9;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFile.Location = new System.Drawing.Point(166, 195);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(38, 20);
            this.lblFile.TabIndex = 10;
            this.lblFile.Text = "File:";
            // 
            // txtFileName
            // 
            this.txtFileName.Enabled = false;
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFileName.Location = new System.Drawing.Point(210, 192);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(392, 26);
            this.txtFileName.TabIndex = 11;
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(608, 195);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(25, 23);
            this.btnOpenFileDialog.TabIndex = 12;
            this.btnOpenFileDialog.Text = "...";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // ImportExistingFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblFile);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.lblAcceptableTypes);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblImportFile);
            this.Name = "ImportExistingFile";
            this.Text = "Import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblImportFile;
        private System.Windows.Forms.Label lblAcceptableTypes;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnOpenFileDialog;
    }
}