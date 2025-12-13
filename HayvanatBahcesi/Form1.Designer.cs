namespace HayvanatBahcesi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EnKalabalikKafes = new Button();
            hayvandgv = new DataGridView();
            riskAnalizi = new Button();
            puanVer = new Button();
            txtGonulluId = new TextBox();
            txtPuan = new TextBox();
            label1 = new Label();
            label2 = new Label();
            dgvZiyaretciler = new DataGridView();
            dgvDetaylar = new DataGridView();
            bagis = new Button();
            txtBagisZiyaretciId = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            ziyaretciAd = new TextBox();
            ziyaretciSoyad = new TextBox();
            ziy_bilet_id = new TextBox();
            ziy_grupNo = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            ziyaretciEkle = new Button();
            bakici_kafesid = new TextBox();
            bakici_id = new TextBox();
            kafesatama = new Button();
            label12 = new Label();
            label13 = new Label();
            hayvan_ekle = new Button();
            hayvan_turid = new TextBox();
            hayvan_yas = new TextBox();
            hayvan_ortamid = new TextBox();
            hayvan_kafesid = new TextBox();
            beslenmesaati = new MaskedTextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            groupBox5 = new GroupBox();
            groupBox4 = new GroupBox();
            personeldgv = new DataGridView();
            tabPage1 = new TabPage();
            groupBox3 = new GroupBox();
            groupBox2 = new GroupBox();
            analizKafesId = new TextBox();
            groupBox1 = new GroupBox();
            tabPage3 = new TabPage();
            groupBox7 = new GroupBox();
            groupBox6 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)hayvandgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvZiyaretciler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).BeginInit();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)personeldgv).BeginInit();
            tabPage1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox7.SuspendLayout();
            groupBox6.SuspendLayout();
            SuspendLayout();
            // 
            // EnKalabalikKafes
            // 
            EnKalabalikKafes.BackColor = SystemColors.GradientInactiveCaption;
            EnKalabalikKafes.Location = new Point(79, 148);
            EnKalabalikKafes.Name = "EnKalabalikKafes";
            EnKalabalikKafes.Size = new Size(94, 29);
            EnKalabalikKafes.TabIndex = 0;
            EnKalabalikKafes.Text = "Öğren";
            EnKalabalikKafes.UseVisualStyleBackColor = false;
            EnKalabalikKafes.Click += EnKalabalikKafes_Click;
            // 
            // hayvandgv
            // 
            hayvandgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            hayvandgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            hayvandgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            hayvandgv.Location = new Point(17, 6);
            hayvandgv.Name = "hayvandgv";
            hayvandgv.RowHeadersVisible = false;
            hayvandgv.RowHeadersWidth = 51;
            hayvandgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            hayvandgv.Size = new Size(1059, 256);
            hayvandgv.TabIndex = 1;
            hayvandgv.CellContentClick += dataGridView1_CellContentClick;
            // 
            // riskAnalizi
            // 
            riskAnalizi.BackColor = SystemColors.GradientInactiveCaption;
            riskAnalizi.Location = new Point(164, 134);
            riskAnalizi.Name = "riskAnalizi";
            riskAnalizi.Size = new Size(94, 29);
            riskAnalizi.TabIndex = 3;
            riskAnalizi.Text = "Analiz Et";
            riskAnalizi.UseVisualStyleBackColor = false;
            riskAnalizi.Click += riskAnalizi_Click;
            // 
            // puanVer
            // 
            puanVer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            puanVer.BackColor = SystemColors.GradientInactiveCaption;
            puanVer.Location = new Point(189, 156);
            puanVer.Name = "puanVer";
            puanVer.Size = new Size(160, 35);
            puanVer.TabIndex = 5;
            puanVer.Text = "Ekle";
            puanVer.UseVisualStyleBackColor = false;
            puanVer.Click += puanVer_Click;
            // 
            // txtGonulluId
            // 
            txtGonulluId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtGonulluId.Location = new Point(189, 89);
            txtGonulluId.Name = "txtGonulluId";
            txtGonulluId.Size = new Size(171, 27);
            txtGonulluId.TabIndex = 6;
            // 
            // txtPuan
            // 
            txtPuan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtPuan.Location = new Point(189, 41);
            txtPuan.Name = "txtPuan";
            txtPuan.Size = new Size(171, 27);
            txtPuan.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(66, 44);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 8;
            label1.Text = "Gönüllü Puanı:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(66, 92);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 9;
            label2.Text = "Personel ID:";
            // 
            // dgvZiyaretciler
            // 
            dgvZiyaretciler.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvZiyaretciler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvZiyaretciler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvZiyaretciler.Location = new Point(8, 6);
            dgvZiyaretciler.Name = "dgvZiyaretciler";
            dgvZiyaretciler.RowHeadersVisible = false;
            dgvZiyaretciler.RowHeadersWidth = 51;
            dgvZiyaretciler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvZiyaretciler.Size = new Size(1075, 188);
            dgvZiyaretciler.TabIndex = 10;
            dgvZiyaretciler.CellClick += dgvZiyaretciler_CellClick;
            // 
            // dgvDetaylar
            // 
            dgvDetaylar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetaylar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetaylar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetaylar.Location = new Point(8, 220);
            dgvDetaylar.Name = "dgvDetaylar";
            dgvDetaylar.RowHeadersVisible = false;
            dgvDetaylar.RowHeadersWidth = 51;
            dgvDetaylar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDetaylar.Size = new Size(1075, 188);
            dgvDetaylar.TabIndex = 11;
            // 
            // bagis
            // 
            bagis.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bagis.BackColor = SystemColors.GradientInactiveCaption;
            bagis.Location = new Point(240, 106);
            bagis.Name = "bagis";
            bagis.Size = new Size(188, 58);
            bagis.TabIndex = 13;
            bagis.Text = "Bağış Öğren";
            bagis.UseVisualStyleBackColor = false;
            bagis.Click += bagis_Click;
            // 
            // txtBagisZiyaretciId
            // 
            txtBagisZiyaretciId.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBagisZiyaretciId.Location = new Point(257, 31);
            txtBagisZiyaretciId.Name = "txtBagisZiyaretciId";
            txtBagisZiyaretciId.Size = new Size(156, 27);
            txtBagisZiyaretciId.TabIndex = 14;
            txtBagisZiyaretciId.TextChanged += txtBagisZiyaretciId_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(153, 34);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 15;
            label3.Text = "Bağışçı ID: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(967, 343);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1049, 224);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 23);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 18;
            label6.Text = "Kafes ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(42, 99);
            label7.Name = "label7";
            label7.Size = new Size(157, 20);
            label7.TabIndex = 19;
            label7.Text = "En Kalabalık Kafes(ler)";
            // 
            // ziyaretciAd
            // 
            ziyaretciAd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ziyaretciAd.Location = new Point(132, 19);
            ziyaretciAd.Name = "ziyaretciAd";
            ziyaretciAd.Size = new Size(152, 27);
            ziyaretciAd.TabIndex = 20;
            // 
            // ziyaretciSoyad
            // 
            ziyaretciSoyad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ziyaretciSoyad.Location = new Point(132, 66);
            ziyaretciSoyad.Name = "ziyaretciSoyad";
            ziyaretciSoyad.Size = new Size(152, 27);
            ziyaretciSoyad.TabIndex = 21;
            // 
            // ziy_bilet_id
            // 
            ziy_bilet_id.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ziy_bilet_id.Location = new Point(132, 110);
            ziy_bilet_id.Name = "ziy_bilet_id";
            ziy_bilet_id.Size = new Size(152, 27);
            ziy_bilet_id.TabIndex = 22;
            // 
            // ziy_grupNo
            // 
            ziy_grupNo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ziy_grupNo.Location = new Point(132, 158);
            ziy_grupNo.Name = "ziy_grupNo";
            ziy_grupNo.Size = new Size(152, 27);
            ziy_grupNo.TabIndex = 23;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Location = new Point(58, 22);
            label8.Name = "label8";
            label8.Size = new Size(31, 20);
            label8.TabIndex = 24;
            label8.Text = "Ad:";
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Location = new Point(58, 69);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 25;
            label9.Text = "Soyad:";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Location = new Point(58, 117);
            label10.Name = "label10";
            label10.Size = new Size(61, 20);
            label10.TabIndex = 26;
            label10.Text = "Bilet ID:";
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Location = new Point(58, 161);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 27;
            label11.Text = "Grup No:";
            // 
            // ziyaretciEkle
            // 
            ziyaretciEkle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ziyaretciEkle.BackColor = SystemColors.GradientInactiveCaption;
            ziyaretciEkle.Location = new Point(310, 84);
            ziyaretciEkle.Name = "ziyaretciEkle";
            ziyaretciEkle.Size = new Size(125, 53);
            ziyaretciEkle.TabIndex = 28;
            ziyaretciEkle.Text = "Ziyaretçi Ekle";
            ziyaretciEkle.UseVisualStyleBackColor = false;
            ziyaretciEkle.Click += ziyaretciEkle_Click;
            // 
            // bakici_kafesid
            // 
            bakici_kafesid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bakici_kafesid.BackColor = SystemColors.Window;
            bakici_kafesid.Location = new Point(202, 41);
            bakici_kafesid.Name = "bakici_kafesid";
            bakici_kafesid.Size = new Size(135, 27);
            bakici_kafesid.TabIndex = 29;
            // 
            // bakici_id
            // 
            bakici_id.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            bakici_id.Location = new Point(202, 93);
            bakici_id.Name = "bakici_id";
            bakici_id.Size = new Size(135, 27);
            bakici_id.TabIndex = 30;
            // 
            // kafesatama
            // 
            kafesatama.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            kafesatama.BackColor = SystemColors.GradientInactiveCaption;
            kafesatama.Location = new Point(202, 156);
            kafesatama.Name = "kafesatama";
            kafesatama.Size = new Size(117, 39);
            kafesatama.TabIndex = 31;
            kafesatama.Text = "Atama Yap";
            kafesatama.UseVisualStyleBackColor = false;
            kafesatama.Click += kafesatama_Click;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Location = new Point(99, 44);
            label12.Name = "label12";
            label12.Size = new Size(67, 20);
            label12.TabIndex = 32;
            label12.Text = "Kafes ID:";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Location = new Point(99, 96);
            label13.Name = "label13";
            label13.Size = new Size(86, 20);
            label13.TabIndex = 33;
            label13.Text = "Personel ID:";
            label13.Click += label13_Click;
            // 
            // hayvan_ekle
            // 
            hayvan_ekle.BackColor = SystemColors.GradientInactiveCaption;
            hayvan_ekle.Location = new Point(103, 257);
            hayvan_ekle.Name = "hayvan_ekle";
            hayvan_ekle.Size = new Size(145, 29);
            hayvan_ekle.TabIndex = 34;
            hayvan_ekle.Text = "Hayvan Ekle";
            hayvan_ekle.UseVisualStyleBackColor = false;
            hayvan_ekle.Click += hayvan_ekle_Click;
            // 
            // hayvan_turid
            // 
            hayvan_turid.Location = new Point(166, 66);
            hayvan_turid.Name = "hayvan_turid";
            hayvan_turid.Size = new Size(125, 27);
            hayvan_turid.TabIndex = 36;
            // 
            // hayvan_yas
            // 
            hayvan_yas.Location = new Point(166, 105);
            hayvan_yas.Name = "hayvan_yas";
            hayvan_yas.Size = new Size(125, 27);
            hayvan_yas.TabIndex = 37;
            // 
            // hayvan_ortamid
            // 
            hayvan_ortamid.Location = new Point(166, 147);
            hayvan_ortamid.Name = "hayvan_ortamid";
            hayvan_ortamid.Size = new Size(125, 27);
            hayvan_ortamid.TabIndex = 39;
            // 
            // hayvan_kafesid
            // 
            hayvan_kafesid.BackColor = SystemColors.Window;
            hayvan_kafesid.Location = new Point(166, 20);
            hayvan_kafesid.Name = "hayvan_kafesid";
            hayvan_kafesid.Size = new Size(125, 27);
            hayvan_kafesid.TabIndex = 40;
            // 
            // beslenmesaati
            // 
            beslenmesaati.Location = new Point(166, 194);
            beslenmesaati.Name = "beslenmesaati";
            beslenmesaati.Size = new Size(125, 27);
            beslenmesaati.TabIndex = 41;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(17, 69);
            label14.Name = "label14";
            label14.Size = new Size(52, 20);
            label14.TabIndex = 42;
            label14.Text = "Tür ID:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(17, 108);
            label15.Name = "label15";
            label15.Size = new Size(33, 20);
            label15.TabIndex = 43;
            label15.Text = "Yaş:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(17, 197);
            label16.Name = "label16";
            label16.Size = new Size(113, 20);
            label16.TabIndex = 44;
            label16.Text = "Beslenme Saati:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(17, 150);
            label17.Name = "label17";
            label17.Size = new Size(73, 20);
            label17.TabIndex = 45;
            label17.Text = "Ortam ID:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(57, 88);
            label18.Name = "label18";
            label18.Size = new Size(67, 20);
            label18.TabIndex = 46;
            label18.Text = "Kafes ID:";
            // 
            // tabControl1
            // 
            tabControl1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1118, 735);
            tabControl1.TabIndex = 47;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox5);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(personeldgv);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1110, 702);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Personel ve Atama";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.DarkGray;
            groupBox5.Controls.Add(label1);
            groupBox5.Controls.Add(label2);
            groupBox5.Controls.Add(puanVer);
            groupBox5.Controls.Add(txtGonulluId);
            groupBox5.Controls.Add(txtPuan);
            groupBox5.Location = new Point(549, 270);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(517, 351);
            groupBox5.TabIndex = 35;
            groupBox5.TabStop = false;
            groupBox5.Text = "Gönüllü Puanı";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.DarkGray;
            groupBox4.Controls.Add(label13);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(kafesatama);
            groupBox4.Controls.Add(bakici_id);
            groupBox4.Controls.Add(bakici_kafesid);
            groupBox4.Location = new Point(24, 270);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(496, 351);
            groupBox4.TabIndex = 34;
            groupBox4.TabStop = false;
            groupBox4.Text = "Gönüllü Atama";
            // 
            // personeldgv
            // 
            personeldgv.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            personeldgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            personeldgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            personeldgv.Location = new Point(24, 6);
            personeldgv.Name = "personeldgv";
            personeldgv.RowHeadersVisible = false;
            personeldgv.RowHeadersWidth = 51;
            personeldgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            personeldgv.Size = new Size(1042, 209);
            personeldgv.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(hayvandgv);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1110, 702);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Hayvan Yönetimi";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.DarkGray;
            groupBox3.Controls.Add(EnKalabalikKafes);
            groupBox3.Controls.Add(label7);
            groupBox3.ForeColor = SystemColors.ControlText;
            groupBox3.Location = new Point(811, 294);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(265, 317);
            groupBox3.TabIndex = 50;
            groupBox3.TabStop = false;
            groupBox3.Text = "Kalabalık Kafes";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.DarkGray;
            groupBox2.Controls.Add(analizKafesId);
            groupBox2.Controls.Add(label18);
            groupBox2.Controls.Add(riskAnalizi);
            groupBox2.Location = new Point(451, 294);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(354, 317);
            groupBox2.TabIndex = 49;
            groupBox2.TabStop = false;
            groupBox2.Text = "Kafes Doluluk Oranı %";
            // 
            // analizKafesId
            // 
            analizKafesId.Location = new Point(152, 85);
            analizKafesId.Name = "analizKafesId";
            analizKafesId.Size = new Size(125, 27);
            analizKafesId.TabIndex = 47;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.DarkGray;
            groupBox1.Controls.Add(hayvan_ekle);
            groupBox1.Controls.Add(hayvan_kafesid);
            groupBox1.Controls.Add(beslenmesaati);
            groupBox1.Controls.Add(hayvan_turid);
            groupBox1.Controls.Add(hayvan_yas);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(hayvan_ortamid);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(17, 294);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 317);
            groupBox1.TabIndex = 48;
            groupBox1.TabStop = false;
            groupBox1.Text = "Hayvan Ekleme";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(groupBox7);
            tabPage3.Controls.Add(groupBox6);
            tabPage3.Controls.Add(dgvZiyaretciler);
            tabPage3.Controls.Add(dgvDetaylar);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1110, 702);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Ziyaretçi ve Bilet";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            groupBox7.BackColor = Color.DarkGray;
            groupBox7.Controls.Add(label3);
            groupBox7.Controls.Add(txtBagisZiyaretciId);
            groupBox7.Controls.Add(bagis);
            groupBox7.Location = new Point(521, 417);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(562, 234);
            groupBox7.TabIndex = 30;
            groupBox7.TabStop = false;
            groupBox7.Text = "Bağış Bilgisi";
            // 
            // groupBox6
            // 
            groupBox6.BackColor = Color.DarkGray;
            groupBox6.Controls.Add(label11);
            groupBox6.Controls.Add(ziyaretciEkle);
            groupBox6.Controls.Add(label10);
            groupBox6.Controls.Add(ziyaretciAd);
            groupBox6.Controls.Add(label9);
            groupBox6.Controls.Add(ziyaretciSoyad);
            groupBox6.Controls.Add(label8);
            groupBox6.Controls.Add(ziy_bilet_id);
            groupBox6.Controls.Add(ziy_grupNo);
            groupBox6.Location = new Point(8, 417);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(486, 230);
            groupBox6.TabIndex = 29;
            groupBox6.TabStop = false;
            groupBox6.Text = "Ziyaretçi Ekleme";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 692);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Hayvanat Bahçesi Yönetimi";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)hayvandgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvZiyaretciler).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvDetaylar).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)personeldgv).EndInit();
            tabPage1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage3.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EnKalabalikKafes;
        private DataGridView hayvandgv;
        private Button riskAnalizi;
        private Button puanVer;
        private TextBox txtGonulluId;
        private TextBox txtPuan;
        private Label label1;
        private Label label2;
        private DataGridView dgvZiyaretciler;
        private DataGridView dgvDetaylar;
        private Button bagis;
        private TextBox txtBagisZiyaretciId;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox ziyaretciAd;
        private TextBox ziyaretciSoyad;
        private TextBox ziy_bilet_id;
        private TextBox ziy_grupNo;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Button ziyaretciEkle;
        private TextBox bakici_kafesid;
        private TextBox bakici_id;
        private Button kafesatama;
        private Label label12;
        private Label label13;
        private Button hayvan_ekle;
        private TextBox hayvan_turid;
        private TextBox hayvan_yas;
        private TextBox hayvan_ortamid;
        private TextBox hayvan_kafesid;
        private MaskedTextBox beslenmesaati;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private DataGridView personeldgv;
        private TextBox analizKafesId;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private GroupBox groupBox7;
        private GroupBox groupBox6;
    }
}
