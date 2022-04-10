namespace Osobe
{
    partial class uiOsobe
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
            this.uiOutputOsobe = new System.Windows.Forms.ListBox();
            this.uiInputIme = new System.Windows.Forms.TextBox();
            this.uiInputPrezime = new System.Windows.Forms.TextBox();
            this.uiInputDatumRodenja = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.uiActionDodaj = new System.Windows.Forms.Button();
            this.uiActionSvi = new System.Windows.Forms.Button();
            this.uiActionPoDatumu = new System.Windows.Forms.Button();
            this.uiInputFilter = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // uiOutputOsobe
            // 
            this.uiOutputOsobe.FormattingEnabled = true;
            this.uiOutputOsobe.ItemHeight = 16;
            this.uiOutputOsobe.Location = new System.Drawing.Point(16, 15);
            this.uiOutputOsobe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiOutputOsobe.Name = "uiOutputOsobe";
            this.uiOutputOsobe.Size = new System.Drawing.Size(373, 340);
            this.uiOutputOsobe.TabIndex = 7;
            // 
            // uiInputIme
            // 
            this.uiInputIme.Location = new System.Drawing.Point(172, 384);
            this.uiInputIme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiInputIme.Name = "uiInputIme";
            this.uiInputIme.Size = new System.Drawing.Size(217, 22);
            this.uiInputIme.TabIndex = 0;
            // 
            // uiInputPrezime
            // 
            this.uiInputPrezime.Location = new System.Drawing.Point(172, 431);
            this.uiInputPrezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiInputPrezime.Name = "uiInputPrezime";
            this.uiInputPrezime.Size = new System.Drawing.Size(217, 22);
            this.uiInputPrezime.TabIndex = 1;
            // 
            // uiInputDatumRodenja
            // 
            this.uiInputDatumRodenja.Location = new System.Drawing.Point(172, 489);
            this.uiInputDatumRodenja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiInputDatumRodenja.Name = "uiInputDatumRodenja";
            this.uiInputDatumRodenja.Size = new System.Drawing.Size(217, 22);
            this.uiInputDatumRodenja.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(132, 389);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 436);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 494);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Datum rođenja";
            // 
            // uiActionDodaj
            // 
            this.uiActionDodaj.Location = new System.Drawing.Point(291, 539);
            this.uiActionDodaj.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionDodaj.Name = "uiActionDodaj";
            this.uiActionDodaj.Size = new System.Drawing.Size(100, 28);
            this.uiActionDodaj.TabIndex = 3;
            this.uiActionDodaj.Text = "Dodaj osobu";
            this.uiActionDodaj.UseVisualStyleBackColor = true;
            this.uiActionDodaj.Click += new System.EventHandler(this.uiActionDodaj_Click);
            // 
            // uiActionSvi
            // 
            this.uiActionSvi.Location = new System.Drawing.Point(412, 15);
            this.uiActionSvi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionSvi.Name = "uiActionSvi";
            this.uiActionSvi.Size = new System.Drawing.Size(100, 28);
            this.uiActionSvi.TabIndex = 6;
            this.uiActionSvi.Text = "Sve osobe";
            this.uiActionSvi.UseVisualStyleBackColor = true;
            this.uiActionSvi.Click += new System.EventHandler(this.uiActionSvi_Click);
            // 
            // uiActionPoDatumu
            // 
            this.uiActionPoDatumu.Location = new System.Drawing.Point(612, 78);
            this.uiActionPoDatumu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiActionPoDatumu.Name = "uiActionPoDatumu";
            this.uiActionPoDatumu.Size = new System.Drawing.Size(100, 28);
            this.uiActionPoDatumu.TabIndex = 5;
            this.uiActionPoDatumu.Text = "Po datumu";
            this.uiActionPoDatumu.UseVisualStyleBackColor = true;
            this.uiActionPoDatumu.Click += new System.EventHandler(this.uiActionPoDatumu_Click);
            // 
            // uiInputFilter
            // 
            this.uiInputFilter.Location = new System.Drawing.Point(412, 78);
            this.uiInputFilter.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uiInputFilter.Name = "uiInputFilter";
            this.uiInputFilter.Size = new System.Drawing.Size(172, 22);
            this.uiInputFilter.TabIndex = 4;
            // 
            // uiOsobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 603);
            this.Controls.Add(this.uiActionPoDatumu);
            this.Controls.Add(this.uiActionSvi);
            this.Controls.Add(this.uiActionDodaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uiInputFilter);
            this.Controls.Add(this.uiInputDatumRodenja);
            this.Controls.Add(this.uiInputPrezime);
            this.Controls.Add(this.uiInputIme);
            this.Controls.Add(this.uiOutputOsobe);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "uiOsobe";
            this.Text = "Osobe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uiOutputOsobe;
        private System.Windows.Forms.TextBox uiInputIme;
        private System.Windows.Forms.TextBox uiInputPrezime;
        private System.Windows.Forms.DateTimePicker uiInputDatumRodenja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button uiActionDodaj;
        private System.Windows.Forms.Button uiActionSvi;
        private System.Windows.Forms.Button uiActionPoDatumu;
        private System.Windows.Forms.DateTimePicker uiInputFilter;
    }
}

