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
    public partial class frmCours : Form
    {
        public frmCours()
        {
            InitializeComponent();
        }
        DataTable tabCours;
        int pos;
        private void frmCours_Load(object sender, EventArgs e)
        {            // gridResult.DataSource = clsGlobal.mySet.Tables["Cours"];
            selectNum(1);
            selectTitre(1);
            selectProfesseur(1);
            selectDuree(1);

        }

        private void gridResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*SqlConnection mycon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=teccartDBSql;Integrated Security=True");
            mycon.Open();

            SqlCommand mycmd = new SqlCommand("SELECT * FROM Etudiants", mycon);
            SqlDataReader myRder = mycmd.ExecuteReader();
            DataTable temp = new DataTable();
            temp.Load(myRder);
            gridResult.DataSource = temp;

            mycon.Close();*/
        }

        private void AfficherTout()
        {

            
        }

        private void gridResult_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPremier_Click(object sender, EventArgs e)
        {
            selectNum(0);
            selectTitre(0);
            selectProfesseur(0);
            selectDuree(0);
        }

        private String selectNum(int i)
        {
            tabCours = clsGlobal.mySet.Tables["Cours"];
            return txtNumero.Text = tabCours.Rows[i]["Numero"].ToString();        
        }

        private string selectTitre(int i)
        {
            return txtTitre.Text = tabCours.Rows[i]["Titre"].ToString();   
        }

        private string selectProfesseur(int i)
        {
            return txtProfesseur.Text = tabCours.Rows[i]["Professeur"].ToString();
        }

        private string selectDuree (int i)
        {
            return txtDuree.Text = tabCours.Rows[i]["Duree"].ToString();
        }

        private int Rechercher( string n)
        {
            int i;
            for (i = 0; i < tabCours.Rows.Count; i++)
            {
                if (tabCours.Rows[i][0].ToString() == n)
                {
                    pos = i;
                    break;
                }
            }
            return pos;

        }
        
        private void Afficher()
        {
            

        }

        private void btnDernier_Click(object sender, EventArgs e)
        {
            int i = tabCours.Rows.Count - 1;       
                selectNum(i);
                selectTitre(i);
                selectProfesseur(i);
                selectDuree(i);  
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            int p = Rechercher(txtNumero.Text);
            if (p > 0)
            {
                selectNum(p-1);
                selectTitre(p-1);
                selectProfesseur(p-1);
                selectDuree(p-1);
            }
            else
            {
                MessageBox.Show("Premier element dja affiché");
            }


        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            int p = Rechercher(txtNumero.Text);
            if (p >= 0)
            {
                selectNum(p + 1);
                selectTitre(p + 1);
                selectProfesseur(p + 1);
                selectDuree(p + 1);
            }
            
            else
            {
                MessageBox.Show("dernier element dja affiché");
            }
        }
    }
}
