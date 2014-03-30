<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Add.aspx.cs" Inherits="Account_Add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="Server">
    <style type="text/css">
        .style2
        {
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="Server">
    <h1>
        Add building</h1>
    <p>
        
    <tr valign="top">
        <td>
            <!-- start id-form -->
            <table border="0" cellpadding="0" cellspacing="0" id="id-form">
                <tr>
                    <th valign="top" class="style2">
                        Building Name:
                    </th>
                    <td class="style2">
                        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th valign="top" class="style2">
                        Location:
                    </th>
                    <td class="style2">
                        <asp:TextBox ID="txtLocation" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th valign="top" class="style2">
                        Info 1:
                    </th>
                    <td class="style2">
                        <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th valign="top" class="style2">
                        Info 2:
                    </th>
                    <td class="style2">
                        <asp:TextBox ID="txt2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <th valign="top" class="style2">
                        Info 3:
                    </th>
                    <td class="style2">
                        <table border="0" cellpadding="0" cellspacing="0">
                            <tr valign="top">
                                <td>
                                    <asp:TextBox ID="txt3" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <th valign="top" style="text-align: right">
                        Info 4:
                    </th>
                    <td class="style2">
                        <asp:TextBox ID="txt4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right">
                        <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
                        <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="Reset" />
                        <br />
                       
                    </td>
                </tr>
            </table>
            <!-- end id-form  -->
        </td>
    </tr>
     <asp:Label ID="Success" runat="server" 
                            Text="You have successfully added a building." Visible="False"></asp:Label>
    &nbsp;</p>
</asp:Content>
