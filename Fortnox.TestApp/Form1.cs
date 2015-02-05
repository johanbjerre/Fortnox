using System;
using System.Windows.Forms;
using Fortnox.Api;
using FortnoxAPILibrary;
using FortnoxAPILibrary.Connectors;


namespace Fortnox.TestApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void getAllArticlesButton_Click(object sender, EventArgs e)
        {
            var test = ApiArticle.ListAll(Constants.AccountConstants.ACCESS_TOKEN, Constants.AccountConstants.CLIENT_SECRET);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var art = new Fortnox.ValueObjects.Article.Article { url = "" };
            ConnectionCredentials.AccessToken = Constants.AccountConstants.ACCESS_TOKEN;
            ConnectionCredentials.ClientSecret = Constants.AccountConstants.CLIENT_SECRET;

            var connector = new AccountConnector();
            //var contract = new ContractConnector()
            //contract.Create()
            var result = connector.Create(new Account { Number = "234234678678678768324234234", Description = "test", VATCode = "sdfsdfsdfdsf" });
            //var customer = new Customer {CustomerNumber = "3345345345345345", Name = "Stefan Andessrsson"};

            //var customerConnector = new CustomerConnector();
            //customerConnector.Create(customer);
        }

        private void articleNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetArticle_Click(object sender, EventArgs e)
        {
            var number = articleNumberBox.Text;
            var test = ApiArticle.Retrieve(Constants.AccountConstants.ACCESS_TOKEN, Constants.AccountConstants.CLIENT_SECRET, number);
        }

        private void appVeyor_Click(object sender, EventArgs e)
        {
            
        }

        private void getAllAccounts_Click(object sender, EventArgs e)
        {
            var test = ApiAccount.ListAll(Constants.AccountConstants.ACCESS_TOKEN, Constants.AccountConstants.CLIENT_SECRET);
        }

        private void getAccount_Click(object sender, EventArgs e)
        {
            var number = accountNumberBox.Text;
            var test = ApiAccount.Retrieve(Constants.AccountConstants.ACCESS_TOKEN, Constants.AccountConstants.CLIENT_SECRET, number);
        }
    }

}
