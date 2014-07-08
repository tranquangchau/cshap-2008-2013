
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

public class Form1 : Form
{
    private System.Windows.Forms.ListBox displayListBox;
    private System.Windows.Forms.TextBox inputTextBox;
    private System.Windows.Forms.Button addButton;
    private System.Windows.Forms.Button removeButton;
    private System.Windows.Forms.Button clearButton;

    public Form1()
    {
        InitializeComponent();
    }

    private void addButton_Click(object sender, EventArgs e)
    {
        displayListBox.Items.Add(inputTextBox.Text);
        inputTextBox.Clear();
    }
    private void removeButton_Click(object sender, EventArgs e)
    {
        if (displayListBox.SelectedIndex != -1)
            displayListBox.Items.RemoveAt(displayListBox.SelectedIndex);
    }

    private void clearButton_Click(object sender, EventArgs e)
    {
        displayListBox.Items.Clear();
    }

    private void InitializeComponent()
    {
        this.displayListBox = new System.Windows.Forms.ListBox();
        this.inputTextBox = new System.Windows.Forms.TextBox();
        this.addButton = new System.Windows.Forms.Button();
        this.removeButton = new System.Windows.Forms.Button();
        this.clearButton = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // displayListBox
        // 
        this.displayListBox.FormattingEnabled = true;
        this.displayListBox.Location = new System.Drawing.Point(13, 12);
        this.displayListBox.Name = "displayListBox";
        this.displayListBox.Size = new System.Drawing.Size(119, 238);
        this.displayListBox.TabIndex = 0;
        // 
        // inputTextBox
        // 
        this.inputTextBox.Location = new System.Drawing.Point(149, 12);
        this.inputTextBox.Name = "inputTextBox";
        this.inputTextBox.Size = new System.Drawing.Size(100, 20);
        this.inputTextBox.TabIndex = 1;
        // 
        // addButton
        // 
        this.addButton.Location = new System.Drawing.Point(149, 56);
        this.addButton.Name = "addButton";
        this.addButton.Size = new System.Drawing.Size(100, 36);
        this.addButton.TabIndex = 2;
        this.addButton.Text = "Add";
        this.addButton.Click += new System.EventHandler(this.addButton_Click);
        // 
        // removeButton
        // 
        this.removeButton.Location = new System.Drawing.Point(149, 109);
        this.removeButton.Name = "removeButton";
        this.removeButton.Size = new System.Drawing.Size(100, 36);
        this.removeButton.TabIndex = 3;
        this.removeButton.Text = "Remove";
        this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
        // 
        // clearButton
        // 
        this.clearButton.Location = new System.Drawing.Point(149, 165);
        this.clearButton.Name = "clearButton";
        this.clearButton.Size = new System.Drawing.Size(100, 36);
        this.clearButton.TabIndex = 4;
        this.clearButton.Text = "Clear";
        this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
        // ListBoxTestForm
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(263, 268);
        this.Controls.Add(this.clearButton);
        this.Controls.Add(this.removeButton);
        this.Controls.Add(this.addButton);
        this.Controls.Add(this.inputTextBox);
        this.Controls.Add(this.displayListBox);
        this.Name = "ListBoxTestForm";
        this.Text = "ListBoxTest";
        this.ResumeLayout(false);
        this.PerformLayout();

    }

    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.Run(new Form1());
    }

}


