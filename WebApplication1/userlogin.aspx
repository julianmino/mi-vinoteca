﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="userlogin.aspx.cs" Inherits="WebApplication1.userlogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class = "container">
                        <h1></h1>

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

                                <label>Nombre de Usuario</label><asp:TextBox CssClass="form-control" ID="txtUsuario" runat="server" placeholder="Nombre de usuario"></asp:TextBox>
                                <div class="form-group">
                                    <asp:Label ID="lblUsuario" runat="server" ForeColor="#FF0030" Text="Ese usuario no existe" Visible="False"></asp:Label>
                                </div>

                                 <label>Contraseña</label><asp:TextBox CssClass="form-control" ID="txtPassword" runat="server" placeholder="Contraseña" TextMode="password"></asp:TextBox>
                                <div class="form-group">

                                 <label>
                                    <asp:Label ID="lblContraseña" runat="server" ForeColor="#FF0030" Text="Contraseña incorrecta" Visible="False"></asp:Label>
                                    </label>
                                </div>


                                <div class="form-group">
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
