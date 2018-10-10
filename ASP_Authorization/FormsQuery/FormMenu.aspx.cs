using ASP_Authorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Authorization.FormsQuery
{
    public partial class FormMenu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReturnDataTable.GetTable(string.Format("SELECT PK_Dish AS [Код блюда], Name_dish AS [Наименование блюда], FK_Ingredient_first AS [Код первого ингредиента], F.Name_ingredient AS [Наименование первого ингредиента], Capacity_first AS [Объем первого ингредиента], FK_Ingredient_second AS [Код второго ингредиента], S.Name_ingredient AS [Наименование второго ингредиента], Capacity_second AS [Объем второго ингредиента], FK_Ingredient_third AS [Код третьего ингредиента], T.Name_ingredient AS [Наименование третьего ингредиента], Capacity_third AS [Объем третьего ингредиента], Dishs.Price AS [Цена], TimeCooking AS [Время приготовления] FROM ((Dishs INNER JOIN Ingredients AS F ON FK_ingredient_first = F.pk_ingredient) INNER JOIN Ingredients AS S ON FK_Ingredient_second = S.pk_ingredient) INNER JOIN Ingredients AS T ON FK_ingredient_third = T.pk_ingredient"),GV_Menu);
        }
    }
}