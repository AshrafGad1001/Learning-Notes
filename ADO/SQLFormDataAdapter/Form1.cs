using System.Data;
using System.Data.SqlClient;
using System.Numerics;

namespace SQLFormDataAdapter
{
    public partial class Form1 : Form
    {
        SqlConnection SqlConn = new SqlConnection("Data Source =.;Initial Catalog=Northwind; Integrated Security=true;");
        SqlCommand SqlCmd;
        SqlDataAdapter DA;
        DataTable DT;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCmd = new SqlCommand("Select * from Products", SqlConn);


            DA = new SqlDataAdapter(SqlCmd);
            DT = new DataTable();


        }

        private void BtnExecute_Click(object sender, EventArgs e)
        {
            /*
             - open Sql Connection
             - Execute Select Command 
             - Fetch Data into DataTable
             */
            DA.Fill(DT);
            //For test
            //this.Text = DT.Rows.Count.ToString();

            /*Complex Data Binding */

            lstProducts.DataSource = DT;
            lstProducts.DisplayMember = "ProductName";
            lstProducts.ValueMember = "ProductID";

        }

        private void lstProducts_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
