namespace LokatyOrazKredyty_Małek
{
    partial class KMsprawdzianSystematyczneOszczedzanie
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStoparoczna = new System.Windows.Forms.ComboBox();
            this.gpczestosckapitalizacjiodsetek = new System.Windows.Forms.GroupBox();
            this.rdbcomiesiac = new System.Windows.Forms.RadioButton();
            this.rdbcokwartal = new System.Windows.Forms.RadioButton();
            this.rdbcopolroku = new System.Windows.Forms.RadioButton();
            this.rdbrazwroku = new System.Windows.Forms.RadioButton();
            this.chtWykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dgvTabelaRozliczeniaLokaty = new System.Windows.Forms.DataGridView();
            this.NumerOkresu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stannapoczatku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odsetki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stannakoniecokresu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblWynikKNM = new System.Windows.Forms.Label();
            this.txtWynikKNM = new System.Windows.Forms.TextBox();
            this.btnObliczStanKonta = new System.Windows.Forms.Button();
            this.btnRozliczLokate = new System.Windows.Forms.Button();
            this.btnUtworzWykres = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.KMgrbRata = new System.Windows.Forms.GroupBox();
            this.KMrdbPoczatek = new System.Windows.Forms.RadioButton();
            this.KMrdbKoniec = new System.Windows.Forms.RadioButton();
            this.KMtxtR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gpczestosckapitalizacjiodsetek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtWykres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaRozliczeniaLokaty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.KMgrbRata.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wysokosc lokaty kapitalowej K";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(12, 69);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(200, 20);
            this.txtK.TabIndex = 3;
            this.txtK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Liczba lat lokaty N";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(15, 117);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(120, 20);
            this.txtN.TabIndex = 5;
            this.txtN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Roczna stopa procentowa p";
            // 
            // cmbStoparoczna
            // 
            this.cmbStoparoczna.FormattingEnabled = true;
            this.cmbStoparoczna.Items.AddRange(new object[] {
            "1,0%",
            "1,1%",
            "1,2%",
            "1,3%",
            "1,4%",
            "1,5%",
            "1,6%",
            "1,7%",
            "1,8%",
            "1,9%",
            "2,0%",
            "2,1%",
            "2,2%",
            "2,3%",
            "2,4%",
            "2,5%",
            "2,6%",
            "2,7%",
            "2,8%",
            "2,9%",
            "3,0%",
            "3,1%",
            "3,2%",
            "3,3%"});
            this.cmbStoparoczna.Location = new System.Drawing.Point(12, 170);
            this.cmbStoparoczna.Name = "cmbStoparoczna";
            this.cmbStoparoczna.Size = new System.Drawing.Size(200, 21);
            this.cmbStoparoczna.TabIndex = 7;
            this.cmbStoparoczna.Text = "Wybierz stope procentowa";
            // 
            // gpczestosckapitalizacjiodsetek
            // 
            this.gpczestosckapitalizacjiodsetek.Controls.Add(this.rdbcomiesiac);
            this.gpczestosckapitalizacjiodsetek.Controls.Add(this.rdbcokwartal);
            this.gpczestosckapitalizacjiodsetek.Controls.Add(this.rdbcopolroku);
            this.gpczestosckapitalizacjiodsetek.Controls.Add(this.rdbrazwroku);
            this.gpczestosckapitalizacjiodsetek.Location = new System.Drawing.Point(15, 217);
            this.gpczestosckapitalizacjiodsetek.Name = "gpczestosckapitalizacjiodsetek";
            this.gpczestosckapitalizacjiodsetek.Size = new System.Drawing.Size(200, 163);
            this.gpczestosckapitalizacjiodsetek.TabIndex = 8;
            this.gpczestosckapitalizacjiodsetek.TabStop = false;
            this.gpczestosckapitalizacjiodsetek.Text = "Czestosc kapitalizacji odsetek M";
            // 
            // rdbcomiesiac
            // 
            this.rdbcomiesiac.AutoSize = true;
            this.rdbcomiesiac.Location = new System.Drawing.Point(14, 135);
            this.rdbcomiesiac.Name = "rdbcomiesiac";
            this.rdbcomiesiac.Size = new System.Drawing.Size(76, 17);
            this.rdbcomiesiac.TabIndex = 3;
            this.rdbcomiesiac.Text = "Co miesiac";
            this.rdbcomiesiac.UseVisualStyleBackColor = true;
            // 
            // rdbcokwartal
            // 
            this.rdbcokwartal.AutoSize = true;
            this.rdbcokwartal.Location = new System.Drawing.Point(14, 105);
            this.rdbcokwartal.Name = "rdbcokwartal";
            this.rdbcokwartal.Size = new System.Drawing.Size(75, 17);
            this.rdbcokwartal.TabIndex = 2;
            this.rdbcokwartal.Text = "Co kwartal";
            this.rdbcokwartal.UseVisualStyleBackColor = true;
            // 
            // rdbcopolroku
            // 
            this.rdbcopolroku.AutoSize = true;
            this.rdbcopolroku.Location = new System.Drawing.Point(14, 75);
            this.rdbcopolroku.Name = "rdbcopolroku";
            this.rdbcopolroku.Size = new System.Drawing.Size(79, 17);
            this.rdbcopolroku.TabIndex = 1;
            this.rdbcopolroku.Text = "Co pol roku";
            this.rdbcopolroku.UseVisualStyleBackColor = true;
            // 
            // rdbrazwroku
            // 
            this.rdbrazwroku.AutoSize = true;
            this.rdbrazwroku.Checked = true;
            this.rdbrazwroku.Location = new System.Drawing.Point(14, 46);
            this.rdbrazwroku.Name = "rdbrazwroku";
            this.rdbrazwroku.Size = new System.Drawing.Size(79, 17);
            this.rdbrazwroku.TabIndex = 0;
            this.rdbrazwroku.TabStop = true;
            this.rdbrazwroku.Text = "Raz w roku";
            this.rdbrazwroku.UseVisualStyleBackColor = true;
            // 
            // chtWykres
            // 
            chartArea1.Name = "ChartArea1";
            this.chtWykres.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtWykres.Legends.Add(legend1);
            this.chtWykres.Location = new System.Drawing.Point(247, 63);
            this.chtWykres.Name = "chtWykres";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtWykres.Series.Add(series1);
            this.chtWykres.Size = new System.Drawing.Size(493, 300);
            this.chtWykres.TabIndex = 18;
            this.chtWykres.Text = "chart1";
            this.chtWykres.Visible = false;
            // 
            // dgvTabelaRozliczeniaLokaty
            // 
            this.dgvTabelaRozliczeniaLokaty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelaRozliczeniaLokaty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumerOkresu,
            this.stannapoczatku,
            this.Odsetki,
            this.Stannakoniecokresu});
            this.dgvTabelaRozliczeniaLokaty.Location = new System.Drawing.Point(247, 37);
            this.dgvTabelaRozliczeniaLokaty.Name = "dgvTabelaRozliczeniaLokaty";
            this.dgvTabelaRozliczeniaLokaty.Size = new System.Drawing.Size(493, 326);
            this.dgvTabelaRozliczeniaLokaty.TabIndex = 19;
            this.dgvTabelaRozliczeniaLokaty.Visible = false;
            // 
            // NumerOkresu
            // 
            this.NumerOkresu.HeaderText = "Numer okresu lokaty";
            this.NumerOkresu.Name = "NumerOkresu";
            this.NumerOkresu.Width = 50;
            // 
            // stannapoczatku
            // 
            this.stannapoczatku.HeaderText = "Stan na poczatku danego okresu lokaty";
            this.stannapoczatku.Name = "stannapoczatku";
            this.stannapoczatku.Width = 150;
            // 
            // Odsetki
            // 
            this.Odsetki.HeaderText = "Odsetki za dany okres lokaty";
            this.Odsetki.Name = "Odsetki";
            // 
            // Stannakoniecokresu
            // 
            this.Stannakoniecokresu.HeaderText = "Stan na koniec danego okresu lokatu";
            this.Stannakoniecokresu.Name = "Stannakoniecokresu";
            this.Stannakoniecokresu.Width = 150;
            // 
            // lblWynikKNM
            // 
            this.lblWynikKNM.AutoSize = true;
            this.lblWynikKNM.Location = new System.Drawing.Point(882, 69);
            this.lblWynikKNM.Name = "lblWynikKNM";
            this.lblWynikKNM.Size = new System.Drawing.Size(120, 13);
            this.lblWynikKNM.TabIndex = 20;
            this.lblWynikKNM.Text = "Przyszly stan konta knm";
            this.lblWynikKNM.Visible = false;
            // 
            // txtWynikKNM
            // 
            this.txtWynikKNM.Location = new System.Drawing.Point(885, 85);
            this.txtWynikKNM.Name = "txtWynikKNM";
            this.txtWynikKNM.ReadOnly = true;
            this.txtWynikKNM.Size = new System.Drawing.Size(150, 20);
            this.txtWynikKNM.TabIndex = 21;
            this.txtWynikKNM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWynikKNM.Visible = false;
            // 
            // btnObliczStanKonta
            // 
            this.btnObliczStanKonta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObliczStanKonta.Location = new System.Drawing.Point(885, 117);
            this.btnObliczStanKonta.Name = "btnObliczStanKonta";
            this.btnObliczStanKonta.Size = new System.Drawing.Size(150, 62);
            this.btnObliczStanKonta.TabIndex = 22;
            this.btnObliczStanKonta.Text = "Oblicz przyszly stan konta";
            this.btnObliczStanKonta.UseVisualStyleBackColor = true;
            this.btnObliczStanKonta.Click += new System.EventHandler(this.btnObliczStanKonta_Click);
            // 
            // btnRozliczLokate
            // 
            this.btnRozliczLokate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRozliczLokate.Location = new System.Drawing.Point(885, 185);
            this.btnRozliczLokate.Name = "btnRozliczLokate";
            this.btnRozliczLokate.Size = new System.Drawing.Size(150, 98);
            this.btnRozliczLokate.TabIndex = 23;
            this.btnRozliczLokate.Text = "Tabelaryczna wizualizacja rozliczenia lokaty kapitalowej";
            this.btnRozliczLokate.UseVisualStyleBackColor = true;
            this.btnRozliczLokate.Click += new System.EventHandler(this.btnRozliczLokate_Click);
            // 
            // btnUtworzWykres
            // 
            this.btnUtworzWykres.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUtworzWykres.Location = new System.Drawing.Point(885, 288);
            this.btnUtworzWykres.Name = "btnUtworzWykres";
            this.btnUtworzWykres.Size = new System.Drawing.Size(150, 75);
            this.btnUtworzWykres.TabIndex = 24;
            this.btnUtworzWykres.Text = "Graficzna wizualizacja rozliczenia lokaty kapitalowej";
            this.btnUtworzWykres.UseVisualStyleBackColor = true;
            this.btnUtworzWykres.Click += new System.EventHandler(this.btnUtworzWykres_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // KMgrbRata
            // 
            this.KMgrbRata.Controls.Add(this.KMrdbKoniec);
            this.KMgrbRata.Controls.Add(this.KMrdbPoczatek);
            this.KMgrbRata.Location = new System.Drawing.Point(15, 405);
            this.KMgrbRata.Name = "KMgrbRata";
            this.KMgrbRata.Size = new System.Drawing.Size(200, 100);
            this.KMgrbRata.TabIndex = 25;
            this.KMgrbRata.TabStop = false;
            this.KMgrbRata.Text = "Rata systematycznego oszczedzania";
            // 
            // KMrdbPoczatek
            // 
            this.KMrdbPoczatek.AutoSize = true;
            this.KMrdbPoczatek.Checked = true;
            this.KMrdbPoczatek.Location = new System.Drawing.Point(14, 20);
            this.KMrdbPoczatek.Name = "KMrdbPoczatek";
            this.KMrdbPoczatek.Size = new System.Drawing.Size(86, 17);
            this.KMrdbPoczatek.TabIndex = 0;
            this.KMrdbPoczatek.TabStop = true;
            this.KMrdbPoczatek.Text = "Na poczatku";
            this.KMrdbPoczatek.UseVisualStyleBackColor = true;
            // 
            // KMrdbKoniec
            // 
            this.KMrdbKoniec.AutoSize = true;
            this.KMrdbKoniec.Location = new System.Drawing.Point(14, 53);
            this.KMrdbKoniec.Name = "KMrdbKoniec";
            this.KMrdbKoniec.Size = new System.Drawing.Size(72, 17);
            this.KMrdbKoniec.TabIndex = 1;
            this.KMrdbKoniec.Text = "Na koncu";
            this.KMrdbKoniec.UseVisualStyleBackColor = true;
            // 
            // KMtxtR
            // 
            this.KMtxtR.Location = new System.Drawing.Point(35, 540);
            this.KMtxtR.Name = "KMtxtR";
            this.KMtxtR.Size = new System.Drawing.Size(100, 20);
            this.KMtxtR.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Podaj rate R";
            // 
            // KMsprawdzianSystematyczneOszczedzanie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 681);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.KMtxtR);
            this.Controls.Add(this.KMgrbRata);
            this.Controls.Add(this.btnUtworzWykres);
            this.Controls.Add(this.btnRozliczLokate);
            this.Controls.Add(this.btnObliczStanKonta);
            this.Controls.Add(this.txtWynikKNM);
            this.Controls.Add(this.lblWynikKNM);
            this.Controls.Add(this.dgvTabelaRozliczeniaLokaty);
            this.Controls.Add(this.chtWykres);
            this.Controls.Add(this.gpczestosckapitalizacjiodsetek);
            this.Controls.Add(this.cmbStoparoczna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.label2);
            this.Name = "KMsprawdzianSystematyczneOszczedzanie";
            this.Text = "KMsprawdzianSystematyczneOszczedzanie";
            this.gpczestosckapitalizacjiodsetek.ResumeLayout(false);
            this.gpczestosckapitalizacjiodsetek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtWykres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaRozliczeniaLokaty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.KMgrbRata.ResumeLayout(false);
            this.KMgrbRata.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStoparoczna;
        private System.Windows.Forms.GroupBox gpczestosckapitalizacjiodsetek;
        private System.Windows.Forms.RadioButton rdbcomiesiac;
        private System.Windows.Forms.RadioButton rdbcokwartal;
        private System.Windows.Forms.RadioButton rdbcopolroku;
        private System.Windows.Forms.RadioButton rdbrazwroku;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtWykres;
        private System.Windows.Forms.DataGridView dgvTabelaRozliczeniaLokaty;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumerOkresu;
        private System.Windows.Forms.DataGridViewTextBoxColumn stannapoczatku;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odsetki;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stannakoniecokresu;
        private System.Windows.Forms.Label lblWynikKNM;
        private System.Windows.Forms.TextBox txtWynikKNM;
        private System.Windows.Forms.Button btnObliczStanKonta;
        private System.Windows.Forms.Button btnRozliczLokate;
        private System.Windows.Forms.Button btnUtworzWykres;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.GroupBox KMgrbRata;
        private System.Windows.Forms.RadioButton KMrdbKoniec;
        private System.Windows.Forms.RadioButton KMrdbPoczatek;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox KMtxtR;
    }
}