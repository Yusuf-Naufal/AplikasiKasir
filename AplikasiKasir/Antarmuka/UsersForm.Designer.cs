namespace AplikasiKasir.Antarmuka
{
    partial class UsersForm
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
            this.search_txt = new System.Windows.Forms.TextBox();
            this.database_users = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis_kelamin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_hp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Header_pnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.hapus_btn = new System.Windows.Forms.Button();
            this.ubah_btn = new System.Windows.Forms.Button();
            this.alamat_rtb = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.noHp_txt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.jenis_cmb = new System.Windows.Forms.ComboBox();
            this.role_cmb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.email_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nama_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idUsers_lbl = new System.Windows.Forms.Label();
            this.reflash_btn = new System.Windows.Forms.Button();
            this.tambahusers_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.database_users)).BeginInit();
            this.Header_pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // search_txt
            // 
            this.search_txt.BackColor = System.Drawing.SystemColors.Control;
            this.search_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.search_txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.search_txt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_txt.Location = new System.Drawing.Point(1327, 139);
            this.search_txt.Name = "search_txt";
            this.search_txt.Size = new System.Drawing.Size(282, 31);
            this.search_txt.TabIndex = 9;
            this.search_txt.TextChanged += new System.EventHandler(this.search_txt_TextChanged);
            // 
            // database_users
            // 
            this.database_users.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.database_users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.database_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.id_user,
            this.nama,
            this.username,
            this.password,
            this.role,
            this.email,
            this.jenis_kelamin,
            this.no_hp,
            this.alamat});
            this.database_users.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.database_users.Location = new System.Drawing.Point(521, 194);
            this.database_users.Name = "database_users";
            this.database_users.RowHeadersWidth = 51;
            this.database_users.RowTemplate.Height = 24;
            this.database_users.Size = new System.Drawing.Size(1088, 727);
            this.database_users.TabIndex = 7;
            this.database_users.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.database_users_CellClick);
            // 
            // no
            // 
            this.no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.no.DataPropertyName = "No";
            this.no.HeaderText = "No";
            this.no.MinimumWidth = 6;
            this.no.Name = "no";
            this.no.Width = 54;
            // 
            // id_user
            // 
            this.id_user.DataPropertyName = "id_user";
            this.id_user.HeaderText = "Id User";
            this.id_user.MinimumWidth = 6;
            this.id_user.Name = "id_user";
            this.id_user.Visible = false;
            this.id_user.Width = 125;
            // 
            // nama
            // 
            this.nama.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nama.DataPropertyName = "nama";
            this.nama.HeaderText = "Nama";
            this.nama.MinimumWidth = 6;
            this.nama.Name = "nama";
            this.nama.Width = 73;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.Width = 99;
            // 
            // password
            // 
            this.password.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.Width = 96;
            // 
            // role
            // 
            this.role.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.role.DataPropertyName = "role";
            this.role.HeaderText = "Role";
            this.role.MinimumWidth = 6;
            this.role.Name = "role";
            this.role.Width = 65;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 70;
            // 
            // jenis_kelamin
            // 
            this.jenis_kelamin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.jenis_kelamin.DataPropertyName = "jenis_kelamin";
            this.jenis_kelamin.HeaderText = "Jenis Kelamin";
            this.jenis_kelamin.MinimumWidth = 6;
            this.jenis_kelamin.Name = "jenis_kelamin";
            this.jenis_kelamin.Width = 119;
            // 
            // no_hp
            // 
            this.no_hp.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.no_hp.DataPropertyName = "no_hp";
            this.no_hp.HeaderText = "No HP";
            this.no_hp.MinimumWidth = 6;
            this.no_hp.Name = "no_hp";
            this.no_hp.Width = 76;
            // 
            // alamat
            // 
            this.alamat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.alamat.DataPropertyName = "alamat";
            this.alamat.HeaderText = "Alamat";
            this.alamat.MinimumWidth = 6;
            this.alamat.Name = "alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "List users pengguna aplikasi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Users";
            // 
            // Header_pnl
            // 
            this.Header_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.Header_pnl.Controls.Add(this.label2);
            this.Header_pnl.Controls.Add(this.label1);
            this.Header_pnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header_pnl.Location = new System.Drawing.Point(0, 0);
            this.Header_pnl.Name = "Header_pnl";
            this.Header_pnl.Size = new System.Drawing.Size(1751, 111);
            this.Header_pnl.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(251)))), ((int)(((byte)(226)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.hapus_btn);
            this.panel1.Controls.Add(this.ubah_btn);
            this.panel1.Controls.Add(this.alamat_rtb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.noHp_txt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.jenis_cmb);
            this.panel1.Controls.Add(this.role_cmb);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.email_txt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.nama_txt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 712);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::AplikasiKasir.Properties.Resources.trashIcon;
            this.pictureBox2.Location = new System.Drawing.Point(414, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // hapus_btn
            // 
            this.hapus_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.hapus_btn.FlatAppearance.BorderSize = 0;
            this.hapus_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hapus_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus_btn.Location = new System.Drawing.Point(26, 654);
            this.hapus_btn.Name = "hapus_btn";
            this.hapus_btn.Size = new System.Drawing.Size(425, 42);
            this.hapus_btn.TabIndex = 31;
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
            this.ubah_btn.Location = new System.Drawing.Point(26, 606);
            this.ubah_btn.Name = "ubah_btn";
            this.ubah_btn.Size = new System.Drawing.Size(425, 42);
            this.ubah_btn.TabIndex = 30;
            this.ubah_btn.Text = "Ubah";
            this.ubah_btn.UseVisualStyleBackColor = false;
            this.ubah_btn.Click += new System.EventHandler(this.ubah_btn_Click);
            // 
            // alamat_rtb
            // 
            this.alamat_rtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.alamat_rtb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat_rtb.Location = new System.Drawing.Point(27, 405);
            this.alamat_rtb.Name = "alamat_rtb";
            this.alamat_rtb.Size = new System.Drawing.Size(424, 181);
            this.alamat_rtb.TabIndex = 29;
            this.alamat_rtb.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(25, 374);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 28);
            this.label7.TabIndex = 28;
            this.label7.Text = "Alamat";
            // 
            // noHp_txt
            // 
            this.noHp_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.noHp_txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.noHp_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noHp_txt.Location = new System.Drawing.Point(28, 338);
            this.noHp_txt.Name = "noHp_txt";
            this.noHp_txt.Size = new System.Drawing.Size(261, 27);
            this.noHp_txt.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 28);
            this.label6.TabIndex = 26;
            this.label6.Text = "No HP";
            // 
            // jenis_cmb
            // 
            this.jenis_cmb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenis_cmb.FormattingEnabled = true;
            this.jenis_cmb.Location = new System.Drawing.Point(26, 253);
            this.jenis_cmb.Name = "jenis_cmb";
            this.jenis_cmb.Size = new System.Drawing.Size(207, 36);
            this.jenis_cmb.TabIndex = 25;
            // 
            // role_cmb
            // 
            this.role_cmb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.role_cmb.FormattingEnabled = true;
            this.role_cmb.Location = new System.Drawing.Point(244, 253);
            this.role_cmb.Name = "role_cmb";
            this.role_cmb.Size = new System.Drawing.Size(207, 36);
            this.role_cmb.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(239, 222);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 28);
            this.label9.TabIndex = 22;
            this.label9.Text = "Role";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 222);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 28);
            this.label8.TabIndex = 20;
            this.label8.Text = "Jenis Kelamin";
            // 
            // email_txt
            // 
            this.email_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email_txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.email_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_txt.Location = new System.Drawing.Point(27, 183);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(424, 27);
            this.email_txt.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "Email";
            // 
            // nama_txt
            // 
            this.nama_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nama_txt.Cursor = System.Windows.Forms.Cursors.Default;
            this.nama_txt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama_txt.Location = new System.Drawing.Point(26, 108);
            this.nama_txt.Name = "nama_txt";
            this.nama_txt.Size = new System.Drawing.Size(425, 27);
            this.nama_txt.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 28);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nama Lengkap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 31);
            this.label3.TabIndex = 15;
            this.label3.Text = "Edit Users";
            // 
            // idUsers_lbl
            // 
            this.idUsers_lbl.AutoSize = true;
            this.idUsers_lbl.Location = new System.Drawing.Point(15, 118);
            this.idUsers_lbl.Name = "idUsers_lbl";
            this.idUsers_lbl.Size = new System.Drawing.Size(0, 16);
            this.idUsers_lbl.TabIndex = 32;
            this.idUsers_lbl.Visible = false;
            // 
            // reflash_btn
            // 
            this.reflash_btn.BackgroundImage = global::AplikasiKasir.Properties.Resources.reflashIcon1;
            this.reflash_btn.FlatAppearance.BorderSize = 0;
            this.reflash_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reflash_btn.Location = new System.Drawing.Point(582, 137);
            this.reflash_btn.Name = "reflash_btn";
            this.reflash_btn.Size = new System.Drawing.Size(52, 49);
            this.reflash_btn.TabIndex = 15;
            this.reflash_btn.UseVisualStyleBackColor = true;
            this.reflash_btn.Click += new System.EventHandler(this.reflash_btn_Click);
            // 
            // tambahusers_btn
            // 
            this.tambahusers_btn.BackgroundImage = global::AplikasiKasir.Properties.Resources.tambahIcon2;
            this.tambahusers_btn.FlatAppearance.BorderSize = 0;
            this.tambahusers_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambahusers_btn.Location = new System.Drawing.Point(521, 137);
            this.tambahusers_btn.Name = "tambahusers_btn";
            this.tambahusers_btn.Size = new System.Drawing.Size(55, 51);
            this.tambahusers_btn.TabIndex = 10;
            this.tambahusers_btn.UseVisualStyleBackColor = true;
            this.tambahusers_btn.Click += new System.EventHandler(this.tambahusers_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AplikasiKasir.Properties.Resources.Search;
            this.pictureBox1.Location = new System.Drawing.Point(1275, 136);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1751, 1104);
            this.Controls.Add(this.idUsers_lbl);
            this.Controls.Add(this.reflash_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tambahusers_btn);
            this.Controls.Add(this.search_txt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.database_users);
            this.Controls.Add(this.Header_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UsersForm";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database_users)).EndInit();
            this.Header_pnl.ResumeLayout(false);
            this.Header_pnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox search_txt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView database_users;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Header_pnl;
        private System.Windows.Forms.Button tambahusers_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nama_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox jenis_cmb;
        private System.Windows.Forms.ComboBox role_cmb;
        private System.Windows.Forms.RichTextBox alamat_rtb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox noHp_txt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button hapus_btn;
        private System.Windows.Forms.Button ubah_btn;
        private System.Windows.Forms.Button reflash_btn;
        private System.Windows.Forms.Label idUsers_lbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
        private System.Windows.Forms.DataGridViewTextBoxColumn role;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis_kelamin;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_hp;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}