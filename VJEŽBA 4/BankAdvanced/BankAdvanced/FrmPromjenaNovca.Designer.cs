
namespace BankAdvanced
{
    partial class FrmPromjenaNovca
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
            this.cmbIzvorisnaValuta = new System.Windows.Forms.ComboBox();
            this.cmbOdredisnaValuta = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIznosIzvorisna = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPromijeni = new System.Windows.Forms.Button();
            this.btnIzlaz = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIznosOdredisna = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Izvorišna valuta:";
            // 
            // cmbIzvorisnaValuta
            // 
            this.cmbIzvorisnaValuta.FormattingEnabled = true;
            this.cmbIzvorisnaValuta.Location = new System.Drawing.Point(113, 17);
            this.cmbIzvorisnaValuta.Name = "cmbIzvorisnaValuta";
            this.cmbIzvorisnaValuta.Size = new System.Drawing.Size(156, 21);
            this.cmbIzvorisnaValuta.TabIndex = 1;
            // 
            // cmbOdredisnaValuta
            // 
            this.cmbOdredisnaValuta.FormattingEnabled = true;
            this.cmbOdredisnaValuta.Location = new System.Drawing.Point(113, 70);
            this.cmbOdredisnaValuta.Name = "cmbOdredisnaValuta";
            this.cmbOdredisnaValuta.Size = new System.Drawing.Size(156, 21);
            this.cmbOdredisnaValuta.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Odredišna valuta:";
            // 
            // txtIznosIzvorisna
            // 
            this.txtIznosIzvorisna.Location = new System.Drawing.Point(194, 44);
            this.txtIznosIzvorisna.Name = "txtIznosIzvorisna";
            this.txtIznosIzvorisna.Size = new System.Drawing.Size(75, 20);
            this.txtIznosIzvorisna.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Izvorišni iznos:";
            // 
            // btnPromijeni
            // 
            this.btnPromijeni.Location = new System.Drawing.Point(113, 123);
            this.btnPromijeni.Name = "btnPromijeni";
            this.btnPromijeni.Size = new System.Drawing.Size(75, 23);
            this.btnPromijeni.TabIndex = 6;
            this.btnPromijeni.Text = "Promijeni";
            this.btnPromijeni.UseVisualStyleBackColor = true;
            this.btnPromijeni.Click += new System.EventHandler(this.btnPromijeni_Click);
            // 
            // btnIzlaz
            // 
            this.btnIzlaz.Location = new System.Drawing.Point(194, 123);
            this.btnIzlaz.Name = "btnIzlaz";
            this.btnIzlaz.Size = new System.Drawing.Size(75, 23);
            this.btnIzlaz.TabIndex = 7;
            this.btnIzlaz.Text = "Izlaz";
            this.btnIzlaz.UseVisualStyleBackColor = true;
            this.btnIzlaz.Click += new System.EventHandler(this.btnIzlaz_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Odredišni iznos:";
            // 
            // txtIznosOdredisna
            // 
            this.txtIznosOdredisna.Enabled = false;
            this.txtIznosOdredisna.Location = new System.Drawing.Point(194, 97);
            this.txtIznosOdredisna.Name = "txtIznosOdredisna";
            this.txtIznosOdredisna.Size = new System.Drawing.Size(75, 20);
            this.txtIznosOdredisna.TabIndex = 8;
            // 
            // FrmPromjenaNovca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 160);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIznosOdredisna);
            this.Controls.Add(this.btnIzlaz);
            this.Controls.Add(this.btnPromijeni);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIznosIzvorisna);
            this.Controls.Add(this.cmbOdredisnaValuta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbIzvorisnaValuta);
            this.Controls.Add(this.label1);
            this.Name = "FrmPromjenaNovca";
            this.Text = "Promjena novca";
            this.Load += new System.EventHandler(this.FrmPromjenaNovca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbIzvorisnaValuta;
        private System.Windows.Forms.ComboBox cmbOdredisnaValuta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIznosIzvorisna;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPromijeni;
        private System.Windows.Forms.Button btnIzlaz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIznosOdredisna;
    }
}