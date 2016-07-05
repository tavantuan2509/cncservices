<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="CNCServices.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnUseCard" runat="server" OnClick="btnBuyCard_Click" Text="Use Card" />
        <br />
        <br />
        <asp:Button ID="btnGetTransaction" runat="server" OnClick="btnGetCard_Click" Text="Get Transaction" />
        <br />
        <br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
