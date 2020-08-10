<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="usersignup.aspx.cs" Inherits="WebApplication1.usersingup" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class = "container">

        <div class = "row">
            <div class = "col-md-8 mx-auto">
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
                                  
                                   <h4>Registro de Usuario </h4>
                                  
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


                                <label>Nombre</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtNombre" runat="server" placeholder="Nombre"></asp:TextBox>
                                </div>

                                <label>Apellido</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtApellido" runat="server" placeholder="Apellido"></asp:TextBox>
                                </div>                                

                            </div>

                             <div class="col-md-6">
                                

                                 <label>Correo electrónico</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server" placeholder="Correo electrónico"></asp:TextBox>
                                </div>

                                 <label>Fecha de Nacimiento</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtFechaNac" runat="server" placeholder="" TextMode="Date" OnTextChanged="TextBox8_TextChanged"></asp:TextBox>
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
                                    <asp:TextBox CssClass="form-control" ID="txtUsuario" runat="server" placeholder="Nombre de Usuario"></asp:TextBox>
                                </div>

                                <label>ID Usuario</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtID" runat="server" placeholder="ID Usuario"></asp:TextBox>
                                </div>

                            </div>

                              <div class="col-md-6">

                                 <label>Contraseña</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtPassword" runat="server" placeholder="Contraseña" TextMode="Password"></asp:TextBox>
                                </div>

                                <label>Confirmar contraseña</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtConfirmPassword" runat="server" placeholder="Confirmar contraseña" TextMode="Password"></asp:TextBox>

                                </div>
                              </div>

                             <div class="col">

                                <%-- podemos cambiar los botones hay varios colorcitos --%>

                                <div class="form-group">
                                    <%-- falta el manejador de eventos, lo veremos en el siguiente episodio, eso es todo amigos --%>

                                    <asp:Button class="btn btn-success btn-block btn-lg" ID="btnRegistrar" runat="server" Text="Registrarse" />

                                </div>
                            </div>
                           </div>
                        </div>
                    </div>
              
                <a href="homepage.aspx">Volver al inicio</a>

                </div>
                
            </div>
        </div>
    

</asp:Content>
