       <%-- design page--%>
<%--//page directive--%> 
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Empty_webform.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 240px;
        }
        .auto-style2 {
            margin-left: 520px;
        }
        .auto-style3 {
            margin-left: 560px;
        }
        .auto-style4 {
            margin-left: 0px;
            margin-right: 121px;
        }
        .auto-style6 {
            width: 1017px;
            height: 34px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
          <div class="auto-style1">
               <div class="auto-style6" style="background-position: center; font-size:x-large; background-color: #000099; color: #FFFFFF; text-decoration: blink;"align="center" ForeColor="White" BackColor="#000066" >Welcome To FEEL AT HOME Hotel</div>  
     

              <asp:Image ID="Image1" runat="server" ImageUrl="image/feel%20at%20home.jpg" Height="275px" Width="1017px" CssClass="auto-style4" />
        </div>
          

          
          <p class="auto-style2">

              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Literal ID="ltrmsg" runat="server" Text="Please Enter Your Name"></asp:Literal>
              </p>
          <p class="auto-style2">

              &nbsp;</p>
          <p class="auto-style2">

              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

              <asp:TextBox ID="Textname" runat="server" ></asp:TextBox>
              </p>
          <p class="auto-style3">
              &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
          </p>
        </form>
    </body>
</html>
