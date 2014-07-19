using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace q2a_now
{
    class Class1
    {
        private bool brandom1 = true;
        /// <summary>
        /// Show or Hide control
        /// </summary>
        /// <param name="control1"></param>
        public void random1(Control control1)
        {
            if (brandom1==true)
            {
                control1.Show();
                brandom1 = false;
            }
            else
            {
                control1.Hide();
                brandom1 = true;
            }
        }
    }
}
