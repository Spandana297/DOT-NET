<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Empty_webform.Menu" %>


<div class="Jumbothron" style="background-position: center; font-size: x-large; background-color: #000099; color: #FFFFFF; text-decoration: blink;" align="center" forecolor="White" backcolor="#000066">Menu</div>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 291px;
        }

        .auto-style2 {
            width: 52%;
            height: 219px;
        }

        .auto-style3 {
            margin-left: 20px;
        }

        .auto-style4 {
            margin-left: 22px;
        }

        .auto-style5 {
            margin-left: 160px;
        }
    </style>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    
    <script type="text/javascript">
        $(document).ready(function () {
         
            $("#saveWithAjax").click(function () {
                var menu = {};
                menu.ID = $('#TextBox1').val();
                menu.Cusine_Name = $('#TextBox2').val();
                menu.Cusine_Type = $('#DropDownList1').val();
                menu.Cost = $('#TextBox3').val();
               

                $.ajax({
                    type: "POST",
                    url: "Menu.aspx/InsertRecords",
                    contentType: "application/json; charset=utf-8",
                    data: "{menu: "+JSON.stringify(menu)+"}",
                    datatype:"json",
                   success: function () {
                     
                      

                    },

                     });
            });
        })
    </script>



</head>
<body>
    <p>
        &nbsp;
    </p>
    <form id="form1" runat="server">
        <p>
            &nbsp;
        </p>
        <table class="auto-style2">
            <tr>
                <td class="auto-style1">ID</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style3" Font-Size="Medium" Height="43px" Width="423px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Cusine_Name</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style3" Font-Size="Medium" Height="43px" Width="423px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Cusine_Type</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style4" Font-Size="Medium" Width="423px">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Indian</asp:ListItem>
                        <asp:ListItem>Continental</asp:ListItem>
                        <asp:ListItem>Mexican</asp:ListItem>
                        <asp:ListItem>Thai</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Cost</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style3" Font-Size="Medium" Height="43px" Width="423px"></asp:TextBox>
                </td>
            </tr>
        </table>
        <div class="auto-style5">
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" BackColor="#003399" Font-Bold="True" ForeColor="White" Height="46px" OnClick="Button1_Click" Text="Save" Width="158px" />
          <%--  <button id="saveWithAjax" style="background-color: forestgreen; color: white; height: 45px" >Save With Ajax</button>--%>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" BackColor="#003399" Font-Bold="True" ForeColor="White" Height="46px" OnClick="Button2_Click" Text="Update" Width="158px" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
        <asp:GridView ID="GridView1" runat="server" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" DataSourceID="SqlDataSource1" Width="770px" GridLines="Vertical">
            <AlternatingRowStyle BackColor="#DCDCDC" />
            <Columns>
                <asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" />
                <asp:BoundField DataField="Cusine_Name" HeaderText="Cusine_Name" SortExpression="Cusine_Name" />
                <asp:BoundField DataField="Cusine_Type" HeaderText="Cusine_Type" SortExpression="Cusine_Type" />
                <asp:BoundField DataField="Cost" HeaderText="Cost" SortExpression="Cost" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#0000A9" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#000065" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MyAPP_dbConnectionString %>" SelectCommand="SELECT DISTINCT * FROM [Menu]"></asp:SqlDataSource>
    </form>
</body>
</html>
