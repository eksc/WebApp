using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ASP_Authorization.Models
{
    public static class ReturnDataTable
    {
        public static void GetTable(string Query, GridView tempGV)
        {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-JM68S6U\SQLEXPRESS;Initial Catalog=Restaraunt;Integrated Security=True");
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(Query, sqlConnection);
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            tempGV.DataSource = dataTable;
            tempGV.DataBind();
            sqlConnection.Close();
        }
    }
}