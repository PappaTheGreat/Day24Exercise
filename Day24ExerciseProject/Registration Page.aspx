<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration Page.aspx.cs" Inherits="Day24ExerciseProject.Registration_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table, tr, td {
            padding: 15px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="lblFirstName" runat="server">First Name :</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblEmailId" runat="server">Email-Id :</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtEmailId" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPassword" runat="server">Password :</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblConfirmPassword" runat="server">Confirm Password :</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblGender" runat="server">Gender :</asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtGender" runat="server"></asp:TextBox>
                    </td>
                </tr>
                
                <tr>
                    <td>
                        <asp:Button ID="btnRegister" runat="server" Text="Register User" OnClick="btnRegister_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnReset" runat="server" Text="Reset" CausesValidation="False" OnClick="btnReset_Click1" />
                    </td>
                </tr>


            </table>
        </div>
    </form>
</body>
</html>
