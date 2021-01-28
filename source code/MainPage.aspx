<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="MainPage.aspx.cs" Inherits="MainPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style ="position:relative; top: 0px; left: 0px; height: 462px;">    
        <asp:Label ID="Label1" runat="server" 
            style="position:absolute; top: 132px; left: 505px; width: 91px;" 
            Text="User Name" Font-Bold="True"></asp:Label>

        <asp:TextBox ID="TextBox1" style="position:absolute; top: 131px; left: 610px; width: 171px;" 
            runat="server"></asp:TextBox>
        
        <asp:Label ID="Label2" runat="server" 
            style="position:absolute; top: 175px; left: 508px; width: 70px;" 
            Text="Password" Font-Bold="True"></asp:Label>

        <asp:TextBox ID="TextBox2" style="position:absolute; top: 171px; left: 612px; width: 169px;" 
            runat="server" TextMode="Password"></asp:TextBox>
    
        <asp:ImageButton ID="ImageButton1" runat="server" 
            
            style="left: 606px; position: absolute; height: 34px; width: 95px; top: 243px" 
            onclick="ImageButton1_Click" ImageUrl="~/images/loginbtn.png" />
    
        <asp:Label ID="Label4" runat="server" 
            style="position:absolute; top: 292px; left: 456px; width: 476px;" 
            Visible="False"></asp:Label>
    
        <asp:ImageButton ID="ImageButton2" runat="server" 
            ImageUrl="~/images/register.png" onclick="ImageButton2_Click" 
            
            style="top: 243px; left: 705px; position: absolute; height: 33px; width: 85px" />
    
    <asp:Image ID="Image1" runat="server" Height="456px" 
            ImageUrl="~/images/Butterfly Background without light.jpg" Width="957px" />
   
    </div>
<div style="position:absolute">   
   
</div>
</asp:Content>
