using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace veritabaniaramakomutu
{
    public partial class Form1 : Form
    {
    SqlConnection baglan=new SqlConnection("Server=DESKTOP-043DB1E;Database=Bilgi;Integrated Security=SSPI");
        public Form1()
        {
            InitializeComponent();
        }
        private void verileriGoster()
        {
            listView1.Items.Clear();    
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From Kişiler", baglan);
            SqlDataReader oku=komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Ad"].ToString();
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Yaş"].ToString());
                ekle.SubItems.Add(oku["İlçe"].ToString());
                ekle.SubItems.Add(oku["Meslek"].ToString());
                listView1.Items.Add(ekle);
                     
            }
            baglan.Close();

        }
        private void btn_verilerigoster_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void btn_bul_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglan.Open();
            SqlCommand komut = new SqlCommand("Select *From Kişiler where Ad like'%"+txt_ara.Text+"%'", baglan);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Ad"].ToString();
                ekle.SubItems.Add(oku["Soyad"].ToString());
                ekle.SubItems.Add(oku["Yaş"].ToString());
                ekle.SubItems.Add(oku["İlçe"].ToString());
                ekle.SubItems.Add(oku["Meslek"].ToString());
                listView1.Items.Add(ekle);
                txt_ad.Text = oku["Ad"].ToString();
                txt_soyad.Text = oku["Soyad"].ToString();
                txt_yaş.Text = oku["Yas"].ToString();
                txt_ilce.Text = oku["İlce"].ToString();
                txt_meslek.Text = oku["Meslek"].ToString() ;    
            }
            baglan.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            baglan.Open();
            SqlCommand komut = new SqlCommand("Insert Into Kişiler (Ad,Soyad,Yaş,İlçe,Meslek) Values ('" + txt_ad.Text.ToString() + "','" + txt_soyad.Text.ToString() + "','" + txt_yaş.Text.ToString() + "','" + txt_ilce.Text.ToString() + "','" + txt_meslek.Text.ToString() + "')", baglan);
            komut.ExecuteNonQuery();
            baglan.Close();
            txt_ad.Clear();
            txt_soyad.Clear();
            txt_yaş.Clear();
            txt_ilce.Clear();
            txt_meslek.Clear();
            verileriGoster();
            baglan.Close();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
