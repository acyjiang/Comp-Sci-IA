
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.chkSetPreviewDefault = new System.Windows.Forms.CheckBox();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtnPreviewModeOff = new System.Windows.Forms.RadioButton();
            this.rbtnPreviewModeOn = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
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
            this.lblWelcome.Location = new System.Drawing.Point(32, 26);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(455, 40);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome! Select an option:";
            // 
            // btnCreateNewFile
            // 
            this.btnCreateNewFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCreateNewFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCreateNewFile.Location = new System.Drawing.Point(632, 402);
            this.btnCreateNewFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateNewFile.Name = "btnCreateNewFile";
            this.btnCreateNewFile.Size = new System.Drawing.Size(165, 46);
            this.btnCreateNewFile.TabIndex = 1;
            this.btnCreateNewFile.Text = "Create";
            this.btnCreateNewFile.UseVisualStyleBackColor = false;
            this.btnCreateNewFile.Click += new System.EventHandler(this.btnCreateNewFile_Click);
            // 
            // btnImportExistingFile
            // 
            this.btnImportExistingFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnImportExistingFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnImportExistingFile.Location = new System.Drawing.Point(277, 72);
            this.btnImportExistingFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnImportExistingFile.Name = "btnImportExistingFile";
            this.btnImportExistingFile.Size = new System.Drawing.Size(404, 74);
            this.btnImportExistingFile.TabIndex = 2;
            this.btnImportExistingFile.Text = "Import Existing File";
            this.btnImportExistingFile.UseVisualStyleBackColor = false;
            this.btnImportExistingFile.Click += new System.EventHandler(this.btnImportExistingFile_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClose.Location = new System.Drawing.Point(972, 604);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(186, 74);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnReturnToEditor
            // 
            this.btnReturnToEditor.BackColor = System.Drawing.Color.Transparent;
            this.btnReturnToEditor.Location = new System.Drawing.Point(972, 14);
            this.btnReturnToEditor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturnToEditor.Name = "btnReturnToEditor";
            this.btnReturnToEditor.Size = new System.Drawing.Size(186, 50);
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
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(40, 200);
            this.tabControl1.Location = new System.Drawing.Point(39, 80);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1119, 495);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 8;
            this.tabControl1.Tag = "";
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.btnOpenFileDialog);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.chkSetPreviewDefault);
            this.tabPage1.Controls.Add(this.txtFileName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.rbtnPreviewModeOff);
            this.tabPage1.Controls.Add(this.rbtnPreviewModeOn);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnCreateNewFile);
            this.tabPage1.Location = new System.Drawing.Point(204, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(911, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(759, 124);
            this.btnOpenFileDialog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(38, 35);
            this.btnOpenFileDialog.TabIndex = 13;
            this.btnOpenFileDialog.Text = "...";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox2.Location = new System.Drawing.Point(326, 124);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(403, 35);
            this.textBox2.TabIndex = 10;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(42, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Save Location (optional):";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Transparent;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnReset.Location = new System.Drawing.Point(447, 402);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(165, 46);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // chkSetPreviewDefault
            // 
            this.chkSetPreviewDefault.AutoSize = true;
            this.chkSetPreviewDefault.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chkSetPreviewDefault.Location = new System.Drawing.Point(545, 205);
            this.chkSetPreviewDefault.Name = "chkSetPreviewDefault";
            this.chkSetPreviewDefault.Size = new System.Drawing.Size(157, 29);
            this.chkSetPreviewDefault.TabIndex = 7;
            this.chkSetPreviewDefault.Text = "Set as default";
            this.chkSetPreviewDefault.UseVisualStyleBackColor = true;
            this.chkSetPreviewDefault.CheckedChanged += new System.EventHandler(this.chkSetPreviewDefault_CheckedChanged);
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFileName.Location = new System.Drawing.Point(326, 46);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(471, 35);
            this.txtFileName.TabIndex = 6;
            this.txtFileName.TextChanged += new System.EventHandler(this.txtFileName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(81, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "File Name (optional):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // rbtnPreviewModeOff
            // 
            this.rbtnPreviewModeOff.AutoSize = true;
            this.rbtnPreviewModeOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtnPreviewModeOff.Location = new System.Drawing.Point(427, 205);
            this.rbtnPreviewModeOff.Name = "rbtnPreviewModeOff";
            this.rbtnPreviewModeOff.Size = new System.Drawing.Size(63, 29);
            this.rbtnPreviewModeOff.TabIndex = 4;
            this.rbtnPreviewModeOff.TabStop = true;
            this.rbtnPreviewModeOff.Text = "Off";
            this.rbtnPreviewModeOff.UseVisualStyleBackColor = true;
            this.rbtnPreviewModeOff.CheckedChanged += new System.EventHandler(this.rbtnPreviewModeOff_CheckedChanged);
            // 
            // rbtnPreviewModeOn
            // 
            this.rbtnPreviewModeOn.AutoSize = true;
            this.rbtnPreviewModeOn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbtnPreviewModeOn.Location = new System.Drawing.Point(343, 205);
            this.rbtnPreviewModeOn.Name = "rbtnPreviewModeOn";
            this.rbtnPreviewModeOn.Size = new System.Drawing.Size(64, 29);
            this.rbtnPreviewModeOn.TabIndex = 3;
            this.rbtnPreviewModeOn.TabStop = true;
            this.rbtnPreviewModeOn.Text = "On";
            this.rbtnPreviewModeOn.UseVisualStyleBackColor = true;
            this.rbtnPreviewModeOn.CheckedChanged += new System.EventHandler(this.rbtnPreviewModeOn_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(38, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Preview Mode (optional):";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(204, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(911, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(9, 9);
            this.listBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(769, 564);
            this.listBox1.TabIndex = 5;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.tabPage3.Controls.Add(this.btnImportExistingFile);
            this.tabPage3.Location = new System.Drawing.Point(204, 4);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage3.Size = new System.Drawing.Size(911, 487);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Import Existing File";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnReturnToEditor);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnCreateNewFile;
        private System.Windows.Forms.Button btnImportExistingFile;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnReturnToEditor;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.RadioButton rbtnPreviewModeOff;
        private System.Windows.Forms.RadioButton rbtnPreviewModeOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSetPreviewDefault;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenFileDialog;
    }
}

