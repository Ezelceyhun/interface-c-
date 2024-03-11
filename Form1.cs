using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        interface pc
        {
            void masaustu();
            void laptop();
        }
        class hp : pc, hpİnterface
        {
            public string ad {  get; set; }
            public int fiyat {  get; set; }
            public void masaustu() 
            {
                ad = "oyuncu kasası";
                fiyat = 5000;
            }
            public void laptop() 
            {
                ad = "oyuncu laptop";
                fiyat = 2000;
            }

            public void laptophp()
            {
                ad = "hp laptop";
                fiyat = 12000;
            }
        }
        interface hpİnterface
        {
            void laptophp();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hp hp = new hp();
            hp.masaustu();
            textBox1.Text = hp.ad + " " + hp.fiyat + Environment.NewLine;
            hp.laptop();
            textBox1.Text += hp.ad + " " + hp.fiyat + Environment.NewLine;
            hp.laptophp();
            textBox1.Text += hp.ad + " " + hp.fiyat + Environment.NewLine;
        }
    }
}
