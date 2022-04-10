namespace BankAdvanced
{
    partial class KreirajKlijentaForm
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
            this.privatniRadio = new System.Windows.Forms.RadioButton();
            this.poslovniRadio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.spremiButton = new System.Windows.Forms.Button();
            this.izlazButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.poduzeceTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.oibTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.privatniRadio);
            this.groupBox1.Controls.Add(this.poslovniRadio);
            this.groupBox1.Location = new System.Drawing.Point(12, 107);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 86);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tip korisnika:";
            // 
            // privatniRadio
            // 
            this.privatniRadio.AutoSize = true;
            this.privatniRadio.Checked = true;
            this.privatniRadio.Location = new System.Drawing.Point(96, 22);
            this.privatniRadio.Name = "privatniRadio";
            this.privatniRadio.Size = new System.Drawing.Size(128, 21);
            this.privatniRadio.TabIndex = 4;
            this.privatniRadio.TabStop = true;
            this.privatniRadio.Text = "Privatni korisnik";
            this.privatniRadio.UseVisualStyleBackColor = true;
            this.privatniRadio.CheckedChanged += new System.EventHandler(this.privatniRadio_CheckedChanged);
            // 
            // poslovniRadio
            // 
            this.poslovniRadio.AutoSize = true;
            this.poslovniRadio.Location = new System.Drawing.Point(96, 49);
            this.poslovniRadio.Name = "poslovniRadio";
            this.poslovniRadio.Size = new System.Drawing.Size(134, 21);
            this.poslovniRadio.TabIndex = 5;
            this.poslovniRadio.TabStop = true;
            this.poslovniRadio.Text = "Poslovni korisnik";
            this.poslovniRadio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Prezime:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Ime:";
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Location = new System.Drawing.Point(108, 68);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(170, 22);
            this.prezimeTextBox.TabIndex = 12;
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(108, 40);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(170, 22);
            this.imeTextBox.TabIndex = 11;
            // 
            // spremiButton
            // 
            this.spremiButton.Location = new System.Drawing.Point(122, 244);
            this.spremiButton.Name = "spremiButton";
            this.spremiButton.Size = new System.Drawing.Size(75, 35);
            this.spremiButton.TabIndex = 19;
            this.spremiButton.Text = "Spremi";
            this.spremiButton.UseVisualStyleBackColor = true;
            this.spremiButton.Click += new System.EventHandler(this.spremiButton_Click);
            // 
            // izlazButton
            // 
            this.izlazButton.Location = new System.Drawing.Point(203, 244);
            this.izlazButton.Name = "izlazButton";
            this.izlazButton.Size = new System.Drawing.Size(75, 35);
            this.izlazButton.TabIndex = 18;
            this.izlazButton.Text = "Izlaz";
            this.izlazButton.UseVisualStyleBackColor = true;
            this.izlazButton.Click += new System.EventHandler(this.izlazButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Poduzeće:";
            // 
            // poduzeceTextBox
            // 
            this.poduzeceTextBox.Enabled = false;
            this.poduzeceTextBox.Location = new System.Drawing.Point(108, 208);
            this.poduzeceTextBox.Name = "poduzeceTextBox";
            this.poduzeceTextBox.Size = new System.Drawing.Size(170, 22);
            this.poduzeceTextBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "OIB:";
            // 
            // oibTextBox
            // 
            this.oibTextBox.Location = new System.Drawing.Point(108, 10);
            this.oibTextBox.Name = "oibTextBox";
            this.oibTextBox.Size = new System.Drawing.Size(170, 22);
            this.oibTextBox.TabIndex = 20;
            // 
            // KreirajKlijentaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 296);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oibTextBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(this.spremiButton);
            this.Controls.Add(this.izlazButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.poduzeceTextBox);
            this.Name = "KreirajKlijentaForm";
            this.Text = "Kreiraj klijenta";
            this.Load += new System.EventHandler(this.KreirajKlijentaForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton privatniRadio;
        private System.Windows.Forms.RadioButton poslovniRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.Button spremiButton;
        private System.Windows.Forms.Button izlazButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox poduzeceTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox oibTextBox;
    }
}