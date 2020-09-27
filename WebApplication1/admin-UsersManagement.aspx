<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="admin-UsersManagement.aspx.cs" Inherits="WebApplication1.admin_UsersManagement" %>
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
                                    <asp:TextBox CssClass="form-control" ID="txtFechaNac" runat="server" placeholder="" TextMode="Date" ReadOnly="True"></asp:TextBox>
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
                                        <div class="input-group">
                                            <asp:TextBox CssClass="form-control" ID="txtUsuario" runat="server" placeholder="Nombre de Usuario" ReadOnly="True"></asp:TextBox>      
                                            <asp:LinkButton class="btn btn-primary" ID="btnCheck" runat="server"><i class="fas fa-check-circle"></i></asp:LinkButton>
                                        </div>
                                    </div>  
                                </div>
                             <div class="col-md-6">
                                 <label>Estado de la cuenta</label>
                                     <div class="form-group">
                                         <div class="input-group">
                                        <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="Estado" ReadOnly="True"></asp:TextBox>      
                                        <asp:LinkButton class="btn btn-success mr-1" ID="LinkButton1" runat="server"><i class="fas fa-check-circle"></i></asp:LinkButton>
                                        <asp:LinkButton class="btn btn-warning mr-1" ID="LinkButton2" runat="server"><i class="fas fa-pause-circle"></i></asp:LinkButton>
                                        <asp:LinkButton class="btn btn-danger mr-1" ID="LinkButton3" runat="server"><i class="fas fa-times-circle"></i></asp:LinkButton>
                                         </div>
                                    </div> 
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
                                <h4>Member List</h4>
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
                                        <asp:BoundField DataField="id_cliente" HeaderText="ID Cliente" />
                                        <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                        <asp:BoundField DataField="apellido" HeaderText="Apellido" />
                                        <asp:BoundField DataField="usuario" HeaderText="Usuario" />
                                        <asp:BoundField DataField="email" HeaderText="Email" />
                                        <asp:BoundField DataField="fecha_nac" HeaderText="Fecha de Nacimiento" />
                                        <asp:BoundField DataField="premium" HeaderText="Premium" />
                                        <asp:BoundField DataField="id_descuento" HeaderText="ID Descuento" />
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