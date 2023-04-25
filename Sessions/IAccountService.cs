using SefaBlog.Models;

namespace SefaBlog.Sessions
{
    public interface IAccountService
    {
        public Account Login(string username, string password);
    }
}
