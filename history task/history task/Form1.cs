using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;

namespace history_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////cach 1
            //// link http://stackoverflow.com/questions/7095359/putting-a-txt-file-into-a-datagridview6
            ////var fileName = this.openFileDialog1.FileName;
            //try
            //{
            //    string fileName = "test.txt";
            //    var rows = System.IO.File.ReadAllLines(fileName);
            //    Char[] separator = new Char[] { ' ' };
            //    DataTable tbl = new DataTable(fileName);
            //    if (rows.Length != 0)
            //    {
            //        foreach (string headerCol in rows[0].Split(separator))
            //        {
            //            tbl.Columns.Add(new DataColumn(headerCol));
            //        }
            //        foreach (string headerCol in rows[2].Split(separator))
            //        {
            //            tbl.Columns.Add(new DataColumn(headerCol));
            //        }
            //        //if (rows.Length > 1)
            //        //{
            //        //    for (int rowIndex = 1; rowIndex < rows.Length; rowIndex++)
            //        //    {
            //        //        var newRow = tbl.NewRow();
            //        //        var cols = rows[rowIndex].Split(separator);
            //        //        for (int colIndex = 0; colIndex < cols.Length; colIndex++)
            //        //        {
            //        //            newRow[colIndex] = cols[colIndex];
            //        //        }
            //        //        tbl.Rows.Add(newRow);
            //        //    }
            //        //}
            //    }
            //    dataGridView1.DataSource = tbl;
            //}
            //catch (Exception )
            //{

            //    //MessageBox.Show(e.ToString());
            //    throw;
            //}

            //string filePath = string.Format("{0}/databases/{1}", AppDomain.CurrentDomain.BaseDirectory, "user_db.txt");
            /******** cacnh 2****/

            string filePath = "test.txt";
            string[] textData = System.IO.File.ReadAllLines(filePath);
            string[] headers = textData[0].Split('\t');

            DataTable dataTable1 = new DataTable();

            foreach (string header in headers)
                dataTable1.Columns.Add(header, typeof(string), null);

            for (int i = 1; i < textData.Length; i++)
            {
                dataTable1.Rows.Add(textData[i].Split('\t'));
            }
            dataGridView1.DataSource = dataTable1;

            /******cach 3********/

             //  usersDataGridView.DataSource = User.LoadUserListFromFile("test.txt");
            //}//form_load

            //public string Id { get; set; }
            //public string Name { get; set; }
            //public string Surname { get; set; }
            //public string Telephone { get; set; }
            //public bool Vip { get; set; }
            //public int Age { get; set; }
            //public decimal Balance { get; set; }
            ////List <string>User="";       

            //public static List<User> LoadUserListFromFile(string path)
            //{
            //    var users = new List<User>();

            //    foreach (var line in File.ReadAllLines(path))
            //    {
            //        var columns = line.Split('\t');
            //        users.Add(new User
            //        {
            //            Id = columns[0],
            //            Name = columns[1],
            //            Surname = columns[2],
            //            Telephone = columns[3],
            //            Vip = columns[4] == "1",
            //            Age = Convert.ToInt32(columns[5]),
            //            Balance = Convert.ToDecimal(columns[6])
            //        });
            //    }
            //    return users;
            //}
        }
    }
}
