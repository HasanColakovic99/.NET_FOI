namespace Studenti_i_timovi
{
    partial class FormGlavna
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
            this.listBoxNedodjeljeniStudenti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxTimovi = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxClanoviTima = new System.Windows.Forms.ListBox();
            this.ButtonNoviStudent = new System.Windows.Forms.Button();
            this.ButtonDodajUTim = new System.Windows.Forms.Button();
            this.ButtonUkloniIzTima = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxNedodjeljeniStudenti
            // 
            this.listBoxNedodjeljeniStudenti.FormattingEnabled = true;
            this.listBoxNedodjeljeniStudenti.Location = new System.Drawing.Point(12, 37);
            this.listBoxNedodjeljeniStudenti.Name = "listBoxNedodjeljeniStudenti";
            this.listBoxNedodjeljeniStudenti.Size = new System.Drawing.Size(178, 303);
            this.listBoxNedodjeljeniStudenti.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nedodijeljeni studenti:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Timovi:";
            // 
            // listBoxTimovi
            // 
            this.listBoxTimovi.FormattingEnabled = true;
            this.listBoxTimovi.Location = new System.Drawing.Point(196, 37);
            this.listBoxTimovi.Name = "listBoxTimovi";
            this.listBoxTimovi.Size = new System.Drawing.Size(178, 303);
            this.listBoxTimovi.TabIndex = 2;
            this.listBoxTimovi.SelectedIndexChanged += new System.EventHandler(this.listBoxTimovi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Članovi tima:";
            // 
            // listBoxClanoviTima
            // 
            this.listBoxClanoviTima.FormattingEnabled = true;
            this.listBoxClanoviTima.Location = new System.Drawing.Point(380, 37);
            this.listBoxClanoviTima.Name = "listBoxClanoviTima";
            this.listBoxClanoviTima.Size = new System.Drawing.Size(178, 303);
            this.listBoxClanoviTima.TabIndex = 4;
            // 
            // ButtonNoviStudent
            // 
            this.ButtonNoviStudent.Location = new System.Drawing.Point(12, 346);
            this.ButtonNoviStudent.Name = "ButtonNoviStudent";
            this.ButtonNoviStudent.Size = new System.Drawing.Size(80, 47);
            this.ButtonNoviStudent.TabIndex = 6;
            this.ButtonNoviStudent.Text = "+ Novi student";
            this.ButtonNoviStudent.UseVisualStyleBackColor = true;
            this.ButtonNoviStudent.Click += new System.EventHandler(this.ButtonNoviStudent_Click);
            // 
            // ButtonDodajUTim
            // 
            this.ButtonDodajUTim.Location = new System.Drawing.Point(98, 346);
            this.ButtonDodajUTim.Name = "ButtonDodajUTim";
            this.ButtonDodajUTim.Size = new System.Drawing.Size(92, 47);
            this.ButtonDodajUTim.TabIndex = 7;
            this.ButtonDodajUTim.Text = "Dodaj u tim >>";
            this.ButtonDodajUTim.UseVisualStyleBackColor = true;
            this.ButtonDodajUTim.Click += new System.EventHandler(this.ButtonDodajUTim_Click);
            // 
            // ButtonUkloniIzTima
            // 
            this.ButtonUkloniIzTima.Location = new System.Drawing.Point(380, 346);
            this.ButtonUkloniIzTima.Name = "ButtonUkloniIzTima";
            this.ButtonUkloniIzTima.Size = new System.Drawing.Size(92, 47);
            this.ButtonUkloniIzTima.TabIndex = 8;
            this.ButtonUkloniIzTima.Text = "<< Ukloni iz tima";
            this.ButtonUkloniIzTima.UseVisualStyleBackColor = true;
            this.ButtonUkloniIzTima.Click += new System.EventHandler(this.ButtonUkloniIzTima_Click);
            // 
            // FormGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 407);
            this.Controls.Add(this.ButtonUkloniIzTima);
            this.Controls.Add(this.ButtonDodajUTim);
            this.Controls.Add(this.ButtonNoviStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxClanoviTima);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxTimovi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxNedodjeljeniStudenti);
            this.Name = "FormGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formiranje projektnih timova";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxNedodjeljeniStudenti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxTimovi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxClanoviTima;
        private System.Windows.Forms.Button ButtonNoviStudent;
        private System.Windows.Forms.Button ButtonDodajUTim;
        private System.Windows.Forms.Button ButtonUkloniIzTima;
    }
}

