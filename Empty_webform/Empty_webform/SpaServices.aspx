<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SpaServices.aspx.cs" Inherits="Empty_webform.SpaServices" %>

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
            <asp:RadioButton ID="Rb1" runat="server" GroupName="group2" Text="Hair Styling" />
            <br />
            <br />
            <asp:RadioButton ID="Rb2" runat="server" GroupName="group2" Text="Massage Services" />
            <br />
            <br />
            <asp:RadioButton ID="Rb3" runat="server" GroupName="group2" Text="Bridal MakeUp" />

            <br />
            <br />
            <asp:RadioButton ID="Rb4" runat="server" GroupName="group2" Text="Pedicure and Manicure" />
            <br />
        </div>
    </form>
</body>
</html>
