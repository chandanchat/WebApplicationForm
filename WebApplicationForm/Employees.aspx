<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="WebApplicationForm.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Name:</td>
                    <td><asp:TextBox ID="txtname" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>age:</td>
                    <td><asp:TextBox ID="txtage" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td>mobile:</td>
                    <td><asp:TextBox ID="txtmobile" runat="server"></asp:TextBox></td>
                </tr>
                 <tr>
                    <td></td>
                    <td><asp:Button ID="btnsave" runat="server" Text ="save" OnClick="btninsert_Click" ></asp:Button>
                     <asp:Button ID="btnselect" runat="server" Text="show" OnClick="btnselect_Click" ></asp:Button>
                        </td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:GridView ID="grd" runat="server" ></asp:GridView></td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
