<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ImageSecurity.aspx.cs" Inherits="ImageSecurity" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
     </head>
<body>
    <form id="form1" runat="server"> 
     <cc1:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server" />
        <div style="text-align:center">    
    <asp:Label ID="Label3" runat="server" 
            style="position:absolute;  text-align: center; top: 19px; left: 263px; width: 560px;" 
            Text="Security System Using Image Base Authentication"></asp:Label>  
            <asp:Label runat="Server" ID="imageTitle" /><br />
            <asp:Image ID="Image1" runat="server" 
                Height="300"
                Style="border: 1px solid black;width:auto" 
                ImageUrl="~/image/x1.png"
                AlternateText="Blue Hills image" />
            <asp:Label runat="server" ID="imageDescription" ></asp:Label>
            <asp:Label runat="server" ID="Label1" ></asp:Label><br /><br />
            <asp:Button runat="Server" ID="prevButton" Text="Prev" Font-Size="Larger" />
            <asp:Button runat="Server" ID="playButton" Text="Play" Font-Size="Larger" />
            <asp:Button runat="Server" ID="nextButton" Text="Next" Font-Size="Larger" />
            <cc1:SlideShowExtender ID="slideshowextend1" runat="server" 
                TargetControlID="Image1"
                SlideShowServiceMethod="GetSlides" 
                AutoPlay="true" 
                ImageTitleLabelID="imageTitle"
                ImageDescriptionLabelID="imageDescription"
                NextButtonID="nextButton" 
                PlayButtonText="Play" 
                StopButtonText="Stop"
                PreviousButtonID="prevButton" 
                PlayButtonID="playButton" 
                Loop="true" />
        </div>
   
    </form>
</body>
</html>
