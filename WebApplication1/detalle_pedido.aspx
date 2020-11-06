<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="detalle_pedido.aspx.cs" Inherits="WebApplication1.detalle_pedido" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col">
                <center>
                <svg width="4em" height="4em" viewBox="0 0 16 16" class="bi bi-cart-check" fill="currentColor" xmlns="http://www.w3.org/2000/svg">
                    <path fill-rule="evenodd" d="M11.354 5.646a.5.5 0 0 1 0 .708l-3 3a.5.5 0 0 1-.708 0l-1.5-1.5a.5.5 0 1 1 .708-.708L8 8.293l2.646-2.647a.5.5 0 0 1 .708 0z"/>
                    <path fill-rule="evenodd" d="M0 1.5A.5.5 0 0 1 .5 1H2a.5.5 0 0 1 .485.379L2.89 3H14.5a.5.5 0 0 1 .491.592l-1.5 8A.5.5 0 0 1 13 12H4a.5.5 0 0 1-.491-.408L2.01 3.607 1.61 2H.5a.5.5 0 0 1-.5-.5zM3.102 4l1.313 7h8.17l1.313-7H3.102zM5 12a2 2 0 1 0 0 4 2 2 0 0 0 0-4zm7 0a2 2 0 1 0 0 4 2 2 0 0 0 0-4zm-7 1a1 1 0 1 0 0 2 1 1 0 0 0 0-2zm7 0a1 1 0 1 0 0 2 1 1 0 0 0 0-2z"/>
                </svg>
             </center>
            </div>
        </div>

        <div class="row">
            <div class="col">
                <center>
                <h4>Pedido Nro
                    <asp:Label ID="lblNroPedido" runat="server"></asp:Label>
                </h4>
                <span class="badge badge-pill badge-info">Información sobre tu pedido</span>
            </center>
            </div>
        </div>

        <div class="row">
            <div class="col">
                <hr>
            </div>
        </div>
        <div class="row">
            <div class="col">
                <center>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id_pedido,id_producto" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="id_producto" HeaderText="ID Producto" ReadOnly="True" SortExpression="id_producto" />
                    <asp:BoundField DataField="nombre" HeaderText="Producto" SortExpression="nombre" />
                    <asp:BoundField DataField="nombre1" HeaderText="Productor" SortExpression="nombre1" />
                    <asp:BoundField DataField="cantidad" HeaderText="Cantidad" SortExpression="cantidad" />
                    <asp:BoundField DataField="subtotal" HeaderText="Subtotal" SortExpression="subtotal" />
                </Columns>
            </asp:GridView>
            </center>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:YaguaronEntities %>"
                    SelectCommand="SELECT * FROM [lineas_pedidos]
                               INNER JOIN productos
                                    ON productos.id_producto=lineas_pedidos.id_producto
                               INNER JOIN productores
                                    ON productores.id_productor = productos.id_productor
                               WHERE ([id_pedido] = @id_pedido)">
                    <SelectParameters>
                        <asp:SessionParameter Name="id_pedido" SessionField="nro_pedido" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>

            </div>
        </div>
        <div class="row">
            <div class="col-lg-8"></div>
            <div class="col-lg-4">
                <asp:Label ID="lblTotal" runat="server"></asp:Label>
            </div>
        </div>
        <div class="row">
            <div class="col-lg-12">
                <asp:LinkButton ID="btnReturn" class="btn btn-secondary" runat="server" OnClick="btnReturn_Click">Volver a Mi Perfil</asp:LinkButton>
            </div>
        </div>
    </div>
</asp:Content>
