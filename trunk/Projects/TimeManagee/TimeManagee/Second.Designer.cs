namespace TimeManagee
{
    partial class Second
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
            this.lbltimer = new System.Windows.Forms.Label();
            this.lblgoaler = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbltimer
            // 
            this.lbltimer.AutoSize = true;
            this.lbltimer.Location = new System.Drawing.Point(128, 37);
            this.lbltimer.Name = "lbltimer";
            this.lbltimer.Size = new System.Drawing.Size(30, 13);
            this.lbltimer.TabIndex = 0;
            this.lbltimer.Text = "Time";
            // 
            // lblgoaler
            // 
            this.lblgoaler.AutoSize = true;
            this.lblgoaler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgoaler.Location = new System.Drawing.Point(12, 87);
            this.lblgoaler.Name = "lblgoaler";
            this.lblgoaler.Size = new System.Drawing.Size(60, 24);
            this.lblgoaler.TabIndex = 1;
            this.lblgoaler.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Second
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 169);
            this.Controls.Add(this.lblgoaler);
            this.Controls.Add(this.lbltimer);
            this.Name = "Second";
            this.Text = "Second";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltimer;
        private System.Windows.Forms.Label lblgoaler;
        private System.Windows.Forms.Timer timer1;
    }
}