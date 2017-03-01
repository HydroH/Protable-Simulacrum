using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portable_Simulacrum
{
    public partial class NumericLeftRight : UserControl
    {
        public NumericUpDown NumericUpDown
        {
            get
            {
                return nudControl;
            }
        }
        public event EventHandler ValueChanged;

        public NumericLeftRight()
        {
            InitializeComponent();
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            nudControl.DownButton();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            nudControl.UpButton();
        }

        private void nudControl_ValueChanged(object sender, EventArgs e)
        {
            ValueChanged(sender, e);
        }
    }
}
