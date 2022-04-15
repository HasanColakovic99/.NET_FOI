namespace Nogometni_susret
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDomacin = new System.Windows.Forms.TextBox();
            this.textBoxGost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxRezultat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonEvidentiraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Domaćin:";
            // 
            // textBoxDomacin
            // 
            this.textBoxDomacin.Location = new System.Drawing.Point(83, 21);
            this.textBoxDomacin.Name = "textBoxDomacin";
            this.textBoxDomacin.Size = new System.Drawing.Size(144, 20);
            this.textBoxDomacin.TabIndex = 1;
            // 
            // textBoxGost
            // 
            this.textBoxGost.Location = new System.Drawing.Point(83, 47);
            this.textBoxGost.Name = "textBoxGost";
            this.textBoxGost.Size = new System.Drawing.Size(144, 20);
            this.textBoxGost.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Gost:";
            // 
            // textBoxRezultat
            // 
            this.textBoxRezultat.Location = new System.Drawing.Point(83, 90);
            this.textBoxRezultat.Name = "textBoxRezultat";
            this.textBoxRezultat.Size = new System.Drawing.Size(144, 20);
            this.textBoxRezultat.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rezultat:";
            // 
            // ButtonEvidentiraj
            // 
            this.ButtonEvidentiraj.Location = new System.Drawing.Point(152, 116);
            this.ButtonEvidentiraj.Name = "ButtonEvidentiraj";
            this.ButtonEvidentiraj.Size = new System.Drawing.Size(75, 23);
            this.ButtonEvidentiraj.TabIndex = 6;
            this.ButtonEvidentiraj.Text = "Evidentiraj";
            this.ButtonEvidentiraj.UseVisualStyleBackColor = true;
            this.ButtonEvidentiraj.Click += new System.EventHandler(this.ButtonEvidentiraj_Click);
            // 
            // FormGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 156);
            this.Controls.Add(this.ButtonEvidentiraj);
            this.Controls.Add(this.textBoxRezultat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxGost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDomacin);
            this.Controls.Add(this.label1);
            this.Name = "FormGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nogometni susret";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDomacin;
        private System.Windows.Forms.TextBox textBoxGost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxRezultat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonEvidentiraj;
    }
}

