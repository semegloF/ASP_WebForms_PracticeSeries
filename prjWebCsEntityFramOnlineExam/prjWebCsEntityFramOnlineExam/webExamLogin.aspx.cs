using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjWebCsEntityFramOnlineExam
{
    public partial class webExamLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCommencer_Click(object sender, EventArgs e)
        {
            string numero = txtNumero.Text.Trim();
            string pass = txtMot2pass.Text.Trim();

            teaccartOnlineSqlDBEntities teccart = new teaccartOnlineSqlDBEntities();
            /*gridEtudiant.DataSource = teccart.Etudiants.ToList();
            gridEtudiant.DataBind();*/

            //Verifier si l'etudiant existe
            //Version boucle
            /*foreach (Etudiant et in teccart.Etudiants) 
            {
                if (numero == et.EtudiantID &&  pass == et.Mot2Passe)
                {                    
                    lblMessage.Text = "Bravo!";
                    if (et.Note != -1)
                    {
                        lblMessage.Text = "Vous avvez dja fait l'examen!";
                        return;
                    }
                }       
                else
                {                    
                    lblMessage.Text = "Numero ou Mot de passe invalite";
                    txtNumero.Focus();
                    txtMot2pass.Text = "";
                    return;
                }
            }*/


            //version LINQ
            var EtudiantsTrouves = from Etudiant et in teccart.Etudiants
                                   where et.EtudiantID == numero && et.Mot2Passe == pass
                                   select et;
            if (EtudiantsTrouves.Count() == 0)
            {
                lblMessage.Text = "Numero ou Mot de passe invalite";
            }
            else
            {
                if (EtudiantsTrouves.First().Note == -1)
                {
                    lblMessage.Text = "Bravo, vous pouvez faire l'examen";
                }
                else
                {
                    lblMessage.Text = "Vous avez deja passé l'examen";
                }
            }




        }
    }
}