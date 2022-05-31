<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Tennisklubben.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
    <style type="text/css">
        .auto-style1 {
            height: 29px;
        }
    </style>
</head>
<body>



    <form id="form1" runat="server">



    <table align="center" style="width: 500px">
        <tr>
            <td>Username:</td>
            <td>
                <asp:TextBox ID="TextBoxUsername" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Password:</td>
            <td>
                <asp:TextBox ID="TextBoxPassword" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Name:</td>
            <td class="auto-style1">
                <asp:TextBox ID="TextBoxName" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Age:</td>
            <td>
                <asp:TextBox ID="TextBoxAge" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Adress:</td>
            <td>
                <asp:TextBox ID="TextBoxAdress" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Phone:</td>
            <td>
                <asp:TextBox ID="TextBoxPhone" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Email: </td>
            <td>
                <asp:TextBox ID="TextBoxEmail" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Reg. date</td>
            <td>
                <asp:TextBox ID="TextBoxRegDate" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Creditcard:</td>
            <td>
                <asp:TextBox ID="TextBoxCreditCard" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            </td>
        </tr>
    </table>


        <p>
</form>
</body>
</html>
