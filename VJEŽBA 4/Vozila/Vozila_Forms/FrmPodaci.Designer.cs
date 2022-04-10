namespace Vozila_Forms_DllRef
{
    partial class FrmPodaci
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
            this.rbAutomobil = new System.Windows.Forms.RadioButton();
            this.rbMotocikl = new System.Windows.Forms.RadioButton();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnSpremi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbAutomobil
            // 
            this.rbAutomobil.AutoSize = true;
            this.rbAutomobil.Checked = true;
            this.rbAutomobil.Location = new System.Drawing.Point(119, 21);
            this.rbAutomobil.Name = "rbAutomobil";
            this.rbAutomobil.Size = new System.Drawing.Size(91, 21);
            this.rbAutomobil.TabIndex = 0;
            this.rbAutomobil.TabStop = true;
            this.rbAutomobil.Text = "Automobil";
            this.rbAutomobil.UseVisualStyleBackColor = true;
            // 
            // rbMotocikl
            // 
            this.rbMotocikl.AutoSize = true;
            this.rbMotocikl.Location = new System.Drawing.Point(119, 48);
            this.rbMotocikl.Name = "rbMotocikl";
            this.rbMotocikl.Size = new System.Drawing.Size(80, 21);
            this.rbMotocikl.TabIndex = 1;
            this.rbMotocikl.TabStop = true;
            this.rbMotocikl.Text = "Motocikl";
            this.rbMotocikl.UseVisualStyleBackColor = true;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(154, 81);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(168, 22);
            this.txtNaziv.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dodavanje novog vozila";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naziv vozila";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAutomobil);
            this.groupBox1.Controls.Add(this.rbMotocikl);
            this.groupBox1.Location = new System.Drawing.Point(35, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tip vozila";
            // 
            // btnOdustani
            // 
            this.btnOdustani.Location = new System.Drawing.Point(196, 215);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(126, 23);
            this.btnOdustani.TabIndex = 6;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnSpremi
            // 
            this.btnSpremi.Location = new System.Drawing.Point(196, 244);
            this.btnSpremi.Name = "btnSpremi";
            this.btnSpremi.Size = new System.Drawing.Size(128, 23);
            this.btnSpremi.TabIndex = 7;
            this.btnSpremi.Text = "Spremi";
            this.btnSpremi.UseVisualStyleBackColor = true;
            this.btnSpremi.Click += new System.EventHandler(this.btnSpremi_Click);
            // 
            // FrmDodavanje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 287);
            this.Controls.Add(this.btnSpremi);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNaziv);
            this.Name = "FrmDodavanje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dodavanje vozila";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbAutomobil;
        private System.Windows.Forms.RadioButton rbMotocikl;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnSpremi;
    }
}