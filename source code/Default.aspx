<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style ="position:relative; top: 0px; left: 0px; height: 462px; width: 936px;">
    <asp:Image ID="Image1" runat="server" 
        ImageUrl="~/images/Butterfly Background without light.jpg" 
            
            
            style="position: absolute; top: -4px; left: 1px; height: 461px; width: 934px;" />
    
      <asp:DataList ID="dtlist" runat="server" RepeatColumns="3" 
            BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
            CellPadding="1" CellSpacing="1" GridLines="Both"
           
            onselectedindexchanged="dtlist_SelectedIndexChanged1"             
            
            
            style="position: absolute;  height: 155px; width: 268px; top: 68px; left: 470px;"   >
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <ItemStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
            <SelectedItemStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <ItemTemplate>
               <%-- <asp: ID="Image1" runat="server" ImageUrl='<%# Eval("Path1") %>' 
                    Width="100" />--%>
                <asp:Image ID="Image1" runat="server"      ImageUrl='<%# Eval("ImagePath")%>'   Height="103px" Width="106px" />
                <asp:HyperLink ID="HyperLink1"     NavigateUrl='<%# Eval("ImageName", "~/Level3.aspx?ImageName{0}")%>'  runat="server">x</asp:HyperLink>
                <br />
            </ItemTemplate>
        </asp:DataList>
        
        <asp:Button ID="Button1" runat="server" 
            Style="position:absolute; top: 338px; left: 466px; width: 333px; height: 40px;" 
            Text="Load" onclick="Button1_Click" />
    
</div>
</asp:Content>