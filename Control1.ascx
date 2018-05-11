<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Control1.ascx.cs" Inherits="seminarito.Control1" %>
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" Width="56px" />
<br />
<asp:TextBox ID="TextBox1" runat="server" Width="194px"></asp:TextBox>
<asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
<br />
<br />
<br />
<br />
<asp:TextBox ID="TextBox2" runat="server" Height="139px" Width="216px"></asp:TextBox>
<br />
<br />
<br />
<br />
<br />
Comentario<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="Nombre" HeaderText="Nombre" SortExpression="Nombre" />
            <asp:BoundField DataField="Comentario" HeaderText="Comentario" SortExpression="Comentario" />
            <asp:CommandField ShowEditButton="True" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:basemasayaConnectionString %>" SelectCommand="SELECT [Nombre], [Comentario] FROM [Tablita]"></asp:SqlDataSource>
</p>

