
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
            this.components = new System.ComponentModel.Container();
            this.btnOpenStart = new System.Windows.Forms.Button();
            this.lblFileName = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBarLower = new System.Windows.Forms.TrackBar();
            this.trackBarLeft = new System.Windows.Forms.TrackBar();
            this.trackBarUpper = new System.Windows.Forms.TrackBar();
            this.trackBarRight = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnCrop = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUpper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpenStart
            // 
            this.btnOpenStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnOpenStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnOpenStart.Location = new System.Drawing.Point(54, 23);
            this.btnOpenStart.Margin = new System.Windows.Forms.Padding(6);
            this.btnOpenStart.Name = "btnOpenStart";
            this.btnOpenStart.Size = new System.Drawing.Size(278, 67);
            this.btnOpenStart.TabIndex = 2;
            this.btnOpenStart.Text = "Return to Start Menu";
            this.btnOpenStart.UseVisualStyleBackColor = false;
            this.btnOpenStart.Click += new System.EventHandler(this.btnReturnToStart_Click);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFileName.Location = new System.Drawing.Point(1048, 42);
            this.lblFileName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(141, 37);
            this.lblFileName.TabIndex = 0;
            this.lblFileName.Text = "Untitled1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(138, 213);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(615, 502);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // trackBarLower
            // 
            this.trackBarLower.Location = new System.Drawing.Point(138, 734);
            this.trackBarLower.Maximum = 1000;
            this.trackBarLower.Name = "trackBarLower";
            this.trackBarLower.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.trackBarLower.Size = new System.Drawing.Size(615, 90);
            this.trackBarLower.TabIndex = 4;
            this.trackBarLower.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarLower.Value = 1000;
            this.trackBarLower.ValueChanged += new System.EventHandler(this.trackBarLower_ValueChanged);
            // 
            // trackBarLeft
            // 
            this.trackBarLeft.Location = new System.Drawing.Point(29, 213);
            this.trackBarLeft.Maximum = 1000;
            this.trackBarLeft.Name = "trackBarLeft";
            this.trackBarLeft.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarLeft.Size = new System.Drawing.Size(90, 502);
            this.trackBarLeft.TabIndex = 5;
            this.trackBarLeft.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarLeft.Value = 1000;
            this.trackBarLeft.ValueChanged += new System.EventHandler(this.trackBarLeft_ValueChanged);
            // 
            // trackBarUpper
            // 
            this.trackBarUpper.Cursor = System.Windows.Forms.Cursors.Cross;
            this.trackBarUpper.Location = new System.Drawing.Point(138, 117);
            this.trackBarUpper.Maximum = 1000;
            this.trackBarUpper.Name = "trackBarUpper";
            this.trackBarUpper.Size = new System.Drawing.Size(615, 90);
            this.trackBarUpper.TabIndex = 6;
            this.trackBarUpper.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarUpper.ValueChanged += new System.EventHandler(this.trackBarUpper_ValueChanged);
            // 
            // trackBarRight
            // 
            this.trackBarRight.Location = new System.Drawing.Point(777, 213);
            this.trackBarRight.Maximum = 1000;
            this.trackBarRight.Name = "trackBarRight";
            this.trackBarRight.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarRight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.trackBarRight.RightToLeftLayout = true;
            this.trackBarRight.Size = new System.Drawing.Size(90, 502);
            this.trackBarRight.TabIndex = 7;
            this.trackBarRight.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBarRight.ValueChanged += new System.EventHandler(this.trackBarRight_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Undo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(524, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "Redo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(343, 376);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 122);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(54, 1208);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(330, 48);
            this.btnExport.TabIndex = 11;
            this.btnExport.Text = "Export as new image";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(468, 1219);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(158, 29);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.Text = "Zoom Mode";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnCrop
            // 
            this.btnCrop.Location = new System.Drawing.Point(468, 1254);
            this.btnCrop.Name = "btnCrop";
            this.btnCrop.Size = new System.Drawing.Size(150, 49);
            this.btnCrop.TabIndex = 13;
            this.btnCrop.Text = "Crop";
            this.btnCrop.UseVisualStyleBackColor = true;
            this.btnCrop.Click += new System.EventHandler(this.btnCrop_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(1430, 734);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(193, 164);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2174, 1329);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnCrop);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trackBarRight);
            this.Controls.Add(this.trackBarUpper);
            this.Controls.Add(this.trackBarLeft);
            this.Controls.Add(this.trackBarLower);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnOpenStart);
            this.Controls.Add(this.lblFileName);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarUpper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnOpenStart;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBarLower;
        private System.Windows.Forms.TrackBar trackBarLeft;
        private System.Windows.Forms.TrackBar trackBarUpper;
        private System.Windows.Forms.TrackBar trackBarRight;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnCrop;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}