<%@ Page Title="" Language="C#" MasterPageFile="~/Director.master" AutoEventWireup="true" CodeFile="ConsultaEmpleados.aspx.cs" Inherits="ConsultaEmpleados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="idEmpleado" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="idEmpleado" HeaderText="idEmpleado" InsertVisible="False" ReadOnly="True" SortExpression="idEmpleado" />
            <asp:BoundField DataField="apellidos" HeaderText="apellidos" SortExpression="apellidos" />
            <asp:BoundField DataField="nombres" HeaderText="nombres" SortExpression="nombres" />
            <asp:BoundField DataField="sueldo" HeaderText="sueldo" SortExpression="sueldo" />
            <asp:BoundField DataField="idsucursal" HeaderText="idsucursal" SortExpression="idsucursal" />
            <asp:BoundField DataField="iddepartamento" HeaderText="iddepartamento" SortExpression="iddepartamento" />
            <asp:BoundField DataField="puesto" HeaderText="puesto" SortExpression="puesto" />
            <asp:BoundField DataField="contraseña" HeaderText="contraseña" SortExpression="contraseña" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT * FROM [Empleado]"></asp:SqlDataSource>
</asp:Content>

