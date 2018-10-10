using ASP_Authorization.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Authorization.FormsQuery
{
    public partial class FormPosition : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReturnDataTable.GetTable(string.Format("SELECT PK_Poisition AS [Код должности], Name_position AS [Наименование должности], Salary AS [Оклад], Responsibility AS [Обязаности], Requirements AS [Требования] FROM Positions"),GV_Position);
        }
    }
}