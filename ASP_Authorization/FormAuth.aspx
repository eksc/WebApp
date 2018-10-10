<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FormAuth.aspx.cs" Inherits="ASP_Authorization.FormAuth"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
         <div>
             <h1 style="text-align: center">Форма авторизации</h1>
            <div style="margin-left:250px">
            <asp:Table ID="TableAuth" runat="server" HorizontalAlign="Center">
                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="L_Login" runat="server" Text="Логин"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TB_Login" runat="server"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Поле логин не может быть пустым" ControlToValidate="TB_Login"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>

                <asp:TableRow>
                    <asp:TableCell>
                        <asp:Label ID="Password" runat="server" Text="Пароль" Height="25px"></asp:Label>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="TB_Password" runat="server" TextMode="Password"></asp:TextBox>
                    </asp:TableCell>
                    <asp:TableCell>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Поле пароль не может быть пустым" ControlToValidate="TB_Password"></asp:RequiredFieldValidator>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell ColumnSpan="2" HorizontalAlign="Right">
                        <asp:Button runat="server" Text="Войти" Id="BT_In" Height="27" OnClick="BT_In_Click"/>
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
        </div>
    </form>
</body>
</html>
