using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace prjWebCsAdoDataset
{
    public partial class webGestionCours : System.Web.UI.Page
    {
        //Declaration des variables globales
        static SqlConnection mycon;
        static DataSet myset;
        static DataTable tabCours, tabEtuds;
        static SqlDataAdapter adpCours;
        static string mode;
        static int refC;
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Page.IsPostBack == false)// if(!IsPostBack)
            {
                myset = new DataSet();
                string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=teccartDBSql;Integrated Security=True";
                mycon = new SqlConnection(conString);
                mycon.Open();

                //Recuperer la table Cours de la bd et l'inserer dans dataset
                ChargerTabCours();

                //Recuperer la table Etudiants de la bd et l'inserer dans dataset
                SqlCommand mycmd2 = new SqlCommand("SELECT * FROM Etudiants", mycon);
                SqlDataAdapter adpEtud = new SqlDataAdapter(mycmd2);
                //remplir le dataset
                adpEtud.Fill(myset, "Etudiants");

                
                tabEtuds = myset.Tables["Etudiants"];

                //remplissage de lstCours
                RemplirListeCours();

                
            }
        }

        protected void ChargerTabCours()
        {
            
            //recupere les elements daans la table cours
            SqlCommand mycmd = new SqlCommand("SELECT * FROM Cours", mycon);
            //stock les elements dans le dataAdapter
            adpCours = new SqlDataAdapter(mycmd);
            //remplir le dataset
            adpCours.Fill(myset, "Cours");

            tabCours = myset.Tables["Cours"];

            //Creation d'une cle primaire pour la table Cours sur  le champ RefCours dans le dataset
            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabCours.Columns["RefCours"];
            tabCours.PrimaryKey = keys;
            tabCours.Columns["RefCours"].AutoIncrement = true;
            tabCours.Columns["RefCours"].AutoIncrementStep = 1;
        }

        protected void lstCours_SelectedIndexChanged(object sender, EventArgs e)
        {
            refC = Convert.ToInt32(lstCours.SelectedItem.Value); // recuperation du refCours

            //foreach (DataRow myrow in tabCours.Rows)
            //{
            //    if (myrow["RefCours"].ToString() == refC.ToString())
            //    {
            //        txtNumero.Text = myrow["Numero"].ToString();
            //        txtTitre.Text = myrow["Titre"].ToString();
            //        txtDuree.Text = myrow["Duree"].ToString();
            //        txtProfesseur.Text = myrow["Professeur"].ToString();
            //        break;
            //    }
            //}

            
                
            //Version 0.0 avec la methode find            
            DataRow myrow = tabCours.Rows.Find(refC);
            txtNumero.Text = myrow["Numero"].ToString();
            txtTitre.Text = myrow["Titre"].ToString();
            txtDuree.Text = myrow["Duree"].ToString();
            txtProfesseur.Text = myrow["Professeur"].ToString();

            //Version 0.0. la methode select de dataTable
            //tabCours.Select();           
            DataRow[] results = tabEtuds.Select("RefCours = " + refC);

            //affiche tous les etudiants qui ont le cours refC
            if(results.Length != 0)
            {
                gridEtudiants.DataSource = results.CopyToDataTable();
                gridEtudiants.DataBind();
            }
           
        }

        private void RemplirListeCours()
        {
            /*
            //version loop 
            foreach (DataRow myrow in tabCours.Rows)
            {
                ListItem elm = new ListItem();
                elm.Text = myrow["Numero"].ToString();
                elm.Value = myrow["RefCours"].ToString();
                lstCours.Items.Add(elm);
            }
            */
            //version databind
            lstCours.DataSource = tabCours;
            lstCours.DataTextField = "Numero";
            lstCours.DataValueField = "RefCours";
            lstCours.DataBind();


        }

        protected void btnAjouter_Click(object sender, EventArgs e)
        {
            mode = "ajout";
            txtNumero.Text = txtDuree.Text = txtProfesseur.Text = txtTitre.Text = "";
            txtNumero.Focus();

            ActiverBoutons(false, true);
        }

        protected void btnModifier_Click(object sender, EventArgs e)
        {
            mode = "modif";
            txtNumero.Focus();

            ActiverBoutons(false, true);
        }

        protected void btnSupprimer_Click(object sender, EventArgs e)
        {
            mode = "sup";
            txtNumero.Focus();
            Panel1.GroupingText = "EN MODE SUPPRESSION";

            //Trouver l'enregistrement selectionner
            DataRow myrow = tabCours.Rows.Find(refC);

            myrow.Delete();

            //pour sauvegarder  ou syncroniser le dataset et la base de données
            //mise à jour de la Dataset vers BD 
            SqlCommandBuilder myBuilder = new SqlCommandBuilder(adpCours);
            adpCours.Update(myset, "Cours");

            //mise à jour de la BD vers Dataset
            myset.Tables.Remove("Cours");
            //Recuperer la table Cours de la bd et l'inserer dans dataset
            ChargerTabCours();

            tabCours = myset.Tables["Cours"];

            //@ce bloc permet de mettre à jour les element de la liste de cours
            lstCours.Items.Clear();
            RemplirListeCours();
            txtNumero.Text = txtDuree.Text = txtProfesseur.Text = txtTitre.Text = "";

            ActiverBoutons(false, true);
        }

        protected void btnSauvegarder_Click(object sender, EventArgs e)
        {
            string num = txtNumero.Text;
            string titre = txtTitre.Text;
            string prof = txtProfesseur.Text;
            Int32 dur = Convert.ToInt32(txtDuree.Text);

            DataRow myrow = tabCours.Rows.Find(refC);

            if (mode == "ajout") {

                //creation d'un nouveau enregistrement
                myrow = tabCours.NewRow();
                myrow["Numero"] = num;
                myrow["Titre"] = titre;
                myrow["Professeur"] = prof;
                myrow["Duree"] = dur;

                tabCours.Rows.Add(myrow);
                



            }
            else if (mode == "modif")
            {
                //Trouver l'enregistrement selectionner
                myrow = tabCours.Rows.Find(refC);
                myrow["Numero"] = num;
                myrow["Titre"] = titre;
                myrow["Professeur"] = prof;
                myrow["Duree"] = dur;
            }
 
            ActiverBoutons(true, false);
            mode = "";

            //pour sauvegarder  ou syncroniser le dataset et la base de données
            //mise à jour de la Dataset vers BD 
            SqlCommandBuilder myBuilder = new SqlCommandBuilder(adpCours);
            adpCours.Update(myset, "Cours");

            //mise à jour de la BD vers Dataset
            myset.Tables.Remove("Cours");
            //Recuperer la table Cours de la bd et l'inserer dans dataset
            ChargerTabCours();

            tabCours = myset.Tables["Cours"];

            //@ce bloc permet de mettre à jour les element de la liste de cours
            lstCours.Items.Clear();
            RemplirListeCours();



        }

        protected void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtDuree.Text = txtNumero.Text = txtProfesseur.Text = txtTitre.Text = "";
            ActiverBoutons(true, true);
        }

        private void ActiverBoutons(bool AjModSup, bool SavAnn)
        {
            btnModifier.Enabled = btnAnnuler.Enabled = btnSupprimer.Enabled = btnAjouter.Enabled = AjModSup;
            btnSauvegarder.Enabled = btnAnnuler.Enabled = SavAnn;
        }
    }
}