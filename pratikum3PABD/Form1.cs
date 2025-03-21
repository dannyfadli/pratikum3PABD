using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratikum3PABD
{
    public partial class form1 : Form
    {
        // Ganti "SERVER" sesuai dengan SQL Server Anda
        private string connectionString = "Data Source=LAPTOP-CUMP4OII\\DANNY; Initial Catalog=OrganisasiMahasiswa ; Integrated Security=True";
        public form1()
        {
            InitializeComponent();
        }

        //Event saat form pertama kali dimuat

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        //Fungsi untuk mengosongkan semua input pada TextBox
        private void ClearForm()
        {
            txtNIM.Clear();
            txtNama.Clear();
            txtEmail.Clear();
            txtTelepon.Clear();
            txtAlamat.Clear();
            //Fokus kembali ke NIM agar user siap memasukkan data baru
            Label1.Focus();
        }
        //Fungsi untuk menampilkan data di DataGridView

       