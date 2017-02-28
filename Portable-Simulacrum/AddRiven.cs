using System;
using System.Windows.Forms;

namespace Portable_Simulacrum
{
    public partial class AddRiven : Form
    {
        public Mod rivenMod { get; private set; }

        public AddRiven()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            rivenMod = new Mod(new double[] {
                (double)nudBase.Value/100,
                (double)nudMulti.Value/100,
                (double)nudCritChan.Value/100,
                (double)nudCritMult.Value/100,
                (double)nudStatChan.Value/100,
                (double)nudImpact.Value/100,
                (double)nudPunc.Value/100,
                (double)nudSlash.Value/100,
                (double)nudCold.Value/100,
                (double)nudElec.Value/100,
                (double)nudHeat.Value/100,
                (double)nudToxin.Value/100,
                (double)nudFireRate.Value/100,
                (double)nudClip.Value/100,
                (double)nudReload.Value/100,
            });
            Hide();
        }
    }
}
