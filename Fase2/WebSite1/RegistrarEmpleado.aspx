<%@ Page Title="" Language="C#" MasterPageFile="~/Director.master" AutoEventWireup="true" CodeFile="RegistrarEmpleado.aspx.cs" Inherits="RegistrarEmpleado" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Contratrar Empleados</p>
<p>
    Apellidos:&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Width="163px"></asp:TextBox>
</p>
<p>
    Nombres:&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" Width="164px"></asp:TextBox>
</p>
<p>
    Sueldo:&nbsp;
    <asp:TextBox ID="TextBox3" runat="server" Width="179px"></asp:TextBox>
</p>
<p>
    Sucursal:&nbsp;
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
</p>
<p>
    Departamento:&nbsp;
    <asp:DropDownList ID="DropDownList2" runat="server">
    </asp:DropDownList>
</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" Text="Guardar" />
</p>
</asp:Content>

