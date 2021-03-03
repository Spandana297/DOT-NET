<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="services.aspx.cs" Inherits="Empty_webform.services" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="Service1">
    <form id="form1" runat="server">
        <div>
            <asp:Literal ID="ltrservice" runat="server"></asp:Literal>


       
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            </p>
        <p>
                <asp:RadioButton ID="service1" runat="server" GroupName="Service" Text="Book _a_room" AutoPostBack="True" OnCheckedChanged="service1_CheckedChanged" />
            </p>
        <p>
                <asp:RadioButton ID="service2" runat="server" GroupName="Service" Text="Spa_Service" AutoPostBack="True"  OnCheckedChanged="service2_CheckedChanged" />
            </p>
        <p>
                <asp:RadioButton ID="service3" runat="server" GroupName="Service" Text="Party_Hall_Booking" AutoPostBack="True" OnCheckedChanged="service3_CheckedChanged" />
            </p>
            <p>
                <asp:RadioButton ID="service4" runat="server" GroupName="Service" Text="Table Reservation" AutoPostBack="True" OnCheckedChanged="service4_CheckedChanged" />


            </p>
             </div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
