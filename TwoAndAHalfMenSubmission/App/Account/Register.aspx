<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Register.aspx.cs" Inherits="Account_Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <style type="text/css">
        .style2
        {
            text-align: left;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
<h1>Register</h1>
<p>
    <tr valign="top">
        <td>
            <!-- start id-form -->
            <table border="0" cellpadding="0" cellspacing="0" id="id-form">
                <tr>
                    <th valign="top" class="style2">
                        Name:
                    </th>
                    <td class="style2">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th valign="top" class="style2">
                        Email:
                    </th>
                    <td class="style2">
                        <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th valign="top" class="style2">
                        User ID:
                    </th>
                    <td class="style2">
                        <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th valign="top" class="style2">
                        Password:
                    </th>
                    <td class="style2">
                        <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th valign="top" style="text-align: right">
                        &nbsp;</th>
                    <td class="style2">
                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" 
                            Text="Submit" style="text-align: left" />
                            &nbsp;
                            <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="Reset" />
                    </td>
                </tr>
                <tr>
                    <td>
                        
                    </td>
                </tr>
            </table>
            <!-- end id-form  -->
        </td>
    </tr>
    </p>
</asp:Content>
