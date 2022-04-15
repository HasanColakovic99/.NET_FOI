using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Filmovi
{
    public partial class Form1 : Form
    {
        StreamingServis servis = new StreamingServis();
        public Form1()
        {
            InitializeComponent();
        }

        public void PrikaziZapoceteFilmove()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = servis.DohvatiZapoceteFilmove();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PrikaziZapoceteFilmove();
        }
    }
}
