﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BankaLib;

namespace Zadatak5
{

    public partial class Detalji : Form
    {
        Racun racuni = new Racun();
        public Detalji(Racun racun)
        {
            InitializeComponent();
            this.racuni = racun;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Detalji_Load(object sender, EventArgs e)
        {
            textBox1.Text = racuni.IBAN;
            textBox2.Text = racuni.Vlasnik;
            textBox3.Text = racuni.Stanje.ToString();
            textBox4.Text = racuni.IzracunajUkupanPromet().ToString();
        }
    }
}
