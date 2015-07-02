<%@ Page Title="" Language="C#" MasterPageFile="~/Empleado.master" AutoEventWireup="true" CodeFile="BuscarCliente.aspx.cs" Inherits="BuscarCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="idCliente" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="idCliente" HeaderText="idCliente" InsertVisible="False" ReadOnly="True" SortExpression="idCliente" />
            <asp:BoundField DataField="apellidos" HeaderText="apellidos" SortExpression="apellidos" />
            <asp:BoundField DataField="nombres" HeaderText="nombres" SortExpression="nombres" />
            <asp:BoundField DataField="dpi" HeaderText="dpi" SortExpression="dpi" />
            <asp:BoundField DataField="nit" HeaderText="nit" SortExpression="nit" />
            <asp:BoundField DataField="telefono" HeaderText="telefono" SortExpression="telefono" />
            <asp:BoundField DataField="direccion" HeaderText="direccion" SortExpression="direccion" />
            <asp:BoundField DataField="tajerta" HeaderText="tajerta" SortExpression="tajerta" />
            <asp:BoundField DataField="casilla" HeaderText="casilla" SortExpression="casilla" />
            <asp:BoundField DataField="idSucursal" HeaderText="idSucursal" SortExpression="idSucursal" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT * FROM [Cliente]"></asp:SqlDataSource>
</asp:Content>

