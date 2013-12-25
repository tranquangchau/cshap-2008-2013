using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int _selectedIndex;
        string _text;
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            _text = comboBox1.Text;
            Display();
        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedIndex = comboBox1.SelectedIndex;
            Display();
        }

        void Display()
        {
            this.Text = string.Format("Text: {0}; SelectedIndex: {1}",_text,_selectedIndex);
        }
    }
}
