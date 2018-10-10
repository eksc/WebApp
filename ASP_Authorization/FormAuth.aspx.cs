using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Authorization
{
    public partial class FormAuth : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BT_In_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-JM68S6U\SQLEXPRESS;Initial Catalog=Restaraunt;Integrated Security=True");
            if (Page.IsValid)
            {
                SqlCommand sqlCommand = new SqlCommand(string.Format("SELECT * FROM Users WHERE LoginUser = '{0}'", TB_Login.Text), sqlConnection);
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                {
                    sqlDataReader.Close();
                    Response.Redirect("/FormsQuery/FormEmployee.aspx");
                }
                // Response.Write("Такого пользователя не существует");
                Page.ClientScript.RegisterStartupScript(this.GetType(), "calling", "alert('Такого пользователя не существует');",true);
                sqlConnection.Close();
            }
        }
    }
}