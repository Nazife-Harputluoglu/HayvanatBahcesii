using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace HayvanatBahcesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        void Listele()
        {
            using (NpgsqlConnection baglanti = VeriTabani.BaglantiGetir())
            {
                try
                {
                    baglanti.Open();

                    string sql = @"
SELECT 
    h.""HayvanId"",
    
   
    h.""TurId"",          
    h.""KafesId"",        
    h.""OrtamId"",        
   

    t.""TurAdi"" AS ""Tür"",
    h.""Yas"" AS ""Yaþ"",
    h.""BeslenmeSaati"" AS ""Beslenme Saati"",
    
    k.""KafesId"" AS ""Kafes No"", 
    (k.""Buyukluk"" || ' m2') AS ""Kafes Boyutu"",
    (k.""MevcutHayvanSayisi"" || ' / ' || k.""Kapasite"") AS ""Doluluk"",
    
    o.""OrtamTuru"" AS ""Ortam"",
    (o.""Sicaklik"" || ' °C') AS ""Sýcaklýk""

FROM ""Hayvan"" h
INNER JOIN ""Tur"" t ON h.""TurId"" = t.""TurId""
INNER JOIN ""Kafes"" k ON h.""KafesId"" = k.""KafesId""
INNER JOIN ""Ortam"" o ON h.""OrtamId"" = o.""OrtamId""
ORDER BY h.""HayvanId"" ASC";



                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    hayvandgv.DataSource = dt;

                    if (hayvandgv.Columns["HayvanId"] != null)
                    {
                        hayvandgv.Columns["HayvanId"].Visible = false;
                    }
                    if (hayvandgv.Columns["TurId"] != null)
                        hayvandgv.Columns["TurId"].Visible = false;

                    // 3. Kafes ID Gizle (SQL'e yeni eklemiþtik)
                    if (hayvandgv.Columns["KafesId"] != null)
                        hayvandgv.Columns["KafesId"].Visible = false;

                    // 4. Ortam ID Gizle (SQL'e yeni eklemiþtik)
                    if (hayvandgv.Columns["OrtamId"] != null)
                        hayvandgv.Columns["OrtamId"].Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Listeleme Hatasý: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
            ListeleTumPersonel();
            ListeleSadeceZiyaretciler();


        }

        private void EnKalabalikKafes_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection baglanti = VeriTabani.BaglantiGetir())
            {
                try
                {
                    baglanti.Open();


                    string sql = "SELECT * FROM en_kalabalik_kafesi_bul()";

                    using (NpgsqlCommand komut = new NpgsqlCommand(sql, baglanti))
                    {
                        using (NpgsqlDataReader okuyucu = komut.ExecuteReader())
                        {

                            string sonucListesi = "";
                            bool kayitBulundu = false;


                            while (okuyucu.Read())
                            {
                                kayitBulundu = true;


                                int kafesId = okuyucu.GetInt32(0);
                                int sayi = okuyucu.GetInt32(1);


                                sonucListesi += $"• Kafes No: {kafesId} (Mevcut Sayý: {sayi})\n";
                            }


                            if (kayitBulundu)
                            {
                                MessageBox.Show("En Kalabalýk Kafes(ler):\n\n" + sonucListesi,
                                                "Analiz Raporu",
                                                MessageBoxButtons.OK,
                                                MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Henüz hiç veri yok.", "Bilgi");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void riskAnalizi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(analizKafesId.Text))
            {
                MessageBox.Show("Lütfen analiz edilecek Kafes ID'sini girin.", "Eksik Bilgi");
                return;
            }

            using (NpgsqlConnection baglanti = VeriTabani.BaglantiGetir())
            {
                try
                {
                    baglanti.Open();

                    string sql = "SELECT kafes_risk_analizi(@id)";

                    using (NpgsqlCommand komut = new NpgsqlCommand(sql, baglanti))
                    {

                        komut.Parameters.AddWithValue("@id", int.Parse(analizKafesId.Text));

                        object sonuc = komut.ExecuteScalar();


                        if (sonuc != null)
                        {
                            MessageBox.Show(sonuc.ToString(),
                                            "Kafes Risk Raporu",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluþtu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void ListeleTumPersonel()
        {
            using (NpgsqlConnection baglanti = VeriTabani.BaglantiGetir())
            {
                try
                {
                    baglanti.Open();

                    string sql = @"
                SELECT 
                    p.""PersonelId"" AS ""ID"",
                    p.""Ad"",
                    p.""Soyad"",
                    p.""Gorev"",
                   
                    y.""Unvan"",
                   
                    (b.""IseBaslamaSaati"" || ' - ' || b.""IstenCikisSaati"") AS ""Vardiya"",
                   
                    h.""UzmanlikAlani"" AS ""Uzmanlýk"",
                  
                    g.""GonulluPuani"" AS ""Puan""

                FROM ""Personel"" p
                LEFT JOIN ""Yonetici"" y ON p.""PersonelId"" = y.""PersonelId""
                LEFT JOIN ""Bekci"" b ON p.""PersonelId"" = b.""PersonelId""
                LEFT JOIN ""HayvanBakicisi"" h ON p.""PersonelId"" = h.""PersonelId""
                LEFT JOIN ""Gonullu"" g ON p.""PersonelId"" = g.""PersonelId""
                
                ORDER BY p.""PersonelId"" ASC";

                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, baglanti);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    personeldgv.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Listeleme Hatasý: " + ex.Message);
                }
            }
        }

        private void puanVer_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txtGonulluId.Text) || string.IsNullOrEmpty(txtPuan.Text))
            {
                MessageBox.Show("Lütfen Personel ID ve Puan alanlarýný doldurun.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (NpgsqlConnection baglanti = VeriTabani.BaglantiGetir())
            {
                try
                {
                    baglanti.Open();

                    string sql = "SELECT gonullu_puan_ver(@id, @puan)";

                    using (NpgsqlCommand komut = new NpgsqlCommand(sql, baglanti))
                    {
                        komut.Parameters.AddWithValue("@id", int.Parse(txtGonulluId.Text));
                        komut.Parameters.AddWithValue("@puan", int.Parse(txtPuan.Text));

                        object sonuc = komut.ExecuteScalar();

                        if (sonuc != null)
                        {
                            MessageBox.Show(sonuc.ToString(),
                                            "Ýþlem Sonucu",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            txtGonulluId.Clear();
                            txtPuan.Clear();
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lütfen kutucuklara sadece SAYI giriniz!", "Hatalý Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message, "Sistem Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void ListeleSadeceZiyaretciler()
        {
            using (NpgsqlConnection baglanti = VeriTabani.BaglantiGetir())
            {
                baglanti.Open();
                string sql = @"
            SELECT 
                z.""ZiyaretciId"" AS ""ID"",
                (z.""Ad"" || ' ' || z.""Soyad"") AS ""Ad Soyad"",
                b.""BiletTuru"" AS ""Bilet"",
                zg.""GrupNo"" AS ""Grup No""
            FROM ""Ziyaretci"" z
            INNER JOIN ""Bilet"" b ON z.""BiletId"" = b.""BiletId""
            LEFT JOIN ""ZiyaretciGrubu"" zg ON z.""GrupNo"" = zg.""GrupNo""
            ORDER BY z.""ZiyaretciId"" ASC";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvZiyaretciler.DataSource = dt;
            }
        }


        void ZiyaretciDetaylariniGetir(int id)
        {
            using (NpgsqlConnection baglanti = VeriTabani.BaglantiGetir())
            {
                baglanti.Open();

                string sql = @"
           
            SELECT 
                'Gezi' AS ""Ýþlem Türü"",
                o.""OrtamTuru"" AS ""Açýklama"",
                (z.""ZiyaretSaati""::varchar) AS ""Detay""
            FROM ""Ziyaret"" z
            JOIN ""Ortam"" o ON z.""OrtamId"" = o.""OrtamId""
            WHERE z.""ZiyaretciId"" = @id

            UNION ALL
 
            SELECT 
                'Etkinlik',
                e.""EtkinlikAdi"",
                (e.""EtkinlikSaati""::varchar)
            FROM ""ZiyaretciEtkinlik"" ze
            JOIN ""Etkinlik"" e ON ze.""EtkinlikId"" = e.""EtkinlikId""
            WHERE ze.""ZiyaretciId"" = @id

            UNION ALL

            SELECT 
                'Baðýþ',
                b.""BagisTuru"",
                (b.""Miktar"" || ' TL')
            FROM ""Bagis"" b
            WHERE b.""ZiyaretciId"" = @id";

                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, baglanti);

                da.SelectCommand.Parameters.AddWithValue("@id", id);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvDetaylar.DataSource = dt;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvZiyaretciler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                int secilenId = Convert.ToInt32(dgvZiyaretciler.Rows[e.RowIndex].Cells["ID"].Value);
                ZiyaretciDetaylariniGetir(secilenId);
            }

        }

        private void ziyaret_Click(object sender, EventArgs e)
        {

        }

        private void dgvZiyaretciler_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    var idDegeri = dgvZiyaretciler.Rows[e.RowIndex].Cells["ID"].Value;

                    if (idDegeri != null)
                    {
                        int secilenId = Convert.ToInt32(idDegeri);
                        ZiyaretciDetaylariniGetir(secilenId);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }


        private void bagis_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBagisZiyaretciId.Text))
            {
                MessageBox.Show("Lütfen bir Ziyaretçi ID giriniz.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (NpgsqlConnection baglanti = VeriTabani.BaglantiGetir())
            {
                try
                {
                    baglanti.Open();
                    string sql = "SELECT ziyaretcinin_toplam_bagisini_hesapla(@id)";

                    using (NpgsqlCommand komut = new NpgsqlCommand(sql, baglanti))
                    {
                        komut.Parameters.AddWithValue("@id", int.Parse(txtBagisZiyaretciId.Text));
                        object sonuc = komut.ExecuteScalar();

                        if (sonuc != null)
                        {
                            MessageBox.Show(sonuc.ToString(),
                                            "Baðýþ Raporu",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);
                        }
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Lütfen ID kutusuna sadece SAYI giriniz!", "Hatalý Giriþ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluþtu: " + ex.Message, "Sistem Hatasý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtBagisZiyaretciId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ziyaretciEkle_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection baglanti = VeriTabani.BaglantiGetir())
            {
                try
                {
                    baglanti.Open();

                    string sql = @"INSERT INTO ""Ziyaretci"" (""Ad"", ""Soyad"", ""BiletId"", ""GrupNo"") 
                           VALUES (@ad, @soyad, @bilet, @grup)";

                    using (NpgsqlCommand komut = new NpgsqlCommand(sql, baglanti))
                    {
                        komut.Parameters.AddWithValue("@ad", ziyaretciAd.Text);
                        komut.Parameters.AddWithValue("@soyad", ziyaretciSoyad.Text);
                        komut.Parameters.AddWithValue("@bilet", int.Parse(ziy_bilet_id.Text));

                        if (string.IsNullOrEmpty(ziy_grupNo.Text))
                        {
                            komut.Parameters.AddWithValue("@grup", DBNull.Value);
                        }
                        else
                        {
                            komut.Parameters.AddWithValue("@grup", int.Parse(ziy_grupNo.Text));
                        }

                        komut.ExecuteNonQuery();
                    }

                    MessageBox.Show("Ziyaretçi eklendi! (Grup varsa sayýsý otomatik arttý)");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void kafesatama_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bakici_kafesid.Text) || string.IsNullOrEmpty(bakici_id.Text))
            {
                MessageBox.Show("Lütfen Kafes ID ve Personel ID giriniz.");
                return;
            }

            using (NpgsqlConnection baglanti = VeriTabani.BaglantiGetir())
            {
                try
                {
                    baglanti.Open();

                    string sql = @"INSERT INTO ""KafesBakici"" (""KafesId"", ""PersonelId"") 
                           VALUES (@kafes, @personel)";

                    using (NpgsqlCommand komut = new NpgsqlCommand(sql, baglanti))
                    {
                        komut.Parameters.AddWithValue("@kafes", int.Parse(bakici_kafesid.Text));
                        komut.Parameters.AddWithValue("@personel", int.Parse(bakici_id.Text));


                        komut.ExecuteNonQuery();

                        MessageBox.Show("Baþarýyla atama yapýldý! Bakýcý göreve baþladý.", "Baþarýlý");
                    }
                }
                catch (PostgresException ex)
                {

                    MessageBox.Show("Atama Baþarýsýz!\n\nSEBEP: " + ex.MessageText,
                                    "Yetki Hatasý",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Bir hata oluþtu: " + ex.Message);
                }
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void mevcuthayvanbuton_Click(object sender, EventArgs e)
        {

        }

        private void hayvan_ekle_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection baglanti = VeriTabani.BaglantiGetir())
            {
                try
                {
                    baglanti.Open();

                    string sql = @"INSERT INTO ""Hayvan"" 
                       (""TurId"", ""KafesId"", ""OrtamId"", ""Yas"", ""BeslenmeSaati"") 
                       VALUES 
                       (@tur, @kafes, @ortam, @yas, @beslenmesaati)";

                    using (NpgsqlCommand komut = new NpgsqlCommand(sql, baglanti))
                    {
                        komut.Parameters.AddWithValue("@tur", int.Parse(hayvan_turid.Text));
                        komut.Parameters.AddWithValue("@kafes", int.Parse(hayvan_kafesid.Text));
                        komut.Parameters.AddWithValue("@ortam", int.Parse(hayvan_ortamid.Text));
                        komut.Parameters.AddWithValue("@yas", int.Parse(hayvan_yas.Text));


                        if (beslenmesaati.MaskFull)
                        {
                            TimeSpan zaman = TimeSpan.Parse(beslenmesaati.Text);

                            komut.Parameters.Add("@beslenmesaati", NpgsqlTypes.NpgsqlDbType.Time).Value = zaman;
                        }
                        else
                        {
                            komut.Parameters.AddWithValue("@beslenmesaati", DBNull.Value);
                        }
                        komut.ExecuteNonQuery();
                    }

                    MessageBox.Show("Hayvan baþarýyla eklendi! Kafes sayacý güncellendi.");

                    Listele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void hayvan_sil_Click(object sender, EventArgs e)
        {
            if (hayvandgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silinecek satýrý seçiniz.");
                return;
            }

            DialogResult hayvancevap = MessageBox.Show("Bu kaydý silmek istediðinize emin misiniz?", "Silme Onayý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (hayvancevap == DialogResult.Yes)
            {

                int hayvanSecilenId = int.Parse(hayvandgv.SelectedRows[0].Cells[0].Value.ToString());

                using (NpgsqlConnection baglanti = VeriTabani.BaglantiGetir())
                {
                    try
                    {
                        baglanti.Open();

                        string sql = @"DELETE FROM ""Hayvan"" WHERE ""HayvanId"" = @id";

                        using (NpgsqlCommand komut = new NpgsqlCommand(sql, baglanti))
                        {
                            komut.Parameters.AddWithValue("@id", hayvanSecilenId);
                            komut.ExecuteNonQuery();
                        }

                        MessageBox.Show("Kayýt baþarýyla silindi.");


                        Listele();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }
                }
            }
        }

        private void ziyaretci_sil_Click(object sender, EventArgs e)
        {
           
        }

        private void hayvandgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = hayvandgv.Rows[e.RowIndex];

                hayvan_turid.Text = row.Cells["TurId"].Value.ToString();
                hayvan_kafesid.Text = row.Cells["KafesId"].Value.ToString();
                hayvan_ortamid.Text = row.Cells["OrtamId"].Value.ToString();

                hayvan_yas.Text = row.Cells["Yaþ"].Value.ToString();


                if (row.Cells["Beslenme Saati"].Value != DBNull.Value)
                {
                    beslenmesaati.Text = row.Cells["Beslenme Saati"].Value.ToString();
                }
                else
                {
                    beslenmesaati.Clear();
                }
            }
        }

        private void hayvan_guncelleme_Click(object sender, EventArgs e)
        {
            if (hayvandgv.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen güncellenecek satýrý listeden seçiniz.");
                return;
            }

            using (NpgsqlConnection baglanti = VeriTabani.BaglantiGetir())
            {
                try
                {
                    baglanti.Open();


                    string sql = @"UPDATE ""Hayvan"" 
                           SET ""TurId"" = @tur, 
                               ""KafesId"" = @kafes, 
                               ""OrtamId"" = @ortam, 
                               ""Yas"" = @yas, 
                               ""BeslenmeSaati"" = @saat
                           WHERE ""HayvanId"" = @id";

                    using (NpgsqlCommand komut = new NpgsqlCommand(sql, baglanti))
                    {

                        komut.Parameters.AddWithValue("@tur", int.Parse(hayvan_turid.Text));
                        komut.Parameters.AddWithValue("@kafes", int.Parse(hayvan_kafesid.Text));
                        komut.Parameters.AddWithValue("@ortam", int.Parse(hayvan_ortamid.Text));
                        komut.Parameters.AddWithValue("@yas", int.Parse(hayvan_yas.Text));


                        if (beslenmesaati.MaskFull)
                            komut.Parameters.Add("@saat", NpgsqlTypes.NpgsqlDbType.Time).Value = TimeSpan.Parse(beslenmesaati.Text);
                        else
                            komut.Parameters.AddWithValue("@saat", DBNull.Value);

                        int secilenId = int.Parse(hayvandgv.SelectedRows[0].Cells[0].Value.ToString());
                        komut.Parameters.AddWithValue("@id", secilenId);

                        komut.ExecuteNonQuery();
                    }

                    MessageBox.Show("Bilgiler baþarýyla güncellendi!");
                    Listele();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: " + ex.Message);
                }
            }
        }

        private void hayvan_arama_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = (DataTable)hayvandgv.DataSource;

            if (dt != null)
            {
                
                string aranan = hayvan_arama.Text;

                try
                {
                    
                    dt.DefaultView.RowFilter = string.Format("[Tür] LIKE '%{0}%' OR [Ortam] LIKE '%{0}%'", aranan);
                }
                catch (Exception)
                {
                   
                }
            }
        }
    }
}

