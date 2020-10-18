<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="homepage.aspx.cs" Inherits="WebApplication1.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container-fluid">
        <div class="row">
            <div class="col-xl-12 text-center title">
                <h1></h1>
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
                <img src="imagenes%20vinoteca/carousel-barricas-iso.jpg" class="d-block w-100" alt="..."/>
            </div>
            <div class="carousel-item">
                <img src="imagenes%20vinoteca/carousel-vinos.jpg" class="d-block w-100" alt="..."/>
            </div>
            <div class="carousel-item">
                <img src="imagenes%20vinoteca/caroussel-barricas-frente.jpg" class="d-block w-100" alt="..."/>
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
            <div class="col-md-4 text-center">
                <h2 class="first-bar"> Ver Catálogo </h2>
                <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                    Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
                    when an unknown printer took a galley of type and scrambled it to make a type specimen book.
                </p>
               <button type="button" class="btn btn-primary p first-bar" onclick="location.href='#productos';">Ver Catálogo</button>
            </div>
            <div class="col-md-4 text-center">
                <h2 class="first-bar"> Conócenos </h2>
                <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                    Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
                    when an unknown printer took a galley of type and scrambled it to make a type specimen book.
                </p>
                <button type="button" class="btn btn-primary first-bar" onclick="location.href='#contacto';">Ver nuestra historia</button> 
            </div>
            <div class="col-md-4 text-center">
                <h2 class="first-bar"> ¡Descuentos! </h2>
                <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                    Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
                    when an unknown printer took a galley of type and scrambled it to make a type specimen book.
                </p>
                <button type="button" class="btn btn-primary first-bar" >Convertite en Premium</button> 
            </div>
        </div>
    </div>

    <%-- Categorias --%>
    <a name="productos" id="productos"></a>
    <hr class="style-four"/>

    <div class="container-fluid">
        <div class="row ">
            <div class="col text-center">
                <h2><i>Nuestros Productos</i></h2>
            </div>
        </div>
        <div class="row">

            <div class="col-xl-3 col-md-4 categorias">
                    <img src="imagenes%20vinoteca/card-vinos.jpg" class="imagen" alt="..."/>
                    <h5>Vinos</h5>
                    <p>Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <a href="#" class="btn btn-primary">Ver más</a>
            </div>

            <div class="col-xl-3 col-md-4 categorias">
                    <img src="imagenes%20vinoteca/card-champagnes.jpg" class="imagen" alt="..."/>
                    <h5>Champagnes</h5>
                    <p >Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <a href="#" class="btn btn-primary">Ver más</a>
            </div>
            <div class="col-xl-3 col-md-4 categorias">
                    <img src="imagenes%20vinoteca/card-cervezas.jpg" class="imagen" alt="..."/>

                    <h5>Cervezas</h5>
                    <p>Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <a href="#" class="btn btn-primary">Ver más</a>
            </div>

            <div class="col-xl-3 col-md-4 categorias">
                    <img src="imagenes%20vinoteca/card-whiskies.jpg" class="imagen" alt="..."/>

                    <h5>Whiskies</h5>
                    <p>Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                    <a href="#" class="btn btn-primary">Ver más</a>
            </div> 
                     
        </div>

    </div>
    <%-- Frase --%>
    <hr class="style-four"/>

        <div class="container">
            <div class="row">
           
                <div class="col-xl-8">
                    <blockquote class="blockquote text-right">
                        <p class="mb-0" style="padding-top: 70px;">El vino es la luz del sol unida por el agua.</p>
                        <footer class="blockquote-footer">Galileo Galilei</footer>
                    </blockquote> 
                </div>
                <div class="col-xl-4">
                    <img src="imagenes%20vinoteca/Galileo_Galilei.svg.png" class="float-right" style="height:200px;" alt="..."/>
                </div>
            </div>
        </div>
    <%-- Contacto --%>
    <hr class="style-four"/>

    <a name="contacto" id="contacto"></a>
    <div class="container-fluid">
        <div class="row" style="padding:150px 0px;">
            <div class="col-xl-1">

            </div>
            <div class="col-xl-5">
                <h2 class="text-left">¿Quiénes somos?</h2>
                <br />
                <br />
                <h3 class="text-left">
                    Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                    Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
                    when an unknown printer took a galley of type and scrambled it to make a type specimen book.
                </h3>
                <br />
                <h3 class="text-left">
                    Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                    Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
                    when an unknown printer took a galley of type and scrambled it to make a type specimen book.
                </h3>
            </div>
            <div class="col-xl-5">
                <img src="imagenes%20vinoteca/restaurant-alcohol-bar-drinks-3540.jpg" style="width:100%;"/>
            </div>
            <div class="col-xl-1">

            </div>
        </div>
        <div class="row">
            <div class="col">
                <blockquote class="blockquote text-center">
                        <p class="mb-0"><i>"El mejor vino no es necesariamente el más caro, sino el que se comparte."</i></p>
                        <footer class="blockquote-footer">Georges Brassens</footer>
                    </blockquote>
            </div>
        </div>
    </div>
    
    <hr class="style-four" />
                    <h1></h1>

</asp:Content>
