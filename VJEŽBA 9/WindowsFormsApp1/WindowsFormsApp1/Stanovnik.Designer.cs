namespace WindowsFormsApp1
{
    partial class Stanovnik
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imeTextBox = new System.Windows.Forms.TextBox();
            this.prezimeTextBox = new System.Windows.Forms.TextBox();
            this.oibTextBox = new System.Windows.Forms.TextBox();
            this.dodajStanovnikaButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.jmbagTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "OIB:";
            // 
            // imeTextBox
            // 
            this.imeTextBox.Location = new System.Drawing.Point(148, 41);
            this.imeTextBox.Name = "imeTextBox";
            this.imeTextBox.Size = new System.Drawing.Size(179, 22);
            this.imeTextBox.TabIndex = 3;
            // 
            // prezimeTextBox
            // 
            this.prezimeTextBox.Location = new System.Drawing.Point(148, 93);
            this.prezimeTextBox.Name = "prezimeTextBox";
            this.prezimeTextBox.Size = new System.Drawing.Size(179, 22);
            this.prezimeTextBox.TabIndex = 4;
            // 
            // oibTextBox
            // 
            this.oibTextBox.Location = new System.Drawing.Point(148, 141);
            this.oibTextBox.Name = "oibTextBox";
            this.oibTextBox.Size = new System.Drawing.Size(179, 22);
            this.oibTextBox.TabIndex = 5;
            // 
            // dodajStanovnikaButton
            // 
            this.dodajStanovnikaButton.Location = new System.Drawing.Point(148, 239);
            this.dodajStanovnikaButton.Name = "dodajStanovnikaButton";
            this.dodajStanovnikaButton.Size = new System.Drawing.Size(78, 43);
            this.dodajStanovnikaButton.TabIndex = 6;
            this.dodajStanovnikaButton.Text = "Dodaj stanovnika";
            this.dodajStanovnikaButton.UseVisualStyleBackColor = true;
            this.dodajStanovnikaButton.Click += new System.EventHandler(this.dodajStanovnikaButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(249, 239);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(78, 43);
            this.odustaniButton.TabIndex = 7;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "JMBAG:";
            // 
            // jmbagTextBox
            // 
            this.jmbagTextBox.Location = new System.Drawing.Point(148, 190);
            this.jmbagTextBox.Name = "jmbagTextBox";
            this.jmbagTextBox.Size = new System.Drawing.Size(179, 22);
            this.jmbagTextBox.TabIndex = 9;
            // 
            // Stanovnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 324);
            this.Controls.Add(this.jmbagTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.dodajStanovnikaButton);
            this.Controls.Add(this.oibTextBox);
            this.Controls.Add(this.prezimeTextBox);
            this.Controls.Add(this.imeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Stanovnik";
            this.Text = "Dodaj stanovnika";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox imeTextBox;
        private System.Windows.Forms.TextBox prezimeTextBox;
        private System.Windows.Forms.TextBox oibTextBox;
        private System.Windows.Forms.Button dodajStanovnikaButton;
        private System.Windows.Forms.Button odustaniButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox jmbagTextBox;
    }
}