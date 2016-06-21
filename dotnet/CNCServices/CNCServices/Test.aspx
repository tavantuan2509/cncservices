<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="CNCServices.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="btnBuyCard" runat="server" OnClick="btnBuyCard_Click" Text="Buy Card" />
        <br />
        <br />
        <asp:Button ID="btnGetCard" runat="server" OnClick="btnGetCard_Click" Text="Get Card" />
        <br />
        <br />
        <asp:Button ID="btnTopup" runat="server" OnClick="btnTopup_Click" Text="Topup" />
        <br />
        <br />
        <asp:Button ID="btnCheckTranTopup" runat="server" OnClick="btnCheckTranTopup_Click" Text="Check Transaction Topup" />
        <br />
        <br />
        <asp:Button ID="btnCheckCount" runat="server" OnClick="btnCheckCount_Click" Text="Check Count" />
        <br />
        <br />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
