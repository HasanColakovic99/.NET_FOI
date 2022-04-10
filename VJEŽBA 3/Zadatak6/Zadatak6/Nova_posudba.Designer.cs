
namespace Zadatak6
{
    partial class Nova_posudba
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
            this.isbnTextBox = new System.Windows.Forms.TextBox();
            this.naslovTextBox = new System.Windows.Forms.TextBox();
            this.osobaTextBox = new System.Windows.Forms.TextBox();
            this.ureduButton = new System.Windows.Forms.Button();
            this.odustaniButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naslov";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Osoba";
            // 
            // isbnTextBox
            // 
            this.isbnTextBox.Location = new System.Drawing.Point(148, 44);
            this.isbnTextBox.Name = "isbnTextBox";
            this.isbnTextBox.Size = new System.Drawing.Size(164, 22);
            this.isbnTextBox.TabIndex = 3;
            // 
            // naslovTextBox
            // 
            this.naslovTextBox.Location = new System.Drawing.Point(148, 86);
            this.naslovTextBox.Name = "naslovTextBox";
            this.naslovTextBox.Size = new System.Drawing.Size(164, 22);
            this.naslovTextBox.TabIndex = 4;
            // 
            // osobaTextBox
            // 
            this.osobaTextBox.Location = new System.Drawing.Point(148, 132);
            this.osobaTextBox.Name = "osobaTextBox";
            this.osobaTextBox.Size = new System.Drawing.Size(164, 22);
            this.osobaTextBox.TabIndex = 5;
            // 
            // ureduButton
            // 
            this.ureduButton.Location = new System.Drawing.Point(148, 178);
            this.ureduButton.Name = "ureduButton";
            this.ureduButton.Size = new System.Drawing.Size(75, 23);
            this.ureduButton.TabIndex = 6;
            this.ureduButton.Text = "U redu";
            this.ureduButton.UseVisualStyleBackColor = true;
            this.ureduButton.Click += new System.EventHandler(this.ureduButton_Click);
            // 
            // odustaniButton
            // 
            this.odustaniButton.Location = new System.Drawing.Point(230, 178);
            this.odustaniButton.Name = "odustaniButton";
            this.odustaniButton.Size = new System.Drawing.Size(82, 23);
            this.odustaniButton.TabIndex = 7;
            this.odustaniButton.Text = "Odustani";
            this.odustaniButton.UseVisualStyleBackColor = true;
            this.odustaniButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // Nova_posudba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 227);
            this.Controls.Add(this.odustaniButton);
            this.Controls.Add(this.ureduButton);
            this.Controls.Add(this.osobaTextBox);
            this.Controls.Add(this.naslovTextBox);
            this.Controls.Add(this.isbnTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Nova_posudba";
            this.Text = "Nova_posudba";
            this.Load += new System.EventHandler(this.Nova_posudba_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isbnTextBox;
        private System.Windows.Forms.TextBox naslovTextBox;
        private System.Windows.Forms.TextBox osobaTextBox;
        private System.Windows.Forms.Button ureduButton;
        private System.Windows.Forms.Button odustaniButton;
    }
}