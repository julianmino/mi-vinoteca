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
                                    <img width="100" src="images/imgs/generaluser.png" />
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
                                    <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ErrorMessage="Ingrese su nombre" ForeColor="#FF0033" ControlToValidate="txtNombre"></asp:RequiredFieldValidator>
                                </div>

                                <label>Apellido</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtApellido" runat="server" placeholder="Apellido"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvApellido" runat="server" ErrorMessage="Ingrese su apellido" ForeColor="#FF0033" ControlToValidate="txtApellido"></asp:RequiredFieldValidator>
                                </div>                                

                            </div>

                             <div class="col-md-6">                                

                                 <label>Correo electrónico</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server" placeholder="Correo electrónico"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ErrorMessage="Ingrese un email" ForeColor="#FF0033" ControlToValidate="txtEmail" Display="Dynamic"></asp:RequiredFieldValidator>
                                    <%--Valida el formato del mail--%>
                                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" ErrorMessage="Ingrese un email válido" ForeColor="#FF0033"
                                        ValidationExpression="^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$" Display="Dynamic"></asp:RegularExpressionValidator>
                                    <asp:Label ID="lblEmailRegistrado" runat="server" ForeColor="#FF3300" Text="Este email ya se encuentra registrado" Visible="False"></asp:Label>
                                    <br />

                                </div>

                                 <label>Fecha de Nacimiento</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtFechaNac" runat="server" placeholder="" TextMode="Date"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvFechaNac" runat="server" ErrorMessage="Ingrese su fecha de nacimiento" ForeColor="#FF0033" ControlToValidate="txtFechaNac" Display="Dynamic"></asp:RequiredFieldValidator>
                                    <asp:RangeValidator ID="rvFechaNac" runat="server" ControlToValidate="txtFechaNac" Display="Dynamic" ErrorMessage="Debe tener mas de 18 años" ForeColor="#FF0033" MinimumValue="1945-01-01" Type="Date"></asp:RangeValidator>
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
                                    <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ErrorMessage="Ingrese su usuario" ForeColor="#FF0033" ControlToValidate="txtUsuario"></asp:RequiredFieldValidator>
                                    <asp:Label ID="lblUsuario" runat="server" ForeColor="#FF0033" Text="Ese usuario ya existe" Visible="False"></asp:Label>
                                </div>                                

                            </div>

                              <div class="col-md-6">

                                 <label>Contraseña</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtPassword" runat="server" placeholder="Contraseña" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ErrorMessage="Ingrese una contraseña" ForeColor="#FF0033" ControlToValidate="txtPassword" Display="Dynamic"></asp:RequiredFieldValidator>

                                    <asp:RegularExpressionValidator ID="revPasswordValidation" runat="server" ControlToValidate="txtPassword" ErrorMessage="Ingrese una contraseña de mas de 6 caracteres" ForeColor="#FF0033"
                                        ValidationExpression=".{6,}" Display="Dynamic"></asp:RegularExpressionValidator>
                                </div>

                                <label>Confirmar contraseña</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtConfirmPassword" runat="server" placeholder="Confirmar contraseña" TextMode="Password"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvConfirmPassword" runat="server" ErrorMessage="Confirme su contraseña" ForeColor="#FF0033" ControlToValidate="txtConfirmPassword" Display="Dynamic"></asp:RequiredFieldValidator>
                                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtPassword" ControlToValidate="txtConfirmPassword" Display="Dynamic" ErrorMessage="Las contraseñas no coinciden" ForeColor="#FF0033"></asp:CompareValidator>
                                </div>
                              </div>

                             <div class="col">

                                <%-- podemos cambiar los botones hay varios colorcitos --%>

                                <div class="form-group">
                                    <%-- falta el manejador de eventos, lo veremos en el siguiente episodio, eso es todo amigos --%>

                                    <asp:Button class="btn btn-success btn-block btn-lg" ID="btnRegistrar" runat="server" Text="Registrarse" OnClick="btnRegistrar_Click" />

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
