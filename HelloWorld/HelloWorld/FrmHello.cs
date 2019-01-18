using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    public partial class FrmHello : Form
    {
        public FrmHello()
        {
            InitializeComponent();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello world");
        }
    }
}
