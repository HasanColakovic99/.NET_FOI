
namespace Zadatak14
{
    partial class Form1
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
            this.prvaLista = new System.Windows.Forms.ListBox();
            this.drugaLista = new System.Windows.Forms.ListBox();
            this.trecaLista = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dodajUTimButton = new System.Windows.Forms.Button();
            this.ukloniIzTimaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prvaLista
            // 
            this.prvaLista.FormattingEnabled = true;
            this.prvaLista.ItemHeight = 16;
            this.prvaLista.Location = new System.Drawing.Point(32, 48);
            this.prvaLista.Name = "prvaLista";
            this.prvaLista.Size = new System.Drawing.Size(271, 388);
            this.prvaLista.TabIndex = 0;
            this.prvaLista.SelectedIndexChanged += new System.EventHandler(this.prvaLista_SelectedIndexChanged);
            // 
            // drugaLista
            // 
            this.drugaLista.FormattingEnabled = true;
            this.drugaLista.ItemHeight = 16;
            this.drugaLista.Location = new System.Drawing.Point(320, 48);
            this.drugaLista.Name = "drugaLista";
            this.drugaLista.Size = new System.Drawing.Size(271, 388);
            this.drugaLista.TabIndex = 1;
            this.drugaLista.SelectedIndexChanged += new System.EventHandler(this.DodajStudentaUTim);
            // 
            // trecaLista
            // 
            this.trecaLista.FormattingEnabled = true;
            this.trecaLista.ItemHeight = 16;
            this.trecaLista.Location = new System.Drawing.Point(606, 48);
            this.trecaLista.Name = "trecaLista";
            this.trecaLista.Size = new System.Drawing.Size(271, 388);
            this.trecaLista.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 460);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "+ Novi student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dodajUTimButton
            // 
            this.dodajUTimButton.Location = new System.Drawing.Point(192, 460);
            this.dodajUTimButton.Name = "dodajUTimButton";
            this.dodajUTimButton.Size = new System.Drawing.Size(111, 53);
            this.dodajUTimButton.TabIndex = 4;
            this.dodajUTimButton.Text = ">> Dodaj u tim";
            this.dodajUTimButton.UseVisualStyleBackColor = true;
            this.dodajUTimButton.Click += new System.EventHandler(this.dodajUTimButton_Click);
            // 
            // ukloniIzTimaButton
            // 
            this.ukloniIzTimaButton.Location = new System.Drawing.Point(606, 460);
            this.ukloniIzTimaButton.Name = "ukloniIzTimaButton";
            this.ukloniIzTimaButton.Size = new System.Drawing.Size(135, 53);
            this.ukloniIzTimaButton.TabIndex = 5;
            this.ukloniIzTimaButton.Text = "<< Ukloni iz tima";
            this.ukloniIzTimaButton.UseVisualStyleBackColor = true;
            this.ukloniIzTimaButton.Click += new System.EventHandler(this.ukloniIzTimaButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 656);
            this.Controls.Add(this.ukloniIzTimaButton);
            this.Controls.Add(this.dodajUTimButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.trecaLista);
            this.Controls.Add(this.drugaLista);
            this.Controls.Add(this.prvaLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox prvaLista;
        private System.Windows.Forms.ListBox drugaLista;
        private System.Windows.Forms.ListBox trecaLista;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button dodajUTimButton;
        private System.Windows.Forms.Button ukloniIzTimaButton;
    }
}

