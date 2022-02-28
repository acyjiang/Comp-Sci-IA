
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
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOpen1 = new System.Windows.Forms.Button();
            this.lblRecentFiles1 = new System.Windows.Forms.Label();
            this.lstbxRecentFiles1 = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnImport2 = new System.Windows.Forms.Button();
            this.lblAcceptableTypes2 = new System.Windows.Forms.Label();
            this.btnOpenFileDialog2 = new System.Windows.Forms.Button();
            this.txtFileNameImport2 = new System.Windows.Forms.TextBox();
            this.lblUploadFile2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblWelcome.Location = new System.Drawing.Point(42, 33);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(607, 55);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome! Select an option:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.Location = new System.Drawing.Point(1296, 756);
            this.btnExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(248, 92);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.ItemSize = new System.Drawing.Size(40, 200);
            this.tabControl1.Location = new System.Drawing.Point(52, 100);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(6);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1492, 619);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 8;
            this.tabControl1.Tag = "";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.btnOpen1);
            this.tabPage2.Controls.Add(this.lblRecentFiles1);
            this.tabPage2.Controls.Add(this.lstbxRecentFiles1);
            this.tabPage2.Location = new System.Drawing.Point(204, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage2.Size = new System.Drawing.Size(1284, 611);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Enter += new System.EventHandler(this.tabPage1_Enter);
            this.tabPage2.Leave += new System.EventHandler(this.tabPage1_Leave);
            // 
            // btnOpen1
            // 
            this.btnOpen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOpen1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOpen1.Location = new System.Drawing.Point(808, 492);
            this.btnOpen1.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpen1.Name = "btnOpen1";
            this.btnOpen1.Size = new System.Drawing.Size(220, 58);
            this.btnOpen1.TabIndex = 19;
            this.btnOpen1.Text = "Open";
            this.btnOpen1.UseVisualStyleBackColor = false;
            this.btnOpen1.Click += new System.EventHandler(this.btnOpen1_Click);
            // 
            // lblRecentFiles1
            // 
            this.lblRecentFiles1.AutoSize = true;
            this.lblRecentFiles1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblRecentFiles1.Location = new System.Drawing.Point(14, 13);
            this.lblRecentFiles1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRecentFiles1.Name = "lblRecentFiles1";
            this.lblRecentFiles1.Size = new System.Drawing.Size(190, 37);
            this.lblRecentFiles1.TabIndex = 6;
            this.lblRecentFiles1.Text = "Recent files:";
            // 
            // lstbxRecentFiles1
            // 
            this.lstbxRecentFiles1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lstbxRecentFiles1.FormattingEnabled = true;
            this.lstbxRecentFiles1.ItemHeight = 37;
            this.lstbxRecentFiles1.Location = new System.Drawing.Point(12, 58);
            this.lstbxRecentFiles1.Margin = new System.Windows.Forms.Padding(6);
            this.lstbxRecentFiles1.Name = "lstbxRecentFiles1";
            this.lstbxRecentFiles1.Size = new System.Drawing.Size(1048, 374);
            this.lstbxRecentFiles1.TabIndex = 5;
            this.lstbxRecentFiles1.SelectedIndexChanged += new System.EventHandler(this.lstbxRecentFiles1_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.tabPage3.Controls.Add(this.btnImport2);
            this.tabPage3.Controls.Add(this.lblAcceptableTypes2);
            this.tabPage3.Controls.Add(this.btnOpenFileDialog2);
            this.tabPage3.Controls.Add(this.txtFileNameImport2);
            this.tabPage3.Controls.Add(this.lblUploadFile2);
            this.tabPage3.Location = new System.Drawing.Point(204, 4);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage3.Size = new System.Drawing.Size(1284, 611);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Import Existing File";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnImport2
            // 
            this.btnImport2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnImport2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnImport2.Location = new System.Drawing.Point(808, 492);
            this.btnImport2.Margin = new System.Windows.Forms.Padding(6);
            this.btnImport2.Name = "btnImport2";
            this.btnImport2.Size = new System.Drawing.Size(220, 58);
            this.btnImport2.TabIndex = 17;
            this.btnImport2.Text = "Import";
            this.btnImport2.UseVisualStyleBackColor = false;
            this.btnImport2.Click += new System.EventHandler(this.btnImport2_Click);
            // 
            // lblAcceptableTypes2
            // 
            this.lblAcceptableTypes2.AutoSize = true;
            this.lblAcceptableTypes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAcceptableTypes2.Location = new System.Drawing.Point(319, 50);
            this.lblAcceptableTypes2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAcceptableTypes2.Name = "lblAcceptableTypes2";
            this.lblAcceptableTypes2.Size = new System.Drawing.Size(561, 37);
            this.lblAcceptableTypes2.TabIndex = 16;
            this.lblAcceptableTypes2.Text = "Acceptable File Types: jpeg, png, bmp";
            // 
            // btnOpenFileDialog2
            // 
            this.btnOpenFileDialog2.Location = new System.Drawing.Point(978, 148);
            this.btnOpenFileDialog2.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenFileDialog2.Name = "btnOpenFileDialog2";
            this.btnOpenFileDialog2.Size = new System.Drawing.Size(50, 44);
            this.btnOpenFileDialog2.TabIndex = 15;
            this.btnOpenFileDialog2.Text = "...";
            this.btnOpenFileDialog2.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog2.Click += new System.EventHandler(this.btnOpenFileDialog2_Click);
            // 
            // txtFileNameImport2
            // 
            this.txtFileNameImport2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFileNameImport2.Location = new System.Drawing.Point(268, 142);
            this.txtFileNameImport2.Margin = new System.Windows.Forms.Padding(6);
            this.txtFileNameImport2.Name = "txtFileNameImport2";
            this.txtFileNameImport2.Size = new System.Drawing.Size(694, 44);
            this.txtFileNameImport2.TabIndex = 14;
            // 
            // lblUploadFile2
            // 
            this.lblUploadFile2.AutoSize = true;
            this.lblUploadFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUploadFile2.Location = new System.Drawing.Point(80, 148);
            this.lblUploadFile2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblUploadFile2.Name = "lblUploadFile2";
            this.lblUploadFile2.Size = new System.Drawing.Size(177, 37);
            this.lblUploadFile2.TabIndex = 13;
            this.lblUploadFile2.Text = "Upload file:";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblWelcome);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Start";
            this.Text = "Start";
            this.Load += new System.EventHandler(this.Start_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lstbxRecentFiles1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnOpenFileDialog2;
        private System.Windows.Forms.TextBox txtFileNameImport2;
        private System.Windows.Forms.Label lblUploadFile2;
        private System.Windows.Forms.Label lblAcceptableTypes2;
        private System.Windows.Forms.Button btnImport2;
        private System.Windows.Forms.Label lblRecentFiles1;
        private System.Windows.Forms.Button btnOpen1;
    }
}

