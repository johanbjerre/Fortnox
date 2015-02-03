using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var test = Fortnox.ApiArticle.GetAllArticles(Constants.AccountConstants.AccessToken, Constants.AccountConstants.ClientSecret);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FortnoxAPILibrary.ConnectionCredentials.AccessToken = Constants.AccountConstants.AccessToken;
            FortnoxAPILibrary.ConnectionCredentials.ClientSecret = Constants.AccountConstants.ClientSecret;

            try
            {
                var customer = new Customer();
                customer.CustomerNumber = "3345345345345345";
                customer.Name = "Stefan Andessrsson";

                var customerConnector = new CustomerConnector();
                customerConnector.Create(customer);
            }
            catch(Exception exception){
                var i = exception.Message;
            }
        }

        private void articleNumberBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void GetArticle_Click(object sender, EventArgs e)
        {
            var articleNumber = articleNumberBox.Text;
            var test=Fortnox.ApiArticle.GetArticle(Constants.AccountConstants.AccessToken, Constants.AccountConstants.ClientSecret,articleNumber);
        }
    }
}
