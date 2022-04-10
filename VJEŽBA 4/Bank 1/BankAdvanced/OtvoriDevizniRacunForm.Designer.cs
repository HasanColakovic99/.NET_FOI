namespace BankAdvanced
{
    partial class OtvoriDevizniRacunForm
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
            this.izlazButton = new System.Windows.Forms.Button();
            this.spremiButton = new System.Windows.Forms.Button();
            this.stanjeTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.valutaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ibanTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.odabirKlijentaButton = new System.Windows.Forms.Button();
            this.klijentTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.odabirValuteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // izlazButton
            // 
            this.izlazButton.Location = new System.Drawing.Point(285, 116);
            this.izlazButton.Name = "izlazButton";
            this.izlazButton.Size = new System.Drawing.Size(84, 46);
            this.izlazButton.TabIndex = 33;
            this.izlazButton.Text = "Izlaz";
            this.izlazButton.UseVisualStyleBackColor = true;
            // 
            // spremiButton
            // 
            this.spremiButton.Location = new System.Drawing.Point(195, 116);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(84, 46);
            this.spremiButton.TabIndex = 32;
            this.spremiButton.Text = "Spremi";
            this.spremiButton.UseVisualStyleBackColor = true;
            this.spremiButton.Click += new System.EventHandler(this.spremiButton_Click);
            // 
            // stanjeTextBox
            // 
            this.stanjeTextBox.Location = new System.Drawing.Point(232, 88);
            this.stanjeTextBox.Name = "stanjeTextBox";
            this.stanjeTextBox.Size = new System.Drawing.Size(137, 22);
            this.stanjeTextBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Početno stanje:";
            // 
            // valutaTextBox
            // 
            this.valutaTextBox.Enabled = false;
            this.valutaTextBox.Location = new System.Drawing.Point(158, 60);
            this.valutaTextBox.Name = "valutaTextBox";
            this.valutaTextBox.Size = new System.Drawing.Size(211, 22);
            this.valutaTextBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Valuta:";
            // 
            // ibanTextBox
            // 
            this.ibanTextBox.Enabled = false;
            this.ibanTextBox.Location = new System.Drawing.Point(158, 6);
            this.ibanTextBox.Name = "ibanTextBox";
            this.ibanTextBox.Size = new System.Drawing.Size(211, 22);
            this.ibanTextBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "IBAN:";
            // 
            // odabirKlijentaButton
            // 
            this.odabirKlijentaButton.Location = new System.Drawing.Point(375, 34);
            this.odabirKlijentaButton.Name = "odabirKlijentaButton";
            this.odabirKlijentaButton.Size = new System.Drawing.Size(36, 22);
            this.odabirKlijentaButton.TabIndex = 23;
            this.odabirKlijentaButton.Text = "...";
            this.odabirKlijentaButton.UseVisualStyleBackColor = true;
            this.odabirKlijentaButton.Click += new System.EventHandler(this.odabirKlijentaButton_Click);
            // 
            // klijentTextBox
            // 
            this.klijentTextBox.Enabled = false;
            this.klijentTextBox.Location = new System.Drawing.Point(158, 34);
            this.klijentTextBox.Name = "klijentTextBox";
            this.klijentTextBox.Size = new System.Drawing.Size(211, 22);
            this.klijentTextBox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Klijent:";
            // 
            // odabirValuteButton
            // 
            this.odabirValuteButton.Location = new System.Drawing.Point(375, 60);
            this.odabirValuteButton.Name = "odabirValuteButton";
            this.odabirValuteButton.Size = new System.Drawing.Size(36, 22);
            this.odabirValuteButton.TabIndex = 34;
            this.odabirValuteButton.Text = "...";
            this.odabirValuteButton.UseVisualStyleBackColor = true;
            this.odabirValuteButton.Click += new System.EventHandler(this.odabirValuteButton_Click);
            // 
            // OtvoriDevizniRacunForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 174);
            this.Controls.Add(this.odabirValuteButton);
            this.Controls.Add(this.izlazButton);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(this.stanjeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valutaTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ibanTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.odabirKlijentaButton);
            this.Controls.Add(this.klijentTextBox);
            this.Controls.Add(this.label4);
            this.Name = "OtvoriDevizniRacunForm";
            this.Text = "Otvori devizni račun";
            this.Load += new System.EventHandler(this.OtvoriDevizniRacunForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button izlazButton;
        private System.Windows.Forms.Button spremiButton;
        private System.Windows.Forms.TextBox stanjeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox valutaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ibanTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button odabirKlijentaButton;
        private System.Windows.Forms.TextBox klijentTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button odabirValuteButton;
    }
}