<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="ProcessMain.aspx.cs" Inherits="ProcessMain" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style ="position:relative; top: 0px; left: 0px; height: 463px;">
    <asp:Image ID="Image1" runat="server" Height="459px" 
        ImageUrl="~/images/Butterfly Background without light.jpg" Width="950px" />

    <asp:FileUpload ID="FileUpload1" runat="server" 
        
        
            style="top: 104px; left: 502px; position: absolute; height: 20px; width: 215px" />
    <asp:Label ID="Label1" runat="server" 
        style="position:absolute; top: 47px; left: 405px; width: 98px; height: 17px;" 
        Text="File Name"></asp:Label>
        <asp:ImageButton ID="ImageButton1" runat="server" 
        
        style="top: 159px; left: 625px; position: absolute; height: 35px; width: 94px" 
        ImageUrl="~/images/upload.png" onclick="ImageButton1_Click" />
    <asp:Label ID="Label2"  style="position:absolute; top: 108px; left: 405px;" 
        runat="server" Text="File upload"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" 
        
        
        style="top: 48px; left: 501px; position: absolute; height: 22px; width: 217px"></asp:TextBox>
        <asp:ImageButton ID="ImageButton2" runat="server" 
        ImageUrl="~/images/Next1.png" onclick="ImageButton2_Click" 
        
            style="top: 417px; left: 827px; position: absolute; height: 36px; width: 114px" />
        </div>

</div>
</asp:Content>