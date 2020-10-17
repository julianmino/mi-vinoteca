<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="admin_PedidosManagement.aspx.cs" Inherits="WebApplication1.admin_PedidosManagement" %>
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
         <div class="col-lg-5">
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
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" updatemode="Always">
            <ContentTemplate>
                  <div class="row">
                     <div class="col-md-4">
                        <label>ID Producto</label>
                        <div class="form-group">
                           <div class="input-group">
                              <asp:TextBox CssClass="form-control" ID="txtIDProducto" runat="server" placeholder="ID Producto" TextMode="Number"></asp:TextBox>

                              <asp:LinkButton class="btn btn-primary" ID="btnChecked" runat="server"><i class="fas fa-check-circle"></i></asp:LinkButton>
                           </div>
                        </div>
                     </div>
                   
                     <div class="col-md-8">
                        <label>Nombre</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtNombre" runat="server" placeholder="Nombre"></asp:TextBox>
                            <asp:Label ID="lblNombre" runat="server" Text="Label" ForeColor="#FF0033" Visible="False">Ingrese su nombre</asp:Label>
                        </div>
                     </div>
                  </div>
            
                  <div class="row">   
                  
                     <div class="col-md-4">
                        <label>Tipo de Producto</label>
                        <div class="form-group">
                           <asp:DropDownList class="form-control text-center" ID="dropTipos" runat="server" AutoPostBack="True">
                              <asp:ListItem Text="Vino" Value="Vino" />
                              <asp:ListItem Text="Cerveza" Value="Cerveza" />
                              <asp:ListItem Text="Licor" Value="Licor" />
                              <asp:ListItem Text="Whisky" Value="Whisky" />
                           </asp:DropDownList>
                           <asp:Label ID="lblTipo" runat="server" Text="Label" ForeColor="#FF0033" Visible="False">Seleccione un Tipo</asp:Label>
                        </div>
                        <label>Cantidad de Mililítros</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtMililitros" runat="server" placeholder="Mililítros" TextMode="Number" AutoPostBack="True"></asp:TextBox>
                           <asp:Label ID="lblMililitros" runat="server" Text="Label" ForeColor="#FF0033" Visible="False">Ingrese cantidad en mililítros</asp:Label>
                        </div>
                     </div>
                     <div class="col-md-8">
                        <label>Productor</label>
                        <div class="form-group">
                           <asp:ListBox CssClass="form-control text-center" ID="listProductores" runat="server" SelectionMode="Single" Rows="5" AutoPostBack="True">
                              
                              
                              <asp:ListItem Text="Cervecería Modelo" Value="Cervecería Modelo" Enabled="false"/>
                              <asp:ListItem Text="Cervecería y Malteria Quilmes" Value="Cervecería y Malteria Quilmes" Enabled="false"/>
                              <asp:ListItem Text="Heineken" Value="Heineken" Enabled="false"/>
                              <asp:ListItem Text="Budweiser" Value="Budweiser" Enabled="false"/>

                               <asp:ListItem Text="Jhonnie Walker" Value="Jhonnie Walker" Enabled="false"/>
                               <asp:ListItem Text="Jack Daniels" Value="Jack Daniels" Enabled="false"/>
                               
                               <asp:ListItem Text="Norton" Value="Norton" />
                               <asp:ListItem Text="Trapiche" Value="Trapiche" />
                               <asp:ListItem Text="Bodega Finca Las Moras" Value="Bodega Finca Las Moras" />
                               <asp:ListItem Text="Los Haroldos" Value="Los Haroldos" />
                               <asp:ListItem Text="Luigi Bosca" Value="Luigi Bosca" />

                               <asp:ListItem Text="Verma" Value="Verma" Enabled="false"/>
                               <asp:ListItem Text="Borgheti" Value="Borgheti" Enabled="false"/>

                           </asp:ListBox>
                           <asp:Label ID="lblProductor" runat="server" Text="Label" ForeColor="#FF0033" Visible="False">Seleccione un Productor</asp:Label>
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
                           <asp:Label ID="lblIBU" runat="server" Text="Label" ForeColor="#FF0033" Visible="False">Ingrese un IBU</asp:Label>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Año</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtAnio" runat="server" placeholder="Año" TextMode="Number" ReadOnly="False"></asp:TextBox>
                            <asp:Label ID="lblAnio" runat="server" Text="Label" ForeColor="#FF0033" Visible="False">Ingrese el año</asp:Label>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Añejamiento</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtAniejamiento" runat="server" placeholder="Añejamiento" TextMode="Number" ReadOnly="True" ></asp:TextBox>
                            <asp:Label ID="lblAniejamiento" runat="server" Text="Label" ForeColor="#FF0033" Visible="False">Ingrese el Añejamiento</asp:Label>
                        </div>
                     </div>

                  </div>
                
                  <div class="row">
                    <div class="col-md-4">
                        <label>Volúmen de Alcohol</label>
                        <div class="form-group">
                            <asp:TextBox CssClass="form-control" ID="txtVolAlcohol" runat="server" placeholder="Vol. Alcohol" AutoPostBack="True" ></asp:TextBox>
                             <asp:Label ID="lblVolAlcohol" runat="server" Text="Label" ForeColor="#FF0033" Visible="False">Ingrese el Volumen de Alcohol</asp:Label>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Precio</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtPrecio" runat="server" placeholder="Precio" TextMode="Number" AutoPostBack="True"></asp:TextBox>
                            <asp:Label ID="lblPrecio" runat="server" Text="Label" ForeColor="#FF0033" Visible="False">Ingrese el Precio</asp:Label>
                        </div>
                     </div>
                     <div class="col-md-4">
                        <label>Stock</label>
                        <div class="form-group">
                           <asp:TextBox CssClass="form-control" ID="txtStock" runat="server" placeholder="Stock" TextMode="Number" ReadOnly="False" AutoPostBack="True" ></asp:TextBox>
                            <asp:Label ID="lblStock" runat="server" Text="Label" ForeColor="#FF0033" Visible="False">Ingrese Stock</asp:Label>
                        </div>
                     </div>
                  </div>
                
                  <div class="row">
                     <div class="col-4">
                        <asp:Button ID="Button1" class="btn btn-lg btn-block btn-success" runat="server" Text="Agregar" AutoPostBack="true"/>
                     </div>
                     <div class="col-4">
                        <asp:Button ID="Button3" class="btn btn-lg btn-block btn-warning" runat="server" Text="Actualizar" AutoPostBack="true"/>
                     </div>
                     <div class="col-4">
                        <asp:Button ID="Button2" class="btn btn-lg btn-block btn-danger" runat="server" Text="Borrar" AutoPostBack="true"/>
                     </div>
                  </div>
            </ContentTemplate>
        </asp:UpdatePanel>
               </div>
            </div>
         <a href="homepage.aspx"><< Volver a la Página Principal</a>
         </div>
                   
         <div class="col-lg-7">
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
                        <asp:GridView class="table table-striped table-bordered table-responsive" ID="dgvProductos" runat="server" AutoGenerateColumns="False">
                            <Columns>
                                <asp:BoundField DataField="id_producto" HeaderText="ID Producto" />
                                <asp:BoundField DataField="nombre" HeaderText="Nombre" />
                                <asp:BoundField DataField="id_productor" HeaderText="Productor" />
                                <asp:BoundField DataField="id_tipo" HeaderText="Tipo Producto" />
                                <asp:BoundField DataField="vol_alcohol" HeaderText="Vol. Alcohol" />
                                <asp:BoundField DataField="ml" HeaderText="Cantidad en ml" />
                                <asp:BoundField DataField="precio" HeaderText="Precio" />
                                <asp:BoundField DataField="stock" HeaderText="Stock" />
                                <asp:BoundField DataField="año" HeaderText="Año" />
                                <asp:BoundField DataField="añejamiento" HeaderText="Añejamiento" />
                                <asp:BoundField DataField="ibu" HeaderText="IBU" />
                            </Columns>
                            <HeaderStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                            <RowStyle HorizontalAlign="Center" VerticalAlign="Middle" />
                         </asp:GridView>
                     </div>
                  </div>
               </div>
            </div>
         </div>
      </div>
   </div>
</asp:Content>