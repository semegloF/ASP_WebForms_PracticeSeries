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
    public partial class webLinq2Dataset : System.Web.UI.Page
    {
        static DataSet TeccartSet;
        static DataTable tabCours, tabEtuds;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                TeccartSet = RecupererDonnees();
                tabCours = TeccartSet.Tables["Cours"];
                tabEtuds = TeccartSet.Tables["Etudiants"];

                //Remplir la listbox avec les noms des professeurs
                    //CopyToDataTable() est utilisé pour databind un dataRow
                var lesCours = from DataRow cr in tabCours.Rows
                               select new {Prof= cr.Field<string>("Professeur") };
                lstProfesseur.DataSource = lesCours.Distinct();
                lstProfesseur.DataTextField = "Prof";
                lstProfesseur.DataBind();
            }
            
        }

        private static DataSet RecupererDonnees()
        {
            DataSet myset = new DataSet();
            SqlConnection mycon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=teccartDBSql;Integrated Security=True");
            mycon.Open();
            SqlDataAdapter adpCours = new SqlDataAdapter("SELECT * FROM Cours", mycon);
            adpCours.Fill(myset, "Cours");

            SqlDataAdapter adpEtuds = new SqlDataAdapter("SELECT * FROM Etudiants", mycon);
            adpEtuds.Fill(myset, "Etudiants");

            return myset;
        }

       

        protected void lstProfesseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Remplir la radioList avec les noms des professeurs
            string prof = lstProfesseur.SelectedItem.Text;
            
            var courDuProf = from DataRow myrow in tabCours.Rows
                           where myrow.Field<string>("Professeur") == prof
                           select new
                           { 
                               Num = myrow.Field<string>("Numero"),
                               idCours= myrow.Field<Int32>("RefCours")

                           };
            
            LstRadCours.DataSource = courDuProf;
            LstRadCours.DataTextField = "Num";
            LstRadCours.DataValueField = "idCours";

            LstRadCours.DataBind();

           
        }

        protected void LstRadCours_SelectedIndexChanged(object sender, EventArgs e)
        {
             Int32 refC = Convert.ToInt32 (LstRadCours.SelectedItem.Value);
            //remplir le gridview avec le etudiants de ce cours
            var lesEtuds = from DataRow et in tabEtuds.Rows
                           where et.Field<Int32>("RefCours") ==refC
                           //select new { Num = et.Field<string>("Nom") };
                           select et;

            //if(lesEtuds.Count() > 0)
            //{
            //    gridEtudiants.DataSource = lesEtuds.CopyToDataTable();
            //    gridEtudiants.DataBind();
            //}
            //else 
            //{
            //    gridEtudiants.DataSource = null;
            //    gridEtudiants.DataBind();
            //}

            gridEtudiants.DataSource = (lesEtuds.Count() > 0)? lesEtuds.CopyToDataTable() : null;
            gridEtudiants.DataBind();

            //Afficher les info du cours dans le label
            var CoursChoisi = from DataRow myRow in tabCours.Rows
                              where myRow.Field<Int32>("RefCours") == refC
                              select myRow;

            DataRow rw = CoursChoisi.First();
            string info = "<br/>Numero : " + rw["Numero"].ToString() +
                "<br/>Titre : " + rw["Titre"].ToString() +
                "<br/>Professeur : " + rw["Professeur"].ToString() +
                "<br/>Duree : " + rw["Duree"].ToString();
            lblInfo.Text = info;

        }
    }
}