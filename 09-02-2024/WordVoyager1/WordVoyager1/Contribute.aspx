<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Contribute.aspx.cs" Inherits="WordVoyager1.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolderLogin" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolderRegister" runat="server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="ContentPlaceHolderContribute" runat="server">
    <section class="background-radial-gradient overflow-hidden">
  

    <div class="container px-4 py-5 px-md-5 text-center text-lg-start my-5">
      <div class="row gx-lg-5 align-items-center mb-5">
        <div class="col-lg-6 mb-5 mb-lg-0" style="z-index: 10">
          <h1 class="my-5 display-5 fw-bold ls-tight" style="color: hsl(218, 81%, 95%)">
            Explore More! <br />
            <span style="color: hsl(218, 81%, 75%)">Contribute More!</span>
          </h1>
          <p class="mb-4 opacity-70" style="color: hsl(218, 81%, 85%)">
            Contribute to our Word voyager. 
          </p>
        </div>
  
        <div class="col-lg-6 mb-5 mb-lg-0 position-relative">
         
          <div class="card bg-glass">
            <div class="card-body px-4 py-5 px-md-5">
              <form >
               
  
                <!-- Email input -->
                <div class="form-outline mb-4">
                    <label for="articleName" class="form-label">Article Name</label>
                    <input type="text" class="form-control" id="articleName" name="articleName" required>
                </div>
  
                <!-- Password input -->
                <div class="form-outline mb-4">
                    <label for="tag" class="form-label">Tag</label>
                    <input type="text" class="form-control" id="tag" name="tag" required>
              </div>
              <div class="form-outline mb-4">
                <label for="tag" class="form-label">Content</label>
                <textarea class="form-control" id="content" name="content" rows="4" required></textarea>
          </div>

              <div class="form-outline mb-4">
                <label for="image" class="form-label">Upload Image</label>
                <input type="file" class="form-control" id="image" name="image" accept="image/*" required>
          </div>

                 <div class="text-center pt-1 mb-4 pb-1"> <!-- Adjusted margins -->
                    <button type="submit" class="btn btn-primary">Submit</button>
                      <br />
                     
                    </div>
                 
  
              </form>
              
            </div>
          </div>
        </div>
      </div>
    </div>
  </section>
   
</asp:Content>