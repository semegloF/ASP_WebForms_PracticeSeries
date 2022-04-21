using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjWebCsEntityFramOnlineExam
{
    public partial class webExamQuestions : System.Web.UI.Page
    {
        teaccartOnlineSqlDBEntities teccart;
        static int note;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                note = 0;
                teccart = new teaccartOnlineSqlDBEntities();
                RemplirQuestions();
                RemplirReponseQ1();
                RemplirReponseQ2();
            }

        }

        private void RemplirReponseQ2()
        {
            var ReponsesQ2 = from Repons rep in teccart.Reponses
                             where rep.RefQuestion == "qu2"
                             select rep;
            lstRadReponsesQ2.DataTextField = "Reponse";
            lstRadReponsesQ2.DataValueField = "Valeur";
            lstRadReponsesQ2.DataSource = ReponsesQ2.ToList();
            lstRadReponsesQ2.DataBind();
        }

        private void RemplirReponseQ1()
        {
            /*
            //Version loop
            foreach (Repons rep in teccart.Reponses)
            {
                if (rep.RefQuestion == "qu1")
                {
                    ListItem itm = new ListItem();
                    itm.Text = rep.Reponse;
                    itm.Value = rep.Valeur.ToString();

                    lstRadReponsesQ1.Items.Add(itm);
                     
                }
            }*/

            var ReponsesQ1 = from Repons rep in teccart.Reponses
                             where rep.RefQuestion == "qu1"
                             select rep;
            lstRadReponsesQ1.DataTextField = "Reponse";
            lstRadReponsesQ1.DataValueField = "Valeur";
            lstRadReponsesQ1.DataSource = ReponsesQ1.ToList();
            lstRadReponsesQ1.DataBind();

        }

        private void RemplirQuestions()
        {
            foreach (Question quest in teccart.Questions)
            {
                if (quest.QuestionID == "qu1")
                {
                    lblQuestion1.Text = quest.Question1;
                }
                else if (quest.QuestionID == "qu2")
                {
                    lblQuestion1.Text = quest.Question1;
                }

            }
        }

        protected void btnValiderQ1_Click(object sender, EventArgs e)
        {
            int tmp =  Convert.ToInt32(lstRadReponsesQ1.SelectedValue);
            note = (tmp == 25) ? tmp : 0;
            lblNote1.Text = note + "/ 100";
        }

        protected void btnValiderQ2_Click(object sender, EventArgs e)
        {
            int tmp = Convert.ToInt32(lstRadReponsesQ2.SelectedValue);
            note += (tmp == 25) ? tmp : 0;
            lblNote2.Text = note + "/ 100";
        }
    }
}