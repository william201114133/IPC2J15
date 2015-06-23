<%@ Page Title="" Language="C#" MasterPageFile="~/Cliente.master" AutoEventWireup="true" CodeFile="EditaCliente.aspx.cs" Inherits="EditaCliente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; EDITAR PERFIL</p>
<p>
    Nombre:&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Width="158px"></asp:TextBox>
</p>
<p>
    Apellido:
    <asp:TextBox ID="TextBox5" runat="server" Width="158px"></asp:TextBox>
</p>
<p>
    DPI:
    <asp:TextBox ID="TextBox6" runat="server" Width="192px"></asp:TextBox>
</p>
<p>
    Nit:&nbsp;
    <asp:TextBox ID="TextBox7" runat="server" Width="197px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server"></asp:Label>
</p>
<p>
    Direccion:&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" Width="160px"></asp:TextBox>
</p>
<p>
    Telefono:
    <asp:TextBox ID="TextBox3" runat="server" Width="172px"></asp:TextBox>
</p>
<p>
    Tarjeta de Debito:&nbsp;
    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
</p>
    <p>
        Contraseña:
        <asp:TextBox ID="TextBox8" runat="server" Width="163px"></asp:TextBox>
</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" Text="Modificar" OnClick="Button1_Click" />
</p>
</asp:Content>

