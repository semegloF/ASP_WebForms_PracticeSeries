using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace prjWebCsAdoDataset
{
    public partial class webLinq : System.Web.UI.Page
    {
        static List<clsEtudiant> tousEtudiants;
        protected void Page_Load(object sender, EventArgs e)
        {
            #region"foreacheMethode"
            //Single[] tabNotes = new Single[] { 25, 90, 67, 100, 43, 69, 58, 89, 65, 95 };

            ////List<Single> ListBNotes = new List<float>();

            ////foreach (Single note in tabNotes)
            ////{
            ////    if (note >= 80)
            ////    {
            ////        ListBNotes.Add(note);
            ////    }
            ////}

            ////lstCours.DataSource = ListBNotes;
            ////lstCours.DataBind();


            ////Methode linqYou
            //var bonneNotes = from note in tabNotes
            //                 where note >= 80
            //                 select note;
            //lstCours.DataSource = bonneNotes;
            //lstCours.DataBind();
            #endregion
            if (!IsPostBack)
            {
                tousEtudiants = new List<clsEtudiant>();
                tousEtudiants.Add(new clsEtudiant("et001", "Femme", "Data SansLaptop", 2));
                tousEtudiants.Add(new clsEtudiant("et002", "Femme", "Hiba LaCrazy", 80));
                tousEtudiants.Add(new clsEtudiant("et003", "Femme", "Samedi Diamanche", 90));
                tousEtudiants.Add(new clsEtudiant("et006", "Homme", "Ami Komla", 726));
                tousEtudiants.Add(new clsEtudiant("et004", "Homme", "Ali Baba", 85));
                tousEtudiants.Add(new clsEtudiant("et005", "Homme", "Ali Baba", 55));

                //======== DATABIND GRIDVIEW========
                gridEtudiants.DataSource = tousEtudiants;
                gridEtudiants.DataBind();

                //======== DATABIND LISTVIEW========
                //LINQ pour recuppere les genres
                var lesGenres = from clsEtudiant et in tousEtudiants
                                select et.Genre;
                lstGenres.DataSource = lesGenres.Distinct();
                lstGenres.DataBind();
            }    
        }

        protected void lstGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gnrSelect = lstGenres.SelectedItem.ToString();

            //Afficher tous les etudiants du genre selectionne dans le grid
            var EtudiantsByGenre = from clsEtudiant et in tousEtudiants
                                   where et.Genre == gnrSelect
                                   select et;
            gridEtudiants.DataSource = EtudiantsByGenre;
            gridEtudiants.DataBind();

            // Afficher les nom des etudiants du genre selectionner dans les radios
            var lesNomsEtuds = from clsEtudiant et in tousEtudiants
                               where et.Genre == gnrSelect
                               select new {nom= et.Nom,numero= et.Numero };//Methode Alias
                               // select et;
            LstRadEtudiants.DataSource = lesNomsEtuds;
            LstRadEtudiants.DataTextField = "nom";
            LstRadEtudiants.DataValueField = "numero";
            LstRadEtudiants.DataBind();


        }

        protected void LstRadEtudiants_SelectedIndexChanged(object sender, EventArgs e)
        {
            string numeroSelect = LstRadEtudiants.SelectedValue;
            // Afficher les informations de l'etudiants selectionne dans les radios
            var etudiantSelects = from clsEtudiant et in tousEtudiants
                            where et.Numero == numeroSelect
                            select et;
            lblInfoEtud.Text = etudiantSelects.First().ToStringEnHtml();
            // lblInfoEtud.Text = etudiantSelects.ElementAt(0).ToStringEnHtml();

        }
    }
}