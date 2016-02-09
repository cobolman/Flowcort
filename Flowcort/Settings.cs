using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flowcort
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            double transparency = Convert.ToDouble(trackBar1.Value) / 10;
            this.Opacity = 1.0 - transparency;
        }

        private void Settings_Load(object sender, EventArgs e)
        {
        }

        private void buttonBar1_ButtonPush(object sender, EventArgs e)
        {
            MessageBox.Show("Button clicked : " + ((Button)sender).Text);
        }
    }
}
