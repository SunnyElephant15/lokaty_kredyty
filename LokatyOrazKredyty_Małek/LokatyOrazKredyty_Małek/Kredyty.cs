using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.IO;


namespace LokatyOrazKredyty_Małek
{
    public partial class Kredyty : Form
    {
        public Kredyty()
        {
            InitializeComponent();
        }

        bool PobranieDanychWejsciowych(out float KMK, out ushort KMn, out float KMp, out ushort KMm, out ushort KMs)
        {//przypisanie wartosci dla przypadku koniecnzosci przerwania pobierania danych
            KMK = 0.0F; KMn = 0; KMp = 0.0F; KMm = 0; KMs = 0;
            //pobranie wysokosci lokaty kapitalowej k
            //1) sprawdzenie czy wpisala zostala kwota k
            if (string.IsNullOrEmpty(txtWysokoscKredytuK.Text))
            {//jest blad to go sygnalizujemy i przerywamy dalsze powielanie danych
                errorProvider1.SetError(txtWysokoscKredytuK, "ERROR: Musisz podac wysokosc Kredytu K");
                return false;

            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();

            //konwersja znakowego napisu kwoty k na wartosc
            if (!float.TryParse(txtWysokoscKredytuK.Text, out KMK))
            {//jest blad to go sygnalizujemy i przerywamy dalsze powielanie danych
                errorProvider1.SetError(txtWysokoscKredytuK, "ERROR: wystapil mniedozwolony znak w zapisie wysokosci lokaty");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //sprawdzenie warunku wejsciowego k >= 100
            if (KMK < 100.0F)
            {//jest blad to go sygnalizujemy i przerywamy dalsze powielanie danych
                errorProvider1.SetError(txtWysokoscKredytuK, "ERROR: minimalna kwota k: k >= 100");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //pobranie liczby lat lokaty
            if (string.IsNullOrEmpty(txtLiczbaLatSplatyKredytuN.Text))
            {//jest blad to go sygnalizujemy i przerywamy dalsze powielanie danych
                errorProvider1.SetError(txtLiczbaLatSplatyKredytuN, "ERROR: musiz podac liczbe lat lokaty");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //konwersja na wartosc
            if (!ushort.TryParse(txtLiczbaLatSplatyKredytuN.Text, out KMn))
            {//jest blad to go sygnalizujemy i przerywamy dalsze powielanie danych
                errorProvider1.SetError(txtLiczbaLatSplatyKredytuN, "ERROR: w zapisie liczby lat lokaty wystapil niedozwolony znak");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //sprzawdzenie warunku wejsciowego: n > 0
            if (KMn <= 0)
            {//jest blad to go sygnalizujemy i przerywamy dalsze powielanie danych
                errorProvider1.SetError(txtLiczbaLatSplatyKredytuN, "ERROR: liczba lat lokaty musi spelniac warunek: k > 0");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //pobranie rocznej stopy procentowej
            //sprawdzenie czy zostala wybrana przez uzytkownika aplikacji
            if (cmbStopaRoczna.SelectedIndex < 0)
            {//jest blad to go sygnalizujemy i przerywamy dalsze powielanie danych
                errorProvider1.SetError(cmbStopaRoczna, "ERROR: musisz wybrac roczna stope procentowa");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //pobranie stopy procentowej
            string StopaProcentowa = cmbStopaRoczna.SelectedItem.ToString();
            StopaProcentowa = StopaProcentowa.Trim();
            //wyciecie znaku miana %
            StopaProcentowa = StopaProcentowa.Substring(0, StopaProcentowa.Length - 1);
            //konwersja na wartosc 
            if (!float.TryParse(StopaProcentowa, out KMp))
            {//jest blad to go sygnalizujemy i przerywamy dalsze powielanie danych
                errorProvider1.SetError(cmbStopaRoczna, "ERROR: wystapil niedozwolony znak w zapiesie wybranej stopy procentwej");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //przeliczenie stopy z mianem procentowym % na wartosc rzeczywista
            KMp = KMp / 100.0F;
            //sprawdzenie warunku wejsciowego dla rocznej stopy
            if ((KMp <= 0.0F) || (KMp >= 1.0F))
            {
                errorProvider1.SetError(cmbStopaRoczna, "ERROR: wartosc rocznej stopy procentowerj musi nalezec do przedzialu 0.0 , 1.0");
                return false;
            }
            else errorProvider1.Dispose();
            //pobranie czestosci kapitalizacji odsetek m
            if (rbRazWRoku.Checked)
                KMm = 1;
            else if (rbCoPolRoku.Checked)
                KMm = 2;
            else if (rbCoKwartal.Checked)
                KMm = 4;
            else if (rbCoMiesiac.Checked)
                KMm = 12;
            else
                KMm = 1;  //domyslnie
            
            if (rbWStalych.Checked)
                KMs = 1;
            if (rbWMalejacych.Checked)
                KMs = 2;
            if (rbWRosnacych.Checked)
                KMs = 3;

            return true;
        }
        private void formularzLokatyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form Formularz in Application.OpenForms)
            {
                if (Formularz.Name == "Lokaty")
                {
                    this.Hide();
                    Formularz.Show();
                    return;

                }
                Lokaty FormularzLokaty = new Lokaty();
                this.Hide();
                FormularzLokaty.Show();
                return;
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            //pusto
        }

        private void btRESET_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //deklaracje mziennych dla przechowania pobranych danych wejsciowych
            float KMK, KMp;
            ushort KMn, KMm, KMs; //tlyko dodatnie
            //wywolanie metody dla pobrania danych wejsciowych
            if (!PobranieDanychWejsciowych(out KMK, out KMn, out KMp, out KMm, out KMs))
                return; //przerwanie obslugi zdarzenia _Click
            //obliczenie wartosci przyszlej
            float KMknm = KMK * (float)Math.Pow(1 + KMp / KMm, KMn * KMm);
            //wizulaizacja wyniku obliczen
            txtOgolnyKosztKredytu.Text = string.Format("{0:0.00}", KMknm);

           /* float Rata = KMknm * (float)Math.Sqrt(KMn * KMm);
            float Rata1 = KMK * ((KMp / KMm) * (float)Math.Pow(1 + KMp / KMm, KMn * KMm)) / ((float)Math.Pow(1 + KMp / KMm, KMn * KMm) - 1);
            float RataOdsetkowa = 
            float RataKapitalowa =*/ 
            //odslonic kontrolki dla wizualizacji wyniku
            lblOgolnyKosztKredytu.Visible = true;
            txtOgolnyKosztKredytu.Visible = true;
            //ustawienie stanu braku aktywnosci dla obslugiwanego przycisku polecen
            txtWysokoscKredytuK.Enabled = false;
            txtLiczbaLatSplatyKredytuN.Enabled = false;
            cmbStopaRoczna.Enabled = false;
            gbLiczbaLatWRoku.Enabled = false;
            txtOgolnyKosztKredytu.Enabled = false;
            btnObliczOgolnyKosztKredytu.Enabled = false;
            gbSplataKredytuWRatach.Enabled = false;
        }
        private void TabelaryczneRozliczenieKredytuStala(float KMK, ushort KMn, float KMp, ushort KMm, out float[,] KMTRL)
        {
            float KMRata = KMK * ((KMp / KMm) * (float)Math.Pow(1 + KMp / KMm, KMn * KMm)) / ((float)Math.Pow(1 + KMp / KMm, KMn * KMm) - 1);

            txtRataRk.Visible = false;
            lblWysokoscRatyRk.Visible = false;

            //utworzenie egzemplarza tablicy TRL
            KMTRL = new float[KMn * KMm + 1, 4];
            //wypelnienie pierwszego wiersza TRL dla tzw okresu zerowego 
            KMTRL[0, 0] = 0.0F;
            KMTRL[0, 1] = 0.0F;
            KMTRL[0, 2] = 0.0F;
            KMTRL[0, 3] = KMK;
            //wypelnienie (wyznaczenie rozliczenia lokaty) tablicy TRL
            for (int i = 1; i < KMTRL.GetLength(0); i++)
            {

                KMTRL[i, 0] = KMTRL[i - 1, 3]; //stan na poczatku okresu lokaty
                KMTRL[i, 1] = KMTRL[i, 0] * KMp / KMm; //odsetki za ity okres lokaty
                KMTRL[i, 2] = KMRata - KMTRL[i, 1]; //stan na koncu okresu lokaty 
                KMTRL[i, 3] = KMTRL[i, 0] - KMTRL[i, 2];
            }
        }
        private void TabelaryczneRozliczenieKredytuMalejaco(float KMK, ushort KMn, float KMp, ushort KMm, out float[,] KMTRL)
        {
            txtRataRk.Text = string.Format("{0:0.00}", KMK / (KMn * KMm));
            float KMRataKapitalowa = KMK / (KMn * KMm);
            //utworzenie egzemplarza tablicy TRL
            KMTRL = new float[KMn * KMm + 1, 4];
            //wypelnienie pierwszego wiersza TRL dla tzw okresu zerowego 
            KMTRL[0, 0] = 0.0F;
            KMTRL[0, 1] = 0.0F;
            KMTRL[0, 2] = 0.0F;
            KMTRL[0, 3] = KMK;
            //wypelnienie (wyznaczenie rozliczenia lokaty) tablicy TRL
            for (int i = 1; i < KMTRL.GetLength(0); i++)
            {

                KMTRL[i, 0] = KMTRL[i - 1, 3]; //stan na poczatku okresu lokaty
                KMTRL[i, 1] = KMTRL[i, 0] * KMp / KMm; //odsetki za ity okres lokaty
                KMTRL[i, 2] = KMRataKapitalowa + KMTRL[i, 1]; //stan na koncu okresu lokaty 
                KMTRL[i, 3] = KMTRL[i, 0] - KMRataKapitalowa;
            }
        }

        private void TabelaryczneRozliczenieKredytuRosnaco(float KMK, ushort KMn, float KMp, ushort KMm, out float[,] KMTRL)
        {
            txtRataRk.Text = string.Format("{0:0.00}", KMK / (KMn * KMm));
            float KMRataKapitalowa = KMK / (KMn * KMm);
            //utworzenie egzemplarza tablicy TRL
            KMTRL = new float[KMn * KMm + 1, 4];
            //wypelnienie pierwszego wiersza TRL dla tzw okresu zerowego 
            KMTRL[0, 0] = 0.0F;
            KMTRL[0, 1] = 0.0F;
            KMTRL[0, 2] = 0.0F;
            KMTRL[0, 3] = 0.0F;
            //wypelnienie (wyznaczenie rozliczenia lokaty) tablicy TRL
            for (int i = 1; i < KMTRL.GetLength(0); i++)
            {

                KMTRL[i, 0] = KMTRL[i - 1, 3]; //stan na poczatku okresu lokaty
                KMTRL[i, 1] = KMTRL[i, 0] * KMp / KMm; //odsetki za ity okres lokaty
                KMTRL[i, 2] = KMRataKapitalowa + KMTRL[i, 1]; //stan na koncu okresu lokaty 
                KMTRL[i, 3] = KMTRL[i, 0] + KMRataKapitalowa;
            }
        }

        private void btTabelaryczneRozliczneieSplatyKredytu_Click(object sender, EventArgs e)
        {
            //deklaracja zmiennych dla przechowania pobranych dancyh wejsciowych z kontrolek formularza\
            float KMK, KMp;
            ushort KMn, KMm, KMs;
            //pobranie danych wejsciowych
            if (!PobranieDanychWejsciowych(out KMK, out KMn, out KMp, out KMm, out KMs))
                return; //czyli przerwanie obslugi przycisku gdyz byl blad w trakcie ich pobierania
            //gdy jestesmy tutaj to nie bylo bledu w pobieraniu danych wejsciowych
            //deklaracja zmiennej referencyjnej do egzemplarza tablicy rozliczenia lokaty
            float[,] KMTRL;
            if (KMs == 1)
            {
                dgvTabelaRozliczeniaKredytu.Visible = true;
                // wywolanie metody rozliczenia lokaty kapitalowej
                TabelaryczneRozliczenieKredytuStala(KMK, KMn, KMp, KMm, out KMTRL);
                // przepisanie danych z tablicy TRL do kontrolki DataGridView
                //dgvTabelaRozliczeniaLokaty.Rows.Clear(); //wyzerowanie kolekcji dantch kontrolki jakiejstam
                    for (int i = 0; i < KMTRL.GetLength(0); i++)
                    {//dodanie nowego wiersza do kontrolki datagridview
                        dgvTabelaRozliczeniaKredytu.Rows.Add();
                        //wpisanie danych do poszczegolnych komorek (kolumn) wiersza
                        dgvTabelaRozliczeniaKredytu.Rows[i].Cells[0].Value = i; //numer okresu
                        dgvTabelaRozliczeniaKredytu.Rows[i].Cells[1].Value =
                            string.Format("{0:0.00}", KMTRL[i, 0]); //stan konta na poczatku itego okresu
                        dgvTabelaRozliczeniaKredytu.Rows[i].Cells[2].Value =
                         string.Format("{0:0.00}", KMTRL[i, 1]); //odsetki za ity okres lokaty
                        dgvTabelaRozliczeniaKredytu.Rows[i].Cells[3].Value =
                         string.Format("{0:0.00}", KMTRL[i, 2]);
                        dgvTabelaRozliczeniaKredytu.Rows[i].Cells[4].Value =
                         string.Format("{0:0.00}", KMTRL[i, 3]);
                        //stan konta na koniec itego okresu lokaty
                        //naprzemienna zmiana koloru tla wiersza danych kontrolki datagridview
                        if (i % 2 == 0)

                            dgvTabelaRozliczeniaKredytu.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                        else
                            dgvTabelaRozliczeniaKredytu.Rows[i].DefaultCellStyle.BackColor = Color.White;

                    }
            }
            else if (KMs == 2)
            {
                dgvTabelaRozliczeniaKredytuMalejaco.Visible = true;
                TabelaryczneRozliczenieKredytuMalejaco(KMK, KMn, KMp, KMm, out KMTRL);
                for (int i = 0; i < KMTRL.GetLength(0); i++)
                {//dodanie nowego wiersza do kontrolki datagridview
                    dgvTabelaRozliczeniaKredytuMalejaco.Rows.Add();
                    //wpisanie danych do poszczegolnych komorek (kolumn) wiersza
                    dgvTabelaRozliczeniaKredytuMalejaco.Rows[i].Cells[0].Value = i; //numer okresu
                    dgvTabelaRozliczeniaKredytuMalejaco.Rows[i].Cells[1].Value =
                        string.Format("{0:0.00}", KMTRL[i, 0]); //stan konta na poczatku itego okresu
                    dgvTabelaRozliczeniaKredytuMalejaco.Rows[i].Cells[2].Value =
                     string.Format("{0:0.00}", KMTRL[i, 1]); //odsetki za ity okres lokaty
                    dgvTabelaRozliczeniaKredytuMalejaco.Rows[i].Cells[3].Value =
                     string.Format("{0:0.00}", KMTRL[i, 2]);
                    dgvTabelaRozliczeniaKredytuMalejaco.Rows[i].Cells[4].Value =
                     string.Format("{0:0.00}", KMTRL[i, 3]);
                    //stan konta na koniec itego okresu lokaty
                    //naprzemienna zmiana koloru tla wiersza danych kontrolki datagridview
                    if (i % 2 == 0)

                        dgvTabelaRozliczeniaKredytuMalejaco.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                    else
                        dgvTabelaRozliczeniaKredytuMalejaco.Rows[i].DefaultCellStyle.BackColor = Color.White;

                }
            }
            else if (KMs == 3)
            {
                dgvTabelaRozliczeniaKredytuRosnaco.Visible = true;
                TabelaryczneRozliczenieKredytuRosnaco(KMK, KMn, KMp, KMm, out KMTRL);
                for (int i = 0; i < KMTRL.GetLength(0); i++)
                {//dodanie nowego wiersza do kontrolki datagridview
                    dgvTabelaRozliczeniaKredytuRosnaco.Rows.Add();
                    //wpisanie danych do poszczegolnych komorek (kolumn) wiersza
                    dgvTabelaRozliczeniaKredytuRosnaco.Rows[i].Cells[0].Value = i; //numer okresu
                    dgvTabelaRozliczeniaKredytuRosnaco.Rows[i].Cells[1].Value =
                        string.Format("{0:0.00}", KMTRL[i, 0]); //stan konta na poczatku itego okresu
                    dgvTabelaRozliczeniaKredytuRosnaco.Rows[i].Cells[2].Value =
                     string.Format("{0:0.00}", KMTRL[i, 1]); //odsetki za ity okres lokaty
                    dgvTabelaRozliczeniaKredytuRosnaco.Rows[i].Cells[3].Value =
                     string.Format("{0:0.00}", KMTRL[i, 2]);
                    dgvTabelaRozliczeniaKredytuRosnaco.Rows[i].Cells[4].Value =
                     string.Format("{0:0.00}", KMTRL[i, 3]);
                    //stan konta na koniec itego okresu lokaty
                    //naprzemienna zmiana koloru tla wiersza danych kontrolki datagridview
                    if (i % 2 == 0)

                        dgvTabelaRozliczeniaKredytuRosnaco.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                    else
                        dgvTabelaRozliczeniaKredytuRosnaco.Rows[i].DefaultCellStyle.BackColor = Color.White;

                }
            }
            //ustawienie centrowania zapisu danych w kolumnach kontrolki DataGridView
            dgvTabelaRozliczeniaKredytu.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //odsloniecie kontrolki DataGridView
            dgvTabelaRozliczeniaKredytu.Visible = true;
            dgvTabelaRozliczeniaKredytu.Visible = true;
            //stawianie stanu braku aktywnosci obslugiwanego przycisku polecen
            btTabelaryczneRozliczneieSplatyKredytu.Enabled = false;
        }

        private void btGraficznaPrezentacjaSplatyKredytu_Click(object sender, EventArgs e)
        {
            //deklaracja zmiennych
            float KMK, KMp;
            ushort KMn, KMm, KMs;
            if (!PobranieDanychWejsciowych(out KMK, out KMn, out KMp, out KMm, out KMs))
                return;

            float[,] KMTRL;
            if (KMs == 1)
            {
                chtWykresStala.Visible = true;
                //wywolanie metody rozliczania lokaty kapitalowej
                TabelaryczneRozliczenieKredytuStala(KMK, KMn, KMp, KMm, out KMTRL);
                //sformatowanie kontrolki chart
                chtWykresStala.Titles.Add("Raty splaty kredytu");
                //wyzerowanie serii dancyh kontrolki Chart
                chtWykresStala.Series.Clear();
                //dodanie nowej nasze jpierwsze jserii dancyh
                chtWykresStala.Series.Add("Rata");
                chtWykresStala.Series.Add("RataO");
                chtWykresStala.Series.Add("RataK");
                //sformatowanie osi ukladu wspolrzednych wykresu
                chtWykresStala.ChartAreas[0].AxisX.Minimum = -1;
                chtWykresStala.ChartAreas[0].AxisX.Interval = 5;
                chtWykresStala.ChartAreas[0].AxisY.Minimum = 0;
                //ustalenie widocznosci legendy wykresu
                chtWykresStala.Series[0].IsVisibleInLegend = true;
                //lokalizacja legendy
                chtWykresStala.Legends.FindByName("Legend1").Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
                //ustalenie nazwy legendy
                chtWykresStala.Series[0].Name = "Rata laczna (R + Rk + Ro)";
                chtWykresStala.Series[1].Name = "Rata odsetkowa Ro";
                chtWykresStala.Series[2].Name = "Rata kapitalowa Rk";
                //typ wykresu
                chtWykresStala.Series[0].ChartType =
                    //System.Windows.Forms.DataVisualization.Charting.
                    SeriesChartType.Line;
                chtWykresStala.Series[1].ChartType =
                    SeriesChartType.Line;
                chtWykresStala.Series[2].ChartType =
                    SeriesChartType.Line;
                //kolor linii wykresu
                chtWykresStala.Series[0].Color = Color.Red;
                chtWykresStala.Series[1].Color = Color.Blue;
                chtWykresStala.Series[2].Color = Color.Green;
                //ustalenie stylu linii
                chtWykresStala.Series[0].BorderDashStyle =
                   ChartDashStyle.Solid;
                chtWykresStala.Series[1].BorderDashStyle =
                   ChartDashStyle.Dot;
                chtWykresStala.Series[2].BorderDashStyle =
                   ChartDashStyle.DashDotDot;
                //ustalenie grubosci
                chtWykresStala.Series[0].BorderWidth = 5;
                chtWykresStala.Series[1].BorderWidth = 3;
                chtWykresStala.Series[1].BorderWidth = 2;
                //itd
                //dodanie do serii danych [0] danych z rtablicy trl z ostatniej kolumny
                for (int i = 0; i < KMTRL.GetLength(0); i++)
                {
                    chtWykresStala.Series[0].Points.AddXY(i, KMTRL[i, 1] + KMTRL[i, 2]);
                    chtWykresStala.Series[1].Points.AddXY(i, KMTRL[i, 1]);
                    chtWykresStala.Series[2].Points.AddXY(i, KMTRL[i, 2]);
                }
                    //odsloniecie kontrolek graficznej wizualizacji wynikow olbiczen
                chtWykresStala.Visible = true;
                //ustawienie stanu braku aktywnosci dla obslugiwanego przycisku polecen
                btGraficznaPrezentacjaSplatyKredytu.Enabled = false;
            }
            if (KMs == 2)
            {
                chtWykresMalejaco.Visible = true;
                //wywolanie metody rozliczania lokaty kapitalowej
                TabelaryczneRozliczenieKredytuMalejaco(KMK, KMn, KMp, KMm, out KMTRL);

                //sformatowanie kontrolki chart
                chtWykresMalejaco.Titles.Add("Raty splaty kredytu");
                //wyzerowanie serii dancyh kontrolki Chart
                chtWykresMalejaco.Series.Clear();
                //dodanie nowej nasze jpierwsze jserii dancyh
                chtWykresMalejaco.Series.Add("Rata");
                chtWykresMalejaco.Series.Add("RataO");
                chtWykresMalejaco.Series.Add("RataK");
                //sformatowanie osi ukladu wspolrzednych wykresu
                chtWykresMalejaco.ChartAreas[0].AxisX.Minimum = -1;
                chtWykresMalejaco.ChartAreas[0].AxisX.Interval = 5;
                chtWykresMalejaco.ChartAreas[0].AxisY.Minimum = 0;
                //ustalenie widocznosci legendy wykresu
                chtWykresMalejaco.Series[0].IsVisibleInLegend = true;
                //lokalizacja legendy
                chtWykresMalejaco.Legends.FindByName("Legend1").Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
                //ustalenie nazwy legendy
                chtWykresMalejaco.Series[0].Name = "Rata laczna (R + Rk + Ro)";
                chtWykresMalejaco.Series[1].Name = "Rata odsetkowa Ro";
                chtWykresMalejaco.Series[2].Name = "Rata kapitalowa Rk";
                //typ wykresu
                chtWykresMalejaco.Series[0].ChartType =
                    //System.Windows.Forms.DataVisualization.Charting.
                    SeriesChartType.Line;
                chtWykresMalejaco.Series[1].ChartType =
                    SeriesChartType.Line;
                chtWykresMalejaco.Series[2].ChartType =
                    SeriesChartType.Line;
                //kolor linii wykresu
                chtWykresMalejaco.Series[0].Color = Color.Red;
                chtWykresMalejaco.Series[1].Color = Color.Blue;
                chtWykresMalejaco.Series[2].Color = Color.Green;
                //ustalenie stylu linii
                chtWykresMalejaco.Series[0].BorderDashStyle =
                   ChartDashStyle.Solid;
                chtWykresMalejaco.Series[1].BorderDashStyle =
                   ChartDashStyle.Dot;
                chtWykresMalejaco.Series[2].BorderDashStyle =
                   ChartDashStyle.DashDotDot;
                //ustalenie grubosci
                chtWykresMalejaco.Series[0].BorderWidth = 5;
                chtWykresMalejaco.Series[1].BorderWidth = 3;
                chtWykresMalejaco.Series[1].BorderWidth = 2;
                //itd
                //dodanie do serii danych [0] danych z rtablicy trl z ostatniej kolumny
                for (int i = 0; i < KMTRL.GetLength(0); i++)
                {
                    chtWykresMalejaco.Series[0].Points.AddXY(i, KMTRL[i, 2]);
                    chtWykresMalejaco.Series[1].Points.AddXY(i, KMTRL[i, 1]);
                    chtWykresMalejaco.Series[2].Points.AddXY(i, KMTRL[i, 2] - KMTRL[i, 1]);
                }
                //odsloniecie kontrolek graficznej wizualizacji wynikow olbiczen
                chtWykresMalejaco.Visible = true;
                //ustawienie stanu braku aktywnosci dla obslugiwanego przycisku polecen
                btGraficznaPrezentacjaSplatyKredytu.Enabled = false;
            }
            if (KMs == 3)
            {
                chtWykresMalejaco.Visible = true;
                //wywolanie metody rozliczania lokaty kapitalowej
                TabelaryczneRozliczenieKredytuRosnaco(KMK, KMn, KMp, KMm, out KMTRL);

                //sformatowanie kontrolki chart
                chtWykresRosnaco.Titles.Add("Raty splaty kredytu");
                //wyzerowanie serii dancyh kontrolki Chart
                chtWykresRosnaco.Series.Clear();
                //dodanie nowej nasze jpierwsze jserii dancyh
                chtWykresRosnaco.Series.Add("Rata");
                chtWykresRosnaco.Series.Add("RataO");
                chtWykresRosnaco.Series.Add("RataK");
                //sformatowanie osi ukladu wspolrzednych wykresu
                chtWykresRosnaco.ChartAreas[0].AxisX.Minimum = -1;
                chtWykresRosnaco.ChartAreas[0].AxisX.Interval = 5;
                chtWykresRosnaco.ChartAreas[0].AxisY.Minimum = 0;
                //ustalenie widocznosci legendy wykresu
                chtWykresRosnaco.Series[0].IsVisibleInLegend = true;
                //lokalizacja legendy
                chtWykresRosnaco.Legends.FindByName("Legend1").Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Right;
                //ustalenie nazwy legendy
                chtWykresRosnaco.Series[0].Name = "Rata laczna (R + Rk + Ro)";
                chtWykresRosnaco.Series[1].Name = "Rata odsetkowa Ro";
                chtWykresRosnaco.Series[2].Name = "Rata kapitalowa Rk";
                //typ wykresu
                chtWykresRosnaco.Series[0].ChartType =
                    //System.Windows.Forms.DataVisualization.Charting.
                    SeriesChartType.Line;
                chtWykresRosnaco.Series[1].ChartType =
                    SeriesChartType.Line;
                chtWykresRosnaco.Series[2].ChartType =
                    SeriesChartType.Line;
                //kolor linii wykresu
                chtWykresRosnaco.Series[0].Color = Color.Red;
                chtWykresRosnaco.Series[1].Color = Color.Blue;
                chtWykresRosnaco.Series[2].Color = Color.Green;
                //ustalenie stylu linii
                chtWykresRosnaco.Series[0].BorderDashStyle =
                   ChartDashStyle.Solid;
                chtWykresRosnaco.Series[1].BorderDashStyle =
                   ChartDashStyle.Dot;
                chtWykresRosnaco.Series[2].BorderDashStyle =
                   ChartDashStyle.DashDotDot;
                //ustalenie grubosci
                chtWykresRosnaco.Series[0].BorderWidth = 5;
                chtWykresRosnaco.Series[1].BorderWidth = 3;
                chtWykresRosnaco.Series[1].BorderWidth = 2;
                //itd
                //dodanie do serii danych [0] danych z rtablicy trl z ostatniej kolumny
                for (int i = 0; i < KMTRL.GetLength(0); i++)
                {
                    chtWykresRosnaco.Series[0].Points.AddXY(i, KMTRL[i, 2]);
                    chtWykresRosnaco.Series[1].Points.AddXY(i, KMTRL[i, 1]);
                    chtWykresRosnaco.Series[2].Points.AddXY(i, KMTRL[i, 2] - KMTRL[i, 1]);
                }
                //odsloniecie kontrolek graficznej wizualizacji wynikow olbiczen
                chtWykresRosnaco.Visible = true;
                //ustawienie stanu braku aktywnosci dla obslugiwanego przycisku polecen
                btGraficznaPrezentacjaSplatyKredytu.Enabled = false;
            }
        }

        private void zamkniecieformularzaLokatyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult PytanieDoUzytkownikaAplikacji =
    MessageBox.Show("Czy rzeczywiscie chcesz zmaknac ten fomrluarz?"
    , this.Text
    , MessageBoxButtons.YesNoCancel
    , MessageBoxIcon.Question
    , MessageBoxDefaultButton.Button3
    );
            switch (PytanieDoUzytkownikaAplikacji)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Nastapi zamkniecie formularza: " + this.Text);
                    this.Close();
                    break;
                case DialogResult.No:
                    MessageBox.Show("Formularz nie bedzie zamkniety");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Anulowanie zamkniecia formularza:");
                    break;
            }
        }

        private void wyjscieZaplikajciLOkatyOrazKredytyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult PytanieDoUzytkownikaAplikacji =
MessageBox.Show("Czy rzeczywiscie chcesz zmaknac ten fomrluarz?"
, this.Text
, MessageBoxButtons.YesNoCancel
, MessageBoxIcon.Question
, MessageBoxDefaultButton.Button3
);
            switch (PytanieDoUzytkownikaAplikacji)
            {
                case DialogResult.Yes:
                    MessageBox.Show("Nastapi zamkniecie aplikacji: " + this.Text);
                    this.Close();
                    break;
                case DialogResult.No:
                    MessageBox.Show("Aplikacja nie bedzie zakmnieta");
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Anulowanie zamkniecia aplikacji:");
                    break;
            }
        }

        private void zapiszWynikiTabelarycznegoRozliczeniaKredytuWPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            float KMK, KMp;
            ushort KMn, KMm, KMs;
            if (!PobranieDanychWejsciowych(out KMK, out KMn, out KMp, out KMm, out KMs))
                return;
            float[,] KMTRL;
            TabelaryczneRozliczenieKredytuStala(KMK, KMn, KMp, KMm, out KMTRL);
            SaveFileDialog OknoZapisuPliku = new SaveFileDialog();
            OknoZapisuPliku.Filter = "txt files (*.txt)|*.txt|All Files(*.*)|*.*";
            OknoZapisuPliku.FilterIndex = 1;
            OknoZapisuPliku.RestoreDirectory = true;
            OknoZapisuPliku.InitialDirectory = "C:\\";
            OknoZapisuPliku.Title = "Zapisanie wynikow obliczen";
            if (OknoZapisuPliku.ShowDialog() == DialogResult.OK)
            {
                StreamWriter PlikZnakowy = new StreamWriter(OknoZapisuPliku.OpenFile());
                for (int i = 0; i < KMTRL.GetLength(0); i++)
                {
                    PlikZnakowy.Write(string.Format(" {0,4} \t", i));
                    PlikZnakowy.Write(string.Format(" {0,8:0.000} \t", KMTRL[i, 0]));
                    PlikZnakowy.Write(string.Format(" {0,6:0.00} \t", KMTRL[i, 1]));
                    PlikZnakowy.Write(string.Format(" {0,8:0.000} \t", KMTRL[i, 2]));
                    PlikZnakowy.WriteLine("\t");

                    PlikZnakowy.Dispose();
                    PlikZnakowy.Close();
                }

            }
        }

        private void pobierzZPlikuZapisaneTamWynikiTabelarycznegoRozliczeniaKredytuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dgvTabelaRozliczeniaKredytu.Rows.Clear();
            OpenFileDialog OknoOdczytuPliku = new OpenFileDialog();
            OknoOdczytuPliku.Title = "Otwarcie pliku z rozliczeniem lokaty kapitalowej";
            if (OknoOdczytuPliku.ShowDialog() == DialogResult.OK)
            {
                string NazwaPliku = OknoOdczytuPliku.FileName;
                string[] ZawartoscPliku = File.ReadAllLines(NazwaPliku);
                dgvTabelaRozliczeniaKredytu.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                foreach (string WierszDanych in ZawartoscPliku)
                    dgvTabelaRozliczeniaKredytu.Rows.Add(WierszDanych.Split('\t'));
                dgvTabelaRozliczeniaKredytu.Visible = true;
                dgvTabelaRozliczeniaKredytu.Visible = true;
            }
        }

        private void formularzSprawdzianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form Formularz in Application.OpenForms)
            {
                if (Formularz.Name == "KMsprawdzianSystematyczneOszczedzanie")
                {
                    this.Hide();
                    Formularz.Show();
                    return;

                }
                KMsprawdzianSystematyczneOszczedzanie FormularzKMsprawdzianSystematyczneOszczedzanie = new KMsprawdzianSystematyczneOszczedzanie();
                this.Hide();
                FormularzKMsprawdzianSystematyczneOszczedzanie.Show();
                return;
            }
        }
    }
}
