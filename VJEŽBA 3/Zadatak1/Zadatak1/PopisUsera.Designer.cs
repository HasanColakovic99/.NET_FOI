
namespace Zadatak1
{
    partial class PopisUsera
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
            this.korisniciDataGridView = new System.Windows.Forms.DataGridView();
            this.aktivirajButton = new System.Windows.Forms.Button();
            this.deaktivirajButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Korisnici:";
            // 
            // korisniciDataGridView
            // 
            this.korisniciDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisniciDataGridView.Location = new System.Drawing.Point(20, 44);
            this.korisniciDataGridView.Name = "korisniciDataGridView";
            this.korisniciDataGridView.Size = new System.Drawing.Size(763, 326);
            this.korisniciDataGridView.TabIndex = 1;
            // 
            // aktivirajButton
            // 
            this.aktivirajButton.Location = new System.Drawing.Point(20, 387);
            this.aktivirajButton.Name = "aktivirajButton";
            this.aktivirajButton.Size = new System.Drawing.Size(92, 51);
            this.aktivirajButton.TabIndex = 2;
            this.aktivirajButton.Text = "Aktiviraj korisnika";
            this.aktivirajButton.UseVisualStyleBackColor = true;
            this.aktivirajButton.Click += new System.EventHandler(this.aktivirajButton_Click);
            // 
            // deaktivirajButton
            // 
            this.deaktivirajButton.Location = new System.Drawing.Point(118, 387);
            this.deaktivirajButton.Name = "deaktivirajButton";
            this.deaktivirajButton.Size = new System.Drawing.Size(92, 51);
            this.deaktivirajButton.TabIndex = 3;
            this.deaktivirajButton.Text = "Deaktiviraj korisnika";
            this.deaktivirajButton.UseVisualStyleBackColor = true;
            this.deaktivirajButton.Click += new System.EventHandler(this.deaktivirajButton_Click);
            // 
            // PopisUsera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deaktivirajButton);
            this.Controls.Add(this.aktivirajButton);
            this.Controls.Add(this.korisniciDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "PopisUsera";
            this.Text = "PopisUsera";
            this.Load += new System.EventHandler(this.PopisUsera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.korisniciDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView korisniciDataGridView;
        private System.Windows.Forms.Button aktivirajButton;
        private System.Windows.Forms.Button deaktivirajButton;
    }
}