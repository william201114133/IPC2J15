<%@ Page Title="" Language="C#" MasterPageFile="~/Director.master" AutoEventWireup="true" CodeFile="DespedirEmpleado.aspx.cs" Inherits="DespedirEmpleado" %>

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
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" DeleteCommand="DELETE FROM [Empleado] WHERE [idEmpleado] = @idEmpleado" InsertCommand="INSERT INTO [Empleado] ([apellidos], [nombres], [sueldo], [idsucursal], [iddepartamento], [puesto], [contraseña]) VALUES (@apellidos, @nombres, @sueldo, @idsucursal, @iddepartamento, @puesto, @contraseña)" SelectCommand="SELECT * FROM [Empleado]" UpdateCommand="UPDATE [Empleado] SET [apellidos] = @apellidos, [nombres] = @nombres, [sueldo] = @sueldo, [idsucursal] = @idsucursal, [iddepartamento] = @iddepartamento, [puesto] = @puesto, [contraseña] = @contraseña WHERE [idEmpleado] = @idEmpleado">
        <DeleteParameters>
            <asp:Parameter Name="idEmpleado" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="apellidos" Type="String" />
            <asp:Parameter Name="nombres" Type="String" />
            <asp:Parameter Name="sueldo" Type="Int32" />
            <asp:Parameter Name="idsucursal" Type="Int32" />
            <asp:Parameter Name="iddepartamento" Type="Int32" />
            <asp:Parameter Name="puesto" Type="String" />
            <asp:Parameter Name="contraseña" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="apellidos" Type="String" />
            <asp:Parameter Name="nombres" Type="String" />
            <asp:Parameter Name="sueldo" Type="Int32" />
            <asp:Parameter Name="idsucursal" Type="Int32" />
            <asp:Parameter Name="iddepartamento" Type="Int32" />
            <asp:Parameter Name="puesto" Type="String" />
            <asp:Parameter Name="contraseña" Type="String" />
            <asp:Parameter Name="idEmpleado" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>

