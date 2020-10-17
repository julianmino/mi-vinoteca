<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="viewproducts.aspx.cs" Inherits="WebApplication1.viewproducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable();

        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class = "container">
        <div class = "row">
            <div class = "col-md-6 mx-auto">
                <div class="row">
                        <div class="col">
                                <center>
                                   <h3>Products List</h3>
                                </center>
                            </div>
                        </div>


                        

                       <div class="row">
                            <div class="col">
                                <asp:GridView class="table table-striped table-bordered" ID="dgvProductos" runat="server" AutoGenerateColumns="False" DataKeyNames="id_producto" DataSourceID="SqlDataSource1" OnRowDataBound="OnRowDataBound">
                                    <Columns>
                                        <asp:BoundField DataField="id_producto" HeaderText="ID" InsertVisible="False" ReadOnly="True" SortExpression="id_producto" >
                                       
                                        <FooterStyle Font-Bold="True" />
                                        </asp:BoundField>
                                       
                                        <asp:TemplateField>
                                            <ItemTemplate>
                                                <div class="conteinner fluid">
                                                    <div class="row">
                                                        <div class="col-lg-7">
                                                            <div class="row">
                                                                <div class="col-lg-12">
                                                                    <asp:Label runat="server" Text='<%# Eval("nombre") %>' ID="lblNombre" Font-Bold="True" Font-Size="Large"></asp:Label>
                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-lg-12">

                                                                    <asp:Label ID="lblTipo" runat="server" Text='<%# Eval("descripcion") %>'></asp:Label>

                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-lg-12">

                                                                    Cant ml -
                                                                    <asp:Label ID="lblml" runat="server" Font-Bold="True" Text='<%# Eval("ml") %>'></asp:Label>

                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-lg-12">

                                                                    Productor -
                                                                    <asp:Label ID="lblProductor" runat="server" Font-Bold="True" Text='<%# Eval("nombre1") %>'></asp:Label>
                                                                    &nbsp;| Vol. Alcohol %
                                                                    <asp:Label ID="lblVolAlcohol" runat="server" Font-Bold="True" Text='<%# Eval("vol_alcohol") %>'></asp:Label>
                                                                    &nbsp;|
                                                                    <asp:Label ID="Label1" runat="server" Text="IBU" OnLoad="Page_Load"></asp:Label>
                                                                    &nbsp;<asp:Label ID="lblIBU" runat="server" Font-Bold="True" Text='<%# Eval("ibu") %>'></asp:Label>

                                                                </div>
                                                            </div>
                                                            <div class="row">
                                                                <div class="col-lg-12">

                                                                    <asp:Label ID="Label2" runat="server" Text="Año -" OnLoad="Page_Load"></asp:Label>
                                                                    &nbsp;<asp:Label ID="lblAño" runat="server" Font-Bold="True" Text='<%# Eval("año") %>'></asp:Label>
                                                                    &nbsp;|
                                                                    <asp:Label ID="Label3" runat="server" Text=" Añejamiento -" OnLoad="Page_Load"></asp:Label>
                                                                    &nbsp;<asp:Label ID="lblAñejamiento" runat="server" Font-Bold="True" Text='<%# Eval("añejamiento") %>'></asp:Label>

                                                                </div>
                                                            </div>
                                                            
                                                            <div class="row">
                                                                <div class="col-lg-12">

                                                                    Precio -
                                                                    <asp:Label ID="lblPrecio" runat="server" Font-Bold="True" Text='<%# Eval("precio") %>'></asp:Label>
                                                                    &nbsp;| Stock -
                                                                    <asp:Label ID="lblStock" runat="server" Font-Bold="True" Text='<%# Eval("stock") %>'></asp:Label>

                                                                </div>
                                                            </div>

                                                        </div>
                                                        <div class="col-lg-3">
                                                            <asp:Image ID="Image" Class="img-fluid" runat="server" ImageUrl='<%# Eval("foto") %>' ImageAlign="Middle" />
                                                        </div>
                                                        <div class="col-lg-2">
                                                            <asp:LinkButton class="btn btn-primary" ID="btnAddToCart" runat="server" Width="44px" OnClick="btnAddToCart_Click"><i class="fas fa-shopping-cart"></i></i></asp:LinkButton>
                                                        </div>
                                                            
                                                    </div>
                                                </div>
                                            </ItemTemplate>
                                        </asp:TemplateField>
                                       
                                    </Columns>
                                </asp:GridView>
                                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:YaguaronEntities %>" 
                                        SelectCommand="SELECT * FROM [productos]
                                        INNER JOIN [tipo_producto]
	                                    ON productos.id_tipo = tipo_producto.id_tipo
                                        INNER JOIN [productores]
                                        ON productos.id_productor = productores.id_productor;" OnSelecting="SqlDataSource1_Selecting">
                                </asp:SqlDataSource>
                            </div>
                        </div> 

                </div>
            </div>
        </div>


</asp:Content>
