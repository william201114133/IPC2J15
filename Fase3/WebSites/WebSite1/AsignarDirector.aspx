<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AsignarDirector.aspx.cs" Inherits="AsignarDirector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="idEmpleado" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:BoundField DataField="idEmpleado" HeaderText="idEmpleado" InsertVisible="False" ReadOnly="True" SortExpression="idEmpleado" />
            <asp:BoundField DataField="nombres" HeaderText="nombres" SortExpression="nombres" />
            <asp:BoundField DataField="apellidos" HeaderText="apellidos" SortExpression="apellidos" />
            <asp:BoundField DataField="sueldo" HeaderText="sueldo" SortExpression="sueldo" />
            <asp:BoundField DataField="iddepartamento" HeaderText="iddepartamento" SortExpression="iddepartamento" />
            <asp:BoundField DataField="idsucursal" HeaderText="idsucursal" SortExpression="idsucursal" />
            <asp:BoundField DataField="puesto" HeaderText="puesto" SortExpression="puesto" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" DeleteCommand="DELETE FROM [Empleado] WHERE [idEmpleado] = @idEmpleado" InsertCommand="INSERT INTO [Empleado] ([puesto], [iddepartamento], [idsucursal], [nombres], [sueldo], [apellidos]) VALUES (@puesto, @iddepartamento, @idsucursal, @nombres, @sueldo, @apellidos)" SelectCommand="SELECT [puesto], [iddepartamento], [idsucursal], [nombres], [sueldo], [idEmpleado], [apellidos] FROM [Empleado]" UpdateCommand="UPDATE [Empleado] SET [puesto] = @puesto, [iddepartamento] = @iddepartamento, [idsucursal] = @idsucursal, [nombres] = @nombres, [sueldo] = @sueldo, [apellidos] = @apellidos WHERE [idEmpleado] = @idEmpleado">
        <DeleteParameters>
            <asp:Parameter Name="idEmpleado" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="puesto" Type="String" />
            <asp:Parameter Name="iddepartamento" Type="Int32" />
            <asp:Parameter Name="idsucursal" Type="Int32" />
            <asp:Parameter Name="nombres" Type="String" />
            <asp:Parameter Name="sueldo" Type="Int32" />
            <asp:Parameter Name="apellidos" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="puesto" Type="String" />
            <asp:Parameter Name="iddepartamento" Type="Int32" />
            <asp:Parameter Name="idsucursal" Type="Int32" />
            <asp:Parameter Name="nombres" Type="String" />
            <asp:Parameter Name="sueldo" Type="Int32" />
            <asp:Parameter Name="apellidos" Type="String" />
            <asp:Parameter Name="idEmpleado" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>

