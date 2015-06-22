<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.master" AutoEventWireup="true" CodeFile="Inhabilitar.aspx.cs" Inherits="Inhabilitar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Impuesto</p>
<p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="idImpuesto" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:BoundField DataField="idImpuesto" HeaderText="idImpuesto" InsertVisible="False" ReadOnly="True" SortExpression="idImpuesto" />
            <asp:BoundField DataField="categoria" HeaderText="categoria" SortExpression="categoria" />
            <asp:BoundField DataField="impuesto" HeaderText="impuesto" SortExpression="impuesto" />
            <asp:BoundField DataField="estado" HeaderText="estado" SortExpression="estado" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" DeleteCommand="DELETE FROM [Impuesto] WHERE [idImpuesto] = @idImpuesto" InsertCommand="INSERT INTO [Impuesto] ([categoria], [impuesto], [estado]) VALUES (@categoria, @impuesto, @estado)" SelectCommand="SELECT * FROM [Impuesto]" UpdateCommand="UPDATE [Impuesto] SET [categoria] = @categoria, [impuesto] = @impuesto, [estado] = @estado WHERE [idImpuesto] = @idImpuesto">
        <DeleteParameters>
            <asp:Parameter Name="idImpuesto" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="categoria" Type="String" />
            <asp:Parameter Name="impuesto" Type="Int32" />
            <asp:Parameter Name="estado" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="categoria" Type="String" />
            <asp:Parameter Name="impuesto" Type="Int32" />
            <asp:Parameter Name="estado" Type="String" />
            <asp:Parameter Name="idImpuesto" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;&nbsp;
</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Costo de Envio</p>
<p>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False" DataKeyNames="idCE" DataSourceID="SqlDataSource2">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:BoundField DataField="idCE" HeaderText="idCE" InsertVisible="False" ReadOnly="True" SortExpression="idCE" />
            <asp:BoundField DataField="detalle" HeaderText="detalle" SortExpression="detalle" />
            <asp:BoundField DataField="porcentaje" HeaderText="porcentaje" SortExpression="porcentaje" />
            <asp:BoundField DataField="estado" HeaderText="estado" SortExpression="estado" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" DeleteCommand="DELETE FROM [CostoEnvio] WHERE [idCE] = @idCE" InsertCommand="INSERT INTO [CostoEnvio] ([detalle], [porcentaje], [estado]) VALUES (@detalle, @porcentaje, @estado)" SelectCommand="SELECT * FROM [CostoEnvio]" UpdateCommand="UPDATE [CostoEnvio] SET [detalle] = @detalle, [porcentaje] = @porcentaje, [estado] = @estado WHERE [idCE] = @idCE">
        <DeleteParameters>
            <asp:Parameter Name="idCE" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="detalle" Type="String" />
            <asp:Parameter Name="porcentaje" Type="Int32" />
            <asp:Parameter Name="estado" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="detalle" Type="String" />
            <asp:Parameter Name="porcentaje" Type="Int32" />
            <asp:Parameter Name="estado" Type="String" />
            <asp:Parameter Name="idCE" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</p>
<p>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Comision</p>
<p>
    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" DataKeyNames="idComision" DataSourceID="SqlDataSource3">
        <Columns>
            <asp:BoundField DataField="idComision" HeaderText="idComision" InsertVisible="False" ReadOnly="True" SortExpression="idComision" />
            <asp:BoundField DataField="detalle" HeaderText="detalle" SortExpression="detalle" />
            <asp:BoundField DataField="porcentaje" HeaderText="porcentaje" SortExpression="porcentaje" />
            <asp:BoundField DataField="estado" HeaderText="estado" SortExpression="estado" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" DeleteCommand="DELETE FROM [Comision] WHERE [idComision] = @idComision" InsertCommand="INSERT INTO [Comision] ([detalle], [porcentaje], [estado]) VALUES (@detalle, @porcentaje, @estado)" SelectCommand="SELECT * FROM [Comision]" UpdateCommand="UPDATE [Comision] SET [detalle] = @detalle, [porcentaje] = @porcentaje, [estado] = @estado WHERE [idComision] = @idComision">
        <DeleteParameters>
            <asp:Parameter Name="idComision" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="detalle" Type="String" />
            <asp:Parameter Name="porcentaje" Type="Int32" />
            <asp:Parameter Name="estado" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="detalle" Type="String" />
            <asp:Parameter Name="porcentaje" Type="Int32" />
            <asp:Parameter Name="estado" Type="String" />
            <asp:Parameter Name="idComision" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</p>
</asp:Content>

