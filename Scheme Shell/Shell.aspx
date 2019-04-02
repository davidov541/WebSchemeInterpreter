<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Shell.aspx.cs" Inherits="Scheme_Shell._Default" Theme="Coding" StyleSheetTheme="Coding" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Chez Scheme</title>
</head>
<body>
    <form id="form1" runat="server">
    <p>
        <asp:TextBox ID="txtConsole" runat="server" Width="922px" 
            OnTextChanged = txtConsole_TextChanged AutoPostBack="True" 
            AutoCompleteType="Disabled"></asp:TextBox>
    </p>
    <asp:Label ID="lblOutput" runat="server" Height="27px" Width="921px"></asp:Label>
    </form>
</body>
</html>
