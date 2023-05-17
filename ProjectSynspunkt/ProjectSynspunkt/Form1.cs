using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectSynspunkt
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection
    ("Data Source=mssql4.unoeuro.com;Initial Catalog=nicklaskruse_dk_db_webdatabase;Persist Security Info=True;User ID=nicklaskruse_dk;Password=9h3fyebHtkF4aApwmGxB");
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Fylder det første datagridview med varetabellen fra vores database.
            LoadDataGridViewKunde();
            
             
            //this.synsPunktVarerTableAdapter.Fill(this.nicklaskruse_dk_db_webdatabaseDataSet.SynsPunktVarer);
            //this.synsPunktKunderTableAdapter.Fill(this.nicklaskruse_dk_db_webdatabaseDataSet.SynsPunktKunder);

        }
        private void CrudInsertVare()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into SynsPunktVarer values ('" + int.Parse(tb_varenummer.Text) + "', '" + tb_varenavn.Text + "', '" + tb_antal.Text + "', '" + tb_salgspris.Text + "', '" + tb_varetype.Text + "'");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data indsat");
            con.Close();
        }
        private void CrudUpdateVare()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update SynsPunktVarer set vareNr = '" + int.Parse(tb_varenummer.Text) + "',vareNavn = '" + tb_varenavn.Text + "',antal = '" + tb_antal.Text + "',salgsPris = '" + decimal.Parse(tb_salgsPris.Text) + "',vareType = '" + tb_varetype.Text + "'");
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data Opdateret");
            con.Close();
        }
        private void CrudDeleteVare()
        {
            if (tb_varenummer.Text != "")
                if (MessageBox.Show("Er du sikker på at du vil slette?", "Slet Data", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Delete SynsPunktVarer where vareNr = '" + int.Parse(tb_varenummer.Text) + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data slettet");
                    con.Close();
            } 
            else
            {
                MessageBox.Show("Du vælger hvad du vil slette, ved at indtaste varenummer: ");
            }
        }
        void LoadDataGridViewVare()
        {
            SqlCommand cmd = new SqlCommand("select * from SynsPunktVarer", con);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
        void LoadDataGridViewKunde()
        {
            // Fyld andet datagridview med kundetabellen.
            /*SqlCommand cmd2 = new SqlCommand("select * from SynsPunktKunder", con);
            SqlDataAdapter sqlDataAdapter2 = new SqlDataAdapter(cmd);
            DataTable dataTable2 = new DataTable();
            sqlDataAdapter.Fill(dataTable2);
            dataGridView2.DataSource = dataTable2;*/
        }
    }
}
