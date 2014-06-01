using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CriticalPathBranch2
{
    public partial class SelectModeForm : Form
    {
        public Mode M;
        public SelectModeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            M = Mode.Simple;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            M = Mode.Sigma;
            Close();
        }
    }
}
