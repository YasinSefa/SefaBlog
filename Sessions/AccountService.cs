using SefaBlog.Models;

namespace SefaBlog.Sessions
{
    public class AccountService : IAccountService
    {
        private List<Account> accounts;
        public AccountService()
        {
            accounts = new List<Account>()
            {
                new Account()
                {
                    Username = "axoy@gmail.com",
                    Password = "a"
                },
                new Account()
                {
                    Username = "a",
                    Password = "a"
                }
        };
        }
        public Account Login(string username, string password)
        {
            return accounts.SingleOrDefault(x=>x.Username==username && x.Password==password);
        }
    }
}
