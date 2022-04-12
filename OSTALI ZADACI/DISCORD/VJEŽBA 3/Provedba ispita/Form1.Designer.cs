namespace Provedba_ispita
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPitanje = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ButtonSljedecePitanje = new System.Windows.Forms.Button();
            this.ButtonPotvrdiOdgovor = new System.Windows.Forms.Button();
            this.textBoxPotvrdeniOdgovor = new System.Windows.Forms.TextBox();
            this.listBoxMoguciOdgovori = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pitanje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mogući odgovori:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Potvrđeni odgovor:";
            // 
            // textBoxPitanje
            // 
            this.textBoxPitanje.Location = new System.Drawing.Point(138, 20);
            this.textBoxPitanje.Name = "textBoxPitanje";
            this.textBoxPitanje.Size = new System.Drawing.Size(410, 20);
            this.textBoxPitanje.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ButtonSljedecePitanje
            // 
            this.ButtonSljedecePitanje.Location = new System.Drawing.Point(353, 66);
            this.ButtonSljedecePitanje.Name = "ButtonSljedecePitanje";
            this.ButtonSljedecePitanje.Size = new System.Drawing.Size(195, 98);
            this.ButtonSljedecePitanje.TabIndex = 6;
            this.ButtonSljedecePitanje.Text = "Sljedeće pitanje >>";
            this.ButtonSljedecePitanje.UseVisualStyleBackColor = true;
            this.ButtonSljedecePitanje.Click += new System.EventHandler(this.ButtonSljedecePitanje_Click);
            // 
            // ButtonPotvrdiOdgovor
            // 
            this.ButtonPotvrdiOdgovor.Location = new System.Drawing.Point(138, 169);
            this.ButtonPotvrdiOdgovor.Name = "ButtonPotvrdiOdgovor";
            this.ButtonPotvrdiOdgovor.Size = new System.Drawing.Size(189, 28);
            this.ButtonPotvrdiOdgovor.TabIndex = 7;
            this.ButtonPotvrdiOdgovor.Text = "Potvrdi odgovor";
            this.ButtonPotvrdiOdgovor.UseVisualStyleBackColor = true;
            this.ButtonPotvrdiOdgovor.Click += new System.EventHandler(this.ButtonPotvrdiOdgovor_Click);
            // 
            // textBoxPotvrdeniOdgovor
            // 
            this.textBoxPotvrdeniOdgovor.Location = new System.Drawing.Point(138, 206);
            this.textBoxPotvrdeniOdgovor.Name = "textBoxPotvrdeniOdgovor";
            this.textBoxPotvrdeniOdgovor.Size = new System.Drawing.Size(189, 20);
            this.textBoxPotvrdeniOdgovor.TabIndex = 8;
            // 
            // listBoxMoguciOdgovori
            // 
            this.listBoxMoguciOdgovori.FormattingEnabled = true;
            this.listBoxMoguciOdgovori.Location = new System.Drawing.Point(138, 66);
            this.listBoxMoguciOdgovori.Name = "listBoxMoguciOdgovori";
            this.listBoxMoguciOdgovori.Size = new System.Drawing.Size(189, 95);
            this.listBoxMoguciOdgovori.TabIndex = 9;
            // 
            // FormGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 248);
            this.Controls.Add(this.listBoxMoguciOdgovori);
            this.Controls.Add(this.textBoxPotvrdeniOdgovor);
            this.Controls.Add(this.ButtonPotvrdiOdgovor);
            this.Controls.Add(this.ButtonSljedecePitanje);
            this.Controls.Add(this.textBoxPitanje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Provedba ispita";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPitanje;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button ButtonSljedecePitanje;
        private System.Windows.Forms.Button ButtonPotvrdiOdgovor;
        private System.Windows.Forms.TextBox textBoxPotvrdeniOdgovor;
        private System.Windows.Forms.ListBox listBoxMoguciOdgovori;
    }
}

