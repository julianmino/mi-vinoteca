<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="admin_ProducerManagement.aspx.cs" Inherits="WebApplication1.admin_ProducerManagement" %>
 
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 

        <div class="container">
                            <h1></h1>

            <div class="row">
                <div class="col-md-5">
 
                    <div class="card">
                        <div class="card-body">
 
                            <div class="row">
                                <div class="col">
                                    <center>
                                            <h4>Detalles del Productor</h4>
                                        </center>
                                </div>
                            </div>
 
                            <div class="row">
                                <div class="col">
                                    <center>
                                            <img width="100px" src="images/imgs/digital-inventory.png" />
                                    </center>
                                </div>
                            </div>
 
                            <div class="row">
                                <div class="col">
                                    <hr>
                                </div>
                            </div>
 
                <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                         <ContentTemplate>
                            <div class="row">
                                <div class="col-md-4">
                                    <label>ID del Productor</label>
                                    <div class="form-group">
                                        <div class="input-group">
                                            <asp:TextBox CssClass="form-control" ID="txtIdProductor" runat="server" placeholder="ID"></asp:TextBox>
                                            <asp:LinkButton class="btn btn-primary" ID="btnChecked" runat="server" OnClick="onCheckedPressed"><i class="fas fa-check-circle"></i></asp:LinkButton>
                                        </div>
                                    </div>
                                </div>
 
                                <div class="col-md-8">
                                    <label>Nombre del Productor</label>
                                    <div class="form-group">
                                        <asp:TextBox CssClass="form-control" ID="txtNombre" runat="server" placeholder="Nombre" OnTextChanged="onTxtChanged"></asp:TextBox>
                                         <asp:Label ID="lblNombre" runat="server" Text="Label" ForeColor="#FF0033" Visible="False">Ingrese su nombre</asp:Label>
 
                                    </div>
                                </div>
                            </div>
 
                            <div class="row">
                                <div class="col-4">
                                    <asp:Button ID="btnAgregar" class="btn btn-lg btn-block btn-success" runat="server" Text="Agregar" OnClick="onAgregarPressed"/>
                                </div>
                                <div class="col-4">
                                    <asp:Button ID="btnActualizar" class="btn btn-lg btn-block btn-warning" runat="server" Text="Actualizar" OnClick="onActualizarPressed"/>
                                </div>
                                <div class="col-4">
                                    <asp:Button ID="btnBorrar" class="btn btn-lg btn-block btn-danger" runat="server" Text="Borrar" OnClick="onBorrarPressed"/>
                                </div>
                            </div>
                    </ContentTemplate>
                </asp:UpdatePanel> 
 
                        </div>
                    </div>
 
                    <a href="homepage.aspx"><< Volver a la Página Principal</a><br>
                    <br>
                </div>
 
                <div class="col-md-7">
 
                    <div class="card">
                        <div class="card-body">
 
 
 
                            <div class="row">
                                <div class="col">
                                    <center>
                                            <h4>Lista de Productores</h4>
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
                                    <asp:GridView class="table table-striped table-bordered" ID="dgvProductores" runat="server"></asp:GridView>
                                </div>
                            </div>
 
 
                        </div>
                    </div>
 
 
                </div>
 
            </div>
        </div>
    
</asp:Content>