
namespace Zadatak2
{
    partial class PopisAutobusnihLinija
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
            this.autobusneLinijeDataGridView = new System.Windows.Forms.DataGridView();
            this.odaberiButton = new System.Windows.Forms.Button();
            this.izlazButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.autobusneLinijeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // autobusneLinijeDataGridView
            // 
            this.autobusneLinijeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.autobusneLinijeDataGridView.Location = new System.Drawing.Point(12, 42);
            this.autobusneLinijeDataGridView.Name = "autobusneLinijeDataGridView";
            this.autobusneLinijeDataGridView.RowHeadersWidth = 51;
            this.autobusneLinijeDataGridView.RowTemplate.Height = 24;
            this.autobusneLinijeDataGridView.Size = new System.Drawing.Size(761, 331);
            this.autobusneLinijeDataGridView.TabIndex = 0;
            // 
            // odaberiButton
            // 
            this.odaberiButton.Location = new System.Drawing.Point(581, 391);
            this.odaberiButton.Name = "odaberiButton";
            this.odaberiButton.Size = new System.Drawing.Size(88, 29);
            this.odaberiButton.TabIndex = 1;
            this.odaberiButton.Text = "Odaberi";
            this.odaberiButton.UseVisualStyleBackColor = true;
            this.odaberiButton.Click += new System.EventHandler(this.odaberiButton_Click);
            // 
            // izlazButton
            // 
            this.izlazButton.Location = new System.Drawing.Point(685, 391);
            this.izlazButton.Name = "izlazButton";
            this.izlazButton.Size = new System.Drawing.Size(88, 29);
            this.izlazButton.TabIndex = 2;
            this.izlazButton.Text = "Izlaz";
            this.izlazButton.UseVisualStyleBackColor = true;
            this.izlazButton.Click += new System.EventHandler(this.izlazButton_Click);
            // 
            // PopisAutobusnihLinija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.izlazButton);
            this.Controls.Add(this.odaberiButton);
            this.Controls.Add(this.autobusneLinijeDataGridView);
            this.Name = "PopisAutobusnihLinija";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PopisAutobusnihLinija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autobusneLinijeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView autobusneLinijeDataGridView;
        private System.Windows.Forms.Button odaberiButton;
        private System.Windows.Forms.Button izlazButton;
    }
}

