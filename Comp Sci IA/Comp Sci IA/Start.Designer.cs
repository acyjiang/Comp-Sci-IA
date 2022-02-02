
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
            this.btnCreateNewFile1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReturnToEditor = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnOpenFileDialog1 = new System.Windows.Forms.Button();
            this.txtSaveLocation1 = new System.Windows.Forms.TextBox();
            this.lblSaveLocation1 = new System.Windows.Forms.Label();
            this.btnReset1 = new System.Windows.Forms.Button();
            this.chkSetPreviewDefault1 = new System.Windows.Forms.CheckBox();
            this.txtFileName1 = new System.Windows.Forms.TextBox();
            this.lblFileName1 = new System.Windows.Forms.Label();
            this.rbtnPreviewModeOff1 = new System.Windows.Forms.RadioButton();
            this.rbtnPreviewModeOn1 = new System.Windows.Forms.RadioButton();
            this.lblPreviewMode1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOpen2 = new System.Windows.Forms.Button();
            this.lblRecentFiles2 = new System.Windows.Forms.Label();
            this.lstbxRecentFiles2 = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnImport3 = new System.Windows.Forms.Button();
            this.lblAcceptableTypes3 = new System.Windows.Forms.Label();
            this.btnOpenFileDialog3 = new System.Windows.Forms.Button();
            this.txtFileNameImport3 = new System.Windows.Forms.TextBox();
            this.lblUploadFile3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblWelcome.Location = new System.Drawing.Point(21, 17);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(306, 29);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome! Select an option:";
            // 
            // btnCreateNewFile1
            // 
            this.btnCreateNewFile1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCreateNewFile1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCreateNewFile1.Location = new System.Drawing.Point(404, 256);
            this.btnCreateNewFile1.Name = "btnCreateNewFile1";
            this.btnCreateNewFile1.Size = new System.Drawing.Size(110, 30);
            this.btnCreateNewFile1.TabIndex = 1;
            this.btnCreateNewFile1.Text = "Create";
            this.btnCreateNewFile1.UseVisualStyleBackColor = false;
            this.btnCreateNewFile1.Click += new System.EventHandler(this.btnCreateNewFile1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.Location = new System.Drawing.Point(648, 393);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(124, 48);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReturnToEditor
            // 
            this.btnReturnToEditor.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnToEditor.Location = new System.Drawing.Point(648, 9);
            this.btnReturnToEditor.Name = "btnReturnToEditor";
            this.btnReturnToEditor.Size = new System.Drawing.Size(124, 32);
            this.btnReturnToEditor.TabIndex = 4;
            this.btnReturnToEditor.Text = "Return to Editor";
            this.btnReturnToEditor.UseVisualStyleBackColor = false;
            this.btnReturnToEditor.Visible = false;
            this.btnReturnToEditor.Click += new System.EventHandler(this.btnReturnToEditor_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(40, 200);
            this.tabControl1.Location = new System.Drawing.Point(26, 52);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(746, 322);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 8;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.btnOpenFileDialog1);
            this.tabPage1.Controls.Add(this.txtSaveLocation1);
            this.tabPage1.Controls.Add(this.lblSaveLocation1);
            this.tabPage1.Controls.Add(this.btnReset1);
            this.tabPage1.Controls.Add(this.chkSetPreviewDefault1);
            this.tabPage1.Controls.Add(this.txtFileName1);
            this.tabPage1.Controls.Add(this.lblFileName1);
            this.tabPage1.Controls.Add(this.rbtnPreviewModeOff1);
            this.tabPage1.Controls.Add(this.rbtnPreviewModeOn1);
            this.tabPage1.Controls.Add(this.lblPreviewMode1);
            this.tabPage1.Controls.Add(this.btnCreateNewFile1);
            this.tabPage1.Location = new System.Drawing.Point(204, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(538, 314);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnOpenFileDialog1
            // 
            this.btnOpenFileDialog1.Location = new System.Drawing.Point(507, 83);
            this.btnOpenFileDialog1.Name = "btnOpenFileDialog1";
            this.btnOpenFileDialog1.Size = new System.Drawing.Size(25, 23);
            this.btnOpenFileDialog1.TabIndex = 13;
            this.btnOpenFileDialog1.Text = "...";
            this.btnOpenFileDialog1.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog1.Click += new System.EventHandler(this.btnOpenFileDialog1_Click);
            // 
            // txtSaveLocation1
            // 
            this.txtSaveLocation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSaveLocation1.Location = new System.Drawing.Point(217, 81);
            this.txtSaveLocation1.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaveLocation1.Name = "txtSaveLocation1";
            this.txtSaveLocation1.ReadOnly = true;
            this.txtSaveLocation1.Size = new System.Drawing.Size(285, 26);
            this.txtSaveLocation1.TabIndex = 10;
            // 
            // lblSaveLocation1
            // 
            this.lblSaveLocation1.AutoSize = true;
            this.lblSaveLocation1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSaveLocation1.Location = new System.Drawing.Point(28, 83);
            this.lblSaveLocation1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaveLocation1.Name = "lblSaveLocation1";
            this.lblSaveLocation1.Size = new System.Drawing.Size(184, 20);
            this.lblSaveLocation1.TabIndex = 9;
            this.lblSaveLocation1.Text = "Save Location (optional):";
            // 
            // btnReset1
            // 
            this.btnReset1.BackColor = System.Drawing.Color.Transparent;
            this.btnReset1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReset1.Location = new System.Drawing.Point(281, 256);
            this.btnReset1.Name = "btnReset1";
            this.btnReset1.Size = new System.Drawing.Size(110, 30);
            this.btnReset1.TabIndex = 8;
            this.btnReset1.Text = "Reset";
            this.btnReset1.UseVisualStyleBackColor = false;
            this.btnReset1.Click += new System.EventHandler(this.btnReset1_Click);
            // 
            // chkSetPreviewDefault1
            // 
            this.chkSetPreviewDefault1.AutoSize = true;
            this.chkSetPreviewDefault1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkSetPreviewDefault1.Location = new System.Drawing.Point(363, 133);
            this.chkSetPreviewDefault1.Margin = new System.Windows.Forms.Padding(2);
            this.chkSetPreviewDefault1.Name = "chkSetPreviewDefault1";
            this.chkSetPreviewDefault1.Size = new System.Drawing.Size(114, 21);
            this.chkSetPreviewDefault1.TabIndex = 7;
            this.chkSetPreviewDefault1.Text = "Set as default";
            this.chkSetPreviewDefault1.UseVisualStyleBackColor = true;
            this.chkSetPreviewDefault1.CheckedChanged += new System.EventHandler(this.chkSetPreviewDefault1_CheckedChanged);
            // 
            // txtFileName1
            // 
            this.txtFileName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFileName1.Location = new System.Drawing.Point(217, 30);
            this.txtFileName1.Margin = new System.Windows.Forms.Padding(2);
            this.txtFileName1.Name = "txtFileName1";
            this.txtFileName1.Size = new System.Drawing.Size(315, 26);
            this.txtFileName1.TabIndex = 6;
            this.txtFileName1.TextChanged += new System.EventHandler(this.txtFileName1_TextChanged);
            // 
            // lblFileName1
            // 
            this.lblFileName1.AutoSize = true;
            this.lblFileName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFileName1.Location = new System.Drawing.Point(54, 32);
            this.lblFileName1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFileName1.Name = "lblFileName1";
            this.lblFileName1.Size = new System.Drawing.Size(154, 20);
            this.lblFileName1.TabIndex = 5;
            this.lblFileName1.Text = "File Name (optional):";
            // 
            // rbtnPreviewModeOff1
            // 
            this.rbtnPreviewModeOff1.AutoSize = true;
            this.rbtnPreviewModeOff1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtnPreviewModeOff1.Location = new System.Drawing.Point(285, 133);
            this.rbtnPreviewModeOff1.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnPreviewModeOff1.Name = "rbtnPreviewModeOff1";
            this.rbtnPreviewModeOff1.Size = new System.Drawing.Size(45, 21);
            this.rbtnPreviewModeOff1.TabIndex = 4;
            this.rbtnPreviewModeOff1.TabStop = true;
            this.rbtnPreviewModeOff1.Text = "Off";
            this.rbtnPreviewModeOff1.UseVisualStyleBackColor = true;
            this.rbtnPreviewModeOff1.CheckedChanged += new System.EventHandler(this.rbtnPreviewModeOff1_CheckedChanged);
            // 
            // rbtnPreviewModeOn1
            // 
            this.rbtnPreviewModeOn1.AutoSize = true;
            this.rbtnPreviewModeOn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtnPreviewModeOn1.Location = new System.Drawing.Point(229, 133);
            this.rbtnPreviewModeOn1.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnPreviewModeOn1.Name = "rbtnPreviewModeOn1";
            this.rbtnPreviewModeOn1.Size = new System.Drawing.Size(45, 21);
            this.rbtnPreviewModeOn1.TabIndex = 3;
            this.rbtnPreviewModeOn1.TabStop = true;
            this.rbtnPreviewModeOn1.Text = "On";
            this.rbtnPreviewModeOn1.UseVisualStyleBackColor = true;
            this.rbtnPreviewModeOn1.CheckedChanged += new System.EventHandler(this.rbtnPreviewModeOn1_CheckedChanged);
            // 
            // lblPreviewMode1
            // 
            this.lblPreviewMode1.AutoSize = true;
            this.lblPreviewMode1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPreviewMode1.Location = new System.Drawing.Point(25, 132);
            this.lblPreviewMode1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreviewMode1.Name = "lblPreviewMode1";
            this.lblPreviewMode1.Size = new System.Drawing.Size(181, 20);
            this.lblPreviewMode1.TabIndex = 2;
            this.lblPreviewMode1.Text = "Preview Mode (optional):";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.btnOpen2);
            this.tabPage2.Controls.Add(this.lblRecentFiles2);
            this.tabPage2.Controls.Add(this.lstbxRecentFiles2);
            this.tabPage2.Location = new System.Drawing.Point(204, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(538, 314);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage2_Enter);
            this.tabPage2.Leave += new System.EventHandler(this.tabPage2_Leave);
            // 
            // btnOpen2
            // 
            this.btnOpen2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOpen2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOpen2.Location = new System.Drawing.Point(404, 256);
            this.btnOpen2.Name = "btnOpen2";
            this.btnOpen2.Size = new System.Drawing.Size(110, 30);
            this.btnOpen2.TabIndex = 19;
            this.btnOpen2.Text = "Open";
            this.btnOpen2.UseVisualStyleBackColor = false;
            this.btnOpen2.Click += new System.EventHandler(this.btnOpen2_Click);
            // 
            // lblRecentFiles2
            // 
            this.lblRecentFiles2.AutoSize = true;
            this.lblRecentFiles2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRecentFiles2.Location = new System.Drawing.Point(7, 7);
            this.lblRecentFiles2.Name = "lblRecentFiles2";
            this.lblRecentFiles2.Size = new System.Drawing.Size(97, 20);
            this.lblRecentFiles2.TabIndex = 6;
            this.lblRecentFiles2.Text = "Recent files:";
            // 
            // lstbxRecentFiles2
            // 
            this.lstbxRecentFiles2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstbxRecentFiles2.FormattingEnabled = true;
            this.lstbxRecentFiles2.ItemHeight = 20;
            this.lstbxRecentFiles2.Location = new System.Drawing.Point(6, 30);
            this.lstbxRecentFiles2.Name = "lstbxRecentFiles2";
            this.lstbxRecentFiles2.Size = new System.Drawing.Size(526, 204);
            this.lstbxRecentFiles2.TabIndex = 5;
            this.lstbxRecentFiles2.Enter += new System.EventHandler(this.lstbxRecentFiles2_Enter);
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.tabPage3.Controls.Add(this.btnImport3);
            this.tabPage3.Controls.Add(this.lblAcceptableTypes3);
            this.tabPage3.Controls.Add(this.btnOpenFileDialog3);
            this.tabPage3.Controls.Add(this.txtFileNameImport3);
            this.tabPage3.Controls.Add(this.lblUploadFile3);
            this.tabPage3.Location = new System.Drawing.Point(204, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(538, 314);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Import Existing File";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnImport3
            // 
            this.btnImport3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnImport3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnImport3.Location = new System.Drawing.Point(404, 256);
            this.btnImport3.Name = "btnImport3";
            this.btnImport3.Size = new System.Drawing.Size(110, 30);
            this.btnImport3.TabIndex = 17;
            this.btnImport3.Text = "Import";
            this.btnImport3.UseVisualStyleBackColor = false;
            this.btnImport3.Click += new System.EventHandler(this.btnImport3_Click);
            // 
            // lblAcceptableTypes3
            // 
            this.lblAcceptableTypes3.AutoSize = true;
            this.lblAcceptableTypes3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAcceptableTypes3.Location = new System.Drawing.Point(171, 32);
            this.lblAcceptableTypes3.Name = "lblAcceptableTypes3";
            this.lblAcceptableTypes3.Size = new System.Drawing.Size(243, 20);
            this.lblAcceptableTypes3.TabIndex = 16;
            this.lblAcceptableTypes3.Text = "Acceptable File Types: pdf, txt, rtf";
            // 
            // btnOpenFileDialog3
            // 
            this.btnOpenFileDialog3.Location = new System.Drawing.Point(489, 77);
            this.btnOpenFileDialog3.Name = "btnOpenFileDialog3";
            this.btnOpenFileDialog3.Size = new System.Drawing.Size(25, 23);
            this.btnOpenFileDialog3.TabIndex = 15;
            this.btnOpenFileDialog3.Text = "...";
            this.btnOpenFileDialog3.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog3.Click += new System.EventHandler(this.btnOpenFileDialog3_Click);
            // 
            // txtFileNameImport3
            // 
            this.txtFileNameImport3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFileNameImport3.Location = new System.Drawing.Point(134, 74);
            this.txtFileNameImport3.Name = "txtFileNameImport3";
            this.txtFileNameImport3.Size = new System.Drawing.Size(349, 26);
            this.txtFileNameImport3.TabIndex = 14;
            // 
            // lblUploadFile3
            // 
            this.lblUploadFile3.AutoSize = true;
            this.lblUploadFile3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUploadFile3.Location = new System.Drawing.Point(40, 77);
            this.lblUploadFile3.Name = "lblUploadFile3";
            this.lblUploadFile3.Size = new System.Drawing.Size(88, 20);
            this.lblUploadFile3.TabIndex = 13;
            this.lblUploadFile3.Text = "Upload file:";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(204, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(538, 314);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnReturnToEditor);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCreateNewFile1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReturnToEditor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstbxRecentFiles2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton rbtnPreviewModeOff1;
        private System.Windows.Forms.RadioButton rbtnPreviewModeOn1;
        private System.Windows.Forms.Label lblPreviewMode1;
        private System.Windows.Forms.CheckBox chkSetPreviewDefault1;
        private System.Windows.Forms.TextBox txtFileName1;
        private System.Windows.Forms.Label lblFileName1;
        private System.Windows.Forms.Button btnReset1;
        private System.Windows.Forms.TextBox txtSaveLocation1;
        private System.Windows.Forms.Label lblSaveLocation1;
        private System.Windows.Forms.Button btnOpenFileDialog1;
        private System.Windows.Forms.Button btnOpenFileDialog3;
        private System.Windows.Forms.TextBox txtFileNameImport3;
        private System.Windows.Forms.Label lblUploadFile3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label lblAcceptableTypes3;
        private System.Windows.Forms.Button btnImport3;
        private System.Windows.Forms.Label lblRecentFiles2;
        private System.Windows.Forms.Button btnOpen2;
    }
}

