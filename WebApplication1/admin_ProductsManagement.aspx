﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="admin_ProductsManagement.aspx.cs" Inherits="WebApplication1.admin_ProductsManagement" %>
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
                  <div class="row">
                     <div class="col">
                        <center>
                           <h4>Detalles del Producto</h4>
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
                        <asp:FileUpload class="form-control" ID="uploaderFoto" runat="server" />
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-md-4">
                        <label>ID Producto</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="txtIDProducto" runat="server" placeholder="ID Producto"></asp:TextBox>
                              <asp:LinkButton class="btn btn-primary" ID="btnChecked" runat="server"><i class="fas fa-check-circle"></i></asp:LinkButton>
                           </div>
                        </div>
                     </div>
                     <div class="col-md-8">
                        <label>Nombre</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtNombre" runat="server" placeholder="Nombre"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">        
                     <div class="col-md-4">
                        <label>Tipo de Producto</label>
                        <div class="form-group">
                           <asp:DropDownList class="form-control text-center" ID="dropTipos" runat="server">
                              <asp:ListItem Text="Vino" Value="Vino" />
                              <asp:ListItem Text="Cerveza" Value="Cerveza" />
                              <asp:ListItem Text="Licor" Value="Licor" />
                              <asp:ListItem Text="Whisky" Value="Whisky" />
                           </asp:DropDownList>
                        </div>
                        <label>Cantidad de Mililítros</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtMililitros" runat="server" placeholder="Mililítros" TextMode="Number"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-8">
                        <label>Productor</label>
                        <div class="form-group">
                           <asp:ListBox CssClass="form-control text-center" ID="listProductores" runat="server" SelectionMode="Multiple" Rows="5">
                              
                              
                              <asp:ListItem Text="Quilmes" Value="Quilmes" />
                              <asp:ListItem Text="Brahma" Value="Brahma" />
                              <asp:ListItem Text="Stella Artois" Value="Stella Artois" />
                              <asp:ListItem Text="Andes Origen" Value="Andes Origen" />
                              <asp:ListItem Text="Corona" Value="Corona" />
                              <asp:ListItem Text="Budweiser" Value="Budweiser" />

                               <asp:ListItem Text="Johnnie Walker" Value="Johnnie Walker" />
                               <asp:ListItem Text="Jameson" Value="Jameson" />
                               <asp:ListItem Text="Jack Daniels" Value="Jack Daniels" />
                               <asp:ListItem Text="Chivas Regal" Value="Chivas Regal" />
                               
                               <asp:ListItem Text="Santa Julia" Value="Santa Julia" />
                               <asp:ListItem Text="Luigi Bosca" Value="Luigi Bosca" />
                               <asp:ListItem Text="Rutini" Value="Rutini" />
                               <asp:ListItem Text="Alma Mora" Value="Alma Mora" />

                               <asp:ListItem Text="Cusenier" Value="Cusenier" />
                               <asp:ListItem Text="Bols" Value="Bols" />
                               <asp:ListItem Text="Tía María" Value="Tía María" />

                           </asp:ListBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                      <div class="col">
                          <hr />
                      </div>
                  </div>
                  <div class="row">
                   
                     <div class="col-md-4">
                        <label>IBU</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtIBU" runat="server" placeholder="IBU" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Año</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtAnio" runat="server" placeholder="Año" TextMode="Number" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Añejamiento</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtAniejamiento" runat="server" placeholder="Añejamiento" TextMode="Number" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>

                  </div>
                  <div class="row">
                    <div class="col-md-4">
                        <label>Volúmen de Alcohol</label>
                        <div class="form-group">
                            <asp:TextBox CssClass="form-control" ID="txtVolAlcohol" runat="server" placeholder="Vol. Alcohol" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Precio</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtPrecio" runat="server" placeholder="Precio" TextMode="Number" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Stock</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtStock" runat="server" placeholder="Stock" TextMode="Number" ReadOnly="True"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-12">
                        <label>Descripción del Producto</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtDescripcion" runat="server" placeholder="Descripción" TextMode="MultiLine" Rows="3"></asp:TextBox>
                        </div>
                     </div>
                  </div>
                  <div class="row">
                     <div class="col-4">
                        <asp:Button ID="Button1" class="btn btn-lg btn-block btn-success" runat="server" Text="Agregar" />
                     </div>
                     <div class="col-4">
                        <asp:Button ID="Button3" class="btn btn-lg btn-block btn-warning" runat="server" Text="Actualizar" />
                     </div>
                     <div class="col-4">
                        <asp:Button ID="Button2" class="btn btn-lg btn-block btn-danger" runat="server" Text="Borrar" />
                     </div>
                  </div>
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
                           <h4>Lista de Productos</h4>
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
                        <asp:GridView class="table table-striped table-bordered" ID="dgvProductos" runat="server"></asp:GridView>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </div>
</asp:Content>