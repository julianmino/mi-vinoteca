<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="shopping_cart.aspx.cs" Inherits="WebApplication1.shopping_cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class = "container">
        <div class = "row">
            <div class = "col-md-6 mx-auto">
                <div class="row">
                        <div class="col">
                                <center>
                                   <h3>Carrito </h3>
                                </center>
                            </div>
                        </div>


                        
                <h1></h1>
                <div class="row">
                    <center>
                        <asp:GridView ID="GridView1" HeaderStyle-BackColor="#3390FF" HeaderStyle-ForeColor="White" runat="server" AutoGenerateColumns="false" OnRowEditing="GridView1_RowEditing">
                            <Columns>
                                <asp:BoundField DataField="id_producto" HeaderText="ID Producto" ReadOnly="true" />
                                <asp:BoundField DataField="producto" HeaderText="Producto" ReadOnly="true" />
                                <asp:BoundField DataField="productor" HeaderText="Productor" ReadOnly="true" />
                                <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
                                <asp:BoundField DataField="subtotal" HeaderText="Subtotal" ReadOnly="true" />
                                <asp:TemplateField>
                                    <ItemTemplate>
                                        <asp:LinkButton class="btn btn-primary" Text="Edit" runat="server" CommandName="Edit" />
                                        <asp:LinkButton class="btn btn-danger" Text="Delete" runat="server" OnClick="OnDelete" />
                                    </ItemTemplate>
                                    <EditItemTemplate>
                                        <asp:LinkButton class="btn btn-success" Text="Update" runat="server" OnClick="OnUpdate" />
                                        <asp:LinkButton class="btn btn-danger" Text="Cancel" runat="server" OnClick="OnCancel" />
                                    </EditItemTemplate>
                                </asp:TemplateField>
                            </Columns>
                        </asp:GridView>
                    </center>
                </div>
                <div class="row">
                    <div class="col-lg-2">
                        <asp:LinkButton ID="btnReturn" runat="server" OnClick="btnReturn_Click" ><-- Ir a Ver Productos</asp:LinkButton>
                    </div>
                    <div class="col-lg-6"></div>
                    <div class="col-lg-2">
                        <asp:LinkButton class="btn btn-danger" ID="BtnCancel" runat="server" OnClick="BtnCancel_Click" >Cancelar</asp:LinkButton>
                    </div>
                    <div class="col-lg-2">
                        <asp:LinkButton class="btn btn-success" ID="btnConfirm" runat="server" OnClick="btnConfirm_Click">Confirmar</asp:LinkButton>
                    </div>
                </div>
                </div>
            </div>
        </div>

</asp:Content>
