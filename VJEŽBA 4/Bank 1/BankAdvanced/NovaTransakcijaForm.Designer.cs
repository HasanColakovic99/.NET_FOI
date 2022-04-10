namespace BankAdvanced
{
    partial class NovaTransakcijaForm
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
            this.racunPlatiteljTextBox = new System.Windows.Forms.TextBox();
            this.racunPlatiteljButton = new System.Windows.Forms.Button();
            this.racunPrimateljButton = new System.Windows.Forms.Button();
            this.racunPrimateljTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.iznosTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.klijentPlatiteljButton = new System.Windows.Forms.Button();
            this.klijentPlatiteljTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.klijentPrimateljButton = new System.Windows.Forms.Button();
            this.klijentPrimateljTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.provediButton = new System.Windows.Forms.Button();
            this.izlazButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Račun:";
            // 
            // racunPlatiteljTextBox
            // 
            this.racunPlatiteljTextBox.Enabled = false;
            this.racunPlatiteljTextBox.Location = new System.Drawing.Point(90, 49);
            this.racunPlatiteljTextBox.Name = "racunPlatiteljTextBox";
            this.racunPlatiteljTextBox.Size = new System.Drawing.Size(409, 22);
            this.racunPlatiteljTextBox.TabIndex = 1;
            // 
            // racunPlatiteljButton
            // 
            this.racunPlatiteljButton.Location = new System.Drawing.Point(505, 49);
            this.racunPlatiteljButton.Name = "racunPlatiteljButton";
            this.racunPlatiteljButton.Size = new System.Drawing.Size(34, 22);
            this.racunPlatiteljButton.TabIndex = 2;
            this.racunPlatiteljButton.Text = "...";
            this.racunPlatiteljButton.UseVisualStyleBackColor = true;
            this.racunPlatiteljButton.Click += new System.EventHandler(this.racunPlatiteljButton_Click);
            // 
            // racunPrimateljButton
            // 
            this.racunPrimateljButton.Location = new System.Drawing.Point(505, 53);
            this.racunPrimateljButton.Name = "racunPrimateljButton";
            this.racunPrimateljButton.Size = new System.Drawing.Size(34, 23);
            this.racunPrimateljButton.TabIndex = 5;
            this.racunPrimateljButton.Text = "...";
            this.racunPrimateljButton.UseVisualStyleBackColor = true;
            this.racunPrimateljButton.Click += new System.EventHandler(this.racunPrimateljButton_Click);
            // 
            // racunPrimateljTextBox
            // 
            this.racunPrimateljTextBox.Enabled = false;
            this.racunPrimateljTextBox.Location = new System.Drawing.Point(90, 54);
            this.racunPrimateljTextBox.Name = "racunPrimateljTextBox";
            this.racunPrimateljTextBox.Size = new System.Drawing.Size(409, 22);
            this.racunPrimateljTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Primatelj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Iznos:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // iznosTextBox
            // 
            this.iznosTextBox.Location = new System.Drawing.Point(102, 215);
            this.iznosTextBox.Name = "iznosTextBox";
            this.iznosTextBox.Size = new System.Drawing.Size(100, 22);
            this.iznosTextBox.TabIndex = 7;
            this.iznosTextBox.Text = "0,00";
            this.iznosTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.klijentPlatiteljButton);
            this.groupBox1.Controls.Add(this.klijentPlatiteljTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.racunPlatiteljTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.racunPlatiteljButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(545, 94);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Platitelj:";
            // 
            // klijentPlatiteljButton
            // 
            this.klijentPlatiteljButton.Location = new System.Drawing.Point(505, 21);
            this.klijentPlatiteljButton.Name = "klijentPlatiteljButton";
            this.klijentPlatiteljButton.Size = new System.Drawing.Size(34, 22);
            this.klijentPlatiteljButton.TabIndex = 4;
            this.klijentPlatiteljButton.Text = "...";
            this.klijentPlatiteljButton.UseVisualStyleBackColor = true;
            this.klijentPlatiteljButton.Click += new System.EventHandler(this.klijentPlatiteljButton_Click);
            // 
            // klijentPlatiteljTextBox
            // 
            this.klijentPlatiteljTextBox.Enabled = false;
            this.klijentPlatiteljTextBox.Location = new System.Drawing.Point(90, 21);
            this.klijentPlatiteljTextBox.Name = "klijentPlatiteljTextBox";
            this.klijentPlatiteljTextBox.Size = new System.Drawing.Size(409, 22);
            this.klijentPlatiteljTextBox.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Klijent:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.klijentPrimateljButton);
            this.groupBox2.Controls.Add(this.klijentPrimateljTextBox);
            this.groupBox2.Controls.Add(this.racunPrimateljTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.racunPrimateljButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 97);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Primatelj:";
            // 
            // klijentPrimateljButton
            // 
            this.klijentPrimateljButton.Location = new System.Drawing.Point(505, 24);
            this.klijentPrimateljButton.Name = "klijentPrimateljButton";
            this.klijentPrimateljButton.Size = new System.Drawing.Size(34, 23);
            this.klijentPrimateljButton.TabIndex = 12;
            this.klijentPrimateljButton.Text = "...";
            this.klijentPrimateljButton.UseVisualStyleBackColor = true;
            this.klijentPrimateljButton.Click += new System.EventHandler(this.klijentPrimateljButton_Click);
            // 
            // klijentPrimateljTextBox
            // 
            this.klijentPrimateljTextBox.Enabled = false;
            this.klijentPrimateljTextBox.Location = new System.Drawing.Point(90, 26);
            this.klijentPrimateljTextBox.Name = "klijentPrimateljTextBox";
            this.klijentPrimateljTextBox.Size = new System.Drawing.Size(409, 22);
            this.klijentPrimateljTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Klijent:";
            // 
            // provediButton
            // 
            this.provediButton.Location = new System.Drawing.Point(377, 255);
            this.provediButton.Name = "provediButton";
            this.provediButton.Size = new System.Drawing.Size(84, 46);
            this.provediButton.TabIndex = 10;
            this.provediButton.Text = "Provedi";
            this.provediButton.UseVisualStyleBackColor = true;
            this.provediButton.Click += new System.EventHandler(this.provediButton_Click);
            // 
            // izlazButton
            // 
            this.izlazButton.Location = new System.Drawing.Point(467, 255);
            this.izlazButton.Name = "izlazButton";
            this.izlazButton.Size = new System.Drawing.Size(84, 46);
            this.izlazButton.TabIndex = 11;
            this.izlazButton.Text = "Izlaz";
            this.izlazButton.UseVisualStyleBackColor = true;
            this.izlazButton.Click += new System.EventHandler(this.odustaniButton_Click);
            // 
            // NovaTransakcijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 313);
            this.Controls.Add(this.izlazButton);
            this.Controls.Add(this.provediButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.iznosTextBox);
            this.Controls.Add(this.label3);
            this.Name = "NovaTransakcijaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nova transakcija";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox racunPlatiteljTextBox;
        private System.Windows.Forms.Button racunPlatiteljButton;
        private System.Windows.Forms.Button racunPrimateljButton;
        private System.Windows.Forms.TextBox racunPrimateljTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox iznosTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox klijentPlatiteljTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox klijentPrimateljTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button provediButton;
        private System.Windows.Forms.Button izlazButton;
        private System.Windows.Forms.Button klijentPlatiteljButton;
        private System.Windows.Forms.Button klijentPrimateljButton;
    }
}