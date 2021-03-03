<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="WebApplication1.Menu" %>




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

            //$("#saveWithAjax").click(function () {
            //    var menu1 = {};// empty JS Object
            //   menu1.ID = $('#TextBox1').val();
            //   menu1.Cusine_Name = $('#TextBox2').val();
            //   menu1.Cusine_Type = $('#DropDownList1').val();
            //   menu1.Cost = $('#TextBox3').val();


            //    $.ajax({
            //        type: "POST",
            //        url: "Menu.aspx/SaveMenu",
            //        contentType: "application/json; charset=utf-8",
            //        data: '{menus:' + JSON.stringify(menu1)+'}',
            //        success: function () {
            //            let x = 2;
            //            getMenu();
            //        },
            //        failure: function (response) {
            //            alert("SaveMenu Failed : " + response.d);
            //        },
            //        error: function (XHR) {
            //            alert("SaveMenu Error : " + XHR.status);
            //        }

            //         });
            //});

            $("#saveWithAjax").click(function (e) {
                e.preventDefault();
                var postData = {
                    "ID": $('#TextBox1').val(), "cusName": $('#TextBox2').val(), "cusType": $('#DropDownList1').val(), "cost": $('#TextBox3').val()
                }
                $.ajax({
                    type: "POST",
                    url: "Menu.aspx/SaveMenuInDb",
                    contentType: "application/json; charset=utf-8",
                    data: JSON.stringify(postData),
                    dataType:"JSON",
                    success: function (data) {
                        alert(data.d);
                        getMenu();
                        return false;
                    },
                    failure: function (response) {
                        alert("SaveMenu Failed : " + response.d);
                    },
                    error: function (XHR) {
                        alert("SaveMenu Error : " + XHR.status);
                    }

                });
            });

           

           
        });

        function getMenu() {
            alert("Start getManu()");
            $.ajax({
                type: "GET",
                url: "Menu.aspx/GetMenu",
                //data: "{type:'" + JSON.stringify(type) + "'}",
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                async: true,
                success: function (data) {
                   
                    $("#Menu").show();
                    var menutable = $('#Menu tbody');
                    menutable.empty();

                    $(JSON.parse(data.d)).each(function (index, menu) {
                        menutable.append('<tr><td>' + menu.ID.trim() + '</td><td>' + menu.Cusine_Name.trim() + '</td><td>'
                            + menu.Cusine_Type.trim() + '</td><td>' + menu.Cost.trim() + '</td></tr>')

                    });
                    //$('#TextBox1').val();
                    //$('#TextBox2').val();
                    //$('#DropDownList1').val();
                    ////$('#TextBox3').val();
                    //return true;
                },
                failure: function (response) {
                    alert("GetMenu Failed : " + response.d);
                },
                error: function (XHR) {
                    alert("GetMenu Error : " + XHR.status);
                }
            });
        }
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
        <table border="1" style="border-collapse: collapse">
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

        <br />
        <br />
        <asp:Button ID="saveWithAjax" runat="server" BackColor="#003399" Font-Bold="True" ForeColor="White" Height="46px" Text="Save" Width="158px" />
        <br />
       
        <br />
        <br />


        <table id="Menu" border="1" style="border-collapse: collapse;display:none">
            <thead>
                <tr style="background-color: blue; color: white;">
                    <th>ID</th>
                    <th>Cusine_Name</th>
                    <th>Cusine_Type</th>
                    <th>Cost</th>
                </tr>
            </thead>
            <tbody style="background-color: whitesmoke; color: black;"></tbody>
        </table>

    </form>
</body>
</html>
