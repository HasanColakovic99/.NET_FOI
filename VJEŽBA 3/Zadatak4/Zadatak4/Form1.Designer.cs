
namespace Zadatak4
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
            this.popisRacunaDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uplateButton = new System.Windows.Forms.RadioButton();
            this.isplateButton = new System.Windows.Forms.RadioButton();
            this.sveButton = new System.Windows.Forms.RadioButton();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.popisRacunaDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // popisRacunaDataGridView
            // 
            this.popisRacunaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.popisRacunaDataGridView.Location = new System.Drawing.Point(23, 118);
            this.popisRacunaDataGridView.Name = "popisRacunaDataGridView";
            this.popisRacunaDataGridView.RowHeadersWidth = 51;
            this.popisRacunaDataGridView.RowTemplate.Height = 24;
            this.popisRacunaDataGridView.Size = new System.Drawing.Size(569, 257);
            this.popisRacunaDataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.uplateButton);
            this.groupBox1.Controls.Add(this.isplateButton);
            this.groupBox1.Controls.Add(this.sveButton);
            this.groupBox1.Controls.Add(this.comboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // uplateButton
            // 
            this.uplateButton.AutoSize = true;
            this.uplateButton.Location = new System.Drawing.Point(249, 66);
            this.uplateButton.Name = "uplateButton";
            this.uplateButton.Size = new System.Drawing.Size(70, 21);
            this.uplateButton.TabIndex = 5;
            this.uplateButton.TabStop = true;
            this.uplateButton.Text = "Uplate";
            this.uplateButton.UseVisualStyleBackColor = true;
            // 
            // isplateButton
            // 
            this.isplateButton.AutoSize = true;
            this.isplateButton.Location = new System.Drawing.Point(172, 66);
            this.isplateButton.Name = "isplateButton";
            this.isplateButton.Size = new System.Drawing.Size(70, 21);
            this.isplateButton.TabIndex = 4;
            this.isplateButton.TabStop = true;
            this.isplateButton.Text = "Isplate";
            this.isplateButton.UseVisualStyleBackColor = true;
            // 
            // sveButton
            // 
            this.sveButton.AutoSize = true;
            this.sveButton.Checked = true;
            this.sveButton.Location = new System.Drawing.Point(112, 66);
            this.sveButton.Name = "sveButton";
            this.sveButton.Size = new System.Drawing.Size(53, 21);
            this.sveButton.TabIndex = 3;
            this.sveButton.TabStop = true;
            this.sveButton.Text = "Sve";
            this.sveButton.UseVisualStyleBackColor = true;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(96, 25);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(169, 24);
            this.comboBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Transakcija:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Račun:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(381, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Filtriraj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(497, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 59);
            this.button2.TabIndex = 3;
            this.button2.Text = "Očisti";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(489, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 56);
            this.button3.TabIndex = 4;
            this.button3.Text = "Detalji računa";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.popisRacunaDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.popisRacunaDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView popisRacunaDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton uplateButton;
        private System.Windows.Forms.RadioButton isplateButton;
        private System.Windows.Forms.RadioButton sveButton;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

