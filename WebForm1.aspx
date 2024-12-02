<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="bank1.WebForm1" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Bank Management System - Account Creation</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Create Bank Account</h2>

        <label>Account Number:</label>
        <input type="text" id="txtAccountNumber" runat="server" />
        <br />

        <label>Account Holder Name:</label>
        <input type="text" id="txtAccountHolderName" runat="server" />
        <br />

        <label>Initial Balance:</label>
        <input type="text" id="txtInitialBalance" runat="server" />
        <br />
        
        <button id="Button1" type="button" runat="server" onserverclick="btnCreateAccount_Click">Create Account</button>
        <br />

        <h3>Account Details:</h3>
        <asp:ListBox id="listBoxAccounts" runat="server"></asp:ListBox>
    </form>
</body>
</html>
