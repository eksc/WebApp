using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ASP_Authorization
{
    public partial class FormRegistr : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BT_Add_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-JM68S6U\SQLEXPRESS;Initial Catalog=Restaraunt;Integrated Security=True");
            if(Page.IsValid)
            {
                SqlCommand sqlCommand = new SqlCommand(string.Format("SELECT * FROM Users WHERE LoginUser = '{0}'",TB_Login.Text),sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (!sqlDataReader.HasRows)
                {
                    sqlDataReader.Close();
                    sqlCommand = new SqlCommand(string.Format("INSERT INTO Users (LoginUser,Password) VALUES ('{0}','{1}');", TB_Login.Text, TB_Password.Text), sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    Response.Redirect("~/FormAuth.aspx");
                }
                sqlConnection.Close();
            }
        }
    }
}