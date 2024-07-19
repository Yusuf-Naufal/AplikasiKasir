namespace AplikasiKasir.Antarmuka
{
    partial class LaporanForm
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
            this.Header_pnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.database_laporan = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_transaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kode_transaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal_transaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_kasir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Header_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database_laporan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Header_pnl
            // 
            this.Header_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.Header_pnl.Controls.Add(this.label2);
            this.Header_pnl.Controls.Add(this.label1);
            this.Header_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_pnl.Location = new System.Drawing.Point(0, 0);
            this.Header_pnl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Header_pnl.Name = "Header_pnl";
            this.Header_pnl.Size = new System.Drawing.Size(1306, 90);
            this.Header_pnl.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(237, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "TreckRecord transaksi penjualan ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Laporan Penjualan";
            // 
            // database_laporan
            // 
            this.database_laporan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.database_laporan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.database_laporan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.id_transaksi,
            this.kode_transaksi,
            this.tanggal_transaksi,
            this.nama_kasir,
            this.total_harga});
            this.database_laporan.Location = new System.Drawing.Point(28, 145);
            this.database_laporan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.database_laporan.Name = "database_laporan";
            this.database_laporan.RowHeadersWidth = 51;
            this.database_laporan.RowTemplate.Height = 24;
            this.database_laporan.Size = new System.Drawing.Size(1145, 574);
            this.database_laporan.TabIndex = 2;
            // 
            // no
            // 
            this.no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.no.DataPropertyName = "No";
            this.no.HeaderText = "No";
            this.no.MinimumWidth = 6;
            this.no.Name = "no";
            this.no.Width = 46;
            // 
            // id_transaksi
            // 
            this.id_transaksi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id_transaksi.DataPropertyName = "id_transaksi";
            this.id_transaksi.HeaderText = "ID Transaksi";
            this.id_transaksi.MinimumWidth = 6;
            this.id_transaksi.Name = "id_transaksi";
            this.id_transaksi.Width = 85;
            // 
            // kode_transaksi
            // 
            this.kode_transaksi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kode_transaksi.DataPropertyName = "kode_transaksi";
            this.kode_transaksi.HeaderText = "Kode Transaksi";
            this.kode_transaksi.MinimumWidth = 6;
            this.kode_transaksi.Name = "kode_transaksi";
            this.kode_transaksi.Width = 97;
            // 
            // tanggal_transaksi
            // 
            this.tanggal_transaksi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.tanggal_transaksi.DataPropertyName = "tanggal_transaksi";
            this.tanggal_transaksi.HeaderText = "Tanggal Transaksi";
            this.tanggal_transaksi.MinimumWidth = 6;
            this.tanggal_transaksi.Name = "tanggal_transaksi";
            this.tanggal_transaksi.Width = 110;
            // 
            // nama_kasir
            // 
            this.nama_kasir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nama_kasir.DataPropertyName = "nama_kasir";
            this.nama_kasir.HeaderText = "Nama Kasir";
            this.nama_kasir.MinimumWidth = 6;
            this.nama_kasir.Name = "nama_kasir";
            this.nama_kasir.Width = 79;
            // 
            // total_harga
            // 
            this.total_harga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total_harga.DataPropertyName = "total_harga";
            this.total_harga.HeaderText = "Total Belanja";
            this.total_harga.MinimumWidth = 6;
            this.total_harga.Name = "total_harga";
            // 
            // search_txt
            // 
            this.search_txt.BackColor = System.Drawing.SystemColors.Control;
            this.search_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.search_txt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(64, 106);
            this.search_txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(212, 25);
            this.search_txt.TabIndex = 11;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AplikasiKasir.Properties.Resources.Search;
            this.pictureBox1.Location = new System.Drawing.Point(25, 103);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // LaporanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1306, 783);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.database_laporan);
            this.Controls.Add(this.Header_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LaporanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LaporanForm";
            this.Load += new System.EventHandler(this.LaporanForm_Load);
            this.Header_pnl.ResumeLayout(false);
            this.Header_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database_laporan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header_pnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView database_laporan;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_transaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_transaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal_transaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_kasir;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_harga;
    }
}