using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;


namespace DemoWindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cek_Click(object sender, EventArgs e)
        {
            int buatvariabelbaru = int.Parse(textBox1.Text);
            Terbilang Terbilang = new Terbilang();
            listBox1.Items.Clear();
            listBox1.Items.Add(Terbilang.TerbilangIndonesia(buatvariabelbaru));
        }
    }
}
