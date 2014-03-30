<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Delete.aspx.cs" Inherits="Account_Delete" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
     <br />
    Please select the building number from the drop down list:<br />
     <br />
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
     <br />
     <asp:Label ID="ID" runat="server" Text="Building ID:" Visible="False"></asp:Label>
     <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" Visible="False" 
         Width="600px"></asp:TextBox>
     <br />
     <asp:Label ID="Name" runat="server" Text="Building Name:" Visible="False"></asp:Label>
     <asp:TextBox ID="TextBox2" runat="server" ReadOnly="True" Visible="False" 
         Width="600px"></asp:TextBox>
     <br />
     <asp:Label ID="Sensor" runat="server" Text="Sensor ID:" Visible="False"></asp:Label>
     <asp:TextBox ID="TextBox8" runat="server" ReadOnly="True" Visible="False" 
         Width="600px"></asp:TextBox>
     <br />
     <asp:Label ID="Location" runat="server" Text="Location: " Visible="False"></asp:Label>
     <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True" Visible="False" 
         Width="600px"></asp:TextBox>
     <br />
     <asp:Label ID="Info1" runat="server" Text="Info 1:" Visible="False"></asp:Label>
     <asp:TextBox ID="TextBox4" runat="server" ReadOnly="True" Visible="False" 
         Width="600px"></asp:TextBox>
     <br />
     <asp:Label ID="Info2" runat="server" Text="Info 2:" Visible="False"></asp:Label>
     <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True" Visible="False" 
         Width="600px"></asp:TextBox>
     <br />
     <asp:Label ID="Info3" runat="server" Text="Info 3:" Visible="False"></asp:Label>
     <asp:TextBox ID="TextBox6" runat="server" ReadOnly="True" Visible="False" 
         Width="600px"></asp:TextBox>
     <br />
     <asp:Label ID="Info4" runat="server" Text="Info 4:" Visible="False"></asp:Label>
     <asp:TextBox ID="TextBox7" runat="server" ReadOnly="True" Visible="False" 
         Width="600px"></asp:TextBox>
     <br />
    <br />

    <br />
     <asp:Button ID="btnEdit" runat="server" onclick="btnEdit_Click" Text="Edit" 
         Visible="False" />
&nbsp;<asp:Button ID="btnDelete" runat="server" onclick="btnDelete_Click" 
         Text="Delete" Visible="False" />
     <asp:Button ID="btnUpdate" runat="server" onclick="btnUpdate_Click" 
         Text="Update" Visible="False" />
     <br />
    <br />
     <asp:Label ID="success" runat="server"></asp:Label>
     <asp:Label ID="noinfo" runat="server" Text="No information available." 
         Visible="False"></asp:Label>
    <br />
    <br />

</asp:Content>

