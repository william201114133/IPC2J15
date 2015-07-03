<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente.master" AutoEventWireup="true" CodeFile="Paquete.aspx.cs" Inherits="Paquete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; INFORMACION DE PAQUETE</p>
    <p>
        Codigo Paquete:&nbsp;&nbsp;
        <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
    </p>
<br />
Categoria de impuesto:
<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
<br />
<br />
Precio:&nbsp;
<asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
<br />
<br />
Peso aproximado:
<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
<br />
<br />
Costo a pagar:&nbsp;
<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
<br />
<br />
<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
    <Columns>
        <asp:BoundField DataField="fecha" HeaderText="fecha" SortExpression="fecha" />
        <asp:BoundField DataField="estado" HeaderText="estado" SortExpression="estado" />
    </Columns>
</asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT [fecha], [estado] FROM [Historial] WHERE ([idPaquete] = @idPaquete)">
        <SelectParameters>
            <asp:ControlParameter ControlID="Label5" Name="idPaquete" PropertyName="Text" Type="Int32" />
        </SelectParameters>
    </asp:SqlDataSource>
</asp:Content>

