using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreyPredator
{
    public partial class Form1 : Form
    {
        PreyPreadtor.Environment environment;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            environment = new PreyPreadtor.Environment(panel1.CreateGraphics());
            environment.initAgents((int)numericUpDownGrass.Value, (int)numericUpDownPreys.Value, (int)numericUpDownPredators.Value);
            
            timerMain.Enabled = true;
            timerMain.Interval = (1500 - trackBarSpeed.Value);
        }

        private void trackBarSpeed_Scroll(object sender, EventArgs e)
        {
            timerMain.Interval = (1500-trackBarSpeed.Value);
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            timerMain.Enabled = false;
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            environment.RunSimulation();
        }
    }
}
