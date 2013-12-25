using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KetNoiCSDL
{
    public partial class DnDtView : Form
    {
        public DnDtView()
        {
            InitializeComponent();
        }

        private void DnDtView_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            DataSet ds = new DataSet();
         ///   ds = DB.getDataSet("Sellection * From DmDt",CommandType);
        //    bSource.DataSource=ds.Tables[0];
        }
    }
}
