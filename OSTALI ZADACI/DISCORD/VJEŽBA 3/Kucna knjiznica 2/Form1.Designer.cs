namespace Kucna_knjiznica_2
{
    partial class FormGlavna
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
            this.radioButtonSvePosudbe = new System.Windows.Forms.RadioButton();
            this.radioButtonTrenutnePosudbe = new System.Windows.Forms.RadioButton();
            this.radioButtonProslePosudbe = new System.Windows.Forms.RadioButton();
            this.dataGridViewPosudbe = new System.Windows.Forms.DataGridView();
            this.ButtonVratiKnjigu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosudbe)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prikaži:";
            // 
            // radioButtonSvePosudbe
            // 
            this.radioButtonSvePosudbe.AutoSize = true;
            this.radioButtonSvePosudbe.Location = new System.Drawing.Point(90, 21);
            this.radioButtonSvePosudbe.Name = "radioButtonSvePosudbe";
            this.radioButtonSvePosudbe.Size = new System.Drawing.Size(88, 17);
            this.radioButtonSvePosudbe.TabIndex = 1;
            this.radioButtonSvePosudbe.TabStop = true;
            this.radioButtonSvePosudbe.Text = "Sve posudbe";
            this.radioButtonSvePosudbe.UseVisualStyleBackColor = true;
            this.radioButtonSvePosudbe.CheckedChanged += new System.EventHandler(this.radioButtonSvePosudbe_CheckedChanged);
            // 
            // radioButtonTrenutnePosudbe
            // 
            this.radioButtonTrenutnePosudbe.AutoSize = true;
            this.radioButtonTrenutnePosudbe.Location = new System.Drawing.Point(197, 21);
            this.radioButtonTrenutnePosudbe.Name = "radioButtonTrenutnePosudbe";
            this.radioButtonTrenutnePosudbe.Size = new System.Drawing.Size(112, 17);
            this.radioButtonTrenutnePosudbe.TabIndex = 2;
            this.radioButtonTrenutnePosudbe.TabStop = true;
            this.radioButtonTrenutnePosudbe.Text = "Trenutne posudbe";
            this.radioButtonTrenutnePosudbe.UseVisualStyleBackColor = true;
            this.radioButtonTrenutnePosudbe.CheckedChanged += new System.EventHandler(this.radioButtonTrenutnePosudbe_CheckedChanged);
            // 
            // radioButtonProslePosudbe
            // 
            this.radioButtonProslePosudbe.AutoSize = true;
            this.radioButtonProslePosudbe.Location = new System.Drawing.Point(330, 21);
            this.radioButtonProslePosudbe.Name = "radioButtonProslePosudbe";
            this.radioButtonProslePosudbe.Size = new System.Drawing.Size(98, 17);
            this.radioButtonProslePosudbe.TabIndex = 3;
            this.radioButtonProslePosudbe.TabStop = true;
            this.radioButtonProslePosudbe.Text = "Prošle posudbe";
            this.radioButtonProslePosudbe.UseVisualStyleBackColor = true;
            this.radioButtonProslePosudbe.CheckedChanged += new System.EventHandler(this.radioButtonProslePosudbe_CheckedChanged);
            // 
            // dataGridViewPosudbe
            // 
            this.dataGridViewPosudbe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPosudbe.Location = new System.Drawing.Point(28, 44);
            this.dataGridViewPosudbe.Name = "dataGridViewPosudbe";
            this.dataGridViewPosudbe.Size = new System.Drawing.Size(721, 196);
            this.dataGridViewPosudbe.TabIndex = 4;
            // 
            // ButtonVratiKnjigu
            // 
            this.ButtonVratiKnjigu.Location = new System.Drawing.Point(674, 258);
            this.ButtonVratiKnjigu.Name = "ButtonVratiKnjigu";
            this.ButtonVratiKnjigu.Size = new System.Drawing.Size(75, 23);
            this.ButtonVratiKnjigu.TabIndex = 5;
            this.ButtonVratiKnjigu.Text = "Vrati knjigu";
            this.ButtonVratiKnjigu.UseVisualStyleBackColor = true;
            this.ButtonVratiKnjigu.Click += new System.EventHandler(this.ButtonVratiKnjigu_Click);
            // 
            // FormGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 296);
            this.Controls.Add(this.ButtonVratiKnjigu);
            this.Controls.Add(this.dataGridViewPosudbe);
            this.Controls.Add(this.radioButtonProslePosudbe);
            this.Controls.Add(this.radioButtonTrenutnePosudbe);
            this.Controls.Add(this.radioButtonSvePosudbe);
            this.Controls.Add(this.label1);
            this.Name = "FormGlavna";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Posudbe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPosudbe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonSvePosudbe;
        private System.Windows.Forms.RadioButton radioButtonTrenutnePosudbe;
        private System.Windows.Forms.RadioButton radioButtonProslePosudbe;
        private System.Windows.Forms.DataGridView dataGridViewPosudbe;
        private System.Windows.Forms.Button ButtonVratiKnjigu;
    }
}

