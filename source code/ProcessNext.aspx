<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="ProcessNext.aspx.cs" Inherits="ProcessNext" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style ="position:relative; top: 0px; left: 0px; height: 463px;">
    <asp:Image ID="Image1" runat="server" Height="459px" 
        ImageUrl="~/images/Butterfly Background without light.jpg" Width="950px" />

        <asp:ImageButton ID="ImageButton2" runat="server"         
        style="top: 311px; left: 616px; position: absolute; " 
        ImageUrl="~/images/processmain.png" onclick="ImageButton2_Click1" />

    <asp:Label ID="Label1" runat="server" 
        style="position:absolute; top: 24px; left: 14px; width: 340px;" 
        Text="File Name"></asp:Label>
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" 
        onselectedindexchanged="ListBox1_SelectedIndexChanged" Rows="10"         
            
            style="top: 55px; left: 26px; position: absolute; height: 409px; width: 345px">
    </asp:ListBox>
        <asp:ImageButton ID="ImageButton1" runat="server" 
        
        style="top: 114px; left: 380px; position: absolute; height: 35px; width: 94px" 
        ImageUrl="~/images/open.png" onclick="ImageButton1_Click" />
    <asp:Label ID="Label3"  style="position:absolute; top: 193px; left: 377px; width: 350px;" 
        runat="server">Password</asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" 
        
            style="top: 239px; left: 380px; position: absolute; height: 48px; width: 348px"></asp:TextBox>
    <asp:Label ID="Label4"  style="position:absolute; top: 12px; left: 388px; width: 325px;" 
        runat="server" Visible="False"></asp:Label>
    <asp:Label ID="Label2"  style="position:absolute; top: 56px; left: 383px; width: 325px;" 
        runat="server"></asp:Label>
        </div>
    </div>
    </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>    
        <asp:Timer ID="Timer1" runat="server" Enabled="False" 
        EnableViewState="False" Interval="100" ontick="Timer1_Tick" >
        </asp:Timer>

</div>
</asp:Content>