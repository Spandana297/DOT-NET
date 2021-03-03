<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="student.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <table class="nav-justified" style="margin-top: 0px;">
        <tr>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <td style="height: 76px; width: 196px">StudentID</td>
            <td style="height: 76px">
                <asp:TextBox ID="TextBox2" runat="server" Font-Size="Medium" Height="52px" Width="265px"></asp:TextBox>
            </td>
            <td style="height: 76px"></td>
        </tr>
        <tr>
            <td style="height: 86px; width: 196px">Student_Percentage</td>
            <td style="height: 86px">
                <asp:TextBox ID="TextBox3" runat="server" Font-Size="Medium" Height="52px" Width="265px"></asp:TextBox>
            </td>
            <td style="height: 86px">&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 86px; width: 196px">&nbsp;</td>
            <td style="height: 86px">
                <asp:Button ID="Button1" runat="server" BackColor="#663300" ForeColor="White" Height="61px" OnClick="Button1_Click" Text="Save" Width="255px" />
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Height="257px" Width="310px">
                    <Columns>
                        <asp:BoundField DataField="StudentID" HeaderText="StudentID" SortExpression="StudentID" />
                        <asp:BoundField DataField="Student_Percentage" HeaderText="Student_Percentage" SortExpression="Student_Percentage" />
                    </Columns>
                </asp:GridView>
                <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource3" Height="257px" style="margin-top: 0px" Width="752px">
                    <Columns>
                        <asp:BoundField DataField="StudentID" HeaderText="StudentID" SortExpression="StudentID" />
                        <asp:BoundField DataField="StudentName" HeaderText="StudentName" SortExpression="StudentName" />
                        <asp:BoundField DataField="State" HeaderText="State" SortExpression="State" />
                        <asp:BoundField DataField="Age" HeaderText="Age" SortExpression="Age" />
                        <asp:BoundField DataField="Contact" HeaderText="Contact" SortExpression="Contact" />
                        <asp:BoundField DataField="Student_Percentage" HeaderText="Student_Percentage" SortExpression="Student_Percentage" />
                    </Columns>
                </asp:GridView>
                <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:programmingDBConnectionString %>" SelectCommand="SELECT Studentinfo_Tab.StudentID, Studentinfo_Tab.StudentName, Studentinfo_Tab.State, Studentinfo_Tab.Age, Studentinfo_Tab.Contact, Studen_Marks.Student_Percentage FROM Studentinfo_Tab RIGHT OUTER JOIN Studen_Marks ON Studentinfo_Tab.StudentID = Studen_Marks.StudentID"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:programmingDBConnectionString %>" SelectCommand="SELECT * FROM [Studen_Marks] ORDER BY [StudentID]"></asp:SqlDataSource>
            </td>
            <td style="height: 86px">&nbsp;</td>
        </tr>
    </table>

    <div>

    <div>


















    </div>
















    </div>


















    </asp:Content>
