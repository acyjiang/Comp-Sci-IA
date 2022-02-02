
namespace Comp_Sci_IA
{
    partial class Main
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
            this.btnPreviewMode = new System.Windows.Forms.Button();
            this.btnOpenStart = new System.Windows.Forms.Button();
            this.txtMain = new System.Windows.Forms.RichTextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtPreview = new System.Windows.Forms.RichTextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnPreviewMode
            // 
            this.btnPreviewMode.Location = new System.Drawing.Point(628, 12);
            this.btnPreviewMode.Name = "btnPreviewMode";
            this.btnPreviewMode.Size = new System.Drawing.Size(144, 34);
            this.btnPreviewMode.TabIndex = 1;
            this.btnPreviewMode.Text = "Preview Mode: Off";
            this.btnPreviewMode.UseVisualStyleBackColor = true;
            this.btnPreviewMode.Click += new System.EventHandler(this.btnPreviewMode_Click);
            // 
            // btnOpenStart
            // 
            this.btnOpenStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOpenStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOpenStart.Location = new System.Drawing.Point(27, 12);
            this.btnOpenStart.Name = "btnOpenStart";
            this.btnOpenStart.Size = new System.Drawing.Size(139, 35);
            this.btnOpenStart.TabIndex = 2;
            this.btnOpenStart.Text = "Return to Start Menu";
            this.btnOpenStart.UseVisualStyleBackColor = false;
            this.btnOpenStart.Click += new System.EventHandler(this.btnReturnToStart_Click);
            // 
            // txtMain
            // 
            this.txtMain.Location = new System.Drawing.Point(27, 68);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(745, 218);
            this.txtMain.TabIndex = 3;
            this.txtMain.Text = "";
            this.txtMain.TextChanged += new System.EventHandler(this.txtMain_TextChanged);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFileName.Location = new System.Drawing.Point(363, 22);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(73, 20);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "Untitled1";
            // 
            // txtPreview
            // 
            this.txtPreview.Location = new System.Drawing.Point(410, 68);
            this.txtPreview.Name = "txtPreview";
            this.txtPreview.Size = new System.Drawing.Size(362, 218);
            this.txtPreview.TabIndex = 4;
            this.txtPreview.Text = "";
            // 
            // checkBox1
            // 
            this.checkBox1.AllowDrop = true;
            this.checkBox1.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(99, 326);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 23);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(367, 359);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(77, 23);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txtPreview);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.btnOpenStart);
            this.Controls.Add(this.btnPreviewMode);
            this.Controls.Add(this.lblFileName);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPreviewMode;
        private System.Windows.Forms.Button btnOpenStart;
        private System.Windows.Forms.RichTextBox txtMain;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.RichTextBox txtPreview;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}