<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="WebApplication1.userlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class = "container">

        <div class = "row">
            <div class = "col-md-6 mx-auto">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="150" src="images/imgs/generaluser.png" />
                                </center>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col">
                                <center>
                                   <h3>Inicio de sesión </h3>
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

                                <label>Nombre de Usuario</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtUsuario" runat="server" placeholder="Nombre de usuario"></asp:TextBox>
                                </div>

                                 <label>Contraseña</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtPassword" runat="server" placeholder="Contraseña" TextMode="password"></asp:TextBox>
                                </div>

                                <%-- podemos cambiar los botones hay varios colorcitos --%>

                                <div class="form-group">
                                    <%-- falta el manejador de eventos, lo veremos en el siguiente episodio, eso es todo amigos --%>
                                    <asp:Button class="btn btn-success btn-block btn-lg" ID="btnIniciarSesion" runat="server" Text="Iniciar Sesión" OnClick="btnIniciarSesion_Click" />
                                </div>

                                 <div class="form-group">
                                    <a href="usersignup.aspx">

                                         <input class="btn btn-info btn-block btn-lg" id="btnRegistrarse" type="button" value="Registrarse" />

                                    </a>
                                </div>

                            </div>
                        </div>


                        </div>
                    </div>
                <a href="homepage.aspx"> Volver al inicio</a><br><br>
                </div>
            </div>
        </div>
    

</asp:Content>
