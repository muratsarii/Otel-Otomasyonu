namespace OtelOtomasyonu.WinFormUI
{
    partial class frmBirimTip
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
            this.txtBirimTipleriAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgrBirimTip = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrBirimTip)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBirimTipleriAdi
            // 
            this.txtBirimTipleriAdi.Location = new System.Drawing.Point(168, 39);
            this.txtBirimTipleriAdi.Name = "txtBirimTipleriAdi";
            this.txtBirimTipleriAdi.Size = new System.Drawing.Size(100, 22);
            this.txtBirimTipleriAdi.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "BİRİM TİPLERİ ADI";
            // 
            // dtgrBirimTip
            // 
            this.dtgrBirimTip.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrBirimTip.Location = new System.Drawing.Point(18, 87);
            this.dtgrBirimTip.Name = "dtgrBirimTip";
            this.dtgrBirimTip.RowTemplate.Height = 24;
            this.dtgrBirimTip.Size = new System.Drawing.Size(384, 150);
            this.dtgrBirimTip.TabIndex = 7;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(327, 38);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmBirimTip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 259);
            this.Controls.Add(this.txtBirimTipleriAdi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgrBirimTip);
            this.Controls.Add(this.btnEkle);
            this.Name = "frmBirimTip";
            this.Text = "frmBirimTip";
            this.Load += new System.EventHandler(this.frmBirimTip_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrBirimTip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBirimTipleriAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgrBirimTip;
        private System.Windows.Forms.Button btnEkle;
    }
}