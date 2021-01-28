<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Level3.aspx.cs" Inherits="Level3" %>

<script runat="server">

    
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style ="position:relative; top: 0px; left: 0px; height: 463px;">
    <asp:Image ID="Image1" runat="server" Height="459px" 
        ImageUrl="~/images/Butterfly Background without light.jpg" Width="950px" />

    <asp:Label ID="Label3" runat="server" 
        style="position:absolute; top: 74px; left: 559px;" Text="Enter Password" 
        Font-Bold="True" Font-Size="Large"></asp:Label>
    <asp:TextBox ID="TextBox2" 
        style="position:absolute; top: 132px; left: 556px; height: 41px; width: 290px;" 
        runat="server"></asp:TextBox>
    
    
        <asp:ImageButton ID="ImageButton1" runat="server" 
            ImageUrl="~/images/process.png" onclick="ImageButton1_Click" 
            
            
            style="top: 229px; position: absolute; left: 558px; height: 45px; width: 121px;" />
        <asp:Label ID="Label5" 
            style=" position: absolute; top: 334px; left: 564px; width: 306px;" 
            runat="server" Text=""></asp:Label>
  </div>
</asp:Content>