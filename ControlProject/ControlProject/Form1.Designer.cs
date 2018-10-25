namespace ControlProject
{
    partial class Form1
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
            this.colorSelection1 = new CustomControls.ColorSelection();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // colorSelection1
            // 
            this.colorSelection1.Location = new System.Drawing.Point(12, 12);
            this.colorSelection1.Name = "colorSelection1";
            this.colorSelection1.Size = new System.Drawing.Size(299, 225);
            this.colorSelection1.TabIndex = 0;
            this.colorSelection1.ColorSelected += new System.EventHandler<CustomControls.ColorSelectionEventArgs>(this.colorSelection1_ColorSelected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorSelection1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomControls.ColorSelection colorSelection1;
        private System.Windows.Forms.Label label1;
    }
}

