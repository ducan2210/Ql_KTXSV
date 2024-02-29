using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thuVienControls;
namespace Main
{
    public partial class testKM : Form
    {

        public testKM()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThuatToanKMeans tt = new ThuatToanKMeans();
            textBox3.Text = tt.TimPhongPhuHop(textBox1.Text, textBox2.Text);

        }

    }
}
