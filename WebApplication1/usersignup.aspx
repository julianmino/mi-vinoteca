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
                                    <img width="100px" src="images/imgs/generaluser.png" />
                                </center>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col">
                                <center>
                                   <h4>User Sign Up </h4>
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

                                <label>Surname</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox6" runat="server" placeholder="Surname"></asp:TextBox>
                                </div>

                                <label>Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server" placeholder="Name"></asp:TextBox>
                                </div>

                            </div>

                             <div class="col-md-6">
                                
                                 <label>Email</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server" placeholder="Email"></asp:TextBox>
                                </div>

                                 <label>Date of Birth</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox8" runat="server" placeholder="" TextMode="Date"></asp:TextBox>
                                    <small id="birthHelp" class="form-text text-muted">You must be over 18 years old.</small>
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

                                <label>User Name</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox7" runat="server" placeholder="User Name"></asp:TextBox>
                                </div>

                                <label>User ID</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server" placeholder="User ID"></asp:TextBox>
                                </div>

                            </div>

                              <div class="col-md-6">

                                 <label>Password</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                                </div>

                                <label>Confirm Password</label>
                                <div class="form-group">
                                    <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server" placeholder="Confirm Password" TextMode="Password"></asp:TextBox>
                                </div>
                              </div>

                             <div class="col">

                                <%-- podemos cambiar los botones hay varios colorcitos --%>

                                <div class="form-group">
                                    <%-- falta el manejador de eventos, lo veremos en el siguiente episodio, eso es todo amigos --%>
                                    <asp:Button class="btn btn-success btn-block btn-lg" ID="Button1" runat="server" Text="Sign Up" />
                                </div>
                            </div>
                           </div>
                        </div>
                    </div>

                <a href="homepage.aspx">Return to Home Page</a>

                </div>
                
            </div>
        </div>
    

</asp:Content>
