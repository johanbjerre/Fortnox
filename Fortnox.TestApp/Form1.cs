using System;
using System.IO;
using System.Net;
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
            /*
            https://ci.appveyor.com/api/environments/h7bgpmu9xklrxmraisg5/deployments
            var urlRoles = "https://ci.appveyor.com/api/roles";
            var urlEnvironments = "https://ci.appveyor.com/api/environments";
            var urlProjects="https://ci.appveyor.com/api/projects";
            */
            const string urlFortnox = "https://ci.appveyor.com/api/projects/johanbjerre/fortnox";
            const string token = "";

            var request = (HttpWebRequest)WebRequest.Create(urlFortnox);
            request.Accept = "application/xml";
            request.Headers.Add("Authorization", "Bearer " + token);

            using (var response = request.GetResponse())
            {
                using (var stream = response.GetResponseStream())
                {
                    if (stream == null) return;
                    using (var reader = new StreamReader(stream))
                    {
                        var result = reader.ReadToEnd();
                    }
                }
            }
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
