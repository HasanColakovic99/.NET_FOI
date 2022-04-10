
namespace Zadatak6
{
    partial class Knjige
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
            this.dostupneKnjigeDataGridView = new System.Windows.Forms.DataGridView();
            this.posudjeneKnjigeDataGridView = new System.Windows.Forms.DataGridView();
            this.posudiButton = new System.Windows.Forms.Button();
            this.vratiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dostupneKnjigeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.posudjeneKnjigeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dostupne knjige";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Posuđene knjige:";
            // 
            // dostupneKnjigeDataGridView
            // 
            this.dostupneKnjigeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dostupneKnjigeDataGridView.Location = new System.Drawing.Point(41, 48);
            this.dostupneKnjigeDataGridView.Name = "dostupneKnjigeDataGridView";
            this.dostupneKnjigeDataGridView.RowHeadersWidth = 51;
            this.dostupneKnjigeDataGridView.RowTemplate.Height = 24;
            this.dostupneKnjigeDataGridView.Size = new System.Drawing.Size(383, 176);
            this.dostupneKnjigeDataGridView.TabIndex = 2;
            // 
            // posudjeneKnjigeDataGridView
            // 
            this.posudjeneKnjigeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.posudjeneKnjigeDataGridView.Location = new System.Drawing.Point(41, 307);
            this.posudjeneKnjigeDataGridView.Name = "posudjeneKnjigeDataGridView";
            this.posudjeneKnjigeDataGridView.RowHeadersWidth = 51;
            this.posudjeneKnjigeDataGridView.RowTemplate.Height = 24;
            this.posudjeneKnjigeDataGridView.Size = new System.Drawing.Size(383, 176);
            this.posudjeneKnjigeDataGridView.TabIndex = 3;
            // 
            // posudiButton
            // 
            this.posudiButton.Location = new System.Drawing.Point(315, 230);
            this.posudiButton.Name = "posudiButton";
            this.posudiButton.Size = new System.Drawing.Size(109, 33);
            this.posudiButton.TabIndex = 4;
            this.posudiButton.Text = "Posudi knjigu";
            this.posudiButton.UseVisualStyleBackColor = true;
            this.posudiButton.Click += new System.EventHandler(this.posudiButton_Click);
            // 
            // vratiButton
            // 
            this.vratiButton.Location = new System.Drawing.Point(315, 498);
            this.vratiButton.Name = "vratiButton";
            this.vratiButton.Size = new System.Drawing.Size(109, 33);
            this.vratiButton.TabIndex = 5;
            this.vratiButton.Text = "Vrati knjigu";
            this.vratiButton.UseVisualStyleBackColor = true;
            this.vratiButton.Click += new System.EventHandler(this.vratiButton_Click);
            // 
            // Knjige
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 543);
            this.Controls.Add(this.vratiButton);
            this.Controls.Add(this.posudiButton);
            this.Controls.Add(this.posudjeneKnjigeDataGridView);
            this.Controls.Add(this.dostupneKnjigeDataGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Knjige";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Knjige_Load);
            this.Shown += new System.EventHandler(this.Refresh);
            ((System.ComponentModel.ISupportInitialize)(this.dostupneKnjigeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.posudjeneKnjigeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dostupneKnjigeDataGridView;
        private System.Windows.Forms.DataGridView posudjeneKnjigeDataGridView;
        private System.Windows.Forms.Button posudiButton;
        private System.Windows.Forms.Button vratiButton;
    }
}

