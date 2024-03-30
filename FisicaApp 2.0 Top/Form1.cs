namespace FisicaApp_2._0_Top
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Todas as unidades estão no padrão universal:  metros, segundos, m/s²e m/s");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public decimal Aceleracao(decimal v, decimal t)
        {
            return v / t;
        }
        public decimal VelMedia(decimal t, decimal s)
        {
            return s / t;
        }
        public decimal Torricelli(decimal v, decimal a, decimal s)
        {
            return (decimal)Math.Sqrt((double)((v * v) + 2 * a * s));
        }
        public decimal Mu(decimal v, decimal t, decimal s)
        {
            return s + (v * t);
        }
        private void btCalc_Click(object sender, EventArgs e)
        {
            decimal s = nmEsp.Value;
            decimal v = nmVel.Value;
            decimal t = nmTemp.Value;
            decimal a, vm, to, mu;

            if (rbAcel.Checked)
            {
                a = Aceleracao(v, t);
                res.Text = a.ToString("F1") + "m/s²";

            }
            else if (rbVm.Checked)
            {
                vm = VelMedia(t, s);
                res.Text = vm.ToString("F1") + "m/s";
            }
            else if (rbTo.Checked)
            {
                to = Torricelli(v, t, s);
                res.Text = to.ToString("F1") + "m/s";
            }
            else if (rbMu.Checked)
            {
                mu = Mu(v, t, s);
                res.Text = mu.ToString("F1") + "m";
            }
        }

        private void rbAcel_CheckedChanged(object sender, EventArgs e)
        {
            lbEsp.Enabled = false;
            nmEsp.Enabled = false;
            nmVel.Enabled = true;
            lbVel.Enabled = true;
            lbTemp.Text = "Tempo";
            btCalc.Enabled = false;

        }

        private void rbVm_CheckedChanged(object sender, EventArgs e)
        {
            lbVel.Enabled = false;
            nmVel.Enabled = false;
            lbEsp.Enabled = true;
            lbTemp.Text = "Tempo";
            nmEsp.Enabled = true;
            btCalc.Enabled = false;
        }

        private void rbTo_CheckedChanged(object sender, EventArgs e)
        {
            lbTemp.Text = "Aceleração";
            nmVel.Enabled = true;
            lbVel.Enabled = true;
            nmEsp.Enabled = true;
            lbEsp.Enabled = true;
            btCalc.Enabled = true;
        }

        private void tbMuv_CheckedChanged(object sender, EventArgs e)
        {
            nmVel.Enabled = true;
            lbVel.Enabled = true;
            lbTemp.Enabled = true;
            lbTemp.Text = "Tempo";
            nmEsp.Enabled = true;
            lbEsp.Enabled = true;
            btCalc.Enabled = true;


        }

        private void nmTemp_ValueChanged(object sender, EventArgs e)
        {
            if (nmTemp.Value == 0)
            {
                if(rbAcel.Checked || rbVm.Checked)
                {
                    btCalc.Enabled = false;
                }
                
                
            }else
                {
                    btCalc.Enabled = true;
                }
        }
    }
}
