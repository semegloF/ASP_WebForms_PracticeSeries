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
    public partial class webMessage : System.Web.UI.Page
    {
        static SqlConnection mycon;
        static DataSet myset;
        static DataTable tabMessages, tabAgents;
        static SqlDataAdapter adpMessages, adpAgents;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) 
            {
                //===Connection à la DB Maison
                myset = new DataSet();
                string conString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=remaxDBSql;Integrated Security=True";
                mycon = new SqlConnection(conString);
                mycon.Open();

                SqlCommand cmdM = new SqlCommand("SELECT * FROM Agents ", mycon);

                ChargerTabAgents();
                //======Affichage de la lsite des Agents
                cboDestinaires.DataSource = tabAgents;
                cboDestinaires.DataTextField = "Email";
                cboDestinaires.DataValueField = "IdAgent";
                cboDestinaires.DataBind();
            }
            
            

        }

        protected void btnEffacer_Click(object sender, EventArgs e)
        {
            txtTitre.Text = txtMessage.Text = "";
        }

        protected void btnLinkRetour_Click(object sender, EventArgs e)
        {
            Server.Transfer("webAccueil.aspx");
        }

        protected void btnEnvoyer_Click(object sender, EventArgs e)
        {
            string receveur = cboDestinaires.SelectedItem.Text;
            string envoyeur = txtEnvoyeur.Text.Trim();
            string titre = txtTitre.Text.Trim();
            string msg = txtMessage.Text.Trim();
            
            DateTime aujour = DateTime.Today;

            string sql = "INSERT INTO Messages(Titre,Message,Envoyeur,Receveur,DateCreation) " +
                "VALUES(@tit, @mes, @moi, @recev,@tody)";

            SqlCommand cmdM = new SqlCommand(sql, mycon);


            cmdM.Parameters.AddWithValue("tit", titre);
            cmdM.Parameters.AddWithValue("mes", msg);
            cmdM.Parameters.AddWithValue("moi", envoyeur);
            cmdM.Parameters.AddWithValue("recev", receveur);
            cmdM.Parameters.AddWithValue("tody", aujour);
            cmdM.ExecuteNonQuery();
            mycon.Close();
            Server.Transfer("webAccueil.aspx");
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