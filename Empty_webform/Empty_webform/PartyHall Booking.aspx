<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PartyHall Booking.aspx.cs" Inherits="Empty_webform.PartyHall_Booking" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:Literal ID="ltrmsg" runat="server" Text="Please Select the service which suits you"></asp:Literal>
            <br />
            <br />
            <asp:RadioButton ID="Rb1" runat="server" GroupName="group3" Text="Hall for Marriage" />
            <br />
            <br />
            <asp:RadioButton ID="Rb2" runat="server" GroupName="group3" Text="Hall for Engagement" />
            <br />
            <br />
            <asp:RadioButton ID="Rb3" runat="server" GroupName="group3" Text="Hall for Naming Ceremony" />

            <br />
            <br />
            <asp:RadioButton ID="Rb4" runat="server" GroupName="group3" Text="Hall for Party" />
            <br />
            <br />
             <asp:Literal ID="Ltr2" runat="server" Text="Select the service, decorations will be made accordingly"></asp:Literal>
            <br />
        </div>
    </form>
</body>
</html>
