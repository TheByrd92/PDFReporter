namespace PDFReporter
{
    partial class Visualizer
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.grabberBtn = new System.Windows.Forms.Button();
            this.MeasureBtn = new System.Windows.Forms.Button();
            this.previewBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.AutoScroll = true;
            this.MainPanel.Location = new System.Drawing.Point(0, 60);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(738, 576);
            this.MainPanel.TabIndex = 0;
            // 
            // grabberBtn
            // 
            this.grabberBtn.BackgroundImage = global::PDFReporter.Properties.Resources.Grabber;
            this.grabberBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.grabberBtn.Location = new System.Drawing.Point(12, 6);
            this.grabberBtn.Name = "grabberBtn";
            this.grabberBtn.Size = new System.Drawing.Size(48, 48);
            this.grabberBtn.TabIndex = 1;
            this.grabberBtn.UseVisualStyleBackColor = true;
            // 
            // MeasureBtn
            // 
            this.MeasureBtn.BackgroundImage = global::PDFReporter.Properties.Resources.Ruler;
            this.MeasureBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MeasureBtn.Location = new System.Drawing.Point(66, 6);
            this.MeasureBtn.Name = "MeasureBtn";
            this.MeasureBtn.Size = new System.Drawing.Size(48, 48);
            this.MeasureBtn.TabIndex = 2;
            this.MeasureBtn.UseVisualStyleBackColor = true;
            // 
            // previewBtn
            // 
            this.previewBtn.BackgroundImage = global::PDFReporter.Properties.Resources.Preview;
            this.previewBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previewBtn.Location = new System.Drawing.Point(120, 6);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(48, 48);
            this.previewBtn.TabIndex = 3;
            this.previewBtn.UseVisualStyleBackColor = true;
            this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // Visualizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 636);
            this.Controls.Add(this.previewBtn);
            this.Controls.Add(this.grabberBtn);
            this.Controls.Add(this.MeasureBtn);
            this.Controls.Add(this.MainPanel);
            this.Name = "Visualizer";
            this.Text = "MainWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button grabberBtn;
        private System.Windows.Forms.Button MeasureBtn;
        private System.Windows.Forms.Button previewBtn;
    }
}

