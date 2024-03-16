using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3
{
    public partial class Form2 : Form
    {
        private Form1 form1;

        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form1 form1)
        {
            this.form1 = form1;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(this.Controls.OfType<TextBox>().All(textBox => string.IsNullOrEmpty(textBox.Text)))
                {
                MessageBox.Show("nie mozna dodac pustego rekordu", "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            //DataGridViewRow row = new();
            //row.CreateCells((DataGridView) form1.bindingSource1.DataSource,++form1.lastID, textBox1.Text, textBox2.Text, int.Parse(textBox3.Text), textBox4.Text);
            //form1.bindingSource1.Add(row);
            //this.Close();
            // Dodaj nowy obiekt do BindingSource
            form1.bindingSource1.AddNew();
            // Pobierz nowy dodany obiekt
            var newRow = (DataRowView)form1.bindingSource1.Current;
            // Ustaw wartości właściwości nowego wiersza
            newRow["ID"] = ++form1.lastID;
            newRow["Imie"] = textBox1.Text;
            newRow["Nazwisko"] = textBox2.Text;
            // Przyjmując, że "textBox3.Text" zawiera wartość typu int
            int parsedValue;
            if (int.TryParse(textBox3.Text, out parsedValue))
            {
                newRow["Wiek"] = parsedValue;
            }
            else
            {
                newRow["Wiek"] = -1;
            }
            newRow["Stanowisko"] = textBox4.Text;
            // Zatwierdź zmiany
            form1.bindingSource1.EndEdit();

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
