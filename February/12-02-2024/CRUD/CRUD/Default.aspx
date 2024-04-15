<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CRUD._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container" style="padding:15px;">
    <div class="left-pane" >
        <h3>Employee Management Form</h3>
        <form>
                  
            <div class="form-outline mb-4">
                <label class="form-label" for="nameText">Employee Name</label>
                <asp:TextBox class="form-control" ID="nameText" runat="server"></asp:TextBox>
            </div>
            <div class="form-outline mb-4">
    <label class="form-label" for="ageText">Employee Age</label>
    <asp:TextBox class="form-control" ID="ageText" runat="server"></asp:TextBox>
</div>
            <div class="form-outline mb-4">
    <label class="form-label" for="designationText">Employee Designation</label>
    <asp:TextBox class="form-control" ID="designationText" runat="server"></asp:TextBox>
</div>
           
    <div class="text-left pt-1 mb-4 pb-1">
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    </div>
        </form>
       
    </div>
       
    <div class="right-pane" >
        <!-- GridView goes here -->
        <asp:GridView runat="server" ID="GridView1" OnSelectedIndexChanged="GridView1_SelectedIndexChanged"
            AutoGenerateColumns="False" OnRowEditing="rowEdit" OnRowUpdating="rowUpdating" OnRowDeleting="rowDeleting" OnRowCancelingEdit="cancelEdit" BackColor="White">
            <Columns>
                <asp:BoundField DataField="eid" HeaderText="Employee Id" ></asp:BoundField>
                <asp:BoundField DataField="ename" HeaderText="Employee Name"></asp:BoundField>
                <asp:BoundField DataField="eage" HeaderText="Employee Age"></asp:BoundField>
                <asp:BoundField DataField="edesignation" HeaderText="Designation"></asp:BoundField>
                <asp:CommandField ShowEditButton="True" ButtonType="Button"></asp:CommandField>
                <asp:CommandField ShowDeleteButton="True" ButtonType="Button"></asp:CommandField>
            </Columns>
           
         </asp:GridView>
        
    </div>
</div>

    

</asp:Content>
