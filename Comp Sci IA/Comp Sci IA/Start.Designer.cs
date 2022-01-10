
namespace Comp_Sci_IA
{
    partial class Start
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnCreateNewFile = new System.Windows.Forms.Button();
            this.btnImportExistingFile = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnReturnToEditor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblWelcome.Location = new System.Drawing.Point(78, 56);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(306, 29);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome! Select an option:";
            // 
            // btnCreateNewFile
            // 
            this.btnCreateNewFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCreateNewFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCreateNewFile.Location = new System.Drawing.Point(233, 129);
            this.btnCreateNewFile.Name = "btnCreateNewFile";
            this.btnCreateNewFile.Size = new System.Drawing.Size(336, 48);
            this.btnCreateNewFile.TabIndex = 1;
            this.btnCreateNewFile.Text = "Create New File";
            this.btnCreateNewFile.UseVisualStyleBackColor = false;
            this.btnCreateNewFile.Click += new System.EventHandler(this.btnCreateNewFile_Click);
            // 
            // btnImportExistingFile
            // 
            this.btnImportExistingFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnImportExistingFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnImportExistingFile.Location = new System.Drawing.Point(233, 205);
            this.btnImportExistingFile.Name = "btnImportExistingFile";
            this.btnImportExistingFile.Size = new System.Drawing.Size(336, 48);
            this.btnImportExistingFile.TabIndex = 2;
            this.btnImportExistingFile.Text = "Import Existing File";
            this.btnImportExistingFile.UseVisualStyleBackColor = false;
            this.btnImportExistingFile.Click += new System.EventHandler(this.btnImportExistingFile_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Location = new System.Drawing.Point(648, 376);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(124, 48);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReturnToEditor
            // 
            this.btnReturnToEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnReturnToEditor.Location = new System.Drawing.Point(628, 12);
            this.btnReturnToEditor.Name = "btnReturnToEditor";
            this.btnReturnToEditor.Size = new System.Drawing.Size(144, 34);
            this.btnReturnToEditor.TabIndex = 4;
            this.btnReturnToEditor.Text = "Return to Editor";
            this.btnReturnToEditor.UseVisualStyleBackColor = false;
            this.btnReturnToEditor.Click += new System.EventHandler(this.btnReturnToEditor_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReturnToEditor);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnImportExistingFile);
            this.Controls.Add(this.btnCreateNewFile);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Start";
            this.Text = "Start";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCreateNewFile;
        private System.Windows.Forms.Button btnImportExistingFile;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReturnToEditor;
    }
}

