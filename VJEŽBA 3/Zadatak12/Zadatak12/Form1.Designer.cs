
namespace Zadatak12
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
            this.prethodnoPitanjeButton = new System.Windows.Forms.Button();
            this.sljedecePitanjeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pitanjeTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prethodnoPitanjeButton
            // 
            this.prethodnoPitanjeButton.Location = new System.Drawing.Point(62, 42);
            this.prethodnoPitanjeButton.Name = "prethodnoPitanjeButton";
            this.prethodnoPitanjeButton.Size = new System.Drawing.Size(182, 54);
            this.prethodnoPitanjeButton.TabIndex = 0;
            this.prethodnoPitanjeButton.Text = "<< Prethodno pitanje";
            this.prethodnoPitanjeButton.UseVisualStyleBackColor = true;
            this.prethodnoPitanjeButton.Click += new System.EventHandler(this.prethodnoPitanjeButton_Click);
            // 
            // sljedecePitanjeButton
            // 
            this.sljedecePitanjeButton.Location = new System.Drawing.Point(262, 42);
            this.sljedecePitanjeButton.Name = "sljedecePitanjeButton";
            this.sljedecePitanjeButton.Size = new System.Drawing.Size(182, 54);
            this.sljedecePitanjeButton.TabIndex = 1;
            this.sljedecePitanjeButton.Text = "Sljedeće pitanje >>";
            this.sljedecePitanjeButton.UseVisualStyleBackColor = true;
            this.sljedecePitanjeButton.Click += new System.EventHandler(this.sljedecePitanjeButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "PITANJE:";
            // 
            // pitanjeTextBox
            // 
            this.pitanjeTextBox.Enabled = false;
            this.pitanjeTextBox.Location = new System.Drawing.Point(62, 179);
            this.pitanjeTextBox.Multiline = true;
            this.pitanjeTextBox.Name = "pitanjeTextBox";
            this.pitanjeTextBox.Size = new System.Drawing.Size(382, 58);
            this.pitanjeTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 286);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "ODGOVORI:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 326);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(382, 57);
            this.button1.TabIndex = 5;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(62, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(382, 56);
            this.button2.TabIndex = 6;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(62, 481);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(382, 56);
            this.button3.TabIndex = 7;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(62, 564);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(382, 56);
            this.button4.TabIndex = 8;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 661);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pitanjeTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sljedecePitanjeButton);
            this.Controls.Add(this.prethodnoPitanjeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button prethodnoPitanjeButton;
        private System.Windows.Forms.Button sljedecePitanjeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox pitanjeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

