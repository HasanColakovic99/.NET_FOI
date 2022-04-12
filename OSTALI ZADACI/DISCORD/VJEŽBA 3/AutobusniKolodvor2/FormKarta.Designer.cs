
namespace AutobusniKolodvor2
{
    partial class FormKarta
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxPrtljaga = new System.Windows.Forms.CheckBox();
            this.checkBoxPovratna = new System.Windows.Forms.CheckBox();
            this.comboBoxVrstaKarte = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonIspisiKartu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxIspis = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxPrtljaga);
            this.groupBox1.Controls.Add(this.checkBoxPovratna);
            this.groupBox1.Controls.Add(this.comboBoxVrstaKarte);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(271, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcije karte:";
            // 
            // checkBoxPrtljaga
            // 
            this.checkBoxPrtljaga.AutoSize = true;
            this.checkBoxPrtljaga.Location = new System.Drawing.Point(80, 89);
            this.checkBoxPrtljaga.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxPrtljaga.Name = "checkBoxPrtljaga";
            this.checkBoxPrtljaga.Size = new System.Drawing.Size(78, 19);
            this.checkBoxPrtljaga.TabIndex = 4;
            this.checkBoxPrtljaga.Text = "Prtljaga?";
            this.checkBoxPrtljaga.UseVisualStyleBackColor = true;
            // 
            // checkBoxPovratna
            // 
            this.checkBoxPovratna.AutoSize = true;
            this.checkBoxPovratna.Location = new System.Drawing.Point(80, 58);
            this.checkBoxPovratna.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxPovratna.Name = "checkBoxPovratna";
            this.checkBoxPovratna.Size = new System.Drawing.Size(114, 19);
            this.checkBoxPovratna.TabIndex = 3;
            this.checkBoxPovratna.Text = "Povratna karta?";
            this.checkBoxPovratna.UseVisualStyleBackColor = true;
            // 
            // comboBoxVrstaKarte
            // 
            this.comboBoxVrstaKarte.FormattingEnabled = true;
            this.comboBoxVrstaKarte.Items.AddRange(new object[] {
            "Regularna",
            "Studentska"});
            this.comboBoxVrstaKarte.Location = new System.Drawing.Point(88, 20);
            this.comboBoxVrstaKarte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxVrstaKarte.Name = "comboBoxVrstaKarte";
            this.comboBoxVrstaKarte.Size = new System.Drawing.Size(92, 21);
            this.comboBoxVrstaKarte.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dodatno:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta karte:";
            // 
            // buttonIspisiKartu
            // 
            this.buttonIspisiKartu.Location = new System.Drawing.Point(174, 138);
            this.buttonIspisiKartu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIspisiKartu.Name = "buttonIspisiKartu";
            this.buttonIspisiKartu.Size = new System.Drawing.Size(75, 29);
            this.buttonIspisiKartu.TabIndex = 1;
            this.buttonIspisiKartu.Text = "Ispisi kartu";
            this.buttonIspisiKartu.UseVisualStyleBackColor = true;
            this.buttonIspisiKartu.Click += new System.EventHandler(this.buttonIspisiKartu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxIspis);
            this.groupBox2.Location = new System.Drawing.Point(9, 191);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(271, 153);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ispis karte:";
            // 
            // textBoxIspis
            // 
            this.textBoxIspis.Location = new System.Drawing.Point(4, 24);
            this.textBoxIspis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxIspis.Multiline = true;
            this.textBoxIspis.Name = "textBoxIspis";
            this.textBoxIspis.Size = new System.Drawing.Size(263, 124);
            this.textBoxIspis.TabIndex = 0;
            // 
            // FormKarta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 366);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonIspisiKartu);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormKarta";
            this.Text = "FormKarta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxVrstaKarte;
        private System.Windows.Forms.CheckBox checkBoxPovratna;
        private System.Windows.Forms.CheckBox checkBoxPrtljaga;
        private System.Windows.Forms.Button buttonIspisiKartu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxIspis;
    }
}