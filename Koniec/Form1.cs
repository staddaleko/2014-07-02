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

            comboBox1.DataSource = ksiazkiDataSet1.Kategorie;
            comboBox1
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
