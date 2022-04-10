
namespace Zadatak2
{
    partial class Kreiranje_karte
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.polazisteTextBox = new System.Windows.Forms.TextBox();
            this.odredisteTextBox = new System.Windows.Forms.TextBox();
            this.udaljenostTextBox = new System.Windows.Forms.TextBox();
            this.prijevoznikTextBox = new System.Windows.Forms.TextBox();
            this.odaberiteLinijuButton = new System.Windows.Forms.Button();
            this.regularnaButton = new System.Windows.Forms.RadioButton();
            this.vrstaKarteGroup = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.studentskaButton = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.povratnaBox = new System.Windows.Forms.CheckBox();
            this.prtljagaBox = new System.Windows.Forms.CheckBox();
            this.kreirajKartuButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.brKarteTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cijenaKarteTextBox = new System.Windows.Forms.TextBox();
            this.vrstaKarteGroup.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Polazište";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Odredište";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Udaljenost (km)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prijevoznik";
            // 
            // polazisteTextBox
            // 
            this.polazisteTextBox.Location = new System.Drawing.Point(87, 25);
            this.polazisteTextBox.Name = "polazisteTextBox";
            this.polazisteTextBox.Size = new System.Drawing.Size(137, 22);
            this.polazisteTextBox.TabIndex = 5;
            // 
            // odredisteTextBox
            // 
            this.odredisteTextBox.Location = new System.Drawing.Point(87, 59);
            this.odredisteTextBox.Name = "odredisteTextBox";
            this.odredisteTextBox.Size = new System.Drawing.Size(137, 22);
            this.odredisteTextBox.TabIndex = 6;
            // 
            // udaljenostTextBox
            // 
            this.udaljenostTextBox.Location = new System.Drawing.Point(121, 94);
            this.udaljenostTextBox.Name = "udaljenostTextBox";
            this.udaljenostTextBox.Size = new System.Drawing.Size(103, 22);
            this.udaljenostTextBox.TabIndex = 7;
            // 
            // prijevoznikTextBox
            // 
            this.prijevoznikTextBox.Location = new System.Drawing.Point(90, 124);
            this.prijevoznikTextBox.Name = "prijevoznikTextBox";
            this.prijevoznikTextBox.Size = new System.Drawing.Size(134, 22);
            this.prijevoznikTextBox.TabIndex = 8;
            // 
            // odaberiteLinijuButton
            // 
            this.odaberiteLinijuButton.Location = new System.Drawing.Point(252, 25);
            this.odaberiteLinijuButton.Name = "odaberiteLinijuButton";
            this.odaberiteLinijuButton.Size = new System.Drawing.Size(127, 72);
            this.odaberiteLinijuButton.TabIndex = 9;
            this.odaberiteLinijuButton.Text = "Odaberite liniju";
            this.odaberiteLinijuButton.UseVisualStyleBackColor = true;
            this.odaberiteLinijuButton.Click += new System.EventHandler(this.odaberiteLinijuButton_Click);
            // 
            // regularnaButton
            // 
            this.regularnaButton.AutoSize = true;
            this.regularnaButton.Location = new System.Drawing.Point(36, 30);
            this.regularnaButton.Name = "regularnaButton";
            this.regularnaButton.Size = new System.Drawing.Size(95, 21);
            this.regularnaButton.TabIndex = 10;
            this.regularnaButton.TabStop = true;
            this.regularnaButton.Text = "Regularna";
            this.regularnaButton.UseVisualStyleBackColor = true;
            // 
            // vrstaKarteGroup
            // 
            this.vrstaKarteGroup.Controls.Add(this.studentskaButton);
            this.vrstaKarteGroup.Controls.Add(this.regularnaButton);
            this.vrstaKarteGroup.Location = new System.Drawing.Point(22, 200);
            this.vrstaKarteGroup.Name = "vrstaKarteGroup";
            this.vrstaKarteGroup.Size = new System.Drawing.Size(266, 67);
            this.vrstaKarteGroup.TabIndex = 11;
            this.vrstaKarteGroup.TabStop = false;
            this.vrstaKarteGroup.Text = "Vrsta karte";
            this.vrstaKarteGroup.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.odredisteTextBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.odaberiteLinijuButton);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.prijevoznikTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.udaljenostTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.polazisteTextBox);
            this.groupBox2.Location = new System.Drawing.Point(22, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 154);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Autobusne linije";
            // 
            // studentskaButton
            // 
            this.studentskaButton.AutoSize = true;
            this.studentskaButton.Location = new System.Drawing.Point(137, 30);
            this.studentskaButton.Name = "studentskaButton";
            this.studentskaButton.Size = new System.Drawing.Size(100, 21);
            this.studentskaButton.TabIndex = 11;
            this.studentskaButton.TabStop = true;
            this.studentskaButton.Text = "Studentska";
            this.studentskaButton.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.prtljagaBox);
            this.groupBox3.Controls.Add(this.povratnaBox);
            this.groupBox3.Location = new System.Drawing.Point(22, 273);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(266, 79);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ostale opcije";
            // 
            // povratnaBox
            // 
            this.povratnaBox.AutoSize = true;
            this.povratnaBox.Location = new System.Drawing.Point(36, 35);
            this.povratnaBox.Name = "povratnaBox";
            this.povratnaBox.Size = new System.Drawing.Size(123, 21);
            this.povratnaBox.TabIndex = 0;
            this.povratnaBox.Text = "Povratna karta";
            this.povratnaBox.UseVisualStyleBackColor = true;
            // 
            // prtljagaBox
            // 
            this.prtljagaBox.AutoSize = true;
            this.prtljagaBox.Location = new System.Drawing.Point(165, 35);
            this.prtljagaBox.Name = "prtljagaBox";
            this.prtljagaBox.Size = new System.Drawing.Size(78, 21);
            this.prtljagaBox.TabIndex = 1;
            this.prtljagaBox.Text = "Prtljaga";
            this.prtljagaBox.UseVisualStyleBackColor = true;
            // 
            // kreirajKartuButton
            // 
            this.kreirajKartuButton.Location = new System.Drawing.Point(22, 358);
            this.kreirajKartuButton.Name = "kreirajKartuButton";
            this.kreirajKartuButton.Size = new System.Drawing.Size(140, 68);
            this.kreirajKartuButton.TabIndex = 14;
            this.kreirajKartuButton.Text = "Kreiraj kartu";
            this.kreirajKartuButton.UseVisualStyleBackColor = true;
            this.kreirajKartuButton.Click += new System.EventHandler(this.kreirajKartuButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 442);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Broj karte:";
            // 
            // brKarteTextBox
            // 
            this.brKarteTextBox.Location = new System.Drawing.Point(89, 442);
            this.brKarteTextBox.Name = "brKarteTextBox";
            this.brKarteTextBox.Size = new System.Drawing.Size(112, 22);
            this.brKarteTextBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(222, 445);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cijena karte:";
            // 
            // cijenaKarteTextBox
            // 
            this.cijenaKarteTextBox.Location = new System.Drawing.Point(315, 442);
            this.cijenaKarteTextBox.Name = "cijenaKarteTextBox";
            this.cijenaKarteTextBox.Size = new System.Drawing.Size(123, 22);
            this.cijenaKarteTextBox.TabIndex = 18;
            // 
            // Kreiranje_karte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 491);
            this.Controls.Add(this.cijenaKarteTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.brKarteTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kreirajKartuButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.vrstaKarteGroup);
            this.Name = "Kreiranje_karte";
            this.Text = "Kreiranje_karte";
            this.Load += new System.EventHandler(this.Kreiranje_karte_Load);
            this.vrstaKarteGroup.ResumeLayout(false);
            this.vrstaKarteGroup.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox polazisteTextBox;
        private System.Windows.Forms.TextBox odredisteTextBox;
        private System.Windows.Forms.TextBox udaljenostTextBox;
        private System.Windows.Forms.TextBox prijevoznikTextBox;
        private System.Windows.Forms.Button odaberiteLinijuButton;
        private System.Windows.Forms.RadioButton regularnaButton;
        private System.Windows.Forms.GroupBox vrstaKarteGroup;
        private System.Windows.Forms.RadioButton studentskaButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox prtljagaBox;
        private System.Windows.Forms.CheckBox povratnaBox;
        private System.Windows.Forms.Button kreirajKartuButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox brKarteTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cijenaKarteTextBox;
    }
}