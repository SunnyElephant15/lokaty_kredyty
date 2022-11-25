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

namespace LokatyOrazKredyty_Małek
{
    public partial class KMsprawdzianSystematyczneOszczedzanie : Form
    {
        public KMsprawdzianSystematyczneOszczedzanie()
        {
            InitializeComponent();
        } 

        bool PobranieDanychWejsciowych(out float KMK, out ushort KMn, out float KMp, out ushort KMm, out ushort KMR)
        {//przypisanie wartosci dla przypadku koniecnzosci przerwania pobierania danych
            KMK = 0.0F; KMn = 0; KMp = 0.0F; KMm = 0; KMR = 0;
            //pobranie wysokosci lokaty kapitalowej k
            //1) sprawdzenie czy wpisala zostala kwota k
            if (string.IsNullOrEmpty(txtK.Text))
            {//jest blad to go sygnalizujemy i przerywamy dalsze powielanie danych
                errorProvider1.SetError(txtK, "ERROR: Musisz podac wysokosc lokaty K");
                return false;

            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();

            //konwersja znakowego napisu kwoty k na wartosc
            if (!float.TryParse(txtK.Text, out KMK))
            {//jest blad to go sygnalizujemy i przerywamy dalsze powielanie danych
                errorProvider1.SetError(txtK, "ERROR: wystapil mniedozwolony znak w zapisie wysokosci lokaty");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //sprawdzenie warunku wejsciowego k >= 100
            if (KMK < 100.0F)
            {//jest blad to go sygnalizujemy i przerywamy dalsze powielanie danych
                errorProvider1.SetError(txtK, "ERROR: minimalna kwota k: k >= 100");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //pobranie liczby lat lokaty
            if (string.IsNullOrEmpty(txtN.Text))
            {//jest blad to go sygnalizujemy i przerywamy dalsze powielanie danych
                errorProvider1.SetError(txtN, "ERROR: musiz podac liczbe lat lokaty");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //konwersja na wartosc
            if (!ushort.TryParse(txtN.Text, out KMn))
            {//jest blad to go sygnalizujemy i przerywamy dalsze powielanie danych
                errorProvider1.SetError(txtN, "ERROR: w zapisie liczby lat lokaty wystapil niedozwolony znak");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //sprzawdzenie warunku wejsciowego: n > 0
            if (KMn <= 0)
            {//jest blad to go sygnalizujemy i przerywamy dalsze powielanie danych
                errorProvider1.SetError(txtN, "ERROR: liczba lat lokaty musi spelniac warunek: k > 0");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //pobranie rocznej stopy procentowej
            //sprawdzenie czy zostala wybrana przez uzytkownika aplikacji
            if (cmbStoparoczna.SelectedIndex < 0)
            {//jest blad to go sygnalizujemy i przerywamy dalsze powielanie danych
                errorProvider1.SetError(cmbStoparoczna, "ERROR: musisz wybrac roczna stope procentowa");
                return false;
            }
            else
                //zgaszenie kontrolki errorProvider
                errorProvider1.Dispose();
            //pobranie stopy procentowej
            string StopaProcentowa = cmbStoparoczna.SelectedItem.ToString();
            StopaProcentowa = StopaProcentowa.Trim();
            //wyciecie znaku miana %
            StopaProcentowa = StopaProcentowa.Substring(0, StopaProcentowa.Length - 1);
            //konwersja na wartosc 
            if (!float.TryParse(StopaProcentowa, out KMp))
            {//jest blad to go sygnalizujemy i przerywamy dalsze powielanie danych
                errorProvider1.SetError(cmbStoparoczna, "ERROR: wystapil niedozwolony znak w zapiesie wybranej stopy procentwej");
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
                errorProvider1.SetError(cmbStoparoczna, "ERROR: wartosc rocznej stopy procentowerj musi nalezec do przedzialu 0.0 , 1.0");
                return false;
            }
            else
                errorProvider1.Dispose();
            //konwersja znakowego napisu kwoty k na wartosc
        /*   if (!float.TryParse(KMtxtR.Text, out KMr))
            {//jest blad to go sygnalizujemy i przerywamy dalsze powielanie danych
                errorProvider1.SetError(txtK, "ERROR: wystapil mniedozwolony znak w zapisie wysokosci lokaty");
                return false;
            }
            else errorProvider1.Dispose();
            */
            //pobranie czestosci kapitalizacji odsetek m
            if (rdbrazwroku.Checked)
                KMm = 1;
            else if (rdbcopolroku.Checked)
                KMm = 2;
            else if (rdbcokwartal.Checked)
                KMm = 4;
            else if (rdbcomiesiac.Checked)
                KMm = 12;
            else
                KMm = 1;  //domyslnie

            if (KMrdbPoczatek.Checked)
                KMR = 1;
            else if (KMrdbKoniec.Checked)
                KMR = 2;

            
            return true;
        }

        private void txtK_TextChanged(object sender, EventArgs e)
        {

        }

        private void TabelaryczneRolziczenieLokatyKapitalowej(float KMK, ushort KMn, float KMp, ushort KMm, ushort KMR, out float[,] KMTRL)
        {
            //utworzenie egzemplarza tablicy TRL
            KMTRL = new float[KMn * KMm + 1, 3];
            if (KMR == 1)
            {
                //wypelnienie pierwszego wiersza TRL dla tzw okresu zerowego 
                KMTRL[0, 0] = 0.0F;
                KMTRL[0, 1] = 0.0F;
                KMTRL[0, 2] = KMK;
                //wypelnienie (wyznaczenie rozliczenia lokaty) tablicy TRL
                for (int i = 1; i < KMTRL.GetLength(0); i++)
                {
                    KMTRL[i, 0] = KMTRL[i - 1, 2]; //stan na poczatku okresu lokaty
                    KMTRL[i, 1] = KMTRL[i, 0] * KMp / KMm; //odsetki za ity okres lokaty
                    KMTRL[i, 2] = KMTRL[i, 0] + KMTRL[i, 1] + KMR; //stan na koncu okresu lokaty 
                }
            }
            else if (KMR == 2)
            {
                //wypelnienie pierwszego wiersza TRL dla tzw okresu zerowego 
                KMTRL[0, 0] = 0.0F;
                KMTRL[0, 1] = 0.0F;
                KMTRL[0, 2] = KMK;
                //wypelnienie (wyznaczenie rozliczenia lokaty) tablicy TRL
                for (int i = 1; i < KMTRL.GetLength(0); i++)
                {
                    KMTRL[i, 0] = KMTRL[i - 1, 2]; //stan na poczatku okresu lokaty
                    KMTRL[i, 1] = KMTRL[i, 0] * KMp / KMm; //odsetki za ity okres lokaty
                    KMTRL[i, 2] = KMTRL[i, 0] + KMTRL[i, 1] + KMR; //stan na koncu okresu lokaty 
                }

            }
        }

        private void btnObliczStanKonta_Click(object sender, EventArgs e)
        {
            float KMK, KMp;
            ushort KMn, KMm, KMR; //tlyko dodatnie
            //wywolanie metody dla pobrania danych wejsciowych
            if (!PobranieDanychWejsciowych(out KMK, out KMn, out KMp, out KMm, out KMR))
                return; //przerwanie obslugi zdarzenia _Click
            //obliczenie wartosci przyszlej
            float KMknm = KMK * (float)Math.Pow(1 + KMp / KMm, KMn * KMm);
            //wizulaizacja wyniku obliczen
            txtWynikKNM.Text = string.Format("{0:0.00}", KMknm);
            //odslonic kontrolki dla wizualizacji wyniku
            lblWynikKNM.Visible = true;
            txtWynikKNM.Visible = true;
            //ustawienie stanu braku aktywnosci dla obslugiwanego przycisku polecen
            txtK.Enabled = false;
            txtN.Enabled = false;
            cmbStoparoczna.Enabled = false;
            gpczestosckapitalizacjiodsetek.Enabled = false;
            txtWynikKNM.Enabled = false;
            btnObliczStanKonta.Enabled = false;
        }

        private void btnRozliczLokate_Click(object sender, EventArgs e)
        {
            //deklaracja zmiennych dla przechowania pobranych dancyh wejsciowych z kontrolek formularza\
            float KMK, KMp;
            ushort KMn, KMm, KMR;
            //pobranie danych wejsciowych
            if (!PobranieDanychWejsciowych(out KMK, out KMn, out KMp, out KMm, out KMR))
                return; //czyli przerwanie obslugi przycisku gdyz byl blad w trakcie ich pobierania
            //gdy jestesmy tutaj to nie bylo bledu w pobieraniu danych wejsciowych
            //deklaracja zmiennej referencyjnej do egzemplarza tablicy rozliczenia lokaty
            float[,] KMTRL;
            // wywolanie metody rozliczenia lokaty kapitalowej
            TabelaryczneRolziczenieLokatyKapitalowej(KMK, KMn, KMp, KMm, KMR, out KMTRL);
            // przepisanie danych z tablicy TRL do kontrolki DataGridView
            //dgvTabelaRozliczeniaLokaty.Rows.Clear(); //wyzerowanie kolekcji dantch kontrolki jakiejstam
            for (int i = 0; i < KMTRL.GetLength(0); i++)
            {//dodanie nowego wiersza do kontrolki datagridview
                dgvTabelaRozliczeniaLokaty.Rows.Add();
                //wpisanie danych do poszczegolnych komorek (kolumn) wiersza
                dgvTabelaRozliczeniaLokaty.Rows[i].Cells[0].Value = i; //numer okresu
                dgvTabelaRozliczeniaLokaty.Rows[i].Cells[1].Value =
                    string.Format("{0:0.000}", KMTRL[i, 0]); //stan konta na poczatku itego okresu
                dgvTabelaRozliczeniaLokaty.Rows[i].Cells[2].Value =
                 string.Format("{0:0.000}", KMTRL[i, 1]); //odsetki za ity okres lokaty
                dgvTabelaRozliczeniaLokaty.Rows[i].Cells[3].Value =
                 string.Format("{0:0.000}", KMTRL[i, 2]); //stan konta na koniec itego okresu lokaty
                //naprzemienna zmiana koloru tla wiersza danych kontrolki datagridview
                if (i % 2 == 0)

                    dgvTabelaRozliczeniaLokaty.Rows[i].DefaultCellStyle.BackColor = Color.LightGray;
                else
                    dgvTabelaRozliczeniaLokaty.Rows[i].DefaultCellStyle.BackColor = Color.White;

            }
            //ustawienie centrowania zapisu danych w kolumnach kontrolki DataGridView
            dgvTabelaRozliczeniaLokaty.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //odsloniecie kontrolki DataGridView
            dgvTabelaRozliczeniaLokaty.Visible = true;

            // ukrycie innych kontrolek z czesci centalnej formularza 

            chtWykres.Visible = false;
            //stawianie stanu braku aktywnosci obslugiwanego przycisku polecen
            btnRozliczLokate.Enabled = false;
        }

        private void btnUtworzWykres_Click(object sender, EventArgs e)
        {
            //deklaracja zmiennych
            float KMK, KMp;
            ushort KMn, KMm, KMR;
            if (!PobranieDanychWejsciowych(out KMK, out KMn, out KMp, out KMm, out KMR))
                return;

            float[,] KMTRL;
            //wywolanie metody rozliczania lokaty kapitalowej
            TabelaryczneRolziczenieLokatyKapitalowej(KMK, KMn, KMp, KMm, KMR, out KMTRL);

            //sformatowanie kontrolki chart
            chtWykres.Titles.Add("wykres zmiany stanu konta w okresie lokaty");
            //wyzerowanie serii dancyh kontrolki Chart
            chtWykres.Series.Clear();
            //dodanie nowej nasze jpierwsze jserii dancyh
            chtWykres.Series.Add("Stan konta Knm na koniec kazdego okresu");
            //sformatowanie osi ukladu wspolrzednych wykresu
            chtWykres.ChartAreas[0].AxisX.Title = "Okresy lokaty";
            chtWykres.ChartAreas[0].AxisX.Minimum = 0;
            chtWykres.ChartAreas[0].AxisX.Interval = 2;
            chtWykres.ChartAreas[0].AxisY.Title = "Wysokosc stanu konta";
            chtWykres.ChartAreas[0].AxisY.Minimum = 0;
            //ustalenie widocznosci legendy wykresu
            chtWykres.Series[0].IsVisibleInLegend = true;
            //lokalizacja legendy
            chtWykres.Legends.FindByName("Legend1").Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            //ustalenie nazwy legendy
            chtWykres.Series[0].Name = "Wykres zmiany stanu konta";
            //typ wykresu
            chtWykres.Series[0].ChartType =
                //System.Windows.Forms.DataVisualization.Charting.
                SeriesChartType.Line;
            //kolor linii wykresu
            chtWykres.Series[0].Color = Color.Red;
            //ustalenie stylu linii
            chtWykres.Series[0].BorderDashStyle =
               //System.Windows.Forms.DataVisualization.Charting.
               ChartDashStyle.Dot;
            //ustalenie grubosci
            chtWykres.Series[0].BorderWidth = 2;
            //itd
            //dodanie do serii danych [0] danych z rtablicy trl z ostatniej kolumny
            for (int i = 0; i < KMTRL.GetLength(0); i++)
                chtWykres.Series[0].Points.AddXY(i, KMTRL[i, 2]);
            //odsloniecie kontrolek graficznej wizualizacji wynikow olbiczen
            chtWykres.Visible = true;
            //ukrycie pozostalych kontrolek z czesci centralnej formularza

            dgvTabelaRozliczeniaLokaty.Visible = false;
            //ustawienie stanu braku aktywnosci dla obslugiwanego przycisku polecen
            btnUtworzWykres.Enabled = false;



        }
    }


}
