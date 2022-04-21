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
    public partial class webPizzaDataset : System.Web.UI.Page
    {
        //@Declarartion de variable gobale
        static DataSet setPizzaria;
        static DataTable tabPizzas, tabCroutes, tabTailles, tabGarnitures;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                panPricing.Visible = panOrder.Visible = false;
                setPizzaria = CreerDataset();


                tabPizzas = setPizzaria.Tables["Pizzas"];
                tabCroutes = setPizzaria.Tables["Croutes"];
                tabTailles = setPizzaria.Tables["Tailles"];
                tabGarnitures = setPizzaria.Tables["Garnitures"];

                RemplirListPizzas();             
                RemplirListCroutes();
                RemplirListTailles();
                RemplirListGarnitures();

                
            }
            else
            {
                panPricing.Visible = true;
                CalculatePrice();
            }
        }

        private void RemplirListGarnitures()
        {
            lstChkToppings.DataTextField = "Nom";
            lstChkToppings.DataValueField = "Prix";
            lstChkToppings.DataSource = tabGarnitures;
            lstChkToppings.DataBind();

        }

        private void RemplirListTailles()
        {
            lstSizes.DataTextField = "Nom";
            lstSizes.DataValueField = "Facteur";
            lstSizes.DataSource = tabTailles;
            lstSizes.DataBind();
            //prmiere element definie comme element par defaut
            lstSizes.SelectedIndex = 0;
        }

        private void RemplirListCroutes()
        {
            lstRadCrusts.DataTextField = "Nom";
            lstRadCrusts.DataValueField = "Prix";
            lstRadCrusts.DataSource= tabCroutes;
            lstRadCrusts.DataBind();

        }

        private void RemplirListPizzas()
        {
            //databinding method
            cboPizzas.DataTextField = "Nom";
            cboPizzas.DataValueField = "Prix";
            cboPizzas.DataSource = tabPizzas;
            cboPizzas.DataBind();
        }

        private  DataSet CreerDataset()
        {
            //dataset temporaire
            DataSet mySet = new DataSet();
            SqlConnection mycon = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=pizzaDB2022;Integrated Security=True");
            mycon.Open();

            //ajouter la table Pizza dans le dataset
           string sql1 = "SELECT * FROM Pizzas";
            SqlDataAdapter myadp = new SqlDataAdapter(sql1, mycon) ;
            //Remplir le dataset en lui donnant Pizzas comme nom 
            myadp.Fill(mySet, "Pizzas");

           string sql2 = "SELECT * FROM Croutes";
            myadp = new SqlDataAdapter(sql2, mycon);
            //Remplir le dataset en lui donnant Pizzas comme nom 
            myadp.Fill(mySet, "Croutes");

            string sql3 = "SELECT * FROM Tailles";
            myadp = new SqlDataAdapter(sql3, mycon);
            //Remplir le dataset en lui donnant Pizzas comme nom 
            myadp.Fill(mySet, "Tailles");

           string sql4 = "SELECT * FROM Garnitures";
            myadp = new SqlDataAdapter(sql4, mycon);
            //Remplir le dataset en lui donnant Pizzas comme nom 
            myadp.Fill(mySet, "Garnitures");

            return mySet;
        }

        void CalculatePrice()
        {

            decimal basePrice = 0;
            decimal top = 0, deliv = 0, subtot = 0, total = 0, tax = 0;
            // evaluate base bas on the pizza and the size
            basePrice = Convert.ToDecimal(cboPizzas.SelectedItem.Value) * Convert.ToDecimal(lstSizes.SelectedItem.Value);
            deliv = (chkDelivery.Checked) ? 5 : 0;


            //Calculate the values of the selected toppings
            foreach (ListItem itm in lstChkToppings.Items)
            {
                if (itm.Selected == true)
                {
                    top = top + Convert.ToDecimal(itm.Value);
                }
            }



            litPricing.Text = "Base : " + basePrice + "<br />";
            litPricing.Text += (chkDelivery.Checked) ? "Delivery : " + deliv + "<br />" : "";
            litPricing.Text += "Toppings : " + top + "<br />";

            subtot = basePrice + deliv + top;
            tax = (subtot * 15) / 100;
            total = subtot + tax;

            litPricing.Text += "-----------------------  <br />";
            litPricing.Text += "Sub Total  : " + subtot + "<br />";
            litPricing.Text += "Taxes (15%) : " + tax + "<br />";
            litPricing.Text += "-----------------------  <br />";
            litPricing.Text += "Total  : " + total + "<br />";

        }
    }
}