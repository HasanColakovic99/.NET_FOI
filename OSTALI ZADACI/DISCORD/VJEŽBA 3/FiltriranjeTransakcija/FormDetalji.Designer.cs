﻿
namespace FiltriranjeTransakcija
{
    partial class FormDetalji
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIBAN = new System.Windows.Forms.TextBox();
            this.textBoxVlasnik = new System.Windows.Forms.TextBox();
            this.textBoxPromet = new System.Windows.Forms.TextBox();
            this.textBoxStanje = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IBAN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vlasnik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Stanje:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ukupni promet:";
            // 
            // textBoxIBAN
            // 
            this.textBoxIBAN.Location = new System.Drawing.Point(146, 22);
            this.textBoxIBAN.Name = "textBoxIBAN";
            this.textBoxIBAN.Size = new System.Drawing.Size(127, 22);
            this.textBoxIBAN.TabIndex = 4;
            // 
            // textBoxVlasnik
            // 
            this.textBoxVlasnik.Location = new System.Drawing.Point(146, 56);
            this.textBoxVlasnik.Name = "textBoxVlasnik";
            this.textBoxVlasnik.Size = new System.Drawing.Size(127, 22);
            this.textBoxVlasnik.TabIndex = 5;
            // 
            // textBoxPromet
            // 
            this.textBoxPromet.Location = new System.Drawing.Point(146, 148);
            this.textBoxPromet.Name = "textBoxPromet";
            this.textBoxPromet.Size = new System.Drawing.Size(127, 22);
            this.textBoxPromet.TabIndex = 6;
            // 
            // textBoxStanje
            // 
            this.textBoxStanje.Location = new System.Drawing.Point(146, 115);
            this.textBoxStanje.Name = "textBoxStanje";
            this.textBoxStanje.Size = new System.Drawing.Size(127, 22);
            this.textBoxStanje.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(187, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 45);
            this.button1.TabIndex = 8;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 290);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxStanje);
            this.Controls.Add(this.textBoxPromet);
            this.Controls.Add(this.textBoxVlasnik);
            this.Controls.Add(this.textBoxIBAN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormDetalji";
            this.Text = "Detalji";
            this.Load += new System.EventHandler(this.FormDetalji_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIBAN;
        private System.Windows.Forms.TextBox textBoxVlasnik;
        private System.Windows.Forms.TextBox textBoxPromet;
        private System.Windows.Forms.TextBox textBoxStanje;
        private System.Windows.Forms.Button button1;
    }
}