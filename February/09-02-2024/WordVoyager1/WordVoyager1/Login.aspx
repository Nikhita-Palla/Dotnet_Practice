<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WordVoyager1.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolderLogin" runat="server">
  
<section class="background-radial-gradient overflow-hidden">
  

  <div class="container px-4 py-5 px-md-5 text-center text-lg-start my-5">
    <div class="row gx-lg-5 align-items-center mb-5">
      <div class="col-lg-6 mb-5 mb-lg-0" style="z-index: 10">
        <h1 class="my-5 display-5 fw-bold ls-tight" style="color: hsl(218, 81%, 95%)">
          Explore More! <br />
          <span style="color: hsl(218, 81%, 75%)">Contribute More!</span>
        </h1>
        <p class="mb-4 opacity-70" style="color: hsl(218, 81%, 85%)">
          Lorem ipsum dolor, sit amet consectetur adipisicing elit.
          Temporibus, expedita iusto veniam atque, magni tempora mollitia
          dolorum consequatur nulla, neque debitis eos reprehenderit quasi
          ab ipsum nisi dolorem modi. Quos?
        </p>
      </div>

      <div class="col-lg-6 mb-5 mb-lg-0 position-relative">
       
        <div class="card bg-glass">
          <div class="card-body px-4 py-5 px-md-5">
            <form >
             

              <!-- Email input -->
              <div class="form-outline mb-4">
                  <label class="form-label" for="form3Example3">Email address</label>

                  <asp:TextBox class="form-control" ID="email2" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="RequiredFieldValidatorpassword" runat="server"
                        ControlToValidate="email2"
                        ErrorMessage="Email is required."
                        Display="Dynamic" />

              </div>

              <!-- Password input -->
              <div class="form-outline mb-4">
                   <label class="form-label" for="password2">Password</label>
                          
                  
                 
                  <asp:TextBox class="form-control" ID="password2" runat="server" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
                    ControlToValidate="password2"
                    ErrorMessage="Field is required."
                    Display="Dynamic" />
            </div>

                <div class="text-center pt-1 mb-4 pb-1"> <!-- Adjusted margins -->
                    <asp:Button ID="Button1" class="btn btn-primary" runat="server" Text="Login" OnClick="Button1_Click" />
                    <br />
                    <a class="text-muted" href="#!">Forgot password?</a>
                  </div>
                <div class="d-flex align-items-center justify-content-center">
                    <p class="mb-0 me-2">Don't have an account?</p>
                    <button type="button" class="btn btn-outline-primary"><a href="register.aspx" style="text-decoration:none">Create new</a></button>
                  </div>

            </form>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>

</asp:Content>
