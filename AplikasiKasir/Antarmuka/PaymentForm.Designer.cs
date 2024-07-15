namespace AplikasiKasir.Antarmuka
{
    partial class PaymentForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.total_belanja_txt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.total_bayar_txt = new System.Windows.Forms.TextBox();
            this.kembalian_txt = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tanggal_lbl = new System.Windows.Forms.Label();
            this.id_transaksi_lbl = new System.Windows.Forms.Label();
            this.kode_transaksi_lbl = new System.Windows.Forms.Label();
            this.kasir_name_lbl = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pembayaran_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 31);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Belanja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Bayar";
            // 
            // total_belanja_txt
            // 
            this.total_belanja_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.total_belanja_txt.Font = new System.Drawing.Font("Malgun Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_belanja_txt.Location = new System.Drawing.Point(17, 50);
            this.total_belanja_txt.Name = "total_belanja_txt";
            this.total_belanja_txt.Size = new System.Drawing.Size(579, 67);
            this.total_belanja_txt.TabIndex = 9;
            this.total_belanja_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.total_belanja_txt.TextChanged += new System.EventHandler(this.total_belanja_txt_TextChanged);
            this.total_belanja_txt.Leave += new System.EventHandler(this.total_belanja_txt_Leave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.total_belanja_txt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(750, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 139);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.total_bayar_txt);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(750, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(618, 132);
            this.panel2.TabIndex = 12;
            // 
            // total_bayar_txt
            // 
            this.total_bayar_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.total_bayar_txt.Font = new System.Drawing.Font("Malgun Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_bayar_txt.Location = new System.Drawing.Point(17, 48);
            this.total_bayar_txt.Name = "total_bayar_txt";
            this.total_bayar_txt.Size = new System.Drawing.Size(579, 67);
            this.total_bayar_txt.TabIndex = 13;
            this.total_bayar_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.total_bayar_txt.TextChanged += new System.EventHandler(this.total_bayar_txt_TextChanged);
            this.total_bayar_txt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.total_bayar_txt_KeyDown);
            this.total_bayar_txt.Leave += new System.EventHandler(this.total_bayar_txt_Leave);
            // 
            // kembalian_txt
            // 
            this.kembalian_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kembalian_txt.Font = new System.Drawing.Font("Malgun Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kembalian_txt.Location = new System.Drawing.Point(17, 47);
            this.kembalian_txt.Name = "kembalian_txt";
            this.kembalian_txt.Size = new System.Drawing.Size(579, 67);
            this.kembalian_txt.TabIndex = 14;
            this.kembalian_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RosyBrown;
            this.panel3.Controls.Add(this.kembalian_txt);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(750, 385);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(618, 136);
            this.panel3.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 31);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kembalian";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.tanggal_lbl);
            this.panel4.Controls.Add(this.id_transaksi_lbl);
            this.panel4.Controls.Add(this.kode_transaksi_lbl);
            this.panel4.Controls.Add(this.kasir_name_lbl);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(40, 96);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(669, 339);
            this.panel4.TabIndex = 16;
            // 
            // tanggal_lbl
            // 
            this.tanggal_lbl.AutoSize = true;
            this.tanggal_lbl.BackColor = System.Drawing.Color.Transparent;
            this.tanggal_lbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tanggal_lbl.Location = new System.Drawing.Point(226, 271);
            this.tanggal_lbl.Name = "tanggal_lbl";
            this.tanggal_lbl.Size = new System.Drawing.Size(94, 31);
            this.tanggal_lbl.TabIndex = 20;
            this.tanggal_lbl.Text = "Tanggal";
            // 
            // id_transaksi_lbl
            // 
            this.id_transaksi_lbl.AutoSize = true;
            this.id_transaksi_lbl.BackColor = System.Drawing.Color.Transparent;
            this.id_transaksi_lbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id_transaksi_lbl.Location = new System.Drawing.Point(226, 36);
            this.id_transaksi_lbl.Name = "id_transaksi_lbl";
            this.id_transaksi_lbl.Size = new System.Drawing.Size(134, 31);
            this.id_transaksi_lbl.TabIndex = 19;
            this.id_transaksi_lbl.Text = "ID Transaksi";
            // 
            // kode_transaksi_lbl
            // 
            this.kode_transaksi_lbl.AutoSize = true;
            this.kode_transaksi_lbl.BackColor = System.Drawing.Color.Transparent;
            this.kode_transaksi_lbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kode_transaksi_lbl.Location = new System.Drawing.Point(226, 116);
            this.kode_transaksi_lbl.Name = "kode_transaksi_lbl";
            this.kode_transaksi_lbl.Size = new System.Drawing.Size(163, 31);
            this.kode_transaksi_lbl.TabIndex = 18;
            this.kode_transaksi_lbl.Text = "Kode Transaksi";
            // 
            // kasir_name_lbl
            // 
            this.kasir_name_lbl.AutoSize = true;
            this.kasir_name_lbl.BackColor = System.Drawing.Color.Transparent;
            this.kasir_name_lbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kasir_name_lbl.Location = new System.Drawing.Point(226, 194);
            this.kasir_name_lbl.Name = "kasir_name_lbl";
            this.kasir_name_lbl.Size = new System.Drawing.Size(130, 31);
            this.kasir_name_lbl.TabIndex = 17;
            this.kasir_name_lbl.Text = "Nama Kasir";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 31);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tanggal ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 31);
            this.label7.TabIndex = 12;
            this.label7.Text = "Nama Kasir";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "Kode Transaksi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 31);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID Transaksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(28, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 68);
            this.label2.TabIndex = 17;
            this.label2.Text = "Pembayaran";
            // 
            // pembayaran_btn
            // 
            this.pembayaran_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pembayaran_btn.Location = new System.Drawing.Point(40, 457);
            this.pembayaran_btn.Name = "pembayaran_btn";
            this.pembayaran_btn.Size = new System.Drawing.Size(669, 64);
            this.pembayaran_btn.TabIndex = 18;
            this.pembayaran_btn.Text = "Bayar";
            this.pembayaran_btn.UseVisualStyleBackColor = true;
            this.pembayaran_btn.Click += new System.EventHandler(this.pembayaran_btn_Click);
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.ClientSize = new System.Drawing.Size(1407, 591);
            this.Controls.Add(this.pembayaran_btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentForm";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox total_belanja_txt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox total_bayar_txt;
        private System.Windows.Forms.TextBox kembalian_txt;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button pembayaran_btn;
        private System.Windows.Forms.Label kasir_name_lbl;
        private System.Windows.Forms.Label kode_transaksi_lbl;
        private System.Windows.Forms.Label tanggal_lbl;
        private System.Windows.Forms.Label id_transaksi_lbl;
    }
}