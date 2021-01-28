<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Registration.aspx.cs" Inherits="Registration" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>
    
 <asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style ="position:relative; top: 0px; left: 0px; height: 463px;">
    <asp:Image ID="Image1" runat="server" Height="459px" 
        ImageUrl="~/images/Butterfly Background without light.jpg" Width="950px" />
        <table style="top: 28px; left: 336px; position: absolute; height: 431px; width: 609px">
    <tr>
     <td>First Name:</td>
     <td><asp:TextBox ID="txtFirstName" runat="server">
        </asp:TextBox>
     </td>
     <td><asp:RequiredFieldValidator ID="rfvFirstName" 
                 runat="server" 
                 ControlToValidate="txtFirstName"
                ErrorMessage="First Name can't be left blank" 
                SetFocusOnError="True">*
         </asp:RequiredFieldValidator>
    </td>
    </tr>
    <tr>
    <td>Last Name:</td>
    <td><asp:TextBox ID="txtLastName" runat="server">
        </asp:TextBox></td>
   <td><asp:RequiredFieldValidator 
             ID="RequiredFieldValidator1" runat="server" 
             ControlToValidate="txtLastName"
             ErrorMessage="Last Name can't be left blank" 
            SetFocusOnError="True">*
        </asp:RequiredFieldValidator>
    </td></tr>
     
    <tr><td>UserName:</td>
    <td><asp:TextBox ID="txtUserName" runat="server">
        </asp:TextBox>
    </td>
    <td><asp:RequiredFieldValidator 
             ID="rfvUserName" 
             runat="server" 
             ControlToValidate="txtUserName"
             ErrorMessage="UserName can't be left blank" 
             SetFocusOnError="True">*
        </asp:RequiredFieldValidator>
    </td></tr>
     
    <tr><td>Password:</td>
    <td><asp:TextBox ID="txtPwd" runat="server"
                     TextMode="Password">
        </asp:TextBox>
    </td>
    <td><asp:RequiredFieldValidator ID="rfvPwd" 
             runat="server" ControlToValidate="txtPwd"
             ErrorMessage="Password can't be left blank" 
             SetFocusOnError="True">*
       </asp:RequiredFieldValidator>
    </td></tr>
     
    <tr><td>Confirm Password:</td>
    <td><asp:TextBox ID="txtRePwd" runat="server"
                     TextMode="Password">
       </asp:TextBox>
    </td>
    <td><asp:CompareValidator ID="CompareValidator1" 
            runat="server" 
            ControlToCompare="txtRePwd" 
            ControlToValidate="txtPwd" 
            Operator="Equal" 
            ErrorMessage="Password and confirm password do not match" 
            SetFocusOnError="True">
        </asp:CompareValidator>
    </td></tr>
     
    <tr><td>Gender:</td>
    <td><asp:RadioButtonList ID="rdoGender" 
                             runat="server">
             <asp:ListItem>Male</asp:ListItem>
             <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
    </td>
    <td><asp:RequiredFieldValidator 
             ID="RequiredFieldValidator2" 
            runat="server" 
            ControlToValidate="rdoGender"
             ErrorMessage="Gender can't be left blank" 
             SetFocusOnError="True">*
         </asp:RequiredFieldValidator>
    </td></tr>
     
    <tr><td>Address:</td>
    <td><asp:TextBox ID="txtAdress" runat="server" 
                     TextMode="MultiLine">
        </asp:TextBox>
    </td>
    <td><asp:RequiredFieldValidator ID="rfvAddress" 
             runat="server" 
             ControlToValidate="txtAdress"
             ErrorMessage="Address can't be left blank" 
             SetFocusOnError="True">*
        </asp:RequiredFieldValidator>
   </td></tr>
                            
    <tr><td>Email ID:</td>
    <td><asp:TextBox ID="txtEmailID" runat="server" AutoPostBack="True" 
            ontextchanged="txtEmailID_TextChanged" Width="180px"></asp:TextBox>
    </td>
   <td><asp:RequiredFieldValidator 
            ID="RequiredFieldValidator3" 
            runat="server" 
            ControlToValidate="txtEmailID"
            ErrorMessage="Email can't be left blank" 
            SetFocusOnError="True">*
       </asp:RequiredFieldValidator>
  </td></tr>
    
   <tr><td><asp:Label ID="lblMsg" runat="server" Width="151px"></asp:Label>
       </td>
       
   <td>
       <asp:ValidationSummary ID="ValidationSummary1" 
            runat="server" ShowMessageBox="True" 
            ShowSummary="False"/>
           <asp:Button ID="btnSave" runat="server" 
                       Text="Sign Up" 
                       onclick="btnSave_Click" 
           
           
           
           style="top: 403px; left: 501px; position: absolute; height: 26px; width: 68px"/>
       <asp:FileUpload ID="FileUpload1" runat="server" />
       <asp:Image ID="Image2" runat="server" Width="53px" />
   </td></tr>
    
   <tr><td>&nbsp;</td><td>
           &nbsp;<td>
           &nbsp;</td>
   </td></tr>
   </table>
    <asp:Label ID="Label1" runat="server" 
            style="position:absolute; top: 6px; left: 349px; width: 592px; font-weight: 700; text-align: center;" 
            Text="Registration "></asp:Label>     
    <img id = "imgDisplay" alt="" src="" style = "display:none"/>
</div>
</asp:Content>