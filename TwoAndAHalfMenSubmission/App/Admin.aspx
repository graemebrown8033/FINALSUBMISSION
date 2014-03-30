<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Admin.aspx.cs" Inherits="Admin" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <h1>
        Admin Control Panel</h1>
    <p>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Height="100px"
            Width="100px" Style="text-align: center" Font-Bold="False" Font-Size="Large" />
        &nbsp;<asp:Button ID="btnDelete" runat="server" Text="Update" Height="100px" Width="100px"
            Font-Bold="False" Font-Size="Large" PostBackUrl="~/Delete.aspx" />
        &nbsp;<asp:Button ID="btnView" runat="server" Text="View" Height="100px" Width="100px"
            Font-Bold="False" Font-Size="Large" PostBackUrl="~/View.aspx" />
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
