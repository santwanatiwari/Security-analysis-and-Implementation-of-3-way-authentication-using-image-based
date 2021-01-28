<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Process.aspx.cs" Inherits="Process" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style ="position:relative; top: 0px; left: 0px; height: 463px;">

     <asp:DataList ID="dtlist" runat="server" RepeatColumns="3" 
            BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
            CellPadding="3" CellSpacing="2" GridLines="Both" CssClass="style1" 
            onitemcommand="dtlist_ItemCommand" 
            onselectedindexchanged="dtlist_SelectedIndexChanged"   >
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <ItemTemplate>
               <%-- <asp: ID="Image1" runat="server" ImageUrl='<%# Eval("Path1") %>' 
                    Width="100" />--%>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%# Eval("ImagePath") %>'  Width="100"  />
                <asp:LinkButton ID="LinkButton1" runat="server"   Text=' <%#"Id:"+ Eval("Tid") %>'     > LinkButton</asp:LinkButton>
                <br />
            </ItemTemplate>
        </asp:DataList>    
    <asp:Image ID="Image1" runat="server" Height="459px" 
        ImageUrl="~/images/Butterfly Background without light.jpg" Width="950px" />

       <asp:Timer ID="Timer1" runat="server" ontick="Timer1_Tick" Interval="1000">
     </asp:Timer>        
  
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
 
</div>
</asp:Content>