
namespace AutobusniKolodovor
{
    partial class PopisLinijaForm
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
            this.odaberiButton = new System.Windows.Forms.Button();
            this.izlazButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.linijeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // linijeDataGridView
            // 
            this.linijeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.linijeDataGridView.Location = new System.Drawing.Point(12, 12);
            this.linijeDataGridView.Name = "linijeDataGridView";
            this.linijeDataGridView.RowHeadersWidth = 51;
            this.linijeDataGridView.RowTemplate.Height = 24;
            this.linijeDataGridView.Size = new System.Drawing.Size(689, 370);
            this.linijeDataGridView.TabIndex = 0;
            // 
            // odaberiButton
            // 
            this.odaberiButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.odaberiButton.Location = new System.Drawing.Point(529, 401);
            this.odaberiButton.Name = "odaberiButton";
            this.odaberiButton.Size = new System.Drawing.Size(75, 23);
            this.odaberiButton.TabIndex = 1;
            this.odaberiButton.Text = "Odaberi";
            this.odaberiButton.UseVisualStyleBackColor = true;
            this.odaberiButton.Click += new System.EventHandler(this.odaberiButton_Click);
            // 
            // izlazButton
            // 
            this.izlazButton.Location = new System.Drawing.Point(626, 401);
            this.izlazButton.Name = "izlazButton";
            this.izlazButton.Size = new System.Drawing.Size(75, 23);
            this.izlazButton.TabIndex = 2;
            this.izlazButton.Text = "Izlaz";
            this.izlazButton.UseVisualStyleBackColor = true;
            this.izlazButton.Click += new System.EventHandler(this.izlazButton_Click);
            // 
            // PopisLinijaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 450);
            this.Controls.Add(this.izlazButton);
            this.Controls.Add(this.odaberiButton);
            this.Controls.Add(this.linijeDataGridView);
            this.Name = "PopisLinijaForm";
            this.Text = "PopisLinijaForm";
            this.Load += new System.EventHandler(this.PopisLinijaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.linijeDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView linijeDataGridView;
        private System.Windows.Forms.Button odaberiButton;
        private System.Windows.Forms.Button izlazButton;
    }
}