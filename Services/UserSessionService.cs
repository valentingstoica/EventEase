using MyBlazorApp.Models;

namespace MyBlazorApp.Services
{
    public class UserSessionService
    {
        public UserModel? CurrentUser { get; private set; }

        public void SetUser(UserModel user)
        {
            CurrentUser = user;
        }

        public bool IsUserLoggedIn()
        {
            return CurrentUser != null;
        }
    }
}



