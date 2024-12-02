using System;
using System.Collections.Generic;
using System.Web.UI;

namespace bank1
{
    public partial class DepositWithdraw : Page
    {
        // Retrieve accounts list from session
        private static List<Account> accounts;

        protected void Page_Load(object sender, EventArgs e)
        {
            // Get the accounts list from session
            accounts = Session["Accounts"] as List<Account>;

            if (accounts != null)
            {
                // Display existing accounts in ListBox
                listBoxAccounts.Items.Clear();
                foreach (var account in accounts)
                {
                    listBoxAccounts.Items.Add(account.AccountNumber + " - " + account.AccountHolderName + " - Balance: " + account.Balance);
                }
            }
        }

        // Handle Deposit
        protected void btnDeposit_Click(object sender, EventArgs e)
        {
            decimal amount;

            if (decimal.TryParse(txtDepositAmount.Value, out amount))
            {
                string accountNumber = txtAccountNumber.Value;
                Account account = accounts.Find(acc => acc.AccountNumber == accountNumber);

                if (account != null)
                {
                    account.Balance += amount;
                    listBoxAccounts.Items.Add("Deposited " + amount + " to account " + accountNumber + ". New balance: " + account.Balance);
                }
                else
                {
                    listBoxAccounts.Items.Add("Account not found.");
                }
            }
            else
            {
                listBoxAccounts.Items.Add("Invalid deposit amount.");
            }
        }

        // Handle Withdraw
        protected void btnWithdraw_Click(object sender, EventArgs e)
        {
            decimal amount;

            if (decimal.TryParse(txtWithdrawAmount.Value, out amount))
            {
                string accountNumber = txtAccountNumber.Value;
                Account account = accounts.Find(acc => acc.AccountNumber == accountNumber);

                if (account != null && account.Balance >= amount)
                {
                    account.Balance -= amount;
                    listBoxAccounts.Items.Add("Withdrew " + amount + " from account " + accountNumber + ". New balance: " + account.Balance);
                }
                else
                {
                    listBoxAccounts.Items.Add("Insufficient funds or account not found.");
                }
            }
            else
            {
                listBoxAccounts.Items.Add("Invalid withdrawal amount.");
            }
        }
    }
}
