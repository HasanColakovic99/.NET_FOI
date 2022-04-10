
namespace Zadatak3
{
    partial class Kupi_kartu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.povrtnaCheckBox = new System.Windows.Forms.CheckBox();
            this.prtljagaCheckBox = new System.Windows.Forms.CheckBox();
            this.ispisKarteButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.prtljagaCheckBox);
            this.groupBox1.Controls.Add(this.povrtnaCheckBox);
            this.groupBox1.Controls.Add(this.comboBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(22, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opcije karte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrsta karte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dodatno:";
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Regularna",
            "Studentska"});
            this.comboBox.Location = new System.Drawing.Point(138, 38);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(150, 24);
            this.comboBox.TabIndex = 2;
            // 
            // povrtnaCheckBox
            // 
            this.povrtnaCheckBox.AutoSize = true;
            this.povrtnaCheckBox.Location = new System.Drawing.Point(138, 86);
            this.povrtnaCheckBox.Name = "povrtnaCheckBox";
            this.povrtnaCheckBox.Size = new System.Drawing.Size(123, 21);
            this.povrtnaCheckBox.TabIndex = 3;
            this.povrtnaCheckBox.Text = "Povratna karta";
            this.povrtnaCheckBox.UseVisualStyleBackColor = true;
            // 
            // prtljagaCheckBox
            // 
            this.prtljagaCheckBox.AutoSize = true;
            this.prtljagaCheckBox.Location = new System.Drawing.Point(138, 114);
            this.prtljagaCheckBox.Name = "prtljagaCheckBox";
            this.prtljagaCheckBox.Size = new System.Drawing.Size(78, 21);
            this.prtljagaCheckBox.TabIndex = 4;
            this.prtljagaCheckBox.Text = "Prtljaga";
            this.prtljagaCheckBox.UseVisualStyleBackColor = true;
            // 
            // ispisKarteButton
            // 
            this.ispisKarteButton.Location = new System.Drawing.Point(208, 199);
            this.ispisKarteButton.Name = "ispisKarteButton";
            this.ispisKarteButton.Size = new System.Drawing.Size(135, 27);
            this.ispisKarteButton.TabIndex = 1;
            this.ispisKarteButton.Text = "Ispiši kartu";
            this.ispisKarteButton.UseVisualStyleBackColor = true;
            this.ispisKarteButton.Click += new System.EventHandler(this.ispisKarteButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Location = new System.Drawing.Point(22, 249);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(321, 189);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ispis karte";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(6, 32);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(309, 151);
            this.textBox1.TabIndex = 0;
            // 
            // Kupi_kartu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.ispisKarteButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Kupi_kartu";
            this.Text = "Kupi_kartu";
            this.Load += new System.EventHandler(this.Kupi_kartu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox prtljagaCheckBox;
        private System.Windows.Forms.CheckBox povrtnaCheckBox;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ispisKarteButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}