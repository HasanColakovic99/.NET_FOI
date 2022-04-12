
namespace FiltriranjeTransakcija
{
    partial class FormTransakcije
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
            this.radioButtonUplate = new System.Windows.Forms.RadioButton();
            this.radioButtonIsplate = new System.Windows.Forms.RadioButton();
            this.radioButtonSve = new System.Windows.Forms.RadioButton();
            this.comboBoxRacun = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFiltriraj = new System.Windows.Forms.Button();
            this.buttonOcisti = new System.Windows.Forms.Button();
            this.dataGridViewTransakcije = new System.Windows.Forms.DataGridView();
            this.buttonDetaljiRacuna = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransakcije)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonUplate);
            this.groupBox1.Controls.Add(this.radioButtonIsplate);
            this.groupBox1.Controls.Add(this.radioButtonSve);
            this.groupBox1.Controls.Add(this.comboBoxRacun);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 114);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter:";
            // 
            // radioButtonUplate
            // 
            this.radioButtonUplate.AutoSize = true;
            this.radioButtonUplate.Location = new System.Drawing.Point(257, 63);
            this.radioButtonUplate.Name = "radioButtonUplate";
            this.radioButtonUplate.Size = new System.Drawing.Size(70, 21);
            this.radioButtonUplate.TabIndex = 5;
            this.radioButtonUplate.TabStop = true;
            this.radioButtonUplate.Text = "Uplate";
            this.radioButtonUplate.UseVisualStyleBackColor = true;
            // 
            // radioButtonIsplate
            // 
            this.radioButtonIsplate.AutoSize = true;
            this.radioButtonIsplate.Location = new System.Drawing.Point(181, 63);
            this.radioButtonIsplate.Name = "radioButtonIsplate";
            this.radioButtonIsplate.Size = new System.Drawing.Size(70, 21);
            this.radioButtonIsplate.TabIndex = 4;
            this.radioButtonIsplate.TabStop = true;
            this.radioButtonIsplate.Text = "Isplate";
            this.radioButtonIsplate.UseVisualStyleBackColor = true;
            // 
            // radioButtonSve
            // 
            this.radioButtonSve.AutoSize = true;
            this.radioButtonSve.Location = new System.Drawing.Point(122, 63);
            this.radioButtonSve.Name = "radioButtonSve";
            this.radioButtonSve.Size = new System.Drawing.Size(53, 21);
            this.radioButtonSve.TabIndex = 3;
            this.radioButtonSve.TabStop = true;
            this.radioButtonSve.Text = "Sve";
            this.radioButtonSve.UseVisualStyleBackColor = true;
            // 
            // comboBoxRacun
            // 
            this.comboBoxRacun.FormattingEnabled = true;
            this.comboBoxRacun.Location = new System.Drawing.Point(122, 19);
            this.comboBoxRacun.Name = "comboBoxRacun";
            this.comboBoxRacun.Size = new System.Drawing.Size(205, 24);
            this.comboBoxRacun.TabIndex = 2;
            this.comboBoxRacun.SelectedIndexChanged += new System.EventHandler(this.comboBoxRacun_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip transakcije:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Račun:";
            // 
            // buttonFiltriraj
            // 
            this.buttonFiltriraj.Location = new System.Drawing.Point(368, 26);
            this.buttonFiltriraj.Name = "buttonFiltriraj";
            this.buttonFiltriraj.Size = new System.Drawing.Size(123, 68);
            this.buttonFiltriraj.TabIndex = 6;
            this.buttonFiltriraj.Text = "Filtriraj";
            this.buttonFiltriraj.UseVisualStyleBackColor = true;
            this.buttonFiltriraj.Click += new System.EventHandler(this.buttonFiltriraj_Click);
            // 
            // buttonOcisti
            // 
            this.buttonOcisti.Location = new System.Drawing.Point(507, 26);
            this.buttonOcisti.Name = "buttonOcisti";
            this.buttonOcisti.Size = new System.Drawing.Size(123, 68);
            this.buttonOcisti.TabIndex = 7;
            this.buttonOcisti.Text = "Ocisti";
            this.buttonOcisti.UseVisualStyleBackColor = true;
            this.buttonOcisti.Click += new System.EventHandler(this.buttonOcisti_Click);
            // 
            // dataGridViewTransakcije
            // 
            this.dataGridViewTransakcije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransakcije.Location = new System.Drawing.Point(12, 133);
            this.dataGridViewTransakcije.Name = "dataGridViewTransakcije";
            this.dataGridViewTransakcije.RowHeadersWidth = 51;
            this.dataGridViewTransakcije.RowTemplate.Height = 24;
            this.dataGridViewTransakcije.Size = new System.Drawing.Size(688, 232);
            this.dataGridViewTransakcije.TabIndex = 8;
            // 
            // buttonDetaljiRacuna
            // 
            this.buttonDetaljiRacuna.Location = new System.Drawing.Point(599, 371);
            this.buttonDetaljiRacuna.Name = "buttonDetaljiRacuna";
            this.buttonDetaljiRacuna.Size = new System.Drawing.Size(101, 68);
            this.buttonDetaljiRacuna.TabIndex = 9;
            this.buttonDetaljiRacuna.Text = "Detalji Računa";
            this.buttonDetaljiRacuna.UseVisualStyleBackColor = true;
            this.buttonDetaljiRacuna.Click += new System.EventHandler(this.buttonDetaljiRacuna_Click);
            // 
            // FormTransakcije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.buttonDetaljiRacuna);
            this.Controls.Add(this.dataGridViewTransakcije);
            this.Controls.Add(this.buttonOcisti);
            this.Controls.Add(this.buttonFiltriraj);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTransakcije";
            this.Text = "Popis transakcija";
            this.Load += new System.EventHandler(this.FormTransakcije_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransakcije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxRacun;
        private System.Windows.Forms.RadioButton radioButtonSve;
        private System.Windows.Forms.RadioButton radioButtonIsplate;
        private System.Windows.Forms.RadioButton radioButtonUplate;
        private System.Windows.Forms.Button buttonFiltriraj;
        private System.Windows.Forms.Button buttonOcisti;
        private System.Windows.Forms.DataGridView dataGridViewTransakcije;
        private System.Windows.Forms.Button buttonDetaljiRacuna;
    }
}

