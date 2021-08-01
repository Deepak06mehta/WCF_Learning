<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeForm.aspx.cs" Inherits="WCFClient.HomeForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family:Arial">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Run WCF Service" style="margin-left: 14px" OnClick="Button1_Click" />
                <br />
               <asp:Label ID="Label1" runat="server" Text="Message From WCF Service:"></asp:Label>
        </div>
    </form>
</body>
</html>
