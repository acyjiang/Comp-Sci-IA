
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblFileName = new System.Windows.Forms.Label();
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
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(27, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(745, 218);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
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
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnOpenStart);
            this.Controls.Add(this.btnPreviewMode);
            this.Controls.Add(this.lblFileName);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPreviewMode;
        private System.Windows.Forms.Button btnOpenStart;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblFileName;
    }
}