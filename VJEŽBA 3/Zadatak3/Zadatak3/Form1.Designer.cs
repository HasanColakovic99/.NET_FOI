
namespace Zadatak3
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
            this.linijeDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.odredisteTextBox = new System.Windows.Forms.TextBox();
            this.kupiKartuButton = new System.Windows.Forms.Button();
            this.pronadjiButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.linijeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // linijeDataGridView
            // 
            this.linijeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.linijeDataGridView.Location = new System.Drawing.Point(30, 69);
            this.linijeDataGridView.Name = "linijeDataGridView";
            this.linijeDataGridView.RowHeadersWidth = 51;
            this.linijeDataGridView.RowTemplate.Height = 24;
            this.linijeDataGridView.Size = new System.Drawing.Size(761, 323);
            this.linijeDataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Odredište:";
            // 
            // odredisteTextBox
            // 
            this.odredisteTextBox.Location = new System.Drawing.Point(107, 27);
            this.odredisteTextBox.Name = "odredisteTextBox";
            this.odredisteTextBox.Size = new System.Drawing.Size(192, 22);
            this.odredisteTextBox.TabIndex = 2;
            // 
            // kupiKartuButton
            // 
            this.kupiKartuButton.Location = new System.Drawing.Point(672, 398);
            this.kupiKartuButton.Name = "kupiKartuButton";
            this.kupiKartuButton.Size = new System.Drawing.Size(119, 30);
            this.kupiKartuButton.TabIndex = 3;
            this.kupiKartuButton.Text = "Kupi kartu";
            this.kupiKartuButton.UseVisualStyleBackColor = true;
            this.kupiKartuButton.Click += new System.EventHandler(this.kupiKartuButton_Click);
            // 
            // pronadjiButton
            // 
            this.pronadjiButton.Location = new System.Drawing.Point(305, 26);
            this.pronadjiButton.Name = "pronadjiButton";
            this.pronadjiButton.Size = new System.Drawing.Size(93, 23);
            this.pronadjiButton.TabIndex = 4;
            this.pronadjiButton.Text = "Pronađi";
            this.pronadjiButton.UseVisualStyleBackColor = true;
            this.pronadjiButton.Click += new System.EventHandler(this.pronadjiButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.pronadjiButton);
            this.Controls.Add(this.kupiKartuButton);
            this.Controls.Add(this.odredisteTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linijeDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.linijeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView linijeDataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox odredisteTextBox;
        private System.Windows.Forms.Button kupiKartuButton;
        private System.Windows.Forms.Button pronadjiButton;
    }
}

