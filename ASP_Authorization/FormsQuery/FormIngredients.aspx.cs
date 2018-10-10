using ASP_Authorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Authorization.FormsQuery
{
    public partial class FormIngredients : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReturnDataTable.GetTable(string.Format("SELECT pk_ingredient AS [Код ингредиента], Name_ingredient AS [Наименование ингредиаента], date_out AS [Дата выпуска], Capacity AS [Объем], ShelfLife AS [Срок годности], Price AS [Цена], Supplier AS [Поставщик] FROM Ingredients"),GV_Ingredients);
        }
    }
}