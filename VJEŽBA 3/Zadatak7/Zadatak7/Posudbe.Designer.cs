
namespace Zadatak7
{
    partial class Posudbe
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
            this.sveButton = new System.Windows.Forms.RadioButton();
            this.trenutnePosudbeButton = new System.Windows.Forms.RadioButton();
            this.proslePosudbeButton = new System.Windows.Forms.RadioButton();
            this.button = new System.Windows.Forms.Button();
            this.posudbeDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.posudbeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prikaži:";
            // 
            // sveButton
            // 
            this.sveButton.AutoSize = true;
            this.sveButton.Checked = true;
            this.sveButton.Location = new System.Drawing.Point(148, 47);
            this.sveButton.Name = "sveButton";
            this.sveButton.Size = new System.Drawing.Size(112, 21);
            this.sveButton.TabIndex = 1;
            this.sveButton.TabStop = true;
            this.sveButton.Text = "Sve posudbe";
            this.sveButton.UseVisualStyleBackColor = true;
            this.sveButton.CheckedChanged += new System.EventHandler(this.sveButton_CheckedChanged);
            // 
            // trenutnePosudbeButton
            // 
            this.trenutnePosudbeButton.AutoSize = true;
            this.trenutnePosudbeButton.Location = new System.Drawing.Point(281, 47);
            this.trenutnePosudbeButton.Name = "trenutnePosudbeButton";
            this.trenutnePosudbeButton.Size = new System.Drawing.Size(146, 21);
            this.trenutnePosudbeButton.TabIndex = 2;
            this.trenutnePosudbeButton.TabStop = true;
            this.trenutnePosudbeButton.Text = "Trenutne posudbe";
            this.trenutnePosudbeButton.UseVisualStyleBackColor = true;
            this.trenutnePosudbeButton.CheckedChanged += new System.EventHandler(this.trenutnePosudbeButton_CheckedChanged);
            // 
            // proslePosudbeButton
            // 
            this.proslePosudbeButton.AutoSize = true;
            this.proslePosudbeButton.Location = new System.Drawing.Point(429, 47);
            this.proslePosudbeButton.Name = "proslePosudbeButton";
            this.proslePosudbeButton.Size = new System.Drawing.Size(128, 21);
            this.proslePosudbeButton.TabIndex = 3;
            this.proslePosudbeButton.TabStop = true;
            this.proslePosudbeButton.Text = "Prošle posudbe";
            this.proslePosudbeButton.UseVisualStyleBackColor = true;
            this.proslePosudbeButton.CheckedChanged += new System.EventHandler(this.proslePosudbeButton_CheckedChanged);
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(668, 383);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(121, 39);
            this.button.TabIndex = 4;
            this.button.Text = "Vrati knjigu";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // posudbeDataGridView
            // 
            this.posudbeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.posudbeDataGridView.Location = new System.Drawing.Point(56, 101);
            this.posudbeDataGridView.Name = "posudbeDataGridView";
            this.posudbeDataGridView.RowHeadersWidth = 51;
            this.posudbeDataGridView.RowTemplate.Height = 24;
            this.posudbeDataGridView.Size = new System.Drawing.Size(733, 262);
            this.posudbeDataGridView.TabIndex = 5;
            // 
            // Posudbe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 450);
            this.Controls.Add(this.posudbeDataGridView);
            this.Controls.Add(this.button);
            this.Controls.Add(this.proslePosudbeButton);
            this.Controls.Add(this.trenutnePosudbeButton);
            this.Controls.Add(this.sveButton);
            this.Controls.Add(this.label1);
            this.Name = "Posudbe";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Posudbe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.posudbeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton sveButton;
        private System.Windows.Forms.RadioButton trenutnePosudbeButton;
        private System.Windows.Forms.RadioButton proslePosudbeButton;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.DataGridView posudbeDataGridView;
    }
}

