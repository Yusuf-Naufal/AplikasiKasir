namespace AplikasiKasir.Antarmuka
{
    partial class BarangForm
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
            this.database_barang = new System.Windows.Forms.DataGridView();
            this.kode_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_beli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga_jual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.search_txt = new System.Windows.Forms.TextBox();
            this.Edit_pnl = new System.Windows.Forms.Panel();
            this.bersih_btn = new System.Windows.Forms.PictureBox();
            this.katbrg_cmb = new System.Windows.Forms.ComboBox();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.ubah_btn = new System.Windows.Forms.Button();
            this.satuan_txt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.hrgjual_txt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.hrgbeli_txt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.jumlah_txt = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.namabrg_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.kodebrg_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idUsers_lbl = new System.Windows.Forms.Label();
            this.reflash_btn = new System.Windows.Forms.Button();
            this.tambahbarang_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Header_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database_barang)).BeginInit();
            this.Edit_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bersih_btn)).BeginInit();
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
            this.Header_pnl.Name = "Header_pnl";
            this.Header_pnl.Size = new System.Drawing.Size(1663, 111);
            this.Header_pnl.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "List barang yang ada di toko";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Barang";
            // 
            // database_barang
            // 
            this.database_barang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.database_barang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.database_barang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kode_barang,
            this.nama_barang,
            this.nama_kategori,
            this.jumlah,
            this.harga_beli,
            this.harga_jual,
            this.satuan});
            this.database_barang.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.database_barang.Location = new System.Drawing.Point(522, 184);
            this.database_barang.Name = "database_barang";
            this.database_barang.RowHeadersWidth = 51;
            this.database_barang.RowTemplate.Height = 24;
            this.database_barang.Size = new System.Drawing.Size(1068, 751);
            this.database_barang.TabIndex = 2;
            this.database_barang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.database_barang_CellClick);
            // 
            // kode_barang
            // 
            this.kode_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kode_barang.DataPropertyName = "kode_barang";
            this.kode_barang.HeaderText = "Kode Barang";
            this.kode_barang.MinimumWidth = 6;
            this.kode_barang.Name = "kode_barang";
            this.kode_barang.Width = 115;
            // 
            // nama_barang
            // 
            this.nama_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nama_barang.DataPropertyName = "nama_barang";
            this.nama_barang.HeaderText = "Nama Barang";
            this.nama_barang.MinimumWidth = 6;
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.Width = 120;
            // 
            // nama_kategori
            // 
            this.nama_kategori.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nama_kategori.DataPropertyName = "nama_kategori";
            this.nama_kategori.HeaderText = "Kategori";
            this.nama_kategori.MinimumWidth = 6;
            this.nama_kategori.Name = "nama_kategori";
            this.nama_kategori.Width = 86;
            // 
            // jumlah
            // 
            this.jumlah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jumlah.DataPropertyName = "jumlah";
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.MinimumWidth = 6;
            this.jumlah.Name = "jumlah";
            this.jumlah.Width = 79;
            // 
            // harga_beli
            // 
            this.harga_beli.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.harga_beli.DataPropertyName = "harga_beli";
            this.harga_beli.HeaderText = "Harga Beli";
            this.harga_beli.MinimumWidth = 6;
            this.harga_beli.Name = "harga_beli";
            // 
            // harga_jual
            // 
            this.harga_jual.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.harga_jual.DataPropertyName = "harga_jual";
            this.harga_jual.HeaderText = "Harga Jual";
            this.harga_jual.MinimumWidth = 6;
            this.harga_jual.Name = "harga_jual";
            this.harga_jual.Width = 102;
            // 
            // satuan
            // 
            this.satuan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.satuan.DataPropertyName = "satuan";
            this.satuan.HeaderText = "Satuan";
            this.satuan.MinimumWidth = 6;
            this.satuan.Name = "satuan";
            // 
            // search_txt
            // 
            this.search_txt.BackColor = System.Drawing.SystemColors.Control;
            this.search_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.search_txt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(1308, 135);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(282, 31);
            this.search_txt.TabIndex = 4;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // Edit_pnl
            // 
            this.Edit_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.Edit_pnl.Controls.Add(this.bersih_btn);
            this.Edit_pnl.Controls.Add(this.katbrg_cmb);
            this.Edit_pnl.Controls.Add(this.hapus_btn);
            this.Edit_pnl.Controls.Add(this.ubah_btn);
            this.Edit_pnl.Controls.Add(this.satuan_txt);
            this.Edit_pnl.Controls.Add(this.label10);
            this.Edit_pnl.Controls.Add(this.hrgjual_txt);
            this.Edit_pnl.Controls.Add(this.label9);
            this.Edit_pnl.Controls.Add(this.hrgbeli_txt);
            this.Edit_pnl.Controls.Add(this.label8);
            this.Edit_pnl.Controls.Add(this.jumlah_txt);
            this.Edit_pnl.Controls.Add(this.label7);
            this.Edit_pnl.Controls.Add(this.label6);
            this.Edit_pnl.Controls.Add(this.namabrg_txt);
            this.Edit_pnl.Controls.Add(this.label5);
            this.Edit_pnl.Controls.Add(this.kodebrg_txt);
            this.Edit_pnl.Controls.Add(this.label4);
            this.Edit_pnl.Controls.Add(this.label3);
            this.Edit_pnl.Location = new System.Drawing.Point(12, 135);
            this.Edit_pnl.Name = "Edit_pnl";
            this.Edit_pnl.Size = new System.Drawing.Size(478, 714);
            this.Edit_pnl.TabIndex = 5;
            // 
            // bersih_btn
            // 
            this.bersih_btn.Image = global::AplikasiKasir.Properties.Resources.trashIcon;
            this.bersih_btn.Location = new System.Drawing.Point(404, 24);
            this.bersih_btn.Name = "bersih_btn";
            this.bersih_btn.Size = new System.Drawing.Size(37, 38);
            this.bersih_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bersih_btn.TabIndex = 33;
            this.bersih_btn.TabStop = false;
            this.bersih_btn.Click += new System.EventHandler(this.bersih_btn_Click);
            // 
            // katbrg_cmb
            // 
            this.katbrg_cmb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.katbrg_cmb.FormattingEnabled = true;
            this.katbrg_cmb.Location = new System.Drawing.Point(26, 276);
            this.katbrg_cmb.Name = "katbrg_cmb";
            this.katbrg_cmb.Size = new System.Drawing.Size(414, 36);
            this.katbrg_cmb.TabIndex = 6;
            // 
            // hapus_btn
            // 
            this.hapus_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.hapus_btn.FlatAppearance.BorderSize = 0;
            this.hapus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapus_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_btn.Location = new System.Drawing.Point(30, 548);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(411, 42);
            this.hapus_btn.TabIndex = 20;
            this.hapus_btn.Text = "Hapus";
            this.hapus_btn.UseVisualStyleBackColor = false;
            this.hapus_btn.Click += new System.EventHandler(this.hapus_btn_Click);
            // 
            // ubah_btn
            // 
            this.ubah_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(191)))), ((int)(((byte)(0)))));
            this.ubah_btn.FlatAppearance.BorderSize = 0;
            this.ubah_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ubah_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubah_btn.Location = new System.Drawing.Point(30, 500);
            this.ubah_btn.Name = "ubah_btn";
            this.ubah_btn.Size = new System.Drawing.Size(411, 42);
            this.ubah_btn.TabIndex = 19;
            this.ubah_btn.Text = "Ubah";
            this.ubah_btn.UseVisualStyleBackColor = false;
            this.ubah_btn.Click += new System.EventHandler(this.ubah_btn_Click);
            // 
            // satuan_txt
            // 
            this.satuan_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.satuan_txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.satuan_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.satuan_txt.Location = new System.Drawing.Point(245, 435);
            this.satuan_txt.Name = "satuan_txt";
            this.satuan_txt.Size = new System.Drawing.Size(195, 27);
            this.satuan_txt.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(240, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 28);
            this.label10.TabIndex = 17;
            this.label10.Text = "Satuan";
            // 
            // hrgjual_txt
            // 
            this.hrgjual_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hrgjual_txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.hrgjual_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrgjual_txt.Location = new System.Drawing.Point(245, 354);
            this.hrgjual_txt.Name = "hrgjual_txt";
            this.hrgjual_txt.Size = new System.Drawing.Size(195, 27);
            this.hrgjual_txt.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(240, 323);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 28);
            this.label9.TabIndex = 15;
            this.label9.Text = "Harga Jual";
            // 
            // hrgbeli_txt
            // 
            this.hrgbeli_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hrgbeli_txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.hrgbeli_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hrgbeli_txt.Location = new System.Drawing.Point(27, 354);
            this.hrgbeli_txt.Name = "hrgbeli_txt";
            this.hrgbeli_txt.Size = new System.Drawing.Size(199, 27);
            this.hrgbeli_txt.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 320);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 28);
            this.label8.TabIndex = 13;
            this.label8.Text = "Harga Beli";
            // 
            // jumlah_txt
            // 
            this.jumlah_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jumlah_txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.jumlah_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlah_txt.Location = new System.Drawing.Point(26, 435);
            this.jumlah_txt.Name = "jumlah_txt";
            this.jumlah_txt.Size = new System.Drawing.Size(200, 27);
            this.jumlah_txt.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 404);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 28);
            this.label7.TabIndex = 11;
            this.label7.Text = "Jumlah";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Kategori";
            // 
            // namabrg_txt
            // 
            this.namabrg_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namabrg_txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.namabrg_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namabrg_txt.Location = new System.Drawing.Point(27, 202);
            this.namabrg_txt.Name = "namabrg_txt";
            this.namabrg_txt.Size = new System.Drawing.Size(413, 27);
            this.namabrg_txt.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nama Barang";
            // 
            // kodebrg_txt
            // 
            this.kodebrg_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kodebrg_txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.kodebrg_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodebrg_txt.Location = new System.Drawing.Point(26, 128);
            this.kodebrg_txt.Name = "kodebrg_txt";
            this.kodebrg_txt.Size = new System.Drawing.Size(414, 27);
            this.kodebrg_txt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kode Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edit Barang";
            // 
            // idUsers_lbl
            // 
            this.idUsers_lbl.AutoSize = true;
            this.idUsers_lbl.Location = new System.Drawing.Point(16, 108);
            this.idUsers_lbl.Name = "idUsers_lbl";
            this.idUsers_lbl.Size = new System.Drawing.Size(0, 16);
            this.idUsers_lbl.TabIndex = 35;
            this.idUsers_lbl.Visible = false;
            // 
            // reflash_btn
            // 
            this.reflash_btn.BackgroundImage = global::AplikasiKasir.Properties.Resources.reflashIcon1;
            this.reflash_btn.FlatAppearance.BorderSize = 0;
            this.reflash_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reflash_btn.Location = new System.Drawing.Point(583, 127);
            this.reflash_btn.Name = "reflash_btn";
            this.reflash_btn.Size = new System.Drawing.Size(52, 49);
            this.reflash_btn.TabIndex = 34;
            this.reflash_btn.UseVisualStyleBackColor = true;
            this.reflash_btn.Click += new System.EventHandler(this.reflash_btn_Click);
            // 
            // tambahbarang_btn
            // 
            this.tambahbarang_btn.BackgroundImage = global::AplikasiKasir.Properties.Resources.tambahIcon2;
            this.tambahbarang_btn.FlatAppearance.BorderSize = 0;
            this.tambahbarang_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambahbarang_btn.Location = new System.Drawing.Point(522, 127);
            this.tambahbarang_btn.Name = "tambahbarang_btn";
            this.tambahbarang_btn.Size = new System.Drawing.Size(55, 51);
            this.tambahbarang_btn.TabIndex = 33;
            this.tambahbarang_btn.UseVisualStyleBackColor = true;
            this.tambahbarang_btn.Click += new System.EventHandler(this.tambahbarang_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AplikasiKasir.Properties.Resources.Search;
            this.pictureBox1.Location = new System.Drawing.Point(1257, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // BarangForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1663, 1102);
            this.Controls.Add(this.idUsers_lbl);
            this.Controls.Add(this.reflash_btn);
            this.Controls.Add(this.tambahbarang_btn);
            this.Controls.Add(this.Edit_pnl);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.database_barang);
            this.Controls.Add(this.Header_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BarangForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BarangFrom";
            this.Load += new System.EventHandler(this.BarangFrom_Load);
            this.Header_pnl.ResumeLayout(false);
            this.Header_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database_barang)).EndInit();
            this.Edit_pnl.ResumeLayout(false);
            this.Edit_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bersih_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Header_pnl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView database_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_beli;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga_jual;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.Panel Edit_pnl;
        private System.Windows.Forms.TextBox jumlah_txt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox namabrg_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox kodebrg_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button ubah_btn;
        private System.Windows.Forms.TextBox satuan_txt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox hrgjual_txt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox hrgbeli_txt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox katbrg_cmb;
        private System.Windows.Forms.PictureBox bersih_btn;
        private System.Windows.Forms.Label idUsers_lbl;
        private System.Windows.Forms.Button reflash_btn;
        private System.Windows.Forms.Button tambahbarang_btn;
    }
}