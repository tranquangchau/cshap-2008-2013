﻿namespace TimeManagee
{
    partial class Thirst
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
            this.label1 = new System.Windows.Forms.Label();
            this.btntrue = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnfalse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "END\\";
            // 
            // btntrue
            // 
            this.btntrue.Location = new System.Drawing.Point(171, 134);
            this.btntrue.Name = "btntrue";
            this.btntrue.Size = new System.Drawing.Size(75, 23);
            this.btntrue.TabIndex = 1;
            this.btntrue.Text = "True";
            this.btntrue.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(37, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(314, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnfalse
            // 
            this.btnfalse.Location = new System.Drawing.Point(276, 134);
            this.btnfalse.Name = "btnfalse";
            this.btnfalse.Size = new System.Drawing.Size(75, 23);
            this.btnfalse.TabIndex = 1;
            this.btnfalse.Text = "False";
            this.btnfalse.UseVisualStyleBackColor = true;
            // 
            // Thirst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 179);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnfalse);
            this.Controls.Add(this.btntrue);
            this.Controls.Add(this.label1);
            this.Name = "Thirst";
            this.Text = "Thirst";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btntrue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnfalse;
    }
}