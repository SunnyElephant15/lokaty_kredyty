namespace LokatyOrazKredyty_Małek
{
    partial class Lokaty
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
            this.Tytul = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbStoparoczna = new System.Windows.Forms.ComboBox();
            this.gpczestosckapitalizacjiodsetek = new System.Windows.Forms.GroupBox();
            this.rdbcomiesiac = new System.Windows.Forms.RadioButton();
            this.rdbcokwartal = new System.Windows.Forms.RadioButton();
            this.rdbcopolroku = new System.Windows.Forms.RadioButton();
            this.rdbrazwroku = new System.Windows.Forms.RadioButton();
            this.lblWynikKNM = new System.Windows.Forms.Label();
            this.txtWynikKNM = new System.Windows.Forms.TextBox();
            this.btnObliczStanKonta = new System.Windows.Forms.Button();
            this.btnRozliczLokate = new System.Windows.Forms.Button();
            this.btnUtworzWykres = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblrozliczenietabelaryczne = new System.Windows.Forms.Label();
            this.dgvTabelaRozliczeniaLokaty = new System.Windows.Forms.DataGridView();
            this.NumerOkresu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stannapoczatku = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Odsetki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stannakoniecokresu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblwykres = new System.Windows.Forms.Label();
            this.chtWykres = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszWynikiTabelarycznegoRozliczneiaLokatyWPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odczytajZPlikuZapisaneWynikiTabelarycznegoRozliczneiaLokatyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zamkniecieFormularzaLokatyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjscieZAplikacjiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nawigacjaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularzKredytyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formularzSprawdzianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gpczestosckapitalizacjiodsetek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaRozliczeniaLokaty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtWykres)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tytul
            // 
            this.Tytul.AutoSize = true;
            this.Tytul.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tytul.Location = new System.Drawing.Point(386, 24);
            this.Tytul.Name = "Tytul";
            this.Tytul.Size = new System.Drawing.Size(375, 31);
            this.Tytul.TabIndex = 0;
            this.Tytul.Text = "Rozliczenie lokat kapitalowych";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wysokosc lokaty kapitalowej K";
            // 
            // txtK
            // 
            this.txtK.Location = new System.Drawing.Point(38, 128);
            this.txtK.Name = "txtK";
            this.txtK.Size = new System.Drawing.Size(200, 26);
            this.txtK.TabIndex = 2;
            this.txtK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Liczba lat lokaty N";
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(38, 197);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(120, 26);
            this.txtN.TabIndex = 4;
            this.txtN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 246);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 19);
            this.label3.TabIndex = 5;
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
            this.cmbStoparoczna.Location = new System.Drawing.Point(38, 268);
            this.cmbStoparoczna.Name = "cmbStoparoczna";
            this.cmbStoparoczna.Size = new System.Drawing.Size(200, 27);
            this.cmbStoparoczna.TabIndex = 6;
            this.cmbStoparoczna.Text = "Wybierz stope procentowa";
            // 
            // gpczestosckapitalizacjiodsetek
            // 
            this.gpczestosckapitalizacjiodsetek.Controls.Add(this.rdbcomiesiac);
            this.gpczestosckapitalizacjiodsetek.Controls.Add(this.rdbcokwartal);
            this.gpczestosckapitalizacjiodsetek.Controls.Add(this.rdbcopolroku);
            this.gpczestosckapitalizacjiodsetek.Controls.Add(this.rdbrazwroku);
            this.gpczestosckapitalizacjiodsetek.Location = new System.Drawing.Point(38, 313);
            this.gpczestosckapitalizacjiodsetek.Name = "gpczestosckapitalizacjiodsetek";
            this.gpczestosckapitalizacjiodsetek.Size = new System.Drawing.Size(200, 163);
            this.gpczestosckapitalizacjiodsetek.TabIndex = 7;
            this.gpczestosckapitalizacjiodsetek.TabStop = false;
            this.gpczestosckapitalizacjiodsetek.Text = "Czestosc kapitalizacji odsetek M";
            // 
            // rdbcomiesiac
            // 
            this.rdbcomiesiac.AutoSize = true;
            this.rdbcomiesiac.Location = new System.Drawing.Point(14, 135);
            this.rdbcomiesiac.Name = "rdbcomiesiac";
            this.rdbcomiesiac.Size = new System.Drawing.Size(94, 23);
            this.rdbcomiesiac.TabIndex = 3;
            this.rdbcomiesiac.Text = "Co miesiac";
            this.rdbcomiesiac.UseVisualStyleBackColor = true;
            // 
            // rdbcokwartal
            // 
            this.rdbcokwartal.AutoSize = true;
            this.rdbcokwartal.Location = new System.Drawing.Point(14, 105);
            this.rdbcokwartal.Name = "rdbcokwartal";
            this.rdbcokwartal.Size = new System.Drawing.Size(95, 23);
            this.rdbcokwartal.TabIndex = 2;
            this.rdbcokwartal.Text = "Co kwartal";
            this.rdbcokwartal.UseVisualStyleBackColor = true;
            // 
            // rdbcopolroku
            // 
            this.rdbcopolroku.AutoSize = true;
            this.rdbcopolroku.Location = new System.Drawing.Point(14, 75);
            this.rdbcopolroku.Name = "rdbcopolroku";
            this.rdbcopolroku.Size = new System.Drawing.Size(101, 23);
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
            this.rdbrazwroku.Size = new System.Drawing.Size(97, 23);
            this.rdbrazwroku.TabIndex = 0;
            this.rdbrazwroku.TabStop = true;
            this.rdbrazwroku.Text = "Raz w roku";
            this.rdbrazwroku.UseVisualStyleBackColor = true;
            // 
            // lblWynikKNM
            // 
            this.lblWynikKNM.AutoSize = true;
            this.lblWynikKNM.Location = new System.Drawing.Point(901, 106);
            this.lblWynikKNM.Name = "lblWynikKNM";
            this.lblWynikKNM.Size = new System.Drawing.Size(154, 19);
            this.lblWynikKNM.TabIndex = 8;
            this.lblWynikKNM.Text = "Przyszly stan konta knm";
            this.lblWynikKNM.Visible = false;
            // 
            // txtWynikKNM
            // 
            this.txtWynikKNM.Location = new System.Drawing.Point(905, 128);
            this.txtWynikKNM.Name = "txtWynikKNM";
            this.txtWynikKNM.ReadOnly = true;
            this.txtWynikKNM.Size = new System.Drawing.Size(150, 26);
            this.txtWynikKNM.TabIndex = 9;
            this.txtWynikKNM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtWynikKNM.Visible = false;
            // 
            // btnObliczStanKonta
            // 
            this.btnObliczStanKonta.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObliczStanKonta.Location = new System.Drawing.Point(905, 161);
            this.btnObliczStanKonta.Name = "btnObliczStanKonta";
            this.btnObliczStanKonta.Size = new System.Drawing.Size(150, 62);
            this.btnObliczStanKonta.TabIndex = 10;
            this.btnObliczStanKonta.Text = "Oblicz przyszly stan konta";
            this.btnObliczStanKonta.UseVisualStyleBackColor = true;
            this.btnObliczStanKonta.Click += new System.EventHandler(this.btnObliczStanKonta_Click);
            // 
            // btnRozliczLokate
            // 
            this.btnRozliczLokate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRozliczLokate.Location = new System.Drawing.Point(905, 229);
            this.btnRozliczLokate.Name = "btnRozliczLokate";
            this.btnRozliczLokate.Size = new System.Drawing.Size(150, 98);
            this.btnRozliczLokate.TabIndex = 11;
            this.btnRozliczLokate.Text = "Tabelaryczna wizualizacja rozliczenia lokaty kapitalowej";
            this.btnRozliczLokate.UseVisualStyleBackColor = true;
            this.btnRozliczLokate.Click += new System.EventHandler(this.btnRozliczLokate_Click);
            // 
            // btnUtworzWykres
            // 
            this.btnUtworzWykres.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUtworzWykres.Location = new System.Drawing.Point(905, 333);
            this.btnUtworzWykres.Name = "btnUtworzWykres";
            this.btnUtworzWykres.Size = new System.Drawing.Size(150, 75);
            this.btnUtworzWykres.TabIndex = 12;
            this.btnUtworzWykres.Text = "Graficzna wizualizacja rozliczenia lokaty kapitalowej";
            this.btnUtworzWykres.UseVisualStyleBackColor = true;
            this.btnUtworzWykres.Click += new System.EventHandler(this.btnUtworzWykres_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnReset.Location = new System.Drawing.Point(905, 414);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 23);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "RESET";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblrozliczenietabelaryczne
            // 
            this.lblrozliczenietabelaryczne.AutoSize = true;
            this.lblrozliczenietabelaryczne.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblrozliczenietabelaryczne.Location = new System.Drawing.Point(392, 106);
            this.lblrozliczenietabelaryczne.Name = "lblrozliczenietabelaryczne";
            this.lblrozliczenietabelaryczne.Size = new System.Drawing.Size(366, 22);
            this.lblrozliczenietabelaryczne.TabIndex = 14;
            this.lblrozliczenietabelaryczne.Text = "Tabelaryczne rozliczenie lokaty kapitalowej";
            this.lblrozliczenietabelaryczne.Visible = false;
            // 
            // dgvTabelaRozliczeniaLokaty
            // 
            this.dgvTabelaRozliczeniaLokaty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelaRozliczeniaLokaty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumerOkresu,
            this.stannapoczatku,
            this.Odsetki,
            this.Stannakoniecokresu});
            this.dgvTabelaRozliczeniaLokaty.Location = new System.Drawing.Point(337, 145);
            this.dgvTabelaRozliczeniaLokaty.Name = "dgvTabelaRozliczeniaLokaty";
            this.dgvTabelaRozliczeniaLokaty.Size = new System.Drawing.Size(493, 326);
            this.dgvTabelaRozliczeniaLokaty.TabIndex = 15;
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
            // lblwykres
            // 
            this.lblwykres.AutoSize = true;
            this.lblwykres.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblwykres.Location = new System.Drawing.Point(388, 106);
            this.lblwykres.Name = "lblwykres";
            this.lblwykres.Size = new System.Drawing.Size(241, 22);
            this.lblwykres.TabIndex = 16;
            this.lblwykres.Text = "Wykres zmiany stanu konta ";
            this.lblwykres.Visible = false;
            // 
            // chtWykres
            // 
            chartArea1.Name = "ChartArea1";
            this.chtWykres.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chtWykres.Legends.Add(legend1);
            this.chtWykres.Location = new System.Drawing.Point(337, 145);
            this.chtWykres.Name = "chtWykres";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chtWykres.Series.Add(series1);
            this.chtWykres.Size = new System.Drawing.Size(493, 300);
            this.chtWykres.TabIndex = 17;
            this.chtWykres.Text = "chart1";
            this.chtWykres.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.nawigacjaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1116, 24);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zapiszWynikiTabelarycznegoRozliczneiaLokatyWPlikuToolStripMenuItem,
            this.odczytajZPlikuZapisaneWynikiTabelarycznegoRozliczneiaLokatyToolStripMenuItem,
            this.zamkniecieFormularzaLokatyToolStripMenuItem,
            this.wyjscieZAplikacjiToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // zapiszWynikiTabelarycznegoRozliczneiaLokatyWPlikuToolStripMenuItem
            // 
            this.zapiszWynikiTabelarycznegoRozliczneiaLokatyWPlikuToolStripMenuItem.Name = "zapiszWynikiTabelarycznegoRozliczneiaLokatyWPlikuToolStripMenuItem";
            this.zapiszWynikiTabelarycznegoRozliczneiaLokatyWPlikuToolStripMenuItem.Size = new System.Drawing.Size(418, 22);
            this.zapiszWynikiTabelarycznegoRozliczneiaLokatyWPlikuToolStripMenuItem.Text = "&Zapisz wyniki tabelarycznego rozliczneia lokaty w pliku";
            this.zapiszWynikiTabelarycznegoRozliczneiaLokatyWPlikuToolStripMenuItem.Click += new System.EventHandler(this.zapiszWynikiTabelarycznegoRozliczneiaLokatyWPlikuToolStripMenuItem_Click);
            // 
            // odczytajZPlikuZapisaneWynikiTabelarycznegoRozliczneiaLokatyToolStripMenuItem
            // 
            this.odczytajZPlikuZapisaneWynikiTabelarycznegoRozliczneiaLokatyToolStripMenuItem.Name = "odczytajZPlikuZapisaneWynikiTabelarycznegoRozliczneiaLokatyToolStripMenuItem";
            this.odczytajZPlikuZapisaneWynikiTabelarycznegoRozliczneiaLokatyToolStripMenuItem.Size = new System.Drawing.Size(418, 22);
            this.odczytajZPlikuZapisaneWynikiTabelarycznegoRozliczneiaLokatyToolStripMenuItem.Text = "&Odczytaj z pliku zapisane wyniki tabelarycznego rozliczneia lokaty";
            this.odczytajZPlikuZapisaneWynikiTabelarycznegoRozliczneiaLokatyToolStripMenuItem.Click += new System.EventHandler(this.odczytajZPlikuZapisaneWynikiTabelarycznegoRozliczneiaLokatyToolStripMenuItem_Click);
            // 
            // zamkniecieFormularzaLokatyToolStripMenuItem
            // 
            this.zamkniecieFormularzaLokatyToolStripMenuItem.Name = "zamkniecieFormularzaLokatyToolStripMenuItem";
            this.zamkniecieFormularzaLokatyToolStripMenuItem.Size = new System.Drawing.Size(418, 22);
            this.zamkniecieFormularzaLokatyToolStripMenuItem.Text = "Zamkniecie &Formularza Lokaty";
            this.zamkniecieFormularzaLokatyToolStripMenuItem.Click += new System.EventHandler(this.zamkniecieFormularzaLokatyToolStripMenuItem_Click);
            // 
            // wyjscieZAplikacjiToolStripMenuItem
            // 
            this.wyjscieZAplikacjiToolStripMenuItem.Name = "wyjscieZAplikacjiToolStripMenuItem";
            this.wyjscieZAplikacjiToolStripMenuItem.Size = new System.Drawing.Size(418, 22);
            this.wyjscieZAplikacjiToolStripMenuItem.Text = "Wyjscie z &Aplikacji LokatyOrazKredyty";
            this.wyjscieZAplikacjiToolStripMenuItem.Click += new System.EventHandler(this.wyjscieZAplikacjiToolStripMenuItem_Click);
            // 
            // nawigacjaToolStripMenuItem
            // 
            this.nawigacjaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formularzKredytyToolStripMenuItem,
            this.formularzSprawdzianToolStripMenuItem});
            this.nawigacjaToolStripMenuItem.Name = "nawigacjaToolStripMenuItem";
            this.nawigacjaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.nawigacjaToolStripMenuItem.Text = "&Nawigacja";
            // 
            // formularzKredytyToolStripMenuItem
            // 
            this.formularzKredytyToolStripMenuItem.Name = "formularzKredytyToolStripMenuItem";
            this.formularzKredytyToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.formularzKredytyToolStripMenuItem.Text = "Formularz &Kredyty";
            this.formularzKredytyToolStripMenuItem.Click += new System.EventHandler(this.formularzKredytyToolStripMenuItem_Click);
            // 
            // formularzSprawdzianToolStripMenuItem
            // 
            this.formularzSprawdzianToolStripMenuItem.Name = "formularzSprawdzianToolStripMenuItem";
            this.formularzSprawdzianToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.formularzSprawdzianToolStripMenuItem.Text = "Formularz Sprawdzian";
            this.formularzSprawdzianToolStripMenuItem.Click += new System.EventHandler(this.formularzSprawdzianToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Items.AddRange(new object[] {
            "Dash (kreskowa)",
            "KreskowoKropkowa",
            "KreskowoKropkowaMala"});
            this.listBox1.Location = new System.Drawing.Point(905, 485);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(179, 61);
            this.listBox1.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(720, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Wybierz styl linii wykresu";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 487);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 59);
            this.button1.TabIndex = 21;
            this.button1.Text = "Wybierz kolor tla wykresu";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(409, 487);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 59);
            this.button2.TabIndex = 22;
            this.button2.Text = "Wybierz kolor linii wykresu";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(251, 504);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 27);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.Text = "Wybierz grubosc linii";
            // 
            // Lokaty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1116, 613);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.chtWykres);
            this.Controls.Add(this.lblwykres);
            this.Controls.Add(this.dgvTabelaRozliczeniaLokaty);
            this.Controls.Add(this.lblrozliczenietabelaryczne);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnUtworzWykres);
            this.Controls.Add(this.btnRozliczLokate);
            this.Controls.Add(this.btnObliczStanKonta);
            this.Controls.Add(this.txtWynikKNM);
            this.Controls.Add(this.lblWynikKNM);
            this.Controls.Add(this.gpczestosckapitalizacjiodsetek);
            this.Controls.Add(this.cmbStoparoczna);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tytul);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lokaty";
            this.Text = "Rozliczenie lokat kapitalowych";
            this.Load += new System.EventHandler(this.Lokaty_Load);
            this.gpczestosckapitalizacjiodsetek.ResumeLayout(false);
            this.gpczestosckapitalizacjiodsetek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaRozliczeniaLokaty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chtWykres)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tytul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbStoparoczna;
        private System.Windows.Forms.GroupBox gpczestosckapitalizacjiodsetek;
        private System.Windows.Forms.RadioButton rdbcomiesiac;
        private System.Windows.Forms.RadioButton rdbcokwartal;
        private System.Windows.Forms.RadioButton rdbcopolroku;
        private System.Windows.Forms.RadioButton rdbrazwroku;
        private System.Windows.Forms.Label lblWynikKNM;
        private System.Windows.Forms.TextBox txtWynikKNM;
        private System.Windows.Forms.Button btnObliczStanKonta;
        private System.Windows.Forms.Button btnRozliczLokate;
        private System.Windows.Forms.Button btnUtworzWykres;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblrozliczenietabelaryczne;
        private System.Windows.Forms.DataGridView dgvTabelaRozliczeniaLokaty;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumerOkresu;
        private System.Windows.Forms.DataGridViewTextBoxColumn stannapoczatku;
        private System.Windows.Forms.DataGridViewTextBoxColumn Odsetki;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stannakoniecokresu;
        private System.Windows.Forms.Label lblwykres;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtWykres;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zapiszWynikiTabelarycznegoRozliczneiaLokatyWPlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odczytajZPlikuZapisaneWynikiTabelarycznegoRozliczneiaLokatyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zamkniecieFormularzaLokatyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjscieZAplikacjiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nawigacjaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formularzKredytyToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ToolStripMenuItem formularzSprawdzianToolStripMenuItem;
    }
}

