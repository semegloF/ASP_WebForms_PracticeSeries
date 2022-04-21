using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsAdoReview
{
    public partial class frmDatasetStatic : Form
    {
        public frmDatasetStatic()
        {
            InitializeComponent();
        }
        DataSet mySetSport;

        private void frmDatasetStatic_Load(object sender, EventArgs e)
        {
            mySetSport = CreerDataset();
            gridResultat.DataSource = mySetSport.Tables["Equipes"];

            
            
        }

        private DataSet CreerDataset()
        {
            mySetSport = new DataSet();
            //creation table Equipes
            DataTable myTb = new DataTable("Equipes");
            //craetion du champs RefEquipe
            DataColumn myCol = new DataColumn("RefEquipe", Type.GetType(" System.Int64"));
            myCol.AutoIncrement = true;
            myCol.AutoIncrementSeed = 1;
            myCol.AutoIncrementStep = 1;
            myTb.Columns.Add(myCol);

            myCol = new DataColumn("Nom", Type.GetType("System.String"));
            myCol.MaxLength = 50;
            myTb.Columns.Add(myCol);

            myCol = new DataColumn("Ville", Type.GetType("System.String"));
            myCol.MaxLength = 50;
            myTb.Columns.Add(myCol);

            myCol = new DataColumn("Budget", Type.GetType("System.Decimal"));
            myTb.Columns.Add(myCol);

            //creation index(la clé primaire)
            DataColumn[] keys = new DataColumn[1];
            keys[0] = myTb.Columns["RefEquipe"];
            myTb.PrimaryKey = keys;

            mySetSport.Tables.Add(myTb);



            //creation table Joueurs
            myTb = new DataTable("Joueurs");
            //craetion du champs RefEquipe
            myCol = new DataColumn("RefJoueur", Type.GetType(" System.Int64"));
            myCol.AutoIncrement = true;
            myCol.AutoIncrementSeed = 1;
            myCol.AutoIncrementStep = 1;
            myTb.Columns.Add(myCol);

            myCol = new DataColumn("Nom", Type.GetType("System.String"));
            myCol.MaxLength = 50;
            myTb.Columns.Add(myCol);

            myCol = new DataColumn("Maissance", Type.GetType("System.DateTime"));
            myTb.Columns.Add(myCol);

            myCol = new DataColumn("Numero", Type.GetType("System.Int16"));
            myTb.Columns.Add(myCol);

            myCol = new DataColumn("RefEquipe", Type.GetType(" System.Int64"));
            myTb.Columns.Add(myCol);

            //creation index(la clé primaire)
            keys = new DataColumn[1];
            keys[0] = myTb.Columns["RefJoueurs"];
            myTb.PrimaryKey = keys;

            mySetSport.Tables.Add(myTb);

            //creation de la relation
            DataRelation myRel = new DataRelation("Equipe_Joueur",
                mySetSport.Tables["Equipes"].Columns["RefEquipe"],
                mySetSport.Tables["Joueurs"].Columns["RefEquipe"]);
            mySetSport.Relations.Add(myRel);

            RemplirTableEquipe();

            return mySetSport;
        }

        private void RemplirTableEquipe()
        {
            DataTable tbEquip = mySetSport.Tables["Equipes"];
            DataRow myrow = tbEquip.NewRow();
            myrow["Nom"] = "FC Barca";
            myrow["Ville"] = "Barcelone";
            myrow["Budget"] = 60000000;
            tbEquip.Rows.Add(myrow);

             myrow = tbEquip.NewRow();
            myrow["Nom"] = "PSG";
            myrow["Ville"] = "Paris";
            myrow["Budget"] = 160000000;
            tbEquip.Rows.Add(myrow);

             myrow = tbEquip.NewRow();
            myrow["Nom"] = "FC Bayren";
            myrow["Ville"] = "Munich";
            myrow["Budget"] = 77000000;
            tbEquip.Rows.Add(myrow);
        }

        private void gridResultat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
