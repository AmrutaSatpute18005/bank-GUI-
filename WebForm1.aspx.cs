using System;
using System.Collections.Generic;
using System.Web.UI;

namespace bank1
{
    public partial class WebForm1 : Page
    {
        // List to store account data (for simplicity, it's static)
        private static List<Account> accounts = new List<Account>();

        // Handle account creation
        protected void btnCreateAccount_Click(object sender, EventArgs e)
        {
            string accountNumber = txtAccountNumber.Value;
            string accountHolderName = txtAccountHolderName.Value;
            decimal initialBalance;

            if (decimal.TryParse(txtInitialBalance.Value, out initialBalance))
            {
                // Create new account
                Account newAccount = new Account
                {
                    AccountNumber = accountNumber,
                    AccountHolderName = accountHolderName,
                    Balance = initialBalance
                };

                // Add account to list
                accounts.Add(newAccount);

                // Display success in ListBox
                listBoxAccounts.Items.Add("Account " + accountNumber + " created with balance " + initialBalance);

                // Store the accounts list in session to pass it to the next page
                Session["Accounts"] = accounts;

                // Redirect to DepositWithdraw.aspx
                Response.Redirect("DepositWithdraw.aspx");
            }
            else
            {
                listBoxAccounts.Items.Add("Invalid initial balance.");
            }
        }
    }

    // Account class to store account information
    public class Account
    {
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; set; }
    }
}
