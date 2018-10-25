namespace CustomControls
{
    partial class ColorSelection
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.colorPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // tbRed
            // 
            this.tbRed.AutoSize = false;
            this.tbRed.Location = new System.Drawing.Point(0, 20);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(296, 30);
            this.tbRed.TabIndex = 0;
            this.tbRed.TickFrequency = 5;
            this.tbRed.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Green";
            // 
            // tbGreen
            // 
            this.tbGreen.AutoSize = false;
            this.tbGreen.Location = new System.Drawing.Point(0, 69);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(296, 30);
            this.tbGreen.TabIndex = 2;
            this.tbGreen.TickFrequency = 5;
            this.tbGreen.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blue";
            // 
            // tbBlue
            // 
            this.tbBlue.AutoSize = false;
            this.tbBlue.Location = new System.Drawing.Point(0, 118);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(296, 30);
            this.tbBlue.TabIndex = 4;
            this.tbBlue.TickFrequency = 5;
            this.tbBlue.Scroll += new System.EventHandler(this.tb_Scroll);
            // 
            // colorPanel
            // 
            this.colorPanel.Location = new System.Drawing.Point(7, 154);
            this.colorPanel.Name = "colorPanel";
            this.colorPanel.Size = new System.Drawing.Size(289, 58);
            this.colorPanel.TabIndex = 6;
            // 
            // ColorSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.colorPanel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbRed);
            this.Name = "ColorSelection";
            this.Size = new System.Drawing.Size(299, 225);
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar tbRed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar tbGreen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar tbBlue;
        private System.Windows.Forms.Panel colorPanel;
    }
}
