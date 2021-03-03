<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="student._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>

     <div class="Jumbothron" style="background-position: center; font-size:x-large; background-color: #000099; color: #FFFFFF; text-decoration: blink;"align="center" ForeColor="White" BackColor="#000066" >Student Information Record</div>  
        <br />
   
      
            <table class="nav-justified">
            <tr>
                <td style="height: 53px; width: 209px">Student ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td style="height: 53px">
                    <asp:TextBox ID="TextBox1" runat="server" Height="33px" style="margin-bottom: 0; margin-left: 0;" Width="176px" placeholder="Enter Integer Value"></asp:TextBox>
                </td>
                <td style="height: 53px"></td>
            </tr>
            <tr>
                <td style="height: 58px; width: 209px">Student Name</td>
                <td style="height: 58px">
                    <asp:TextBox ID="TextBox2" runat="server" Height="33px" style="margin-bottom: 0" Width="176px"></asp:TextBox>
                </td>
                <td style="height: 58px"></td>
            </tr>
            <tr>
                <td style="height: 49px; width: 209px">State</td>
                <td style="height: 49px">
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="46px" Width="191px">
                        <asp:ListItem>Select</asp:ListItem>
                        <asp:ListItem>Karnataka</asp:ListItem>
                        <asp:ListItem>tamilNadu</asp:ListItem>
                        <asp:ListItem>kerala</asp:ListItem>
                        <asp:ListItem>maharastra</asp:ListItem>
                        <asp:ListItem>AP</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td style="height: 49px"></td>
            </tr>
                 <tr>
                <td style="height: 58px; width: 209px">Age</td>
                <td style="height: 58px">
                    <asp:TextBox ID="TextBox3" runat="server" Height="33px" style="margin-bottom: 0" Width="176px" placeholder="Enter Integer Value"></asp:TextBox>
                </td>
                <td style="height: 58px"></td>
            </tr>
                 <tr>
                <td style="height: 58px; width: 209px">Contact</td>
                <td style="height: 58px">
                    <asp:TextBox ID="TextBox4" runat="server" Height="33px" style="margin-bottom: 0" Width="176px"></asp:TextBox>
                    <br />
                </td>
                <td style="height: 58px">&nbsp;</td>
            </tr>
                 
                 <tr>
                <td style="height: 58px; width: 209px">&nbsp;</td>
                <td style="height: 58px">
                    <asp:Button ID="Button1" runat="server" Text="Insert" Font-Bold="True" ForeColor="White" Height="57px" Width="126px" OnClick="Button1_Click"  BackColor="#000066" Font-Size="Medium"/> 
                   
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button2" runat="server" Text="Update" Font-Bold="True" ForeColor="White" Height="57px" Width="126px" OnClick="Button2_Click"  BackColor="#000066" Font-Size="Medium"/> 
                   
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button3" runat="server" Text="Delete" Font-Bold="True" ForeColor="White" Height="57px" Width="126px" OnClick="Button3_Click" OnClientClick="return confirm('Are you sure to Delete the record')" BackColor="#000066" Font-Size="Medium"/> 
                   
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button4" runat="server" Text="Search" Font-Bold="True" ForeColor="White" Height="57px" Width="126px" OnClick="Button4_Click"  BackColor="#000066" Font-Size="Medium"/> 
                   
                    <br />
                    <br />
                    <br />
                    <br />
                   
                    <br />
                   <%-- <asp:GridView ID="GridView1" runat="server" Height="257px" Width="722px" AllowSorting="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="Student ID" DataSourceID="SqlDataSource1" ForeColor="#333333" GridLines="None">
                        <AlternatingRowStyle BackColor="White" />
                        <Columns>
                            <asp:CommandField ShowSelectButton="True" />
                            <asp:BoundField DataField="Student ID" HeaderText="Student ID" ReadOnly="True" SortExpression="Student ID" />
                            <asp:BoundField DataField="Student Name" HeaderText="Student Name" SortExpression="Student Name" />
                            <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                            <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
                            <asp:BoundField DataField="Contact" HeaderText="Contact" SortExpression="Contact" />
                        </Columns>
                        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                        <SortedAscendingCellStyle BackColor="#FDF5AC" />
                        <SortedAscendingHeaderStyle BackColor="#4D0000" />
                        <SortedDescendingCellStyle BackColor="#FCF6C0" />
                        <SortedDescendingHeaderStyle BackColor="#820000" />
                    </asp:GridView>--%>
                    <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:programmingDBConnectionString %>" SelectCommand="SELECT * FROM [Studentinfo_Tab]"></asp:SqlDataSource>--%>
                    <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" Height="244px" Width="926px">
                        <AlternatingRowStyle BackColor="#DCDCDC" />
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
                </td>
                <td style="height: 58px">&nbsp;</td>
            </tr>
            </table>
       
        
        
       
        
    </div>
    <div>


    </div>
   

</asp:Content>
