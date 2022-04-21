using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace prjWebCsRemax
{
    public partial class webCritereMaison : System.Web.UI.Page
    {
        static SqlConnection mycon;
        static DataSet myset;
        static DataTable tabMaisons, tabRegions, tabVilles;
        static SqlDataAdapter adpMaisons, adpRegions, adpVilles;
        static string selectRegion;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                //===Connection à la DB Maison
                myset = new DataSet();
                string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=remaxDBSql;Integrated Security=True";
                mycon = new SqlConnection(conString);
                mycon.Open();

                ChargerTabMaisons();

                //======Affichage de la lsite des maisons
                gridMaison.DataSource = tabMaisons;
                gridMaison.DataBind();

                //======Affichage de la lsite de type de maison
                lstCboType.DataSource = tabMaisons;
                lstCboType.DataTextField = "Type";
                lstCboType.DataBind();

                //======Affichage de la lsite de type de regions
                chargerTabRegions();
                lstCboRegion.DataSource = tabRegions;
                lstCboRegion.DataTextField = "NomRegion";
                lstCboRegion.DataValueField = "IdRegion";
                lstCboRegion.DataBind();

                //======Affichage de la lsite de type de Ville selon la region choisie       
                chargerTabVille();
                lstCboVille.DataSource = tabVilles;
                lstCboVille.DataTextField = "NomVille";
                lstCboVille.DataBind();

                //===Definition par defaut du nombre de chambre
                lstRadBtnChambre.SelectedIndex = 0;

            }
            




        }

        private void chargerTabVille()
        {
            selectRegion = lstCboRegion.SelectedValue;
            SqlCommand cmdV = new SqlCommand("SELECT * FROM Villes WHERE IdRegion="+ selectRegion, mycon);
            adpVilles = new SqlDataAdapter(cmdV);
            //remplir le dataset
            adpVilles.Fill(myset, "Villes");
            tabVilles = myset.Tables["Villes"];

            DataColumn[] Rkeys = new DataColumn[1];
            Rkeys[0] = tabVilles.Columns["IdVille"];
            tabVilles.PrimaryKey = Rkeys;
            tabVilles.Columns["IdVille"].AutoIncrement = true;
            tabVilles.Columns["IdVille"].AutoIncrementStep = 1;
        }

        protected void btnContacter_Click(object sender, EventArgs e)
        {
            Server.Transfer("webMessage.aspx");
        }

        protected void btnLinkEffacr_Click(object sender, EventArgs e)
        {
            panCritere.Visible = false;
            lstCboType.SelectedIndex = lstCboPrix.SelectedIndex = lstCboRegion.SelectedIndex = lstCboVille.SelectedIndex = lstRadBtnChambre.SelectedIndex = 0;

            //======Affichage de la lsite des Agents
            gridMaison.DataSource = tabMaisons;
            gridMaison.DataBind();
        }

        protected void btnLinkRetour_Click(object sender, EventArgs e)
        {
            Server.Transfer("webAccueil.aspx");
        }

        private void chargerTabRegions()
        {
            SqlCommand cmdR = new SqlCommand("SELECT * FROM Regions", mycon);
            adpRegions = new SqlDataAdapter(cmdR);
            //remplir le dataset
            adpRegions.Fill(myset, "Regions");
            tabRegions = myset.Tables["Regions"];

            DataColumn[] Rkeys = new DataColumn[1];
            Rkeys[0] = tabRegions.Columns["IdRegion"];
            tabRegions.PrimaryKey = Rkeys;
            tabRegions.Columns["IdRegion"].AutoIncrement = true;
            tabRegions.Columns["IdRegion"].AutoIncrementStep = 1;
        }

        private void ChargerTabMaisons()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Maisons", mycon);
            adpMaisons = new SqlDataAdapter(cmd);
            //remplir le dataset
            adpMaisons.Fill(myset, "Maisons");
            tabMaisons = myset.Tables["Maisons"];

             DataColumn[] keys = new DataColumn[1];
             keys[0] = tabMaisons.Columns["IdMaison"];
             tabMaisons.PrimaryKey = keys;
             tabMaisons.Columns["IdMaison"].AutoIncrement = true;
             tabMaisons.Columns["IdMaison"].AutoIncrementStep = 1;             
        }

        protected void btnFiltrer_Click(object sender, EventArgs e)
        {
            panCritere.Visible = true;
        }

        protected void btnTrouver_Click(object sender, EventArgs e)
        {
            string type = lstCboType.SelectedItem.Text;
            string ville = lstCboVille.SelectedItem.Text;
            string region = lstCboRegion.SelectedItem.Text;
            int prix = Convert.ToInt32(lstCboPrix.SelectedItem.Value);
            int chambre =Convert.ToInt32(lstRadBtnChambre.SelectedItem.Value);

            var lesMaisons = from DataRow maison in tabMaisons.Rows
                           where maison.Field<string>("Type") == type
                           && maison.Field<string>("Ville")== ville
                           && maison.Field<string>("Region") == region
                           && maison.Field<int>("Prix") >= prix
                           && maison.Field<int>("Nbr2Chambre") >= chambre
                           select maison;

            gridMaison.DataSource = (lesMaisons.Count() > 0) ? lesMaisons.CopyToDataTable() : null;
            gridMaison.DataBind();
        }
    }
}