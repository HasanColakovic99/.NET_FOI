namespace Provedba_ispita_2
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
            this.ButtonPrethodnoPitanje = new System.Windows.Forms.Button();
            this.ButtonSljedecePitanje = new System.Windows.Forms.Button();
            this.ButtonOdgovor1 = new System.Windows.Forms.Button();
            this.ButtonOdgovor2 = new System.Windows.Forms.Button();
            this.ButtonOdgovor3 = new System.Windows.Forms.Button();
            this.ButtonOdgovor4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPitanje = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonPrethodnoPitanje
            // 
            this.ButtonPrethodnoPitanje.Location = new System.Drawing.Point(12, 12);
            this.ButtonPrethodnoPitanje.Name = "ButtonPrethodnoPitanje";
            this.ButtonPrethodnoPitanje.Size = new System.Drawing.Size(117, 39);
            this.ButtonPrethodnoPitanje.TabIndex = 0;
            this.ButtonPrethodnoPitanje.Text = "<< Prethodno pitanje";
            this.ButtonPrethodnoPitanje.UseVisualStyleBackColor = true;
            this.ButtonPrethodnoPitanje.Click += new System.EventHandler(this.ButtonPrethodnoPitanje_Click);
            // 
            // ButtonSljedecePitanje
            // 
            this.ButtonSljedecePitanje.Location = new System.Drawing.Point(135, 12);
            this.ButtonSljedecePitanje.Name = "ButtonSljedecePitanje";
            this.ButtonSljedecePitanje.Size = new System.Drawing.Size(105, 39);
            this.ButtonSljedecePitanje.TabIndex = 1;
            this.ButtonSljedecePitanje.Text = "Sljedeće pitanje >>";
            this.ButtonSljedecePitanje.UseVisualStyleBackColor = true;
            this.ButtonSljedecePitanje.Click += new System.EventHandler(this.ButtonSljedecePitanje_Click);
            // 
            // ButtonOdgovor1
            // 
            this.ButtonOdgovor1.Location = new System.Drawing.Point(12, 167);
            this.ButtonOdgovor1.Name = "ButtonOdgovor1";
            this.ButtonOdgovor1.Size = new System.Drawing.Size(228, 39);
            this.ButtonOdgovor1.TabIndex = 2;
            this.ButtonOdgovor1.UseVisualStyleBackColor = true;
            this.ButtonOdgovor1.Click += new System.EventHandler(this.ButtonOdgovor1_Click);
            // 
            // ButtonOdgovor2
            // 
            this.ButtonOdgovor2.Location = new System.Drawing.Point(12, 212);
            this.ButtonOdgovor2.Name = "ButtonOdgovor2";
            this.ButtonOdgovor2.Size = new System.Drawing.Size(228, 39);
            this.ButtonOdgovor2.TabIndex = 3;
            this.ButtonOdgovor2.UseVisualStyleBackColor = true;
            this.ButtonOdgovor2.Click += new System.EventHandler(this.ButtonOdgovor2_Click);
            // 
            // ButtonOdgovor3
            // 
            this.ButtonOdgovor3.Location = new System.Drawing.Point(12, 257);
            this.ButtonOdgovor3.Name = "ButtonOdgovor3";
            this.ButtonOdgovor3.Size = new System.Drawing.Size(228, 39);
            this.ButtonOdgovor3.TabIndex = 4;
            this.ButtonOdgovor3.UseVisualStyleBackColor = true;
            this.ButtonOdgovor3.Click += new System.EventHandler(this.ButtonOdgovor3_Click);
            // 
            // ButtonOdgovor4
            // 
            this.ButtonOdgovor4.Location = new System.Drawing.Point(12, 302);
            this.ButtonOdgovor4.Name = "ButtonOdgovor4";
            this.ButtonOdgovor4.Size = new System.Drawing.Size(228, 39);
            this.ButtonOdgovor4.TabIndex = 5;
            this.ButtonOdgovor4.UseVisualStyleBackColor = true;
            this.ButtonOdgovor4.Click += new System.EventHandler(this.ButtonOdgovor4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "PITANJE:";
            // 
            // textBoxPitanje
            // 
            this.textBoxPitanje.Enabled = false;
            this.textBoxPitanje.Location = new System.Drawing.Point(12, 80);
            this.textBoxPitanje.Multiline = true;
            this.textBoxPitanje.Name = "textBoxPitanje";
            this.textBoxPitanje.Size = new System.Drawing.Size(228, 45);
            this.textBoxPitanje.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ODGOVORI:";
            // 
            // FormGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 362);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPitanje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonOdgovor4);
            this.Controls.Add(this.ButtonOdgovor3);
            this.Controls.Add(this.ButtonOdgovor2);
            this.Controls.Add(this.ButtonOdgovor1);
            this.Controls.Add(this.ButtonSljedecePitanje);
            this.Controls.Add(this.ButtonPrethodnoPitanje);
            this.Name = "FormGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ispit";
            this.Load += new System.EventHandler(this.FormGlavna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonPrethodnoPitanje;
        private System.Windows.Forms.Button ButtonSljedecePitanje;
        private System.Windows.Forms.Button ButtonOdgovor1;
        private System.Windows.Forms.Button ButtonOdgovor2;
        private System.Windows.Forms.Button ButtonOdgovor3;
        private System.Windows.Forms.Button ButtonOdgovor4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPitanje;
        private System.Windows.Forms.Label label2;
    }
}

