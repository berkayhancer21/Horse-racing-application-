using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp40
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int birinciatsolauzaklık, ikinciatsolauzaklık, ucuncuatsolauzaklık;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int derece = Convert.ToInt32(label7.Text);
            derece++;
            label7.Text = derece.ToString();
            int birinciatingenisligi = pictureBox1.Width;
            int ikinciatingenisligi = pictureBox2.Width;
            int ucuncuatingenisligi = pictureBox3.Width;

            int bitisuzakligi = label5.Left;

            pictureBox1.Left = pictureBox1.Left + rnd.Next(5, 15);
            pictureBox2.Left = pictureBox2.Left + rnd.Next(5, 15);
            pictureBox3.Left = pictureBox3.Left + rnd.Next(5, 15);

            if(pictureBox1.Left>pictureBox2.Left+5 && pictureBox1.Left>=pictureBox3.Left+5)
            {
                label6.Text = "1 NUMARALI AT YARIŞI ÖNDE GÖTÜRÜYOR.";
            }

            if (pictureBox2.Left > pictureBox1.Left + 5 && pictureBox2.Left >= pictureBox3.Left + 5)
            {
                label6.Text = "2 NUMARALI AT İYİ BİR ATAKLA ÖNE GEÇTİ.";
            }

            if (pictureBox3.Left > pictureBox1.Left + 5 && pictureBox3.Left >= pictureBox2.Left + 5)
            {
                label6.Text = "3 NUMARALI AT DESTAN YAZDI.SAPLAAAA!!!";
            }

            if (birinciatingenisligi+pictureBox1.Left>=bitisuzakligi)
            {
                timer1.Enabled = false;
                label6.Text = "1 NUMARALI AT KAZANDI!!!";
            }

            if(ikinciatingenisligi+pictureBox2.Left>=bitisuzakligi)
            {
                timer1.Enabled = false;
                label6.Text="2 NUMARALI AT KAZANDI!!!";
            }

            if(ucuncuatingenisligi+pictureBox3.Left>=bitisuzakligi)
            {
                timer1.Enabled = false;
                label6.Text = "3 NUMARALI AT KAZANDI!!!";
            }

            
        }

        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            birinciatsolauzaklık = pictureBox1.Left;
            ikinciatsolauzaklık = pictureBox2.Left;
            ucuncuatsolauzaklık = pictureBox3.Left;
        }
    }
}
