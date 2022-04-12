namespace Studenti_i_timovi
{
    partial class FormNoviStudent
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
            this.textBoxJMBAG = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonURedu = new System.Windows.Forms.Button();
            this.ButtonOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "JMBAG:";
            // 
            // textBoxJMBAG
            // 
            this.textBoxJMBAG.Location = new System.Drawing.Point(95, 19);
            this.textBoxJMBAG.Name = "textBoxJMBAG";
            this.textBoxJMBAG.Size = new System.Drawing.Size(100, 20);
            this.textBoxJMBAG.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(95, 45);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(100, 20);
            this.textBoxIme.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ime:";
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(95, 71);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrezime.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prezime:";
            // 
            // ButtonURedu
            // 
            this.ButtonURedu.Location = new System.Drawing.Point(30, 107);
            this.ButtonURedu.Name = "ButtonURedu";
            this.ButtonURedu.Size = new System.Drawing.Size(75, 23);
            this.ButtonURedu.TabIndex = 7;
            this.ButtonURedu.Text = "U redu";
            this.ButtonURedu.UseVisualStyleBackColor = true;
            this.ButtonURedu.Click += new System.EventHandler(this.ButtonURedu_Click);
            // 
            // ButtonOdustani
            // 
            this.ButtonOdustani.Location = new System.Drawing.Point(120, 107);
            this.ButtonOdustani.Name = "ButtonOdustani";
            this.ButtonOdustani.Size = new System.Drawing.Size(75, 23);
            this.ButtonOdustani.TabIndex = 8;
            this.ButtonOdustani.Text = "Odustani";
            this.ButtonOdustani.UseVisualStyleBackColor = true;
            this.ButtonOdustani.Click += new System.EventHandler(this.ButtonOdustani_Click);
            // 
            // FormNoviStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 152);
            this.Controls.Add(this.ButtonOdustani);
            this.Controls.Add(this.ButtonURedu);
            this.Controls.Add(this.textBoxPrezime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxJMBAG);
            this.Controls.Add(this.label1);
            this.Name = "FormNoviStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxJMBAG;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBoxIme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonURedu;
        private System.Windows.Forms.Button ButtonOdustani;
    }
}