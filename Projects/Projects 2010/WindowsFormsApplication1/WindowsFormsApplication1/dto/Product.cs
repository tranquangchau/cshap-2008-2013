using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace WindowsFormsApplication1.dto
{
    class Product
    {
        //private, protected, public pham vi truy cap.
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string code;

        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public Product() //ko co tham so
        {
        }
        public Product(DataRow dr) //1 tham so gach vi chua co nam space
        {
            this.id = int.Parse(dr["id"].ToString());
            this.name = dr["name"].ToString();
            this.code = dr["code"].ToString();
            this.price = decimal.Parse(dr["price"].ToString());

        }
    }
    
}
