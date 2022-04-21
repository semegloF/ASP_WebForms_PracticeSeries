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
    public partial class webCritereAgent : System.Web.UI.Page
    {
        static SqlConnection mycon;
        static DataSet myset;
        static DataTable tabAgents, tabRegions, tabVilles;
        static SqlDataAdapter adpAgents, adpRegions, adpVilles;
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

                ChargerTabAgents();

                //======Affichage de la lsite des Agents
                gridAgents.DataSource = tabAgents;
                gridAgents.DataBind();

                //======Affichage de la lsite de numero des Agents
                lstCboNumero.DataSource = tabAgents;
                lstCboNumero.DataTextField = "Numero";
                lstCboNumero.DataBind();

                //======Affichage de la lsite  des regions
                chargerTabRegions();
                lstCboRegion.DataSource = tabRegions;
                lstCboRegion.DataTextField = "NomRegion";
                lstCboRegion.DataValueField = "IdRegion";
                lstCboRegion.DataBind();

                //======Affichage de la lsite des Villes selon la region choisie       
                chargerTabVille();
                lstCboVille.DataSource = tabVilles;
                lstCboVille.DataTextField = "NomVille";
                lstCboVille.DataBind();

                //===Definition par defaut du genre
                lstRadBtnGenre.SelectedIndex = 0;

            }

        }

        protected void btnFiltrer_Click(object sender, EventArgs e)
        {
            panCritere.Visible = true;
        }

        protected void btnLinkEffacr_Click(object sender, EventArgs e)
        {
            panCritere.Visible = false;
            lstCboLangue.SelectedIndex = lstCboNumero.SelectedIndex = lstCboRegion.SelectedIndex = lstCboVille.SelectedIndex = lstRadBtnGenre.SelectedIndex = 0;

            //======Affichage de la lsite des Agents
            gridAgents.DataSource = tabAgents;
            gridAgents.DataBind();
        }

        protected void btnContacter_Click(object sender, EventArgs e)
        {
            Server.Transfer("webMessage.aspx");
        }

        protected void btnLinkRetour_Click(object sender, EventArgs e)
        {
            Server.Transfer("webAccueil.aspx");
        }

        protected void btnTrouver_Click(object sender, EventArgs e)
        {
            string genre = lstRadBtnGenre.SelectedItem.Text;
            string ville = lstCboVille.SelectedItem.Text;
            string region = lstCboRegion.SelectedItem.Text;
            string numero = lstCboNumero.SelectedItem.Value;
            string langue = lstCboLangue.SelectedItem.Value;

            var lesAgents = from DataRow agents in tabAgents.Rows
                             where agents.Field<string>("Numero") == numero
                             && agents.Field<string>("Ville") == ville
                             && agents.Field<string>("Region") == region
                             && agents.Field<string>("Genre") == genre
                             && agents.Field<string>("Langue") == langue
                             select agents;

            gridAgents.DataSource = (lesAgents.Count() > 0) ? lesAgents.CopyToDataTable() : null;
            gridAgents.DataBind();
        }


        private void chargerTabVille()
        {
            selectRegion = lstCboRegion.SelectedValue;
            SqlCommand cmdV = new SqlCommand("SELECT * FROM Villes WHERE IdRegion=" + selectRegion, mycon);
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

        private void ChargerTabAgents()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Agents", mycon);
            adpAgents = new SqlDataAdapter(cmd);
            //remplir le dataset
            adpAgents.Fill(myset, "Agents");
            tabAgents = myset.Tables["Agents"];

            DataColumn[] keys = new DataColumn[1];
            keys[0] = tabAgents.Columns["IdAgent"];
            tabAgents.PrimaryKey = keys;
            tabAgents.Columns["IdAgent"].AutoIncrement = true;
            tabAgents.Columns["IdAgent"].AutoIncrementStep = 1;
        }
    }
}