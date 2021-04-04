
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exchange</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Convert VND to Foreign currency <br />
            <input id="txtVND" type="number" step="any" runat ="server" />VND <asp:Label ID="lblerrorVND" runat="server" Text=""></asp:Label> <br />
            Exchange to: <select id="Select1" runat ="server" >
                <option>AUST.DOLLAR</option>
                <option>EURO</option>
                <option>BRITISH POUND</option>
                <option>HONGKONG DOLLAR</option>
                <option>JAPANESE YEN</option>
                <option>SINGAPORE DOLLAR</option>
                <option>THAI BAHT</option>
                <option>US DOLLAR</option>
            </select> <br />
            Receive: <asp:Label ID="lblResult" runat="server" Text=""></asp:Label><br />
            <asp:Button ID="btnConvertToForeign" runat="server" Text="Convert" OnClick="btnConvertToForeign_Click" />
            <br />
            <br />
            <br />
            <div>
            Convert Foreign currency to VND <br />
            <input id="txtMoney" type="number" step="any" runat ="server" />
            <select id="Select2" runat ="server" >
                <option>AUST.DOLLAR</option>
                <option>EURO</option>
                <option>BRITISH POUND</option>
                <option>HONGKONG DOLLAR</option>
                <option>JAPANESE YEN</option>
                <option>SINGAPORE DOLLAR</option>
                <option>THAI BAHT</option>
                <option>US DOLLAR</option>
            </select> 
                <asp:Label ID="lblErrorMoney" runat="server" Text=""></asp:Label> <br />
             Receive: <asp:Label ID="lblReceive" runat="server" Text=""></asp:Label> <br /> 
            <asp:Button ID="btnConvertToVND" runat="server" Text="Convert" OnClick="btnConvertToVND_Click" /> 
            </div>
        </div>
    </form>
</body>
</html>
