<%@ Page Title="" Language="C#" MasterPageFile="~/Bodega.master" AutoEventWireup="true" CodeFile="ReportePerdido.aspx.cs" Inherits="ReportePerdido" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="idPaquete" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:CommandField ShowEditButton="True" />
            <asp:BoundField DataField="idPaquete" HeaderText="idPaquete" InsertVisible="False" ReadOnly="True" SortExpression="idPaquete" />
            <asp:BoundField DataField="categoria" HeaderText="categoria" SortExpression="categoria" />
            <asp:BoundField DataField="casilla" HeaderText="casilla" SortExpression="casilla" />
            <asp:BoundField DataField="precio" HeaderText="precio" SortExpression="precio" />
            <asp:BoundField DataField="peso" HeaderText="peso" SortExpression="peso" />
            <asp:BoundField DataField="estado" HeaderText="estado" SortExpression="estado" />
            <asp:BoundField DataField="estadotrayecto" HeaderText="estadotrayecto" SortExpression="estadotrayecto" />
            <asp:BoundField DataField="idCliente" HeaderText="idCliente" SortExpression="idCliente" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QuetzalExpressConnectionString %>" DeleteCommand="DELETE FROM [Paquete] WHERE [idPaquete] = @idPaquete" InsertCommand="INSERT INTO [Paquete] ([categoria], [casilla], [precio], [peso], [estado], [estadotrayecto], [idCliente]) VALUES (@categoria, @casilla, @precio, @peso, @estado, @estadotrayecto, @idCliente)" SelectCommand="SELECT * FROM [Paquete]" UpdateCommand="UPDATE [Paquete] SET [categoria] = @categoria, [casilla] = @casilla, [precio] = @precio, [peso] = @peso, [estado] = @estado, [estadotrayecto] = @estadotrayecto, [idCliente] = @idCliente WHERE [idPaquete] = @idPaquete">
        <DeleteParameters>
            <asp:Parameter Name="idPaquete" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="categoria" Type="String" />
            <asp:Parameter Name="casilla" Type="Int32" />
            <asp:Parameter Name="precio" Type="Int32" />
            <asp:Parameter Name="peso" Type="Int32" />
            <asp:Parameter Name="estado" Type="String" />
            <asp:Parameter Name="estadotrayecto" Type="String" />
            <asp:Parameter Name="idCliente" Type="Int32" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="categoria" Type="String" />
            <asp:Parameter Name="casilla" Type="Int32" />
            <asp:Parameter Name="precio" Type="Int32" />
            <asp:Parameter Name="peso" Type="Int32" />
            <asp:Parameter Name="estado" Type="String" />
            <asp:Parameter Name="estadotrayecto" Type="String" />
            <asp:Parameter Name="idCliente" Type="Int32" />
            <asp:Parameter Name="idPaquete" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>
</asp:Content>

