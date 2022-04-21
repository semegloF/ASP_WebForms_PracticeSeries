using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace prjWebCsAdoDataset
{
    public class clsEtudiant
    {
        private string genre, nom, numero;
        private Single note;

        public clsEtudiant()
        {
            Numero = "Non defini";
            Genre = "Non defini";
            Nom = "Non defini";
            Note = -1;
        }

        public clsEtudiant(string numero, string genre, string nom, float note)
        {
            Numero = numero;
            Genre = genre;
            Nom = nom;
            Note = note;
        }

        public string Genre { get => genre; set => genre = value; }
        public string Nom { get => nom; set => nom = value; }
        public float Note { get => note; set => note = value; }
        public string Numero { get => numero; set => numero = value; }

        public override string ToString()
        {
            string info = "Numero : " + Numero + "\nGenre : " + Genre + "\nNom : " + Nom;
            info += "\nNote : " + Note + "/100";

            return info;
        }

        public string ToStringEnHtml()
        {
            string info = "Numero : " + Numero + "<br />Genre : " + Genre + "<br />Nom : " + Nom;
            info += "<br />Note : " + Note + "/100";

            return info;
        }
    }
}