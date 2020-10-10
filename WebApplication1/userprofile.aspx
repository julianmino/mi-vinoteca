<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userprofile.aspx.cs" Inherits="WebApplication1.userprofile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class = "container-fluid">

        <div class = "row">
            <div class = "col-md-5">
                <div class="card">
                    <div class="card-body">
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

                                <label>Apellido</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtApellido" runat="server" placeholder="Apellido"></asp:TextBox>
                                </div>

                                <label>Nombre</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtNombre" runat="server" placeholder="Nombre"></asp:TextBox>
                                </div>

                            </div>

                             <div class="col-md-6">
                                
                                 <label>Email</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server" placeholder="Email"></asp:TextBox>
                                </div>

                                 <label>Fecha de Nacimiento</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtFechaNac" runat="server" placeholder="" TextMode="Date"></asp:TextBox>
                                    <small id="birthHelp" class="form-text text-muted">Debes ser mayor de edad</small>
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

                                <label>Nombre de Usuario</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtUsuario" runat="server" placeholder="Nombre de Usuario" ReadOnly="True"></asp:TextBox>
                                </div>                               

                            </div>

                              <div class="col-md-6">

                                 <label>Contraseña actual</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtPassActual" runat="server" placeholder="Contraseña actual" TextMode="Password" ReadOnly="True"></asp:TextBox>
                                </div>

                                <label>Contraseña nueva</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtPassNueva" runat="server" placeholder="Contraseña nueva" TextMode="Password"></asp:TextBox>
                                </div>
                              </div>

                             <div class="col-md-8 mx-auto">

                                <%-- podemos cambiar los botones hay varios colorcitos --%>

                               <center>
                                <div class="form-group">
                                    <%-- falta el manejador de eventos, lo veremos en el siguiente episodio, eso es todo amigos --%>
                                    <asp:Button class="btn btn-primary btn-block btn-lg" ID="btnActualizar" runat="server" Text="Actualizar" />
                                </div>
                                </center>
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
                                    <asp:GridView class="table table-striped table-bordered" ID="dgvPedidos" runat="server">

                                    </asp:GridView>
                                </div>
                            </div>



                        </div>
                    </div>

                </div>

                <a href="homepage.aspx">Volver al inicio</a>

                </div>
                
            </div>
        

</asp:Content>
