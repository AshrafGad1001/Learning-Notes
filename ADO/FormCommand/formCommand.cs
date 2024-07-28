
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace FormCommand
{
    public partial class formCommand : Form
    {
        SqlConnection SqlConn;
        SqlCommand SqlCmd;
        public formCommand()
        {
            InitializeComponent();
            SqlConn = new SqlConnection();
            SqlConn.ConnectionString = "Data Source =.;Initial Catalog=Northwind; Integrated Security=true;";

            SqlCmd = new SqlCommand();

            /*
                -  Use This When Run SQL Statment Not Stored Procedure
             */
            // SqlCmd.CommandType= CommandType.Text;


            SqlCmd.Connection = SqlConn;

            /* If Execute NonQuery CRUD */
            //SqlCmd.CommandText = "select Count (*) From Products";


            //----------------------------
            //----------------------------


        }

        private void formCommand_Load(object sender, EventArgs e)
        {

            /*Read IDs  From Data base and */
            SqlCommand SqlGetPrdIDs = new SqlCommand("select productID from Products", SqlConn);

            SqlConn.Open();

            SqlDataReader Dr = SqlGetPrdIDs.ExecuteReader();

            while (Dr.Read())
            {
                cmbProductIDs.Items.Add(Dr["productID"]);
            }


            SqlConn.Close();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            #region Scaalar
            //if (SqlConn.State == ConnectionState.Closed)
            //    SqlConn.Open();

            //if (int.TryParse(SqlCmd.ExecuteScalar()?.ToString() ?? "0", out int N))
            //{
            //    this.Text = $"Product Count : {N}";
            //}
            //SqlConn.Close();
            #endregion




        }


    }
}
