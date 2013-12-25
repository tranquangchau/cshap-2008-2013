namespace KetNoiCSDL
{
    partial class DnDtView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.colMa_Dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTen_Dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDia_Chi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSo_Dt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGhi_Chu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMa_Dt,
            this.colTen_Dt,
            this.colDia_Chi,
            this.colSo_Dt,
            this.colFax,
            this.colEmail,
            this.colGhi_Chu});
            this.dataGridView1.Location = new System.Drawing.Point(12, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(780, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // colMa_Dt
            // 
            this.colMa_Dt.HeaderText = "Ma So";
            this.colMa_Dt.Name = "colMa_Dt";
            this.colMa_Dt.Width = 110;
            // 
            // colTen_Dt
            // 
            this.colTen_Dt.HeaderText = "Ten doi tuong";
            this.colTen_Dt.Name = "colTen_Dt";
            // 
            // colDia_Chi
            // 
            this.colDia_Chi.HeaderText = "Dia chi";
            this.colDia_Chi.Name = "colDia_Chi";
            // 
            // colSo_Dt
            // 
            this.colSo_Dt.HeaderText = "Dien thoai";
            this.colSo_Dt.Name = "colSo_Dt";
            // 
            // colFax
            // 
            this.colFax.HeaderText = "Fax";
            this.colFax.Name = "colFax";
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // colGhi_Chu
            // 
            this.colGhi_Chu.HeaderText = "Ghi Chu";
            this.colGhi_Chu.Name = "colGhi_Chu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Them";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 218);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sua";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(204, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "Xoa";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(285, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 1;
            this.button4.Text = "Thoat";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // DnDtView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 270);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DnDtView";
            this.Text = "DnDtView";
            this.Load += new System.EventHandler(this.DnDtView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMa_Dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTen_Dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDia_Chi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSo_Dt;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGhi_Chu;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}