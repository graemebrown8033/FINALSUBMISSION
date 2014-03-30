<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style2
        {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
   
      <img id="Img1" alt="" runat="server" class="style1" src="~/Images/logo.png" />
           <h2>
        Welcome to our Hack Day App!
    </h2>      
    <p class="style2">
        Here at Two &amp; A Half Men, we have created a device that uses both hardware and 
        software in order to assist the visually impaired.</p>
<p class="style2">
    Our device uses Arduino, C# and Cassandra technologies that, when combined allow 
    the user to recieve detailed information about their surroundings with the click 
    of a button.</p>
<p class="style2">
    This site provides the adminstrative side of our project and allows the user to 
    register and log in. From there they will be able to create, retrieve, update 
    and delete information stored in our Cassandra database. This information can 
    range from other users to updated check point details.
</p>


</asp:Content>
