<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Modify.aspx.cs" Inherits="Modify" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style ="position:relative; top: 0px; left: 0px; height: 463px;">
        <asp:Button ID="Button1" runat="server" 
            style="position: absolute; top: 432px; left: 480px; height: 26px; width: 197px" 
            Text="Process" />
    <asp:Image ID="Image1" runat="server" Height="459px" 
        ImageUrl="~/images/Butterfly Background without light.jpg" Width="950px" />
     <asp:DataList ID="dtlist" runat="server"  
     Style="position :absolute; height : 48px; width: 216px; left: 616px; top: 72px;" 
         RepeatColumns="5" 
             CellPadding="1" CellSpacing="1" GridLines="Horizontal" 
            BorderStyle="Double" onitemcommand="dtlist_ItemCommand" >
        <ItemTemplate>
            <asp:ImageButton ID="Image5" runat="server" CommandName="Load"
               ImageUrl='<%# Eval("Path1") %>' PostBackUrl="Level3.aspx" Width="50" />
            <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# Eval("pa1", "~/Level3.aspx?pa1{0}")%>'  runat="server">x</asp:HyperLink>                
            <asp:CheckBox ID="CheckBox1" runat="server" Visible="False" />
        </ItemTemplate>       
    </asp:DataList>    
      <asp:DataList ID="DataList1" runat="server"  Style="position :absolute; height : 34px; width: 278px; left: 615px; top: 204px; margin-top: 0px;" 
        RepeatColumns="5" 
             CellPadding="1" CellSpacing="1" GridLines="Horizontal" 
            BorderStyle="Double" onitemcommand="DataList1_ItemCommand">
        <ItemTemplate>
            <asp:ImageButton ID="Image2" runat="server" CommandName="Load"
               ImageUrl='<%# Eval("Path2") %>' PostBackUrl="Level3.aspx"
                 Width="50" />
                 <asp:HyperLink ID="HyperLink1"     NavigateUrl='<%# Eval("pa2", "~/Level3.aspx?pa2{0}")%>'  runat="server">x</asp:HyperLink>
            <asp:CheckBox ID="CheckBox6" runat="server" Visible="False" />
        </ItemTemplate>
       
    </asp:DataList>
          <asp:DataList ID="DataList2" runat="server"  
          Style="position :absolute; height : 23px; width: 241px; left: 306px; top: 330px;" 
        RepeatColumns="5" 
             CellPadding="1" CellSpacing="1" GridLines="Both" BorderStyle="Double" 
            onitemcommand="DataList2_ItemCommand">
        <ItemTemplate>
            <asp:ImageButton ID="Image4" runat="server" CommandName="Load"
               ImageUrl='<%# Eval("Path5") %>' PostBackUrl="Level3.aspx"
                 Width="50" />
           <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# Eval("pa5", "~/Level3.aspx?pa5{0}")%>'  runat="server">x</asp:HyperLink>
            <asp:CheckBox ID="CheckBox4" runat="server" Visible="False" />
        </ItemTemplate>
       
    </asp:DataList>
    
      <asp:DataList ID="DataList5" runat="server"  Style="position :absolute; height : 24px; width: 218px; left: 618px; top: 325px;" 
         RepeatColumns="5" CellPadding="1" CellSpacing="1" GridLines="Both" 
            BorderStyle="Double" onitemcommand="DataList5_ItemCommand">
        <ItemTemplate>
            <asp:ImageButton ID="Image1" runat="server" CommandName="Load"
               ImageUrl='<%# Eval("Path6") %>' PostBackUrl="Level3.aspx"
                 Width="50" />
                <asp:HyperLink ID="HyperLink1"     NavigateUrl='<%# Eval("pa6", "~/Level3.aspx?pa6{0}")%>'  runat="server">x</asp:HyperLink>
            <asp:CheckBox ID="CheckBox5" runat="server" Visible="False" />
        </ItemTemplate>
       
    </asp:DataList>
   
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
        <asp:Timer ID="Timer1" runat="server" ontick="Timer1_Tick">
        </asp:Timer>
    
      <asp:DataList ID="DataList3" runat="server"  
      Style="position :absolute; height : 40px; width: 234px; left: 303px; top: 75px; margin-top: 0px;" 
        RepeatColumns="5" CellPadding="1" CellSpacing="1" GridLines="Horizontal" 
            BorderStyle="Double" onitemcommand="DataList3_ItemCommand" >
        <ItemTemplate>
            <asp:ImageButton ID="ImageButton1" runat="server"   ImageUrl='<%# Eval("Path3") %>'
            PostBackUrl="Level3.aspx"  Width="50" CommandName="Load"  />
            <asp:HyperLink ID="HyperLink1"     NavigateUrl='<%# Eval("pa3", "~/Level3.aspx?pa3{0}")%>'  runat="server">x</asp:HyperLink>
            <asp:CheckBox ID="CheckBox2" runat="server" Visible="False" />
        </ItemTemplate>
       
    </asp:DataList>
   
      <asp:DataList ID="DataList4" runat="server"  
      Style="position :absolute; height : 17px; width: 242px; left: 307px; top: 205px;" 
         RepeatColumns="5" 
            CellPadding="1" CellSpacing="1" GridLines="Both" BorderStyle="Double" 
            onitemcommand="DataList4_ItemCommand">
        <ItemTemplate>        
   
              <asp:ImageButton ID="Image3" runat="server" CommandName="Load"
               ImageUrl='<%# Eval("Path4") %>' PostBackUrl="Level3.aspx"
                 Width="50" />
         <asp:HyperLink ID="HyperLink1"     NavigateUrl='<%# Eval("pa4", "~/Level3.aspx?pa4{0}")%>'  runat="server">x</asp:HyperLink>
            <asp:CheckBox ID="CheckBox3" runat="server" Visible="False" />
        </ItemTemplate>
       
    </asp:DataList>
  
</div>
</asp:Content>