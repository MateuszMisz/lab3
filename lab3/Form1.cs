using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace lab3
{
    public partial class Form1 : Form
    {
        public BindingSource bindingSource1 = new BindingSource();
        public int lastID;

        public Form1()
        {
            InitializeComponent();
            // Utw�rz dane do siatki
            var dataTable = new System.Data.DataTable();
            dataTable.Columns.Add("ID", typeof(int));
            dataTable.Columns.Add("Imie", typeof(string));
            dataTable.Columns.Add("Nazwisko", typeof(string));
            dataTable.Columns.Add("Wiek", typeof(int));
            dataTable.Columns.Add("Stanowisko", typeof(string));


            
            lastID = 0;
            // Po��cz dane z BindingSource
            bindingSource1.DataSource = dataTable;
            // Inicjalizacja DataGridView
            //dataGridView1.Dock = DockStyle.Fill;
            // Przypisz DataGridView do BindingSource

            dataGridView1.DataSource = bindingSource1;
            // Dodaj DataGridView do formularza
            Controls.Add(dataGridView1);
        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            Form2 form2=new Form2(this);
            form2.Show();
        }

        private void usun_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
        }

        

       
        private void zapis_do_csv_Click(object sender, EventArgs e)
        {
            // Wy�wietlanie okna dialogowego wyboru lokalizacji zapisu
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            saveFileDialog1.Title = "Wybierz lokalizacj� zapisu pliku CSV";
            saveFileDialog1.ShowDialog();
            // Je�li u�ytkownik wybierze lokalizacj� i zatwierdzi, zapisz plik CSV
            if (saveFileDialog1.FileName != "")
            {
                // U�yj metody ExportToCSV i podaj obiekt DataGridView oraz �cie�k� do pliku CSV
                ExportToCSV(dataGridView1, saveFileDialog1.FileName);
            }
        }
        private void ExportToCSV(DataGridView dataGridView, string filePath)
        {
            // Tworzenie nag��wka pliku CSV
            string csvContent = "ID,Imie,Nazwisko,Wiek,Stanowisko" + Environment.NewLine;
            // Dodawanie danych z DataGridView
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                // Pomijaj wiersze niemieszcz�ce si� w DataGridView (np. wiersz zaznaczania)
                if (!row.IsNewRow)
                {
                    // Dodaj kolejne warto�ci w wierszu, oddzielone przecinkami
                    csvContent += string.Join(",", Array.ConvertAll(row.Cells.Cast<DataGridViewCell>()
                    .ToArray(), c => c.Value)) + Environment.NewLine;
                }
            }
            // Zapisanie zawarto�ci do pliku CSV
            File.WriteAllText(filePath, csvContent);
        }
        private void LoadCSVToDataGridView(string filePath)
        {
            // Sprawd�, czy plik istnieje
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Plik CSV nie istnieje.", "B��d", MessageBoxButtons.OK, MessageBoxIcon.Error); return;
            }
            // Odczytaj zawarto�� pliku CSV
            string[] lines = File.ReadAllLines(filePath);
            // Tworzenie tabeli danych
            DataTable dataTable = new DataTable();
            // Dodanie kolumn na podstawie nag��wka
            string[] headers = lines[0].Split(',');
            foreach (string header in headers)
            {
                dataTable.Columns.Add(header);
            }
            // Dodawanie wierszy do tabeli danych
            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');
                dataTable.Rows.Add(values);
            }
            // Przypisanie tabeli danych do DataGridView
            bindingSource1.DataSource = dataTable;
            dataGridView1.DataSource = bindingSource1;
        }
        private void odczyt_z_csv_Click(object sender, EventArgs e)
        {
            // Wy�wietlenie okna dialogowego wyboru pliku CSV
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Pliki CSV (*.csv)|*.csv|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.Title = "Wybierz plik CSV do wczytania";
            openFileDialog1.ShowDialog();
            // Je�li u�ytkownik wybierze plik i zatwierdzi, wczytaj dane z pliku CSV
            if (openFileDialog1.FileName != "")
            {
                // Wywo�anie funkcji wczytuj�cej dane z pliku CSV
                LoadCSVToDataGridView(openFileDialog1.FileName);
            }
        }
    }

}
