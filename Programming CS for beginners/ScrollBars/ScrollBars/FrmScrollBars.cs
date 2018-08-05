using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollBars
{
    public partial class FrmScrollBars : Form
    {
        public FrmScrollBars()
        {
            InitializeComponent();
        }

        private void HsbDemo_Scroll(object sender, ScrollEventArgs e)
        {
            LblDemo.Text = HsbDemo.Value.ToString();
        }
    }
}
