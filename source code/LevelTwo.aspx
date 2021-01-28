<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LevelTwo.aspx.cs" Inherits="LevelTwo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label3" runat="server" 
            style="position:absolute; top: 27px; left: 137px; width: 638px; font-weight: 700; text-align: center;" 
            Text="Security System Using Image Base Authentication"></asp:Label>

    </div>
    <asp:Image ID="Image1" runat="server" ImageUrl="~/image/beaten.png" 
        style="top: 236px; left: 130px; position: absolute; height: 74px; width: 61px" />
    <asp:Image ID="Image3" runat="server" ImageUrl="~/image/ignoring.png" 
        
        style="top: 243px; left: 200px; position: absolute; height: 59px; width: 66px" />
    <p>
        <asp:Button ID="Button3" runat="server" onclick="Button3_Click" 
            style="top: 196px; left: 279px; position: absolute; height: 26px; width: 56px" 
            Text="C" />
        <asp:Label ID="Label4" runat="server" 
            style="position:absolute; top: 350px; left: 140px; width: 214px;" Text="Label"></asp:Label>
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
            style="top: 194px; left: 205px; position: absolute; height: 26px; width: 56px" 
            Text="B" />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
            style="top: 194px; left: 131px; position: absolute; height: 26px; width: 56px; right: 516px;" 
            Text="A" />
        <asp:Label ID="Label5" runat="server"  
            style=" position: absolute; top: 147px; left: 129px; width: 254px;"></asp:Label>
    <asp:Image ID="Image2" runat="server" ImageUrl="~/image/disapointed.png" 
        
            
            style="top: 238px; position: absolute; height: 65px; width: 55px; right: 602px" />
    </p>
    </form>
</body>
</html>
