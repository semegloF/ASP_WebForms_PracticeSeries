using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace testProjet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection mycon;

        private void gridResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mycon = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = testData; Integrated Security = True");
            
               

            SqlCommand mycmd = new SqlCommand("SELECT * FROM Test", mycon);
            SqlDataReader myRder = mycmd.ExecuteReader();
            DataTable temp = new DataTable();
            temp.Load(myRder);
            gridResult.DataSource = temp;


        }
    }
}
