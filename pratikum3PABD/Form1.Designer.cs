namespace pratikum3PABD
{
    partial class form1
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
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.botton2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtNIM = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelepon = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.dgvMahasiswa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label1.Location = new System.Drawing.Point(75, 61);
            this.Label1.Name = "Label1";
            this.Label1.Padding = new System.Windows.Forms.Padding(0, 10, 119, 10);
            this.Label1.Size = new System.Drawing.Size(148, 35);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "NIM";
            this.Label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label2.Location = new System.Drawing.Point(75, 95);
            this.Label2.Name = "Label2";
            this.Label2.Padding = new System.Windows.Forms.Padding(0, 10, 111, 10);
            this.Label2.Size = new System.Drawing.Size(148, 35);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Nama";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label3.Location = new System.Drawing.Point(75, 130);
            this.Label3.Name = "Label3";
            this.Label3.Padding = new System.Windows.Forms.Padding(0, 10, 114, 10);
            this.Label3.Size = new System.Drawing.Size(148, 35);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Email";
            this.Label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label4.Location = new System.Drawing.Point(75, 165);
            this.Label4.Name = "Label4";
            this.Label4.Padding = new System.Windows.Forms.Padding(0, 10, 100, 10);
            this.Label4.Size = new System.Drawing.Size(148, 35);
            this.Label4.TabIndex = 3;
            this.Label4.Text = "Telepon";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Label5.Location = new System.Drawing.Point(75, 200);
            this.Label5.Name = "Label5";
            this.Label5.Padding = new System.Windows.Forms.Padding(0, 10, 107, 10);
            this.Label5.Size = new System.Drawing.Size(148, 35);
            this.Label5.TabIndex = 4;
            this.Label5.Text = "Alamat";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(432, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnTambah);
            // 
            // botton2
            // 
            this.botton2.Location = new System.Drawing.Point(432, 107);
            this.botton2.Name = "botton2";
            this.botton2.Size = new System.Drawing.Size(75, 23);
            this.botton2.TabIndex = 6;
            this.botton2.Text = "Hapus";
            this.botton2.UseVisualStyleBackColor = true;
            this.botton2.Click += new System.EventHandler(this.BtnHapus);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(432, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Ubah";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(432, 200);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BtnRefresh);
            // 
            // txtNama
            // 
            this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNama.Location = new System.Drawing.Point(224, 98);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(188, 20);
            this.txtNama.TabIndex = 10;
            // 
            // txtNIM
            // 
            this.txtNIM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNIM.Location = new System.Drawing.Point(224, 64);
            this.txtNIM.Name = "txtNIM";
            this.txtNIM.Size = new System.Drawing.Size(188, 20);
            this.txtNIM.TabIndex = 11;
            this.txtNIM.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(224, 133);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(188, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtTelepon
            // 
            this.txtTelepon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelepon.Location = new System.Drawing.Point(224, 168);
            this.txtTelepon.Name = "txtTelepon";
            this.txtTelepon.Size = new System.Drawing.Size(188, 20);
            this.txtTelepon.TabIndex = 13;
            // 
            // txtAlamat
            // 
            this.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlamat.Location = new System.Drawing.Point(224, 203);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(188, 20);
            this.txtAlamat.TabIndex = 14;
            // 
            // dgvMahasiswa
            // 
            this.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMahasiswa.Location = new System.Drawing.Point(12, 238);
            this.dgvMahasiswa.Name = "dgvMahasiswa";
            this.dgvMahasiswa.Size = new System.Drawing.Size(788, 200);
            this.dgvMahasiswa.TabIndex = 15;
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvMahasiswa);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtTelepon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNIM);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.botton2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMahasiswa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.Label Label4;
        private System.Windows.Forms.Label Label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button botton2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtNIM;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelepon;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.DataGridView dgvMahasiswa;
    }
}

