<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente.master" AutoEventWireup="true" CodeFile="InfoPaquete.aspx.cs" Inherits="InfoPaquete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1" AutoGenerateColumns="False" DataKeyNames="idPaquete">
        <Columns>
            <asp:BoundField DataField="idPaquete" HeaderText="idPaquete" SortExpression="idPaquete" InsertVisible="False" ReadOnly="True" />
            <asp:BoundField DataField="categoria" HeaderText="categoria" SortExpression="categoria" />
            <asp:BoundField DataField="casilla" HeaderText="casilla" SortExpression="casilla" />
            <asp:BoundField DataField="precio" HeaderText="precio" SortExpression="precio" />
            <asp:BoundField DataField="peso" HeaderText="peso" SortExpression="peso" />
            <asp:BoundField DataField="estado" HeaderText="estado" SortExpression="estado" />
            <asp:BoundField DataField="estadotrayecto" HeaderText="estadotrayecto" SortExpression="estadotrayecto" />
            <asp:BoundField DataField="idCliente" HeaderText="idCliente" SortExpression="idCliente" />
            <asp:BoundField DataField="costo" HeaderText="costo" SortExpression="costo" />
            <asp:BoundField DataField="idLote" HeaderText="idLote" SortExpression="idLote" />
        </Columns>
</asp:GridView>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT * FROM [Paquete]">
    </asp:SqlDataSource>
</asp:Content>

