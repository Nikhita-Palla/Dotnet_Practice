<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CalculationWithWCF._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        

        <div style="width:50%">
            <div style="background-color:blue;color:white;font-size:large;">Calculator Using WCF</div>
            <br />.

            <div style="color:blue;font-size:medium;font-weight:bolder">
                Number 1 : <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
                Number 2 : <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
             
            </div>
            <br />
            <div>
                <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />
                 <asp:Button ID="Button2" runat="server" Text="Subtract" OnClick="Button2_Click" />
                 <asp:Button ID="Button3" runat="server" Text="Multiply" OnClick="Button3_Click" />
                 <asp:Button ID="Button4" runat="server" Text="Divide" OnClick="Button4_Click" />
            </div><br /><br />
              <div style="color:blue;font-size:medium;font-weight:bolder">
                  Result : <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                  </div><br />
        </div>

    </main>

</asp:Content>
