using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace prjWinCsAdoReview
{
    public partial class frmRecherche : Form
    {
        public frmRecherche()
        {
            InitializeComponent();
        }

        SqlConnection mycon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=teccartDBSql;Integrated Security=True");


        private void gridResultat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            mycon.Open();

            AfficherTout();
            RemplireCours();
            RemplirMoyennes();

            mycon.Close();
        }

        private void RemplirMoyennes()
        {
            SqlCommand mycmd = new SqlCommand("SELECT DISTINCT Moyennes FROM Etudiants", mycon);
            SqlDataReader myReader = mycmd.ExecuteReader();

            cboMoyennes.DisplayMember = "Moyenne";

            DataTable tmp = new DataTable();
            tmp.Load(myReader);
            gridResultat.DataSource = tmp;
            cboMoyennes.DataSource = tmp;
        }

        private void RemplireCours()
        {
            SqlCommand mycmd = new SqlCommand("SELECT RefCours,Numero FROM Cours", mycon);
            SqlDataReader myReader = mycmd.ExecuteReader();

            cboCours.DisplayMember = "Numero";
            cboCours.ValueMember = "RefCours";

            DataTable tmp = new DataTable();
            tmp.Load(myReader);
            gridResultat.DataSource = tmp;
            cboCours.DataSource = tmp;
            
        }

        private void AfficherTout()
        {
            
            SqlCommand mycmd = new SqlCommand("SELECT * FROM Etudiants", mycon);
            SqlDataReader myReader = mycmd.ExecuteReader();
            DataTable temp = new DataTable();
            temp.Load(myReader);
            gridResultat.DataSource = temp;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTrouver_Click(object sender, EventArgs e)
        {
            mycon.Open();
            SqlCommand mycmd = new SqlCommand("SELECT RefCours,Numero FROM Cours", mycon);
            
            SqlDataReader myReader = mycmd.ExecuteReader();

            string sql = "SELECT * FROM Etudiants";
            Int32 refC = Convert.ToInt32(cboCours.SelectedValue.ToString());
            Single moy = Convert.ToSingle(cboMoyennes.Text.ToString());


            if (chkCours.Checked == true && chkMoyenne.Checked == false)
            {
                sql = "SELECT * FROM Etudiants WHERE RefCours = " + refC;
            }
            else if (chkCours.Checked == false && chkMoyenne.Checked == true)
            {
                sql = "SELECT * FROM Etudiants WHERE Moyenne >= " + moy;
            }
            else if (chkCours.Checked == true && chkMoyenne.Checked == true)
            {
                sql = "SELECT * FROM Etudiants WHERE RefCours = " + refC + "AND Moyenne >=" + moy;
            }
            else
            {
                chkCours.Text = "rien";
            }
            ExecuterRequete(sql);
            mycon.Close();
            
        }
        private void ExecuterRequete(string requete) 
        {
            SqlCommand mycmd = new SqlCommand(requete, mycon);
            SqlDataReader myReader = mycmd.ExecuteReader();
            DataTable temp = new DataTable();
            temp.Load(myReader);
            gridResultat.DataSource = temp;
        }
    }

    
}
