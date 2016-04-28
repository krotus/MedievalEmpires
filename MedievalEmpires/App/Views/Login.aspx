<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="Login.aspx.vb" Inherits="MedievalEmpires.Login1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Sign in to BoME"></asp:Label>
    <br />
    <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
&nbsp;<asp:TextBox ID="tbUsername" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
&nbsp;<asp:TextBox ID="tbPassword" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="btnLogin" runat="server" Text="Login" />
    <br />
</asp:Content>
