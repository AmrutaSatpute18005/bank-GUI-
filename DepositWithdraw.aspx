<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepositWithdraw.aspx.cs" Inherits="bank1.DepositWithdraw" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Deposit & Withdraw - Bank Management</title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Deposit & Withdraw</h2>

        <!-- Account Number input for Deposit/Withdraw -->
        <label>Account Number:</label>
        <input type="text" id="txtAccountNumber" runat="server" />
        <br />

        <!-- Deposit -->
        <label>Amount to Deposit:</label>
        <input type="text" id="txtDepositAmount" runat="server" />
        <br />
        <button id="Button2" type="button" runat="server" onserverclick="btnDeposit_Click">Deposit</button>

        <br /><br />

        <!-- Withdraw -->
        <label>Amount to Withdraw:</label>
        <input type="text" id="txtWithdrawAmount" runat="server" />
        <br />
        <button id="Button3" type="button" runat="server" onserverclick="btnWithdraw_Click">Withdraw</button>

        <br /><br />

        <!-- Account List -->
        <h3>Account Details:</h3>
        <asp:ListBox id="listBoxAccounts" runat="server"></asp:ListBox>
    </form>
</body>
</html>
