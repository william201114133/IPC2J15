<%@ Page Title="" Language="C#" MasterPageFile="~/Empleado.master" AutoEventWireup="true" CodeFile="AprobarCliente.aspx.cs" Inherits="AprobarCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="idCliente" DataSourceID="SqlDataSource1">
    <Columns>
        <asp:CommandField ShowEditButton="True" />
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
        <asp:BoundField DataField="estado" HeaderText="estado" SortExpression="estado" />
        <asp:BoundField DataField="contraseña" HeaderText="contraseña" SortExpression="contraseña" />
    </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" DeleteCommand="DELETE FROM [Cliente] WHERE [idCliente] = @idCliente" InsertCommand="INSERT INTO [Cliente] ([apellidos], [nombres], [dpi], [nit], [telefono], [direccion], [tajerta], [casilla], [idSucursal], [estado], [contraseña]) VALUES (@apellidos, @nombres, @dpi, @nit, @telefono, @direccion, @tajerta, @casilla, @idSucursal, @estado, @contraseña)" SelectCommand="SELECT * FROM [Cliente]" UpdateCommand="UPDATE [Cliente] SET [apellidos] = @apellidos, [nombres] = @nombres, [dpi] = @dpi, [nit] = @nit, [telefono] = @telefono, [direccion] = @direccion, [tajerta] = @tajerta, [casilla] = @casilla, [idSucursal] = @idSucursal, [estado] = @estado, [contraseña] = @contraseña WHERE [idCliente] = @idCliente">
    <DeleteParameters>
        <asp:Parameter Name="idCliente" Type="Int32" />
    </DeleteParameters>
    <InsertParameters>
        <asp:Parameter Name="apellidos" Type="String" />
        <asp:Parameter Name="nombres" Type="String" />
        <asp:Parameter Name="dpi" Type="Int32" />
        <asp:Parameter Name="nit" Type="Int32" />
        <asp:Parameter Name="telefono" Type="Int32" />
        <asp:Parameter Name="direccion" Type="String" />
        <asp:Parameter Name="tajerta" Type="Int32" />
        <asp:Parameter Name="casilla" Type="Int32" />
        <asp:Parameter Name="idSucursal" Type="Int32" />
        <asp:Parameter Name="estado" Type="String" />
        <asp:Parameter Name="contraseña" Type="String" />
    </InsertParameters>
    <UpdateParameters>
        <asp:Parameter Name="apellidos" Type="String" />
        <asp:Parameter Name="nombres" Type="String" />
        <asp:Parameter Name="dpi" Type="Int32" />
        <asp:Parameter Name="nit" Type="Int32" />
        <asp:Parameter Name="telefono" Type="Int32" />
        <asp:Parameter Name="direccion" Type="String" />
        <asp:Parameter Name="tajerta" Type="Int32" />
        <asp:Parameter Name="casilla" Type="Int32" />
        <asp:Parameter Name="idSucursal" Type="Int32" />
        <asp:Parameter Name="estado" Type="String" />
        <asp:Parameter Name="contraseña" Type="String" />
        <asp:Parameter Name="idCliente" Type="Int32" />
    </UpdateParameters>
</asp:SqlDataSource>
</asp:Content>

