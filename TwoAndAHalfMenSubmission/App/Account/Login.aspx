<%@ Page Title="Log In" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Login.aspx.cs" Inherits="Account_Login" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>
        Log In
    </h2>
    <p>
        Please enter your username and password.
        <asp:HyperLink ID="RegisterHyperLink" runat="server">Register</asp:HyperLink> if you don't have an account.</p>
    <p>
        <br />
        Username : <asp:TextBox ID="txtUser" runat="server"></asp:TextBox><br< /><br />
        Password :&nbsp; <asp:TextBox ID="txtPass" runat="server" TextMode="Password"></asp:TextBox><br< />
        <asp:
    </p>
   
    <p>
                <asp:Label ID="Label2" runat="server" ForeColor="Red"></asp:Label>
    </p>
    <p>
        <asp:Button ID="btnLogin" runat="server" Text="Login" 
            onclick="btnLogin_Click" />
    </p>
  
</asp:Content>