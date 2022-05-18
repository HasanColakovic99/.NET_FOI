using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STATE_Oven
{
    public partial class FrmPecnica : Form
    {
        Pecnica pecnica = new Pecnica();
        public FrmPecnica()
        {
            InitializeComponent();
        }

        private void FrmPerilica_Load(object sender, EventArgs e)
        {
           
            Osvjezi();
        }

        public void Osvjezi()
        {
            StanjePecnice.Stanje stanje = pecnica.Stanje.trenutnoStanje;

            btn150C.Enabled = stanje == StanjePecnice.Stanje.Upaljena || stanje == StanjePecnice.Stanje.PecenjeZapoceto;
            btn180C.Enabled = stanje == StanjePecnice.Stanje.Upaljena || stanje == StanjePecnice.Stanje.PecenjeZapoceto;
            btn200C.Enabled = stanje == StanjePecnice.Stanje.Upaljena || stanje == StanjePecnice.Stanje.PecenjeZapoceto;

            btnStart.Enabled = stanje == StanjePecnice.Stanje.ProgramOdabran;
            btnIstekloVrijeme.Enabled = stanje == StanjePecnice.Stanje.PecenjeZapoceto;
            btnOhladiPecnicu.Enabled = stanje == StanjePecnice.Stanje.PecenjeZavrseno;

            btnOnOff.Enabled = stanje == StanjePecnice.Stanje.HladenjeGotovo || stanje == StanjePecnice.Stanje.Ugasena || stanje == StanjePecnice.Stanje.Upaljena;
        }

        private void btnOnOff_Click(object sender, EventArgs e)
        {
            StanjePecnice.Stanje stanje = pecnica.Stanje.trenutnoStanje;
            if(stanje == StanjePecnice.Stanje.Upaljena)
            {
                pecnica.Ugasi();
            }
            else if(stanje == StanjePecnice.Stanje.Ugasena || stanje == StanjePecnice.Stanje.HladenjeGotovo)
            {
                pecnica.Upali();
            }
            Osvjezi();
        }

        private void btn150C_Click(object sender, EventArgs e)
        {
            pecnica.OdaberiProgram(ProgramRada.Pečenje_150C);
            Osvjezi();
        }

        private void btn180C_Click(object sender, EventArgs e)
        {
            pecnica.OdaberiProgram(ProgramRada.Pečenje_180C);
            Osvjezi();
        }

        private void btn200C_Click(object sender, EventArgs e)
        {
            pecnica.OdaberiProgram(ProgramRada.Pečenje_200C);
            Osvjezi();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pecnica.ZapocniPecenje();
            Osvjezi();
        }

        private void btnIstekloVrijeme_Click(object sender, EventArgs e)
        {
            pecnica.OznaciKaoZavrseno();
            Osvjezi();
        }

        private void btnOhladiPecnicu_Click(object sender, EventArgs e)
        {
            pecnica.OhladiPecnicu();
            Osvjezi();
        }
    }
}
