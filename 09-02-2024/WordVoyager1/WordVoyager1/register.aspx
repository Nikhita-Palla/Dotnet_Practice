<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="WordVoyager1.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderLogin" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderRegister" runat="server">
     
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
              
            <form  id="registrationForm" onsubmit="return validate()">
             <div class="form-outline mb-4">
            <label class="form-label" for="form3Example2">User Name</label>

            <asp:TextBox class="form-control" ID="username" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorUserName" runat="server"
    ControlToValidate="username"
    ErrorMessage="UserName is required."
    Display="Dynamic" />
        </div>

              <!-- Email input -->
              <div class="form-outline mb-4">
                  <label class="form-label" for="form3Example3">Email address</label>

                  <asp:TextBox class="form-control" ID="email" runat="server"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail" runat="server"
    ControlToValidate="email"
    ErrorMessage="Email is required."
    Display="Dynamic" />
              </div>

              <!-- Password input -->
              <div class="form-outline mb-4">
                   <label class="form-label" for="password">Password</label>

                  <asp:TextBox class="form-control" ID="password" runat="server" TextMode="Password"></asp:TextBox>
              <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword" runat="server"
    ControlToValidate="password"
    ErrorMessage="Password is required."
    Display="Dynamic" />
            </div>
                  <div class="form-outline mb-4">
       <label class="form-label" for="form3Example4">Retype Password</label>

      <asp:TextBox class="form-control" ID="repassword" runat="server" TextMode="Password"></asp:TextBox>
  <asp:RequiredFieldValidator ID="RequiredFieldValidatorRepassword" runat="server"
    ControlToValidate="repassword"
    ErrorMessage="Field is required."
    Display="Dynamic" />
</div>

                <div class="text-center pt-1 mb-4 pb-1"> <!-- Adjusted margins -->
                    
                    <asp:Button class="btn btn-primary btn-block fa-lg gradient-custom-2 mb-2" ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" /><br />
                   
                  </div>
             

            </form>
          </div>
        </div>
      </div>
    </div>
  </div>
</section>
    <script>
        var re = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        function validate() {
            var email = document.getElementById('email').value;
            if (re.test(email) == false) {
                alert("Enter valid Email!");
                return false;
            }
            else {
                return true;
            }
        }
    </script>
   
</asp:Content>
