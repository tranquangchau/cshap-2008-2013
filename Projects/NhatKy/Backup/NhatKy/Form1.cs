using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NhatKy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSucKhoe sk = new frmSucKhoe();
            sk.Show();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            label2.Text = "Gieo Suy Nghĩ, Gặt Hành Động;\n Gieo Hành Động, Gặt Thói Quen \n Gieo Thói Quen, Gặt Tính Cách;\n Gieo Tính Cách, Gặt Số Phận";
            toolStripStatusLabel4.Text = DateTime.Now.ToString();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmCamXuc cx = new frmCamXuc();
            cx.Show();           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmKienThuc kt = new frmKienThuc();
            kt.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmQuanHe qh = new frmQuanHe();
            qh.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmTriTue tt = new frmTriTue();
            tt.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmVanHoa vh = new frmVanHoa();
            vh.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmYChi yc = new frmYChi();
            yc.Show();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            frmGhiChep gc = new frmGhiChep();
            gc.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            frmThoikhoabieu frmtkb = new frmThoikhoabieu();
            frmtkb.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            frmThoiQuen tq = new frmThoiQuen();
            tq.Show();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            frmMucTieu mt = new frmMucTieu();
            mt.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            frmDayli dl = new frmDayli();
            dl.Show();
        }

        private void button17_MouseLeave(object sender, EventArgs e)
        {
            button17.Text = "";
            //button17.Text.
            button17.ForeColor = Color.Black;
            //button17.Font = new Font(button17.Font, FontStyle.Bold);
            button17.BackColor = Color.Black;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            frmLearNing ln = new frmLearNing();
            ln.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            thoigianbieu tkb = new thoigianbieu();
            tkb.Show();
        }

        private void richTextBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Random randomcolor = new Random();
            this.richTextBox1.ForeColor = Color.FromArgb(randomcolor.Next(0, 256), randomcolor.Next(0, 256), randomcolor.Next(0, 256));
        }      

        private void richTextBox2_MouseMove(object sender, MouseEventArgs e)
        {
            Random randomcolor1 = new Random();
            this.richTextBox2.ForeColor = Color.FromArgb(randomcolor1.Next(0, 256), randomcolor1.Next(0, 256), randomcolor1.Next(0, 256));
        }

        private void Form1_Click(object sender, EventArgs e)
        {            
            toolStripStatusLabel4.Text = DateTime.Now.ToString();
        }




        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gửi yêu cầu tới địa chỉ email tranquangchau155@gmail.com để được câu trả lời!");
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần mềm được tạo bởi chautranquang \n" +
            "Với mong muốn ghi chép lại cuộc sống để dễ dàng quản lý hơn \n" +
            "Phiên bản hiện tại vision 4");
        }

        private void toolStripStatusLabel5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
