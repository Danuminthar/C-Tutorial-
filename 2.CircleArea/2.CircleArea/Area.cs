using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2.CircleArea
{
    public partial class AreaOfCircle : Form
    {
        public AreaOfCircle()
        {
            InitializeComponent();
        }

        private void btm_Click(object sender, EventArgs e)
        {
            double dRadius;//Radius of circle in mm
            double dArea;//Area of circle in sq mm

            dRadius = double.Parse(txtRadius.Text.ToString());
            dArea = 3.1415 * dRadius * dRadius;
            txtArea.Text = dArea.ToString();
        }
    }
}
