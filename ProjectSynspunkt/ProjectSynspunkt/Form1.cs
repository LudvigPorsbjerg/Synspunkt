using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSynspunkt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nicklaskruse_dk_db_webdatabaseDataSet.SynsPunktVarer' table. You can move, or remove it, as needed.
            this.synsPunktVarerTableAdapter.Fill(this.nicklaskruse_dk_db_webdatabaseDataSet.SynsPunktVarer);
            // TODO: This line of code loads data into the 'nicklaskruse_dk_db_webdatabaseDataSet.SynsPunktKunder' table. You can move, or remove it, as needed.
            this.synsPunktKunderTableAdapter.Fill(this.nicklaskruse_dk_db_webdatabaseDataSet.SynsPunktKunder);
            // TODO: This line of code loads data into the 'nicklaskruse_dk_db_webdatabaseDataSet.SynsPunktVarer' table. You can move, or remove it, as needed.
            this.synsPunktVarerTableAdapter.Fill(this.nicklaskruse_dk_db_webdatabaseDataSet.SynsPunktVarer);
            // TODO: This line of code loads data into the 'nicklaskruse_dk_db_webdatabaseDataSet.SynsPunktKunder' table. You can move, or remove it, as needed.
            this.synsPunktKunderTableAdapter.Fill(this.nicklaskruse_dk_db_webdatabaseDataSet.SynsPunktKunder);

        }
    }
}