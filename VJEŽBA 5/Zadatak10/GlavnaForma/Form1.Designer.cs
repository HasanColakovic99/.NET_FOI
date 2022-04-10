
namespace GlavnaForma
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dodajAutoraButton = new System.Windows.Forms.Button();
            this.ukloniAutoraButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(524, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // dodajAutoraButton
            // 
            this.dodajAutoraButton.Location = new System.Drawing.Point(750, 164);
            this.dodajAutoraButton.Name = "dodajAutoraButton";
            this.dodajAutoraButton.Size = new System.Drawing.Size(92, 52);
            this.dodajAutoraButton.TabIndex = 1;
            this.dodajAutoraButton.Text = "Dodaj autora";
            this.dodajAutoraButton.UseVisualStyleBackColor = true;
            this.dodajAutoraButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // ukloniAutoraButton
            // 
            this.ukloniAutoraButton.Location = new System.Drawing.Point(454, 346);
            this.ukloniAutoraButton.Name = "ukloniAutoraButton";
            this.ukloniAutoraButton.Size = new System.Drawing.Size(92, 52);
            this.ukloniAutoraButton.TabIndex = 2;
            this.ukloniAutoraButton.Text = "Ukloni autora";
            this.ukloniAutoraButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(750, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(152, 22);
            this.textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1166, 539);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ukloniAutoraButton);
            this.Controls.Add(this.dodajAutoraButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dodajAutoraButton;
        private System.Windows.Forms.Button ukloniAutoraButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

