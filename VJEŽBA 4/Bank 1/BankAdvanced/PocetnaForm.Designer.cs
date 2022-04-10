namespace BankAdvanced
{
    partial class PocetnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.izbornik = new System.Windows.Forms.MenuStrip();
            this.bankaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popisKlijenataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajKlijentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.popisRacunaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otvoriNoviRačunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekućiRačunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devizniRačunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transakcijeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.popisTransakcijaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novaTransakcijaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.izbornik.SuspendLayout();
            this.SuspendLayout();
            // 
            // izbornik
            // 
            this.izbornik.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.izbornik.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bankaToolStripMenuItem,
            this.transakcijeToolStripMenuItem});
            this.izbornik.Location = new System.Drawing.Point(0, 0);
            this.izbornik.Name = "izbornik";
            this.izbornik.Size = new System.Drawing.Size(800, 28);
            this.izbornik.TabIndex = 1;
            this.izbornik.Text = "menuStrip1";
            // 
            // bankaToolStripMenuItem
            // 
            this.bankaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popisKlijenataToolStripMenuItem,
            this.kreirajKlijentaToolStripMenuItem,
            this.toolStripMenuItem2,
            this.popisRacunaToolStripMenuItem,
            this.otvoriNoviRačunToolStripMenuItem});
            this.bankaToolStripMenuItem.Name = "bankaToolStripMenuItem";
            this.bankaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.bankaToolStripMenuItem.Text = "Računi";
            // 
            // popisKlijenataToolStripMenuItem
            // 
            this.popisKlijenataToolStripMenuItem.Name = "popisKlijenataToolStripMenuItem";
            this.popisKlijenataToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.popisKlijenataToolStripMenuItem.Text = "Popis klijenata";
            this.popisKlijenataToolStripMenuItem.Click += new System.EventHandler(this.popisKlijenataToolStripMenuItem_Click);
            // 
            // kreirajKlijentaToolStripMenuItem
            // 
            this.kreirajKlijentaToolStripMenuItem.Name = "kreirajKlijentaToolStripMenuItem";
            this.kreirajKlijentaToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.kreirajKlijentaToolStripMenuItem.Text = "Kreiraj klijenta";
            this.kreirajKlijentaToolStripMenuItem.Click += new System.EventHandler(this.kreirajKlijentaToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(194, 6);
            // 
            // popisRacunaToolStripMenuItem
            // 
            this.popisRacunaToolStripMenuItem.Name = "popisRacunaToolStripMenuItem";
            this.popisRacunaToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.popisRacunaToolStripMenuItem.Text = "Popis računa";
            this.popisRacunaToolStripMenuItem.Click += new System.EventHandler(this.popisRacunaToolStripMenuItem_Click);
            // 
            // otvoriNoviRačunToolStripMenuItem
            // 
            this.otvoriNoviRačunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tekućiRačunToolStripMenuItem,
            this.devizniRačunToolStripMenuItem});
            this.otvoriNoviRačunToolStripMenuItem.Name = "otvoriNoviRačunToolStripMenuItem";
            this.otvoriNoviRačunToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.otvoriNoviRačunToolStripMenuItem.Text = "Otvori novi račun";
            // 
            // tekućiRačunToolStripMenuItem
            // 
            this.tekućiRačunToolStripMenuItem.Name = "tekućiRačunToolStripMenuItem";
            this.tekućiRačunToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.tekućiRačunToolStripMenuItem.Text = "Tekući račun";
            this.tekućiRačunToolStripMenuItem.Click += new System.EventHandler(this.tekućiRačunToolStripMenuItem_Click);
            // 
            // devizniRačunToolStripMenuItem
            // 
            this.devizniRačunToolStripMenuItem.Name = "devizniRačunToolStripMenuItem";
            this.devizniRačunToolStripMenuItem.Size = new System.Drawing.Size(173, 26);
            this.devizniRačunToolStripMenuItem.Text = "Devizni račun";
            this.devizniRačunToolStripMenuItem.Click += new System.EventHandler(this.devizniRačunToolStripMenuItem_Click);
            // 
            // transakcijeToolStripMenuItem
            // 
            this.transakcijeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.popisTransakcijaToolStripMenuItem,
            this.novaTransakcijaToolStripMenuItem1});
            this.transakcijeToolStripMenuItem.Name = "transakcijeToolStripMenuItem";
            this.transakcijeToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.transakcijeToolStripMenuItem.Text = "Transakcije";
            // 
            // popisTransakcijaToolStripMenuItem
            // 
            this.popisTransakcijaToolStripMenuItem.Name = "popisTransakcijaToolStripMenuItem";
            this.popisTransakcijaToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.popisTransakcijaToolStripMenuItem.Text = "Popis transakcija";
            this.popisTransakcijaToolStripMenuItem.Click += new System.EventHandler(this.popisTransakcijaToolStripMenuItem_Click);
            // 
            // novaTransakcijaToolStripMenuItem1
            // 
            this.novaTransakcijaToolStripMenuItem1.Name = "novaTransakcijaToolStripMenuItem1";
            this.novaTransakcijaToolStripMenuItem1.Size = new System.Drawing.Size(193, 26);
            this.novaTransakcijaToolStripMenuItem1.Text = "Nova transakcija";
            this.novaTransakcijaToolStripMenuItem1.Click += new System.EventHandler(this.novaTransakcijaToolStripMenuItem1_Click);
            // 
            // PocetnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.izbornik);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.izbornik;
            this.Name = "PocetnaForm";
            this.Text = "Početna forma";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.PocetnaForm_Load);
            this.izbornik.ResumeLayout(false);
            this.izbornik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip izbornik;
        private System.Windows.Forms.ToolStripMenuItem bankaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popisRacunaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transakcijeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popisTransakcijaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novaTransakcijaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem otvoriNoviRačunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem popisKlijenataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajKlijentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tekućiRačunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devizniRačunToolStripMenuItem;
    }
}

