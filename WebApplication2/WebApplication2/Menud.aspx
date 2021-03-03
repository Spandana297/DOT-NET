<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menud.aspx.cs" Inherits="WebApplication2.Menud1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> AJAX </title>
 <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {

            $('#getmenu').click(function () {
                //var menu1 = {};// empty JS Object
                //menu1.ID = $('#TextBox1').val();
                //menu1.Cusine_Name = $('#TextBox2').val();
                //menu1.Cusine_Type = $('#DropDownList1').val();
                //menu1.Cost = $('#TextBox3').val();

                $(function () {
                    $.ajax({
                        type: "GET",
                        url: "Menud.aspx/GetMenu",
                        //data: "{type:'" + JSON.stringify(type) + "'}",
                        contentType: "application/json; charset=utf-8",
                        dataType: "json",
                        async: true,
                        success: function (data) {
                            $("#Menu").show();
                            var menutable = $('#Menu tbody');
                            menutable.empty();

                            $(JSON.parse(data.d)).each(function (index, menu) {
                                menutable.append('<tr><td>' + menu.ID.trim()+ '</td><td>' + menu.Cusine_Name.trim() + '</td><td>'
                                    + menu.Cusine_Type.trim() + '</td><td>' + menu.Cost.trim() + '</td></tr>')

                            });
                            //$('#TextBox1').val();
                            //$('#TextBox2').val();
                            //$('#DropDownList1').val();
                            //$('#TextBox3').val();
                        },
                        failure: function (response) {
                            alert("GetMenu Failed : " + response.d);
                        },
                        error: function (XHR) {
                            alert("GetMenu Error : " + XHR.status);
                        }
                    });
                });

                //$.ajax({
                //    type: 'GET',
                //    url: 'Menud.aspx/GetMenu',
                //    datatype: "json",
                   
                //    success: function (data) {
                //        var menutable = $('#Menu tbody');
                //        menutable.empty();
                      
                //        $(data).each(function (index, menu) {
                //            menutable.append('<tr><td>' + menu.ID + '</td><td>' + menu.Cusine_Name + '</td><td>'
                //                + menu.Cusine_Type + '</td><td>' + menu.Cost + '</td></tr>')

                //        });
                //        $('#TextBox1').val();
                //        $('#TextBox2').val();
                //        $('#DropDownList1').val();
                //        $('#TextBox3').val();


                //    },
                //    error: function (er) {
                //        alert(er);
                //    },

                //});

            });
        });
    </script>


    <meta charset="utf-8" />
  
</head>
<body>
    <input type="button" id="getmenu" value="Get Menu" />
    <br />
    <br />
    <table id="Menu" border="1" style="border-collapse:collapse;display:none" >
        <thead>
            <tr style="background-color:blue;color:white;">
                <th>ID</th>
                <th>Cusine_Name</th>
                <th>Cusine_Type</th>
                <th>Cost</th>
            </tr>
        </thead>
        <tbody style="background-color:whitesmoke;color:black;"></tbody>
    </table>
</body>
</html>
