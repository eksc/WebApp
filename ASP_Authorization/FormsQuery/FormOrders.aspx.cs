using ASP_Authorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Authorization.FormsQuery
{
    public partial class FormOrders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReturnDataTable.GetTable(string.Format("SELECT pk_order AS [Код заказа], Date AS [Дата], Time AS [Время],FIO_customer AS [ФИО заказчика], Phone_customer AS [Номер заказчика], FK_dish_first AS [Код первого блюда], F.Name_dish AS [Наименование второго блюда], FK_dish_second AS [Код второго блюда], S.Name_dish AS [Наименование второго блюда], FK_dish_third AS [Код третьего блюда], T.Name_dish AS [Наименование третьего блюда], Orders.Price AS [Цена], ExecutionNote AS [Отметка о выполнении], FK_employee AS [Код сотрудника], FIO_employee AS [ФИО сотрудника] FROM (((Orders INNER JOIN Dishs AS F ON FK_dish_first = F.pk_dish) INNER JOIN Dishs AS S ON FK_dish_second = S.pk_dish) INNER JOIN Dishs AS T ON FK_dish_third = T.pk_dish) INNER JOIN Employee ON FK_Employee = PK_Employee"),GV_Orders);
        }
    }
}