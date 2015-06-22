<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="AsignarDirector.aspx.cs" Inherits="AsignarDirector" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="idEmpleado" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:BoundField DataField="idEmpleado" HeaderText="idEmpleado" InsertVisible="False" ReadOnly="True" SortExpression="idEmpleado" />
            <asp:BoundField DataField="apellidos" HeaderText="apellidos" SortExpression="apellidos" />
            <asp:BoundField DataField="nombres" HeaderText="nombres" SortExpression="nombres" />
            <asp:BoundField DataField="sueldo" HeaderText="sueldo" SortExpression="sueldo" />
            <asp:BoundField DataField="sucursal" HeaderText="sucursal" SortExpression="sucursal" />
            <asp:BoundField DataField="departamento" HeaderText="departamento" SortExpression="departamento" />
            <asp:BoundField DataField="puesto" HeaderText="puesto" SortExpression="puesto" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" DeleteCommand="DELETE FROM [Empleado] WHERE [idEmpleado] = @idEmpleado" InsertCommand="INSERT INTO [Empleado] ([apellidos], [nombres], [sueldo], [sucursal], [departamento], [puesto]) VALUES (@apellidos, @nombres, @sueldo, @sucursal, @departamento, @puesto)" SelectCommand="SELECT * FROM [Empleado]" UpdateCommand="UPDATE [Empleado] SET [apellidos] = @apellidos, [nombres] = @nombres, [sueldo] = @sueldo, [sucursal] = @sucursal, [departamento] = @departamento, [puesto] = @puesto WHERE [idEmpleado] = @idEmpleado">
        <DeleteParameters>
            <asp:Parameter Name="idEmpleado" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="apellidos" Type="String" />
            <asp:Parameter Name="nombres" Type="String" />
            <asp:Parameter Name="sueldo" Type="Int32" />
            <asp:Parameter Name="sucursal" Type="Int32" />
            <asp:Parameter Name="departamento" Type="Int32" />
            <asp:Parameter Name="puesto" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="apellidos" Type="String" />
            <asp:Parameter Name="nombres" Type="String" />
            <asp:Parameter Name="sueldo" Type="Int32" />
            <asp:Parameter Name="sucursal" Type="Int32" />
            <asp:Parameter Name="departamento" Type="Int32" />
            <asp:Parameter Name="puesto" Type="String" />
            <asp:Parameter Name="idEmpleado" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>

