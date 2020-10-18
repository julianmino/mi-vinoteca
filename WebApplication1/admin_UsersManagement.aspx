
<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="admin_UsersManagement.aspx.cs" Inherits="WebApplication1.admin_UsersManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <div class="container-fluid">
                       <h1></h1>

      <div class="row">
         <div class = "col-lg-5">
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
                                   <h4>Usuario</h4>
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
                                        <div class="input-group">
                                            <asp:TextBox CssClass="form-control" ID="txtUsuario" runat="server" placeholder="Nombre de Usuario" ReadOnly="False"></asp:TextBox>      
                                            <asp:LinkButton class="btn btn-primary" ID="btnCheck" runat="server" OnClick="btnCheckPressed"><i class="fas fa-check-circle"></i></asp:LinkButton>
                                        </div>
                                    </div>  
                                </div>
                             <div class="col-md-6">
                                 <label>Estado de la cuenta</label>
                                     <div class="form-group">
                                         <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="txtEstado" runat="server" placeholder="Estado" ReadOnly="True" Font-Bold="False"></asp:TextBox>      
                                        <asp:LinkButton class="btn btn-success mr-1" ID="btnHabilitado" runat="server" OnClick="btnHabilitadoPressed" Visible="False"><i class="fas fa-check-circle"></i></asp:LinkButton>
                                        <asp:LinkButton class="btn btn-warning mr-1" ID="btnPendiente" runat="server" OnClick="btnPendientePressed" Visible="False"><i class="fas fa-pause-circle"></i></asp:LinkButton>
                                        <asp:LinkButton class="btn btn-danger mr-1" ID="btnCancelado" runat="server" OnClick="btnCanceladoPressed" Visible="False"><i class="fas fa-times-circle"></i></asp:LinkButton>
                                         </div>
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

                                <label>Apellido</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtApellido" runat="server" placeholder="Apellido" ReadOnly="True"></asp:TextBox>
                                </div>

                                <label>Nombre</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtNombre" runat="server" placeholder="Nombre" ReadOnly="True"></asp:TextBox>
                                </div>

                            </div>

                             <div class="col-md-6">
                                
                                 <label>Email</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtEmail" runat="server" placeholder="Email" ReadOnly="True"></asp:TextBox>
                                </div>

                                 <label>Fecha de Nacimiento</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="txtFechaNac" runat="server" placeholder="" ReadOnly="True"></asp:TextBox>
                                    &nbsp;</div>

                            </div>
                        </div>

                         <div class="row">
                            <div class="col">
                                <hr>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-8 mx-auto">
                                <asp:Button ID="btnBorrarUsuario" class="btn btn-lg btn-block btn-danger" runat="server" Text="Borrar Usuario" OnClick="btnBorrarUsuarioPressed" Visible="False"/>
                            </div>
                        </div>
                        </div>
                    </div>
                </div>
            <div class="col-lg-7 col-md-12">
                <div class="card">
                    <div class="card-body">
                        <div class="row">
                            <div class="col">
                            <center>
                                <h4>Listado de Usuarios</h4>
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
                               <asp:GridView class="table table-striped table-bordered table-responsive" ID="dgvUsuarios" runat="server" AutoGenerateColumns="False">
                                    <Columns>
                                        <asp:BoundField DataField="usuario" HeaderText="Usuario" />
                                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                        <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                                        <asp:BoundField DataField="email" HeaderText="Email" />
                                        <asp:BoundField DataField="fecha_nac" HeaderText="Fecha de Nacimiento" />
                                        <asp:BoundField DataField="premium" HeaderText="Premium" />
                                        <asp:BoundField DataField="id_descuento" HeaderText="ID Descuento" />
                                        <asp:BoundField DataField="estado" HeaderText="Estado" />
                                    </Columns>
                                    <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                                    <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" Wrap="True" />
                                 </asp:GridView>
                            </div>
                        </div>
                        
                    </div>
                </div>
            </div>
        </div>
    </div>
    
</asp:Content>