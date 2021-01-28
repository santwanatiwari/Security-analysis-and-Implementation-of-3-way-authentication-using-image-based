<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Test.aspx.cs" Inherits="Test" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
 
 <asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style ="position:relative; top: 0px; left: 0px; height: 463px;">
    <asp:Image ID="Image4" runat="server" Height="459px" 
        ImageUrl="~/images/Butterfly Background without light.jpg" Width="950px" />
      <div style="height: 46px">         
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <div style=" position:absolute; width: 143px; top: 188px; left: 461px;">        
        <div class="Image">
             <asp:ImageButton ID="Image2" runat="server"
             Height="104px" Width="101px"
             ImageUrl="~/image/x1.png" onclick="Image2_Click" />
        </div>       
        <cc1:SlideShowExtender ID="SlideShowExtender3" runat="server"
BehaviorID="SSBehaviorID"
            TargetControlID="Image2"
            SlideShowServiceMethod="GetSlides1"
            AutoPlay="true"
            ImageDescriptionLabelID="Label8"
            ImageTitleLabelID="Label7"
            NextButtonID="Button7"
            PreviousButtonID="Button5"
            PlayButtonID="Button6"
            PlayButtonText="Play"
            StopButtonText="Stop"
            Loop="true" >
        </cc1:SlideShowExtender>
        <div>
            <asp:Label ID="Label7" runat="server"></asp:Label>
            <asp:Label ID="Label8" runat="server"></asp:Label><br />
            <asp:Button ID="Button5" runat="server" Text="Previous" />
            <asp:Button ID="Button6" runat="server" Text="" />
            <asp:Button ID="Button7" runat="server" Text="Next" />
        </div>
    </div>
    <div style=" position:absolute; width: 143px; top: 188px; left: 607px;">
      
        <div class="Image">
             <asp:ImageButton ID="Image1" runat="server"
             Height="104px" Width="101px"
             ImageUrl="~/image/x1.png" onclick="Image1_Click" />
        </div>       
        <cc1:SlideShowExtender ID="SlideShowExtender2" runat="server"
BehaviorID="SSBehaviorID1"
            TargetControlID="Image1"
            SlideShowServiceMethod="GetSlides"
            AutoPlay="true"
            ImageDescriptionLabelID="Label5"
            ImageTitleLabelID="Label4"
            NextButtonID="Button4"
            PreviousButtonID="Button2"
            PlayButtonID="Button3"
            PlayButtonText="Play"
            StopButtonText="Stop"
            Loop="true" >
        </cc1:SlideShowExtender>
        <div>
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label5" runat="server" Text=""></asp:Label><br />
            <asp:Button ID="Button2" runat="server" Text="Previous" />
            <asp:Button ID="Button3" runat="server" Text="" />
            <asp:Button ID="Button4" runat="server" Text="Next" />
        </div>
    </div>
    <div style="position:absolute; width: 140px; top: 187px; left: 754px;">
        
        <div class="Image">
             <asp:ImageButton ID="img1" runat="server"
             Height="104px" Width="101px"
             ImageUrl="~/image/x1.png" onclick="img1_Click" />
        </div>       
        <cc1:SlideShowExtender ID="SlideShowExtender1" runat="server"
BehaviorID="SSBehaviorID2"
            TargetControlID="img1"
            SlideShowServiceMethod="GetSlides2"
            AutoPlay="true"
            ImageDescriptionLabelID="lblDesc"
            ImageTitleLabelID="Label1"
            NextButtonID="btnNext"
            PreviousButtonID="btnPrev"
            PlayButtonID="btnPlay"
            PlayButtonText="Play"
            StopButtonText="Stop"
            Loop="true" >
        </cc1:SlideShowExtender>
        <div>
            <asp:Label ID="lblDesc" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label><br />
            <asp:Button ID="btnPrev" runat="server" Text="Previous" />
            <asp:Button ID="btnPlay" runat="server" Text="" />
            <asp:Button ID="btnNext" runat="server" Text="Next" />
        </div>
    </div>
    </div> 
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Select" 
        Height="32px" Width="186px" 
        style="top: 459px; left: 751px; position: absolute" Visible="False" />
 
</div>
</asp:Content>