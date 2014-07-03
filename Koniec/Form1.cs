using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Koniec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            kategorieTableAdapter1.Fill(ksiazkiDataSet1.Kategorie);
            ksiazkiTableAdapter1.Fill(ksiazkiDataSet1.Ksiazki);

            //var kat = from k in ksiazkiDataSet1.Kategorie select k;

            //comboBox1.DataSource = ksiazkiDataSet1.Kategorie;
            //comboBox1.DisplayMember = "Kategoria";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void combobox1_Format(object sender, ListControlConvertEventArgs e)
        {
            DataRowView rv = (DataRowView)e.ListItem;
            KsiazkiDataSet.KategorieRow r = (KsiazkiDataSet.KategorieRow)rv.Row;
            e.Value = r.Kategoria;
        }
    }
}
