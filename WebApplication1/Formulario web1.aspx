<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Formulario web1.aspx.cs" Inherits="WebApplication1.Formulario_web1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
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

    <div class="container first-bar">
        <div class="row"> 
            <div class="col-xl-4 text-center">
                <h2> Ver Catálogo </h2>
                <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                    Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
                    when an unknown printer took a galley of type and scrambled it to make a type specimen book.
                </p>
                <button type="button" class="btn btn-primary" >Ver Catálogo</button> 
            </div>
            <div class="col-xl-4 text-center">
                <h2> Conócenos </h2>
                <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                    Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
                    when an unknown printer took a galley of type and scrambled it to make a type specimen book.
                </p>
                <button type="button" class="btn btn-primary" >Ver nuestra historia</button> 
            </div>
            <div class="col-xl-4 text-center">
                <h2> Obtené descuentos </h2>
                <p>Lorem Ipsum is simply dummy text of the printing and typesetting industry.
                    Lorem Ipsum has been the industry's standard dummy text ever since the 1500s,
                    when an unknown printer took a galley of type and scrambled it to make a type specimen book.
                </p>
                <button type="button" class="btn btn-primary" >Convertite en Premium</button> 
            </div>
        </div>
    </div>
</asp:Content>
