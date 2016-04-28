<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="AjaxTest.aspx.vb" Inherits="MedievalEmpires.AjaxTest" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <ajaxToolkit:BarChart ID="BarChart1" runat="server">
        </ajaxToolkit:BarChart>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <ajaxToolkit:PasswordStrength ID="TextBox1_PasswordStrength" runat="server" TargetControlID="TextBox1" />
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    
    </div>
    </form>
</body>
</html>
