namespace TimeManagee
{
    partial class First
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblgoal = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblnote = new System.Windows.Forms.Label();
            this.lblin = new System.Windows.Forms.Label();
            this.lblout = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(373, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(34, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblgoal
            // 
            this.lblgoal.AutoSize = true;
            this.lblgoal.Location = new System.Drawing.Point(25, 64);
            this.lblgoal.Name = "lblgoal";
            this.lblgoal.Size = new System.Drawing.Size(29, 13);
            this.lblgoal.TabIndex = 1;
            this.lblgoal.Text = "Goal";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 20);
            this.textBox1.TabIndex = 2;
            // 
            // lblnote
            // 
            this.lblnote.AutoSize = true;
            this.lblnote.Location = new System.Drawing.Point(24, 210);
            this.lblnote.Name = "lblnote";
            this.lblnote.Size = new System.Drawing.Size(30, 13);
            this.lblnote.TabIndex = 1;
            this.lblnote.Text = "Note";
            // 
            // lblin
            // 
            this.lblin.AutoSize = true;
            this.lblin.Location = new System.Drawing.Point(25, 102);
            this.lblin.Name = "lblin";
            this.lblin.Size = new System.Drawing.Size(16, 13);
            this.lblin.TabIndex = 1;
            this.lblin.Text = "In";
            // 
            // lblout
            // 
            this.lblout.AutoSize = true;
            this.lblout.Location = new System.Drawing.Point(25, 161);
            this.lblout.Name = "lblout";
            this.lblout.Size = new System.Drawing.Size(24, 13);
            this.lblout.TabIndex = 1;
            this.lblout.Text = "Out";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "15",
            "30",
            "45",
            "60",
            "90",
            "180"});
            this.comboBox1.Location = new System.Drawing.Point(69, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Location = new System.Drawing.Point(25, 22);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(30, 13);
            this.lbltime.TabIndex = 1;
            this.lbltime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 99);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(253, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(72, 154);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(253, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(74, 203);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(253, 20);
            this.textBox4.TabIndex = 2;
            // 
            // First
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 277);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblout);
            this.Controls.Add(this.lblin);
            this.Controls.Add(this.lblnote);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblgoal);
            this.Controls.Add(this.button1);
            this.Name = "First";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.First_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblgoal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblnote;
        private System.Windows.Forms.Label lblin;
        private System.Windows.Forms.Label lblout;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

