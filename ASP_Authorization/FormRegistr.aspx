<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="FormRegistr.aspx.cs" Inherits="ASP_Authorization.FormRegistr" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentsForm" runat="server">
    <asp:Table runat="server" HorizontalAlign="Center" Width="500">
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label1" runat="server" Text="Логин"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TB_Login" runat="server" CausesValidation="False"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Не заполнено поле логин" ControlToValidate="TB_Login"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label2" runat="server" Text="Пароль"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TB_Password" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Не заполнено поле пароль" ControlToValidate="TB_Password"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="Label3" runat="server" Text="Повторите пароль"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="TB_AgainPassword" runat="server"></asp:TextBox>
            </asp:TableCell>
            <asp:TableCell>
                <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Пароли не совпадают" ControlToCompare="TB_Password" ControlToValidate="TB_AgainPassword"></asp:CompareValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="2" HorizontalAlign="Right">
                <div style="margin-right:4px">
                    <asp:Button ID="BT_Add" runat="server" Text="Записать" OnClick="BT_Add_Click" />
                </div>
            </asp:TableCell>
        </asp:TableRow>
    </asp:Table>

</asp:Content>

