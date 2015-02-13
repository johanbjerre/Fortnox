using Fortnox.Services.Helpers;
using Fortnox.Services.ValueObjects.Account;
using Fortnox.Services.ValueObjects.Accounts;

// ReSharper disable CheckNamespace
namespace Fortnox
// ReSharper restore CheckNamespace
{
    public static class ApiAccount
    {
        public static Accounts ListAll(string accessToken, string clientSecret)
        {
            return ApiHelpers.TryWrap(() => CommunicationHelper.GetAllAccounts(accessToken, clientSecret),
                                      "Unable to get all accounts");
        }

        public static Account Retrieve(string accessToken, string clientSecret, string number)
        {
            return ApiHelpers.TryWrap(() => CommunicationHelper.GetAccount(accessToken, clientSecret, number),
                           string.Format("Unable to get account with number '{0}'", number));
        }
    }
}
