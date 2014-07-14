namespace mp3playtest
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
            this.button1 = new System.Windows.Forms.Button();
            this.volumeSlider1 = new NAudio.Gui.VolumeSlider();
            this.progressLog1 = new NAudio.Utils.ProgressLog();
            this.fader1 = new NAudio.Gui.Fader();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(127, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(49, 56);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // volumeSlider1
            // 
            this.volumeSlider1.Location = new System.Drawing.Point(38, 179);
            this.volumeSlider1.Name = "volumeSlider1";
            this.volumeSlider1.Size = new System.Drawing.Size(65, 32);
            this.volumeSlider1.TabIndex = 1;
            // 
            // progressLog1
            // 
            this.progressLog1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.progressLog1.Location = new System.Drawing.Point(113, 233);
            this.progressLog1.Name = "progressLog1";
            this.progressLog1.Padding = new System.Windows.Forms.Padding(1);
            this.progressLog1.Size = new System.Drawing.Size(63, 28);
            this.progressLog1.TabIndex = 3;
            // 
            // fader1
            // 
            this.fader1.ImeMode = System.Windows.Forms.ImeMode.On;
            this.fader1.Location = new System.Drawing.Point(44, 11);
            this.fader1.Maximum = 0;
            this.fader1.Minimum = 0;
            this.fader1.Name = "fader1";
            this.fader1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.fader1.Size = new System.Drawing.Size(131, 59);
            this.fader1.TabIndex = 4;
            this.fader1.Text = "fader1";
            this.fader1.Value = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.fader1);
            this.Controls.Add(this.progressLog1);
            this.Controls.Add(this.volumeSlider1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private NAudio.Gui.VolumeSlider volumeSlider1;
        private NAudio.Utils.ProgressLog progressLog1;
        private NAudio.Gui.Fader fader1;
    }
}

