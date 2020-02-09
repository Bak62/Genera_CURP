namespace Genera_CURP
{
    partial class FRMregistros
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
            this.DGVregistros = new System.Windows.Forms.DataGridView();
            this.BTNseleccionar = new System.Windows.Forms.Button();
            this.BTNcancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVregistros)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVregistros
            // 
            this.DGVregistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVregistros.Location = new System.Drawing.Point(12, 12);
            this.DGVregistros.MultiSelect = false;
            this.DGVregistros.Name = "DGVregistros";
            this.DGVregistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVregistros.Size = new System.Drawing.Size(495, 475);
            this.DGVregistros.TabIndex = 0;
            this.DGVregistros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVregistros_CellContentClick);
            // 
            // BTNseleccionar
            // 
            this.BTNseleccionar.Location = new System.Drawing.Point(12, 493);
            this.BTNseleccionar.Name = "BTNseleccionar";
            this.BTNseleccionar.Size = new System.Drawing.Size(155, 45);
            this.BTNseleccionar.TabIndex = 1;
            this.BTNseleccionar.Text = "Seleccionar";
            this.BTNseleccionar.UseVisualStyleBackColor = true;
            // 
            // BTNcancelar
            // 
            this.BTNcancelar.Location = new System.Drawing.Point(352, 493);
            this.BTNcancelar.Name = "BTNcancelar";
            this.BTNcancelar.Size = new System.Drawing.Size(155, 45);
            this.BTNcancelar.TabIndex = 2;
            this.BTNcancelar.Text = "Cancelar";
            this.BTNcancelar.UseVisualStyleBackColor = true;
            this.BTNcancelar.Click += new System.EventHandler(this.BTNcancelar_Click);
            // 
            // FRMregistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 573);
            this.Controls.Add(this.BTNcancelar);
            this.Controls.Add(this.BTNseleccionar);
            this.Controls.Add(this.DGVregistros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRMregistros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRMregistros";
            ((System.ComponentModel.ISupportInitialize)(this.DGVregistros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVregistros;
        private System.Windows.Forms.Button BTNseleccionar;
        private System.Windows.Forms.Button BTNcancelar;
    }
}