using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
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
            var test = Fortnox.ApiArticle.GetAllArticles(Constants.AccountConstants.ACCESS_TOKEN, Constants.AccountConstants.CLIENT_SECRET);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectionCredentials.AccessToken = Constants.AccountConstants.ACCESS_TOKEN;
            ConnectionCredentials.ClientSecret = Constants.AccountConstants.CLIENT_SECRET;

            try
            {
                var customer = new Customer {CustomerNumber = "3345345345345345", Name = "Stefan Andessrsson"};

                var customerConnector = new CustomerConnector();
                customerConnector.Create(customer);
            }
            catch (Exception exception)
            {
                var i = exception.Message;
            }
        }

        private void articleNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetArticle_Click(object sender, EventArgs e)
        {
            var articleNumber = articleNumberBox.Text;
            var test = ApiArticle.GetArticle(Constants.AccountConstants.ACCESS_TOKEN, Constants.AccountConstants.CLIENT_SECRET, articleNumber);
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
    }

}
