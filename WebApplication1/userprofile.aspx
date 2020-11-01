<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userprofile.aspx.cs" Inherits="WebApplication1.userprofile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();

        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container-fluid">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                            <ContentTemplate>
                                <div class="row">
                                    <div class="col">
                                        <center>
                                    <img width="100px" src="images/imgs/generaluser.png" />
                                </center>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <center>
                                   <h4>Your Profile</h4>
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

                                        <label>Nombre de Usuario</label>
                                        <div class="form-group">
                                            <asp:TextBox CssClass="form-control" ID="txtUsuario" runat="server" placeholder="Nombre de Usuario" ReadOnly="True"></asp:TextBox>
                                        </div>

                                    </div>
                                    <div class="col-md-6">

                                        <label>Estado</label>
                                        <div class="form-group">
                                            <asp:TextBox CssClass="form-control" ID="txtEstado" runat="server" placeholder="Estado" ReadOnly="True" Font-Bold="true"></asp:TextBox>
                                        </div>

                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <hr>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6">

                                        <label>Nombre</label>
                                        <div class="form-group">
                                            <asp:TextBox CssClass="form-control" ID="txtNombre" runat="server" placeholder="Nombre" ReadOnly="true"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="Ingrese su nombre" ForeColor="#FF0033" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <label>Apellido</label>
                                        <div class="form-group">
                                            <asp:TextBox CssClass="form-control" ID="txtApellido" runat="server" placeholder="Apellido" ReadOnly="true"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ErrorMessage="Ingrese su apellido" ForeColor="#FF0033" ControlToValidate="txtApellido"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col-md-6">

                                        <label>Email</label>
                                        <div class="form-group">
                                            <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server" placeholder="Email" ReadOnly="true"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="Ingrese un email" ForeColor="#FF0033" ControlToValidate="txtEmail" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <%--Valida el formato del mail--%>
                                            <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Ingrese un email válido" ForeColor="#FF0033"
                                                ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" Display="Dynamic"></asp:RegularExpressionValidator>
                                            <asp:Label ID="lblEmailRegistrado" runat="server" ForeColor="#FF3300" Text="Este email ya se encuentra registrado" Visible="False"></asp:Label>
                                        </div>
                                    </div>
                                    <div class="col-md-6">
                                        <label>Fecha de Nacimiento</label>
                                        <div class="form-group">
                                            <asp:TextBox CssClass="form-control" ID="txtFechaNac" runat="server" placeholder="" TextMode="SingleLine" ReadOnly="true"></asp:TextBox>
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                        <div class="col-md-4">
                                            <div class="form-group">
                                            <asp:Button class="btn btn-primary btn-block btn-lg" ID="btnEditarDatos" runat="server" Text="Editar Datos" OnClick="btnEditarDatos_Click" Visible="true" />
                                        </div>
                                    </div>
                                   <%-- <div class="form-group">
                                        <div class="col-md-4">
                                            <asp:Button class="btn btn-secondary btn-block btn-lg" ID="btnCancelarEdicion" runat="server" Text="Cancelar" OnClick="btnCancelarEdicion_Click" Visible="false" />
                                        </div>
                                    </div>--%>
                                        <div class="col-md-8">
                                            <div class="form-group">
                                            <asp:Button class="btn btn-success btn-block btn-lg" ID="btnConfirmarEdicion" runat="server" Text="Confirmar" OnClick="btnConfirmarEdicion_Click" Visible="false" />
                                        </div>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="col">
                                        <hr>
                                    </div>
                                </div>
                            </ContentTemplate>
                        </asp:UpdatePanel>
                        <div class="row">
                            <div class="col-md-6">
                                
                                <label>Contraseña actual</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtPassActual" runat="server" placeholder="Contraseña actual" TextMode="Password" ReadOnly="True"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Ingrese su contraseña actual" ForeColor="#FF0033" ControlToValidate="txtPassActual" Display="Dynamic" Enabled="false"></asp:RequiredFieldValidator>
                                    <asp:Label ID="lblContraseña" runat="server" ForeColor="#FF0030" Text="Contraseña incorrecta" Visible="False"></asp:Label>
                                </div>
                            </div>

                            <div class="col-md-6">
                                <label>Contraseña nueva</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtPassNueva" runat="server" placeholder="Contraseña nueva" TextMode="Password" ReadOnly="true">111111</asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvNewPassword" runat="server" ErrorMessage="Ingrese contraseña nueva" ForeColor="#FF0033" ControlToValidate="txtPassNueva" Display="Dynamic" Enabled="false"></asp:RequiredFieldValidator>
                                    <asp:RegularExpressionValidator ID="revPasswordValidation" runat="server" ControlToValidate="txtPassNueva" ErrorMessage="Ingrese una contraseña de mas de 6 caracteres" ForeColor="#FF0033"
                                        ValidationExpression=".{6,}" Display="Dynamic" Enabled="False"></asp:RegularExpressionValidator>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-12 mx-auto">
                                <small id="birthHelp" class="form-text text-muted">Si desea mantener su contraseña, ingresela dos veces</small> 
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-md-4">
                                <div class="form-group">
                                    <asp:Button class="btn btn-primary btn-block btn-lg" ID="btnActualizar" runat="server" Text="Actualizar" OnClick="btnActualizar_Click" Visible="true" />
                                </div>
                            </div>
                                <div class="col-md-8">
                                    <div class="form-group">
                                        <asp:Button class="btn btn-success btn-block btn-lg" ID="btnConfirmar" runat="server" Text="Confirmar" OnClick="btnConfirmar_Click" Visible="false" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                    <div class="col-md-7">

                        <div class="card">
                            <div class="card-body">

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
                                   <h4>Tus Pedidos</h4>
                                    <span class="badge badge-pill badge-info">Información sobre tus pedidos</span>
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
                                        <asp:GridView class="table table-striped table-bordered" ID="dgvPedidos" runat="server" AutoGenerateColumns="False" DataKeyNames="id_pedido" DataSourceID="SqlDataSource1">
                                            <Columns>
                                                <asp:BoundField DataField="id_pedido" HeaderText="Nro Pedido" InsertVisible="False" ReadOnly="True" SortExpression="id_pedido"></asp:BoundField>
                                                <asp:BoundField DataField="observaciones" HeaderText="Observaciones" SortExpression="observaciones" />
                                                <asp:BoundField DataField="fecha" HeaderText="Fecha" SortExpression="fecha" />
                                                <asp:BoundField DataField="total" HeaderText="Total" SortExpression="total" />
                                                <asp:TemplateField>
                                                    <ItemTemplate>
                                                        <asp:LinkButton class="btn btn-primary" ID="btnVerDetalle" runat="server" CommandArgument='<%#Eval("id_pedido")%>' OnClick="btnVerDetalle_Click">Ver Detalle</asp:LinkButton>
                                                    </ItemTemplate>
                                                </asp:TemplateField>

                                            </Columns>
                                        </asp:GridView>
                                        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:YaguaronEntities %>"
                                            SelectCommand="SELECT * FROM [pedidos] WHERE ([usuario] = @usuario)">
                                            <SelectParameters>
                                                <asp:SessionParameter DefaultValue="" Name="usuario" SessionField="username" Type="String" />
                                            </SelectParameters>

                                        </asp:SqlDataSource>
                                    </div>
                                </div>



                            </div>
                        </div>

                    </div>

                    <a href="homepage.aspx">Volver al inicio</a>

                </div>

            </div>
</asp:Content>
