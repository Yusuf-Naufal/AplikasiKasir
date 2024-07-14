namespace AplikasiKasir.Antarmuka
{
    partial class TransaksiForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransaksiForm));
            this.database_keranjang = new System.Windows.Forms.DataGridView();
            this.id_keranjang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kode_transaksi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kode_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalHarga_txt = new System.Windows.Forms.TextBox();
            this.waktu_lbl = new System.Windows.Forms.Label();
            this.Waktu = new System.Windows.Forms.Timer(this.components);
            this.tanggal_lbl = new System.Windows.Forms.Label();
            this.kode_txt = new System.Windows.Forms.TextBox();
            this.jumlah_txt = new System.Windows.Forms.TextBox();
            this.nama_barang_txt = new System.Windows.Forms.TextBox();
            this.harga_txt = new System.Windows.Forms.TextBox();
            this.subtotal_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.kode_transaksi_txt = new System.Windows.Forms.TextBox();
            this.id_ker_txt = new System.Windows.Forms.TextBox();
            this.payment_btn = new System.Windows.Forms.PictureBox();
            this.bersih_btn = new System.Windows.Forms.PictureBox();
            this.hapusBelanja_btn = new System.Windows.Forms.PictureBox();
            this.tambahBelanja_btn = new System.Windows.Forms.PictureBox();
            this.dashboard_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.database_keranjang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bersih_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hapusBelanja_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tambahBelanja_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboard_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // database_keranjang
            // 
            this.database_keranjang.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.database_keranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.database_keranjang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_keranjang,
            this.kode_transaksi,
            this.kode_barang,
            this.nama_barang,
            this.harga,
            this.jumlah_barang,
            this.subtotal,
            this.tanggal});
            this.database_keranjang.Location = new System.Drawing.Point(74, 195);
            this.database_keranjang.Name = "database_keranjang";
            this.database_keranjang.RowHeadersWidth = 51;
            this.database_keranjang.RowTemplate.Height = 24;
            this.database_keranjang.Size = new System.Drawing.Size(1894, 768);
            this.database_keranjang.TabIndex = 0;
            this.database_keranjang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.database_keranjang_CellClick);
            // 
            // id_keranjang
            // 
            this.id_keranjang.DataPropertyName = "id_keranjang";
            this.id_keranjang.HeaderText = "ID";
            this.id_keranjang.MinimumWidth = 6;
            this.id_keranjang.Name = "id_keranjang";
            this.id_keranjang.Visible = false;
            this.id_keranjang.Width = 125;
            // 
            // kode_transaksi
            // 
            this.kode_transaksi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kode_transaksi.DataPropertyName = "kode_transaksi";
            this.kode_transaksi.HeaderText = "Kode Transaksi";
            this.kode_transaksi.MinimumWidth = 6;
            this.kode_transaksi.Name = "kode_transaksi";
            this.kode_transaksi.Width = 120;
            // 
            // kode_barang
            // 
            this.kode_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kode_barang.DataPropertyName = "kode_barang";
            this.kode_barang.HeaderText = "Kode Barang";
            this.kode_barang.MinimumWidth = 6;
            this.kode_barang.Name = "kode_barang";
            this.kode_barang.Width = 106;
            // 
            // nama_barang
            // 
            this.nama_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nama_barang.DataPropertyName = "nama_barang";
            this.nama_barang.HeaderText = "Nama Barang";
            this.nama_barang.MinimumWidth = 6;
            this.nama_barang.Name = "nama_barang";
            this.nama_barang.Width = 110;
            // 
            // harga
            // 
            this.harga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.harga.DataPropertyName = "harga_jual";
            this.harga.HeaderText = "Harga ";
            this.harga.MinimumWidth = 6;
            this.harga.Name = "harga";
            this.harga.Width = 77;
            // 
            // jumlah_barang
            // 
            this.jumlah_barang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jumlah_barang.DataPropertyName = "jumlah_barang";
            this.jumlah_barang.HeaderText = "Jumlah";
            this.jumlah_barang.MinimumWidth = 6;
            this.jumlah_barang.Name = "jumlah_barang";
            this.jumlah_barang.Width = 79;
            // 
            // subtotal
            // 
            this.subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.subtotal.DataPropertyName = "subtotal";
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.MinimumWidth = 6;
            this.subtotal.Name = "subtotal";
            this.subtotal.Width = 85;
            // 
            // tanggal
            // 
            this.tanggal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tanggal.DataPropertyName = "tanggal_transaksi";
            this.tanggal.HeaderText = "Tanggal";
            this.tanggal.MinimumWidth = 6;
            this.tanggal.Name = "tanggal";
            // 
            // totalHarga_txt
            // 
            this.totalHarga_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.totalHarga_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalHarga_txt.Font = new System.Drawing.Font("Microsoft Tai Le", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHarga_txt.Location = new System.Drawing.Point(1182, 35);
            this.totalHarga_txt.Name = "totalHarga_txt";
            this.totalHarga_txt.Size = new System.Drawing.Size(786, 71);
            this.totalHarga_txt.TabIndex = 1;
            this.totalHarga_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // waktu_lbl
            // 
            this.waktu_lbl.AutoSize = true;
            this.waktu_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waktu_lbl.Location = new System.Drawing.Point(1666, 159);
            this.waktu_lbl.Name = "waktu_lbl";
            this.waktu_lbl.Size = new System.Drawing.Size(154, 30);
            this.waktu_lbl.TabIndex = 3;
            this.waktu_lbl.Text = "Tampil Waktu";
            // 
            // Waktu
            // 
            this.Waktu.Enabled = true;
            this.Waktu.Interval = 1000;
            this.Waktu.Tick += new System.EventHandler(this.Waktu_Tick);
            // 
            // tanggal_lbl
            // 
            this.tanggal_lbl.AutoSize = true;
            this.tanggal_lbl.BackColor = System.Drawing.Color.Transparent;
            this.tanggal_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggal_lbl.Location = new System.Drawing.Point(1826, 159);
            this.tanggal_lbl.Name = "tanggal_lbl";
            this.tanggal_lbl.Size = new System.Drawing.Size(102, 30);
            this.tanggal_lbl.TabIndex = 4;
            this.tanggal_lbl.Text = "Tanggal ";
            // 
            // kode_txt
            // 
            this.kode_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.kode_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kode_txt.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kode_txt.Location = new System.Drawing.Point(268, 152);
            this.kode_txt.Name = "kode_txt";
            this.kode_txt.Size = new System.Drawing.Size(190, 37);
            this.kode_txt.TabIndex = 5;
            this.kode_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.kode_txt_KeyDown);
            // 
            // jumlah_txt
            // 
            this.jumlah_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.jumlah_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.jumlah_txt.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jumlah_txt.Location = new System.Drawing.Point(464, 152);
            this.jumlah_txt.Name = "jumlah_txt";
            this.jumlah_txt.Size = new System.Drawing.Size(75, 37);
            this.jumlah_txt.TabIndex = 6;
            this.jumlah_txt.TextChanged += new System.EventHandler(this.jumlah_txt_TextChanged);
            // 
            // nama_barang_txt
            // 
            this.nama_barang_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nama_barang_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nama_barang_txt.Enabled = false;
            this.nama_barang_txt.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_barang_txt.Location = new System.Drawing.Point(545, 152);
            this.nama_barang_txt.Name = "nama_barang_txt";
            this.nama_barang_txt.Size = new System.Drawing.Size(319, 37);
            this.nama_barang_txt.TabIndex = 7;
            // 
            // harga_txt
            // 
            this.harga_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.harga_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.harga_txt.Enabled = false;
            this.harga_txt.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.harga_txt.Location = new System.Drawing.Point(870, 152);
            this.harga_txt.Name = "harga_txt";
            this.harga_txt.Size = new System.Drawing.Size(124, 37);
            this.harga_txt.TabIndex = 9;
            // 
            // subtotal_txt
            // 
            this.subtotal_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.subtotal_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.subtotal_txt.Enabled = false;
            this.subtotal_txt.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal_txt.Location = new System.Drawing.Point(1000, 152);
            this.subtotal_txt.Name = "subtotal_txt";
            this.subtotal_txt.Size = new System.Drawing.Size(124, 37);
            this.subtotal_txt.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(264, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kode";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Jumlah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(541, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nama Barang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(866, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 22);
            this.label4.TabIndex = 14;
            this.label4.Text = "Harga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(996, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 22);
            this.label5.TabIndex = 15;
            this.label5.Text = "Subtotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 22);
            this.label6.TabIndex = 16;
            this.label6.Text = "Kode Transaksi";
            // 
            // kode_transaksi_txt
            // 
            this.kode_transaksi_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.kode_transaksi_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kode_transaksi_txt.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kode_transaksi_txt.Location = new System.Drawing.Point(74, 152);
            this.kode_transaksi_txt.Name = "kode_transaksi_txt";
            this.kode_transaksi_txt.Size = new System.Drawing.Size(190, 37);
            this.kode_transaksi_txt.TabIndex = 17;
            // 
            // id_ker_txt
            // 
            this.id_ker_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.id_ker_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.id_ker_txt.Enabled = false;
            this.id_ker_txt.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_ker_txt.Location = new System.Drawing.Point(22, 208);
            this.id_ker_txt.Name = "id_ker_txt";
            this.id_ker_txt.Size = new System.Drawing.Size(46, 37);
            this.id_ker_txt.TabIndex = 18;
            this.id_ker_txt.Visible = false;
            // 
            // payment_btn
            // 
            this.payment_btn.Image = global::AplikasiKasir.Properties.Resources.paymentIcon;
            this.payment_btn.Location = new System.Drawing.Point(244, 35);
            this.payment_btn.Name = "payment_btn";
            this.payment_btn.Size = new System.Drawing.Size(76, 63);
            this.payment_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.payment_btn.TabIndex = 34;
            this.payment_btn.TabStop = false;
            this.payment_btn.Click += new System.EventHandler(this.payment_btn_Click);
            // 
            // bersih_btn
            // 
            this.bersih_btn.Image = global::AplikasiKasir.Properties.Resources.trashIcon;
            this.bersih_btn.Location = new System.Drawing.Point(22, 151);
            this.bersih_btn.Name = "bersih_btn";
            this.bersih_btn.Size = new System.Drawing.Size(37, 38);
            this.bersih_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bersih_btn.TabIndex = 33;
            this.bersih_btn.TabStop = false;
            this.bersih_btn.Click += new System.EventHandler(this.bersih_btn_Click);
            // 
            // hapusBelanja_btn
            // 
            this.hapusBelanja_btn.BackColor = System.Drawing.Color.Transparent;
            this.hapusBelanja_btn.Image = global::AplikasiKasir.Properties.Resources.removebasketIcon;
            this.hapusBelanja_btn.Location = new System.Drawing.Point(162, 35);
            this.hapusBelanja_btn.Name = "hapusBelanja_btn";
            this.hapusBelanja_btn.Size = new System.Drawing.Size(76, 63);
            this.hapusBelanja_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.hapusBelanja_btn.TabIndex = 20;
            this.hapusBelanja_btn.TabStop = false;
            this.hapusBelanja_btn.Click += new System.EventHandler(this.hapusBelanja_btn_Click);
            // 
            // tambahBelanja_btn
            // 
            this.tambahBelanja_btn.BackColor = System.Drawing.Color.Transparent;
            this.tambahBelanja_btn.Image = global::AplikasiKasir.Properties.Resources.addbasketIcon;
            this.tambahBelanja_btn.Location = new System.Drawing.Point(80, 35);
            this.tambahBelanja_btn.Name = "tambahBelanja_btn";
            this.tambahBelanja_btn.Size = new System.Drawing.Size(76, 63);
            this.tambahBelanja_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tambahBelanja_btn.TabIndex = 19;
            this.tambahBelanja_btn.TabStop = false;
            this.tambahBelanja_btn.Click += new System.EventHandler(this.tambahBelanja_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.Image = global::AplikasiKasir.Properties.Resources.HomeDashboard;
            this.dashboard_btn.Location = new System.Drawing.Point(326, 35);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(76, 63);
            this.dashboard_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dashboard_btn.TabIndex = 35;
            this.dashboard_btn.TabStop = false;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // TransaksiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2041, 1046);
            this.Controls.Add(this.dashboard_btn);
            this.Controls.Add(this.payment_btn);
            this.Controls.Add(this.bersih_btn);
            this.Controls.Add(this.hapusBelanja_btn);
            this.Controls.Add(this.tambahBelanja_btn);
            this.Controls.Add(this.id_ker_txt);
            this.Controls.Add(this.kode_transaksi_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subtotal_txt);
            this.Controls.Add(this.harga_txt);
            this.Controls.Add(this.nama_barang_txt);
            this.Controls.Add(this.jumlah_txt);
            this.Controls.Add(this.kode_txt);
            this.Controls.Add(this.tanggal_lbl);
            this.Controls.Add(this.waktu_lbl);
            this.Controls.Add(this.totalHarga_txt);
            this.Controls.Add(this.database_keranjang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TransaksiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TransaksiForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TransaksiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database_keranjang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payment_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bersih_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hapusBelanja_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tambahBelanja_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dashboard_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox totalHarga_txt;
        private System.Windows.Forms.Label waktu_lbl;
        private System.Windows.Forms.Timer Waktu;
        private System.Windows.Forms.Label tanggal_lbl;
        private System.Windows.Forms.TextBox kode_txt;
        private System.Windows.Forms.TextBox jumlah_txt;
        private System.Windows.Forms.TextBox nama_barang_txt;
        private System.Windows.Forms.TextBox harga_txt;
        private System.Windows.Forms.TextBox subtotal_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_keranjang;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_transaksi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kode_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox kode_transaksi_txt;
        private System.Windows.Forms.TextBox id_ker_txt;
        private System.Windows.Forms.PictureBox tambahBelanja_btn;
        private System.Windows.Forms.PictureBox hapusBelanja_btn;
        private System.Windows.Forms.PictureBox bersih_btn;
        private System.Windows.Forms.PictureBox payment_btn;
        private System.Windows.Forms.PictureBox dashboard_btn;
        private System.Windows.Forms.DataGridView database_keranjang;
    }
}