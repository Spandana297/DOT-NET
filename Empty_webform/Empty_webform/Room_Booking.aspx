<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Room_Booking.aspx.cs" Inherits="Empty_webform.Room_Booking" %>

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
            <asp:RadioButton ID="Rb1" runat="server" GroupName="group1" Text="Room_for_2" />
            <br />
            <br />
            <asp:RadioButton ID="Rb2" runat="server" GroupName="group1" Text="Room_for_4" />
            <br />
            <br />
            <asp:RadioButton ID="Rb3" runat="server" GroupName="group1" Text="AC_Room_for_2" />

            <br />

            <br />
            <asp:RadioButton ID="Rb4" runat="server" GroupName="group1" Text="AC_Room_for_4" />
            <br />

        </div>
    </form>
</body>
</html>
