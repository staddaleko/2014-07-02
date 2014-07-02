using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kontakty2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'biblioteka.Autorzy' table. You can move, or remove it, as needed.
            this.autorzyTableAdapter.Fill(this.biblioteka.Autorzy);

        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            //autorzyTableAdapter.Update(biblioteka.Autorzy);//metoda 'update' jest niejako iteratorem. Sprawdza po kolei wpisy. Jezeli wiersz nie jest modyfikowany to przechodzi do nastepnego. Działa po kolei, dokładnie tak jakby było robione ręcznie. W razie zmian, odpowiednio je podaje (delete, modify, etc.). Na zakończenie robi coś takiego jak 'accept change' i zatwierdza wszystkie dane jako 'oryginalne'.

            try
            {
                autorzyTableAdapter.Update(biblioteka.Autorzy);
            }
            catch (Exception ex)
            {
                biblioteka.Autorzy.RejectChanges();
                
            }
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
            MessageBox.Show("You made a BIG mistake, bro...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KsiazkiWgKategorii dlg = new KsiazkiWgKategorii();
            dlg.Show(this);
        }
    }
}
