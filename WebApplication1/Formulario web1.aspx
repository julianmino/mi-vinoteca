<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Formulario web1.aspx.cs" Inherits="WebApplication1.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container-fluid">
        <div class="row">
            <div class="col-xl-12 text-center title">
                <h1>Mi Vinoteca</h1>
            </div>
        </div>
    </div>
    <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel" data-interval ="5000" data-pause="false">
        <ol class="carousel-indicators">
            <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
            <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
            <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner">
            <div class="carousel-item active">
                <img src="imagenes%20vinoteca/alcohol-barrel-basement-beer-434311.jpg" class="d-block w-100" alt="..."/>
            </div>
            <div class="carousel-item">
                <img src="imagenes%20vinoteca/car%202.jpg" class="d-block w-100" alt="..."/>
            </div>
            <div class="carousel-item">
                <img src="imagenes%20vinoteca/caroussel%203.jpg" class="d-block w-100" alt="..."/>
            </div>
        </div>
        <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>

    <div class="container-fluid">
        <div class="row"> 
            <div class="col-xl-4 text-center">
                <h2 class="first-bar"> Ver Catálogo </h2>
                <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                    Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
                    when an unknown printer took a galley of type and scrambled it to make a type specimen book.
                </p>
                <button type="button" class="btn btn-primary p first-bar" >Ver Catálogo</button> 
            </div>
            <div class="col-xl-4 text-center">
                <h2 class="first-bar"> Conócenos </h2>
                <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                    Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
                    when an unknown printer took a galley of type and scrambled it to make a type specimen book.
                </p>
                <button type="button" class="btn btn-primary first-bar" >Ver nuestra historia</button> 
            </div>
            <div class="col-xl-4 text-center">
                <h2 class="first-bar"> Obtené descuentos </h2>
                <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                    Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
                    when an unknown printer took a galley of type and scrambled it to make a type specimen book.
                </p>
                <button type="button" class="btn btn-primary first-bar" >Convertite en Premium</button> 
            </div>
        </div>
    </div>

    <%-- Categorias --%>
    <hr class="style-four"/>
    <div class="container-fluid">
        <div class="row">
            <div class="col-xl-2 col-md-4 categorias">
                    <img src="imagenes%20vinoteca/card%201.jpg" class="imagen" alt="..."/>
                    <h5>Vinos</h5>
                    <p>Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <a href="#" class="btn btn-primary">Ver más</a>
            </div>
            <div class="col-xl-2 col-md-4 categorias">
                    <img src="imagenes%20vinoteca/card%202.jpg" class="imagen" alt="..."/>
                    <h5>Champagnes</h5>
                    <p >Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <a href="#" class="btn btn-primary">Ver más</a>
            </div>
            <div class="col-xl-2 col-md-4 categorias">
                    <img src="imagenes%20vinoteca/card%203.jpg" class="imagen" alt="..."/>
                    <h5>Cervezas</h5>
                    <p>Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <a href="#" class="btn btn-primary">Ver más</a>
            </div>
            <div class="col-xl-2 col-md-4 categorias">
                    <img src="imagenes%20vinoteca/card%204.jpg" class="imagen" alt="..."/>
                    <h5>Whiskies</h5>
                    <p>Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <a href="#" class="btn btn-primary">Ver más</a>
            </div> 
            <div class="col-xl-2 col-md-4 categorias">
                    <img src="imagenes%20vinoteca/card%205.jpg" class="imagen" alt="..."/>                    
                    <h5>Espirituosas</h5>
                    <p>Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <a href="#" class="btn btn-primary">Ver más</a>
            </div>
            <div class="col-xl-2 col-md-4 categorias">               
                    <img src="imagenes%20vinoteca/card%202-1.jpg" class="imagen" alt="..."/>                  
                    <h5>Más Champagnes</h5>
                    <p>Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <a href="#" class="btn btn-primary">Ver más</a>                   
            </div>
        </div>
    </div>
</asp:Content>
