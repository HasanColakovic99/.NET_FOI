
namespace Zadatak11
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pitanjeTextBox = new System.Windows.Forms.TextBox();
            this.pitanjeButton = new System.Windows.Forms.Button();
            this.odgovorButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.potvrdjenOdgovorTextBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pitanje:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mogući odgovori:";
            // 
            // pitanjeTextBox
            // 
            this.pitanjeTextBox.Enabled = false;
            this.pitanjeTextBox.Location = new System.Drawing.Point(190, 43);
            this.pitanjeTextBox.Name = "pitanjeTextBox";
            this.pitanjeTextBox.Size = new System.Drawing.Size(410, 22);
            this.pitanjeTextBox.TabIndex = 2;
            this.pitanjeTextBox.TextChanged += new System.EventHandler(this.pitanjeTextBox_TextChanged);
            // 
            // pitanjeButton
            // 
            this.pitanjeButton.Location = new System.Drawing.Point(434, 134);
            this.pitanjeButton.Name = "pitanjeButton";
            this.pitanjeButton.Size = new System.Drawing.Size(166, 110);
            this.pitanjeButton.TabIndex = 4;
            this.pitanjeButton.Text = "Sljedeće pitanje >>";
            this.pitanjeButton.UseVisualStyleBackColor = true;
            this.pitanjeButton.Click += new System.EventHandler(this.pitanjeButton_Click);
            // 
            // odgovorButton
            // 
            this.odgovorButton.Location = new System.Drawing.Point(190, 260);
            this.odgovorButton.Name = "odgovorButton";
            this.odgovorButton.Size = new System.Drawing.Size(220, 37);
            this.odgovorButton.TabIndex = 5;
            this.odgovorButton.Text = "Potvrdi odgovor";
            this.odgovorButton.UseVisualStyleBackColor = true;
            this.odgovorButton.Click += new System.EventHandler(this.odgovorButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Potvrđeni odgovor:";
            // 
            // potvrdjenOdgovorTextBox
            // 
            this.potvrdjenOdgovorTextBox.Enabled = false;
            this.potvrdjenOdgovorTextBox.Location = new System.Drawing.Point(190, 343);
            this.potvrdjenOdgovorTextBox.Name = "potvrdjenOdgovorTextBox";
            this.potvrdjenOdgovorTextBox.Size = new System.Drawing.Size(220, 22);
            this.potvrdjenOdgovorTextBox.TabIndex = 7;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 16;
            this.listBox.Location = new System.Drawing.Point(190, 128);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(220, 116);
            this.listBox.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 405);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.potvrdjenOdgovorTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.odgovorButton);
            this.Controls.Add(this.pitanjeButton);
            this.Controls.Add(this.pitanjeTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pitanjeTextBox;
        private System.Windows.Forms.Button pitanjeButton;
        private System.Windows.Forms.Button odgovorButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox potvrdjenOdgovorTextBox;
        private System.Windows.Forms.ListBox listBox;
    }
}

