using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//
using System.Data.SqlClient;

namespace prjWinCsAdoReview
{
    public partial class frmPrincipale : Form
    {
        public frmPrincipale()
        {
            InitializeComponent();
        }

        private void mnuCours_Click(object sender, EventArgs e)
        {
            frmCours fc = new frmCours();
            fc.MdiParent = this;
            fc.Show();

        }

        private void mnuEtudiants_Click(object sender, EventArgs e)
        {
            frmEtudiants fe = new frmEtudiants();
            fe.MdiParent = this;
            fe.Show();
        }

        private void mnuRechercher_Click(object sender, EventArgs e)
        {
            frmRecherche fr = new frmRecherche();
            fr.MdiParent = this;
            fr.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string msg = "Etes vous sur de vouloir quitter cette application?";
            string titre = "Avertissement : Fermeture du programme";
            if (MessageBox.Show(msg, titre, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }   
        }

        private void frmPrincipale_Load(object sender, EventArgs e)
        {
            clsGlobal.mySet = new DataSet();
            SqlConnection mycon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=teccartDBSql;Integrated Security=True");
            mycon.Open();
            //Remplire le dataset avec les tables de la base de données
            SqlCommand myCmd = new SqlCommand("SELECT * FROM cours",mycon);
            SqlDataAdapter adpCours = new SqlDataAdapter(myCmd);
            adpCours.Fill(clsGlobal.mySet, "Cours");

            SqlCommand myCmd2 = new SqlCommand("SELECT * FROM Etudiants", mycon);
            SqlDataAdapter adpEtuds = new SqlDataAdapter(myCmd2);
            adpCours.Fill(clsGlobal.mySet, "Etudiants");

            DataRelation myRel = new DataRelation("cours_Etuds",
                clsGlobal.mySet.Tables["Cours"].Columns["RefCours"],
                clsGlobal.mySet.Tables["Etudiants"].Columns["RefCours"]);
            clsGlobal.mySet.Relations.Add(myRel);

            mycon.Close();
        }
    }
}
