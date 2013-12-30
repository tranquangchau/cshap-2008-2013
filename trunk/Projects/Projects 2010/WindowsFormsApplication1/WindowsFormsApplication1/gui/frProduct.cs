using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.gui
{
    public partial class frProduct : Form
    {
        public frProduct()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validate form
            string error = ProductBill.checkForm(Form, obj);
            //if error
            if (error != "")
            {
                MessageBox.Show(error);
                return;
            }
            if (obj == null)//add new
            {
                obj = doInput(obj);
                if (new ProductBill().insert(obj))
                {
                    obj = null;
                    MessageBox.Show(Defaul.AddNewSuccess);
                }
            }
        }
    }
}
