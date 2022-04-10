namespace BankAdvanced
{
    partial class RacuniForm
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
            this.racuniDataGridView = new System.Windows.Forms.DataGridView();
            this.detaljiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.racuniDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Popis računa:";
            // 
            // racuniDataGridView
            // 
            this.racuniDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.racuniDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.racuniDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.racuniDataGridView.Location = new System.Drawing.Point(12, 29);
            this.racuniDataGridView.Name = "racuniDataGridView";
            this.racuniDataGridView.RowHeadersVisible = false;
            this.racuniDataGridView.RowTemplate.Height = 24;
            this.racuniDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.racuniDataGridView.Size = new System.Drawing.Size(1031, 391);
            this.racuniDataGridView.TabIndex = 1;
            // 
            // detaljiButton
            // 
            this.detaljiButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.detaljiButton.Location = new System.Drawing.Point(946, 426);
            this.detaljiButton.Name = "detaljiButton";
            this.detaljiButton.Size = new System.Drawing.Size(97, 34);
            this.detaljiButton.TabIndex = 2;
            this.detaljiButton.Text = "Detalji";
            this.detaljiButton.UseVisualStyleBackColor = true;
            this.detaljiButton.Click += new System.EventHandler(this.detaljiButton_Click);
            // 
            // RacuniForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 472);
            this.Controls.Add(this.detaljiButton);
            this.Controls.Add(this.racuniDataGridView);
            this.Controls.Add(this.label1);
            this.Name = "RacuniForm";
            this.Text = "Računi";
            this.Load += new System.EventHandler(this.RacuniForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.racuniDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView racuniDataGridView;
        private System.Windows.Forms.Button detaljiButton;
    }
}