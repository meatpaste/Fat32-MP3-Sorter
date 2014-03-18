namespace Fat32_MP3_Sorter
{
    partial class Fat32_MP3_Sorter
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
            this.lblDevices = new System.Windows.Forms.Label();
            this.lstDevices = new System.Windows.Forms.ListBox();
            this.lblPartitions = new System.Windows.Forms.Label();
            this.lstPartitions = new System.Windows.Forms.ListBox();
            this.stBottom = new System.Windows.Forms.StatusStrip();
            this.stlblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.stBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDevices
            // 
            this.lblDevices.AutoSize = true;
            this.lblDevices.Location = new System.Drawing.Point(12, 9);
            this.lblDevices.Name = "lblDevices";
            this.lblDevices.Size = new System.Drawing.Size(71, 13);
            this.lblDevices.TabIndex = 0;
            this.lblDevices.Text = "USB Devices";
            // 
            // lstDevices
            // 
            this.lstDevices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDevices.FormattingEnabled = true;
            this.lstDevices.Location = new System.Drawing.Point(12, 25);
            this.lstDevices.Name = "lstDevices";
            this.lstDevices.Size = new System.Drawing.Size(260, 56);
            this.lstDevices.TabIndex = 1;
            this.lstDevices.SelectedIndexChanged += new System.EventHandler(this.lstDevices_SelectedIndexChanged);
            // 
            // lblPartitions
            // 
            this.lblPartitions.AutoSize = true;
            this.lblPartitions.Location = new System.Drawing.Point(12, 84);
            this.lblPartitions.Name = "lblPartitions";
            this.lblPartitions.Size = new System.Drawing.Size(102, 13);
            this.lblPartitions.TabIndex = 2;
            this.lblPartitions.Text = "Partitions on Device";
            // 
            // lstPartitions
            // 
            this.lstPartitions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstPartitions.FormattingEnabled = true;
            this.lstPartitions.Location = new System.Drawing.Point(15, 100);
            this.lstPartitions.Name = "lstPartitions";
            this.lstPartitions.Size = new System.Drawing.Size(257, 43);
            this.lstPartitions.TabIndex = 3;
            this.lstPartitions.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstPartitions_MouseDoubleClick);
            // 
            // stBottom
            // 
            this.stBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlblStatus});
            this.stBottom.Location = new System.Drawing.Point(0, 154);
            this.stBottom.Name = "stBottom";
            this.stBottom.Size = new System.Drawing.Size(284, 22);
            this.stBottom.SizingGrip = false;
            this.stBottom.TabIndex = 4;
            // 
            // stlblStatus
            // 
            this.stlblStatus.Name = "stlblStatus";
            this.stlblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // Fat32_MP3_Sorter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 176);
            this.Controls.Add(this.stBottom);
            this.Controls.Add(this.lstPartitions);
            this.Controls.Add(this.lblPartitions);
            this.Controls.Add(this.lstDevices);
            this.Controls.Add(this.lblDevices);
            this.Name = "Fat32_MP3_Sorter";
            this.Text = "Fat32 MP3 Sorter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.stBottom.ResumeLayout(false);
            this.stBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDevices;
        private System.Windows.Forms.ListBox lstDevices;
        private System.Windows.Forms.Label lblPartitions;
        private System.Windows.Forms.ListBox lstPartitions;
        private System.Windows.Forms.StatusStrip stBottom;
        private System.Windows.Forms.ToolStripStatusLabel stlblStatus;
    }
}

