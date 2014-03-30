<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="View.aspx.cs" Inherits="Account_View" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <br />
    Please select the building number from the drop down list:<br />
    <asp:DropDownList ID="buildDD" runat="server">
        <asp:ListItem>1</asp:ListItem>
        <asp:ListItem>2</asp:ListItem>
        <asp:ListItem>3</asp:ListItem>
        <asp:ListItem>4</asp:ListItem>
        <asp:ListItem>5</asp:ListItem>
        <asp:ListItem>6</asp:ListItem>
        <asp:ListItem>7</asp:ListItem>
        <asp:ListItem>8</asp:ListItem>
        <asp:ListItem>9</asp:ListItem>
        <asp:ListItem>10</asp:ListItem>
    </asp:DropDownList>
    <asp:Button ID="btnGo" runat="server" onclick="btnGo_Click" Text="Go" />
    <br />

    <asp:Label ID="Label1" runat="server"></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server"></asp:Label>
    <br />
    <asp:Label ID="Label3" runat="server"></asp:Label>
    <br />
    <asp:Label ID="Label4" runat="server"></asp:Label>
    <br />
    <asp:Label ID="Label5" runat="server"></asp:Label>
    <br />
    <asp:Label ID="Label6" runat="server"></asp:Label>
    <br />
    <asp:Label ID="Label7" runat="server"></asp:Label>

    <br />
    <br />
    <br />
    <br />
    <br />


    </asp:Content>
