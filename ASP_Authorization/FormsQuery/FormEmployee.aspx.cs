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
    public partial class FormEmployee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReturnDataTable.GetTable(string.Format("SELECT PK_Employee AS [Код сотрудника],FIO_Employee AS [ФИО],Age_Employee AS [Возраст],Maul_Employee AS [Пол],Adress_Employe AS [Адрес проживания],Phone_Employee AS [Номер телеофна],Passport_Employee AS [Паспортные данные],FK_Position AS [Код должности],Name_Position AS [Наименование должности] FROM Employee INNER JOIN Positions ON FK_position = pk_poisition"), GV_Employee);


        }
    }
}