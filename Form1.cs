using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursach_V3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cD_and_DVD_V2DataSet.Sclad". При необходимости она может быть перемещена или удалена.
            this.scladTableAdapter.Fill(this.cD_and_DVD_V2DataSet.Sclad);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cD_and_DVD_V2DataSet.Prodavec". При необходимости она может быть перемещена или удалена.
            this.prodavecTableAdapter.Fill(this.cD_and_DVD_V2DataSet.Prodavec);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "cD_and_DVD_V2DataSet.Prodasha". При необходимости она может быть перемещена или удалена.
            this.prodashaTableAdapter.Fill(this.cD_and_DVD_V2DataSet.Prodasha);

        }
    }
}
