using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace prjWebCsAdoDataset
{
    public partial class webPizza : System.Web.UI.Page
    {        
            protected void Page_Load(object sender, EventArgs e)
            {
                lblAddress.Visible = txtAddress.Visible = false;
                panOrder.Visible = false;
                if (Page.IsPostBack == false) // if it is the first time
                {
                    panPricing.Visible = false;
                    FillSize(); // fill the combobox with sizes
                    FillPizza();
                    FillToppings();
                    FillCrust();
                }
                else
                {
                    panPricing.Visible = true;
                    CalculatePrice();
                    panOrder.Visible = false;

                }

            }

            private void FillCrust()
            {
                lstRadCrusts.Items.Add(new ListItem("Normal", "0"));
                lstRadCrusts.Items.Add(new ListItem("Thin", "0"));
                lstRadCrusts.Items.Add(new ListItem("Thick", "0"));

                lstRadCrusts.SelectedIndex = 0;
            }

            private void FillToppings()
            {
                lstChkToppings.Items.Add(new ListItem("Pepperoni", "1,0"));
                lstChkToppings.Items.Add(new ListItem("Mushrooms and Peppers", "2,0"));
                lstChkToppings.Items.Add(new ListItem("Extra Cheese", "1,2"));
                lstChkToppings.Items.Add(new ListItem("bacon and Ham", "2,2"));
            }
            private void FillSize()
            {
                ListItem elm = new ListItem();
                elm.Text = "Small";
                elm.Value = "1";
                // elm.Selected = true;
                lstSizes.Items.Add(elm);

                ListItem elm2 = new ListItem("Medium", "1,5");
                lstSizes.Items.Add(elm2);

                lstSizes.Items.Add(new ListItem("Large", "2"));

                // select the first item by default
                lstSizes.SelectedIndex = 0;
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
            private void FillPizza()
            {
                cboPizzas.Items.Add(new ListItem("The Napolitana", "10"));
                cboPizzas.Items.Add(new ListItem("The Quebecoise", "8"));
                cboPizzas.Items.Add(new ListItem("The Vegetarian", "12"));
                cboPizzas.Items.Add(new ListItem("The Hawaian", "11"));

            }
            protected void chkDelivery_CheckedChanged(object sender, EventArgs e)
            {
                if (chkDelivery.Checked == true)
                {
                    lblAddress.Visible = txtAddress.Visible = true;
                }
                else // (chkDelivery.Checked == false)
                {
                    lblAddress.Visible = txtAddress.Visible = false;
                }
            }

            protected void txtAddress_TextChanged(object sender, EventArgs e)
            {

            }

            protected void btnOrder_Click(object sender, EventArgs e)
            {
                panOrder.Visible = true;
            }
        
    }
}