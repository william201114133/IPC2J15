<%@ Page Title="" Language="C#" MasterPageFile="~/EmpleadoUSA.master" AutoEventWireup="true" CodeFile="ControlEstados.aspx.cs" Inherits="ControlEstados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="idPaquete" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="idPaquete" HeaderText="idPaquete" InsertVisible="False" ReadOnly="True" SortExpression="idPaquete" />
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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" SelectCommand="SELECT * FROM [Paquete]"></asp:SqlDataSource>
</asp:Content>

