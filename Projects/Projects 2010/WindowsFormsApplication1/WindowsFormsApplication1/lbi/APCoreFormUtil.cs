using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.lbi
{
    class APCoreFormUtil
    {
        public static void clearTexBox(Panel form)
        {
            foreach (Control ctl in form.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                {
                    TextBox txt = (TextBox)ctl;
                    txt.Clear();
                }
            }
        }
    }
}
