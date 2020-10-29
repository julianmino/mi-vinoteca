<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="admin_PedidosManagement.aspx.cs" Inherits="WebApplication1.admin_PedidosManagement" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <div class="col-lg-6">
                <div class="card">
                    <div class="card-body">
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <div class="row">
                                    <div class="col">
                                        <center>
                                            <h4>Gestión de Pedidos</h4>
                                        </center>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <center>
                                            <img width="100px" src="images/imgs/publisher.png" />
                                        </center>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <hr>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6">
                                        <label>Nombre del Usuario</label>
                                        <div class="form-group">
                                            <asp:TextBox CssClass="form-control" ID="txtUsuario" runat="server" placeholder="Usuario"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <label>ID del Pedido</label>
                                        <div class="input-group">
                                            <asp:TextBox class="form-control" ID="txtIdPedido" runat="server" placeholder="ID Pedido" TextMode="Number"></asp:TextBox>
                                            <asp:LinkButton class="btn btn-primary" ID="btnChecked" runat="server" OnClick="onCheckedPressed"><i class="fas fa-check-circle"></i></asp:LinkButton>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6">
                                        <label>Nombre y Apellido</label>
                                        <div class="form-group">
                                            <asp:TextBox CssClass="form-control" ID="txtNombreYApellido" runat="server" placeholder="Nombre completo" ReadOnly="True"></asp:TextBox>
                                        </div>

                                        <label>E-mail</label>
                                        <div class="form-group">
                                            <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server" placeholder="Email" ReadOnly="True"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <label>Observaciones</label>
                                        <div class="form-group">
                                            <asp:TextBox CssClass="form-control" ID="txtObservaciones" runat="server" placeholder="Observaciones" ReadOnly="True" TextMode="MultiLine" Rows="5"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>

                                <div class="row">
                                    <div class="col">
                                        <hr>
                                    </div>
                                </div>

                                <div class="row">
                                    <div class="col-md-4">
                                        <label>Fecha que fue realizado</label>
                                        <div class="form-group">
                                            <asp:TextBox CssClass="form-control" ID="txtFecha" runat="server" placeholder="Fecha" TextMode="Date" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <label>Descuento</label>
                                        <div class="form-group">
                                            <asp:TextBox CssClass="form-control" ID="txtDescuento" runat="server" placeholder="Descuento" TextMode="Number" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                    <div class="col-md-4">
                                        <label>Total</label>
                                        <div class="form-group">
                                            <asp:TextBox CssClass="form-control" ID="txtTotal" runat="server" placeholder="Total" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>

                                <div class="row">
                                    <div class="col">
                                        <hr>
                                    </div>
                                </div>

                                <div class="row">
                                    <div class="col-6">
                                        <asp:Button ID="btnCancelar" class="btn btn-lg btn-block btn-dark" runat="server" Text="Cancelar Pedido" OnClick="onCancelarPressed"/>
                                    </div>
                                    <div class="col-6">
                                        <asp:Button ID="btnFinalizar" class="btn btn-lg btn-block btn-success" runat="server" Text="Finalizar Pedido" OnClick="onFinalizarPressed"/>
                                    </div>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                    </div>
                </div>
                <a href="homepage.aspx"><< Volver a la Página Principal</a>
            </div>

            <div class="col-lg-6">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Lista de Pedidos</h4>
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
                                <asp:GridView class="table table-striped table-bordered table-responsive" ID="dgvPedidos" runat="server" AutoGenerateColumns="False">
                                    <Columns>
                                        <asp:BoundField DataField="id_pedido" HeaderText="ID Pedido" >
                                        <ItemStyle Wrap="True" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="usuario" HeaderText="Usuario" >
                                        <HeaderStyle Wrap="False" />
                                        <ItemStyle Wrap="True" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="fecha" HeaderText="Fecha de Emisión" >
                                        <ItemStyle Wrap="True" />
                                        </asp:BoundField>
                                        <asp:BoundField DataField="total" HeaderText="Total" >
                                        <ItemStyle Wrap="True" />
                                        </asp:BoundField>
                                    </Columns>
                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                </asp:GridView>
                                </center>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <h4>Descripción del Pedido Seleccionado</h4>
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
                                <asp:GridView class="table table-striped table-bordered table-responsive" ID="dgvProductos" runat="server" AutoGenerateColumns="True">
                            <Columns>
                                <asp:BoundField DataField="id_producto" HeaderText="ID Producto" />
                                <asp:BoundField DataField="cantidad" HeaderText="Cantidad" />
                                <asp:BoundField DataField="subtotal" HeaderText="Subtotal" />
                            </Columns>
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                        </asp:GridView>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
