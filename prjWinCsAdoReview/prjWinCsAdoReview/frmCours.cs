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
//librairie de duider
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
        Int32 posCourante;
        
        private void frmCours_Load(object sender, EventArgs e)
        {
            tabCours = clsGlobal.mySet.Tables["Cours"];
            posCourante = 0;
            TableVersTxtbox(posCourante);

            ActiverBoutons(true, false, true);
        }

        private void TableVersTxtbox(Int32 pos)
        {
            txtNumero.Text = tabCours.Rows[pos]["Numero"].ToString();
            txtTitre.Text = tabCours.Rows[pos]["Titre"].ToString();
            txtProfesseur.Text = tabCours.Rows[pos]["Professeur"].ToString();
            txtDuree.Text = tabCours.Rows[pos]["Duree"].ToString();
            lblInfo.Text = "Cours" + (posCourante + 1) + " sur un total de " + tabCours.Rows.Count;
        }

        private void btnSuivant_Click(object sender, EventArgs e)
        {
            if (posCourante <(tabCours.Rows.Count-1))
            {
                posCourante++;
                TableVersTxtbox(posCourante);
            }           

        }
        private void btnPremier_Click(object sender, EventArgs e)
        {
            posCourante = 0;
            TableVersTxtbox(posCourante);
        }  

        private void btnDernier_Click(object sender, EventArgs e)
        {
            posCourante = tabCours.Rows.Count - 1;
            TableVersTxtbox(posCourante);
        }

        private void btnPrecedent_Click(object sender, EventArgs e)
        {
            if (posCourante > 0)
            {
                posCourante--;
                TableVersTxtbox(posCourante);
            }
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            txtNumero.Text = txtDuree.Text = txtProfesseur.Text = txtTitre.Text = "";
            txtNumero.Focus();
            lblInfo.Text = "EN MODE AJOUT";

            ActiverBoutons(false, true, false);
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            txtNumero.Text = txtDuree.Text = txtProfesseur.Text = txtTitre.Text = "";
            txtNumero.Focus();
            lblInfo.Text = "EN MODE MODIFICATION";

            ActiverBoutons(false, true, false);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            txtNumero.Text = txtDuree.Text = txtProfesseur.Text = txtTitre.Text = "";
            txtNumero.Focus();
            lblInfo.Text = "EN MODE SUPPRESSION";

            ActiverBoutons(false, true, false);
        }

        private void ActiverBoutons(bool AjModSup, bool SavAnn, bool Navig)
        {
            btnModifier.Enabled = btnAnnuler.Enabled = btnSupprimer.Enabled = btnAjouter.Enabled = AjModSup;
            btnSauvegarder.Enabled = btnAnnuler.Enabled = SavAnn;
            btnPremier.Enabled = btnPrecedent.Enabled = btnDernier.Enabled = btnSuivant.Enabled = Navig;
        }

        private void btnSauvegarder_Click(object sender, EventArgs e)
        {
            string num = txtNumero.Text;
            string titre = txtTitre.Text;
            string prof = txtProfesseur.Text;
            Int32 dur = Convert.ToInt32(txtDuree.Text);

            //creation d'un nouveau enregistrement
            DataRow myrow = tabCours.NewRow();
            myrow["Numero"] = num;
            myrow["Titre"] = titre;
            myrow["Professeur"] = prof;
            myrow["Duree"] = dur;

            tabCours.Rows.Add(myrow);

            //pour sauvegarder  ou syncroniser le dataset et la base de données    
            ActiverBoutons(true, false, true);
            posCourante = tabCours.Rows.Count - 1;
            TableVersTxtbox(posCourante);
           
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
    }
}
