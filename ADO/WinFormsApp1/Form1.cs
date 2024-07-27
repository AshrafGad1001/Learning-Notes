using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection SqlConn;
        private void Form1_Load(object sender, EventArgs e)
        {





            SqlConn = new SqlConnection();
            //ConnectionString  -> To stablish Connection To Sspec Database
            //Not Recommended To Write This Connection String 
            // SqlConn.ConnectionString = "Data Source =.;Initial Catalog=Northwind; Integrated Security=true;";


            SqlConn.ConnectionString = ConfigurationManager.ConnectionStrings["NorthwindConnection"].ConnectionString;





            //------------------------------------------------------
            this.Text = ConfigurationManager.AppSettings["BranchId"];
            //------------------------------------------------------


            //Text That Apper In Title Of Windows Form
            SqlConn.StateChange += (sender, e) =>
                this.Text = $"State Was {e.CurrentState} and Cahnged To {e.CurrentState}";

            //Show Error Msg
            SqlConn.InfoMessage += (sender, e) => MessageBox.Show(e.Message);

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (SqlConn.State == ConnectionState.Closed)
            {
                SqlConn.Open();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (SqlConn.State != ConnectionState.Closed)
            {
                SqlConn.Close();
            }
        }

        private void btnChangeDb_Click(object sender, EventArgs e)
        {
            //Open Connection
            //Change Database
            if (SqlConn.State == ConnectionState.Open)
            {
                SqlConn.ChangeDatabase("TalabatAPI");
            }
        }
    }
}
