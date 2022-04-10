
namespace Zadatak15
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
            this.dodajButton = new System.Windows.Forms.Button();
            this.promijeniButton = new System.Windows.Forms.Button();
            this.obrisiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(664, 290);
            this.dataGridView1.TabIndex = 0;
            // 
            // dodajButton
            // 
            this.dodajButton.Location = new System.Drawing.Point(272, 337);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(138, 52);
            this.dodajButton.TabIndex = 1;
            this.dodajButton.Text = "Dodaj vozilo";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // promijeniButton
            // 
            this.promijeniButton.Location = new System.Drawing.Point(416, 337);
            this.promijeniButton.Name = "promijeniButton";
            this.promijeniButton.Size = new System.Drawing.Size(138, 52);
            this.promijeniButton.TabIndex = 2;
            this.promijeniButton.Text = "Promijeni naziv";
            this.promijeniButton.UseVisualStyleBackColor = true;
            this.promijeniButton.Click += new System.EventHandler(this.promijeniButton_Click);
            // 
            // obrisiButton
            // 
            this.obrisiButton.Location = new System.Drawing.Point(560, 337);
            this.obrisiButton.Name = "obrisiButton";
            this.obrisiButton.Size = new System.Drawing.Size(138, 52);
            this.obrisiButton.TabIndex = 3;
            this.obrisiButton.Text = "Obriši vozilo";
            this.obrisiButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 431);
            this.Controls.Add(this.obrisiButton);
            this.Controls.Add(this.promijeniButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button promijeniButton;
        private System.Windows.Forms.Button obrisiButton;
    }
}

