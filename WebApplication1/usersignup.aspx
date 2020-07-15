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
                                <enter>
                                    <img width="100px" src="images/imgs/generaluser.png" />
                                </enter>
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
                                    <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Nombre"></asp:TextBox>
                                </div>

                                <label>Apellido</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Apellido"></asp:TextBox>
                                </div>                                

                            </div>

                             <div class="col-md-6">
                                
                                 <label>Correo electrónico</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Correo electrónico"></asp:TextBox>
                                </div>

                                 <label>Fecha de Nacimiento</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="" TextMode="Date"></asp:TextBox>
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
                                    <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" placeholder="Nombre de Usuario"></asp:TextBox>
                                </div>
                                
                            </div>

                              <div class="col-md-6">

                                 <label>Contraseña</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Contraseña" TextMode="Password"></asp:TextBox>
                                </div>

                                <label>Confirmar contraseña</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Confirmar contraseña" TextMode="Password"></asp:TextBox>
                                </div>
                              </div>

                             <div class="col">

                                <%-- podemos cambiar los botones hay varios colorcitos --%>

                                <div class="form-group">
                                    <%-- falta el manejador de eventos, lo veremos en el siguiente episodio, eso es todo amigos --%>
                                    <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Registrarse" />
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
