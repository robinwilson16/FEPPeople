using FEPPeople.Models;

namespace FEPPeople.Services
{
    public class AppData
    {
        //This is needed in case multiple blazor components are displayed on the page then all will detect the change made on one
        private User? _user;
        public User? User 
        {
            get
            {
                return _user;
            }
            set
            {
                _user = value;
                NotifyDataChanged();
            }
        }

        public AppData()
        { 
            User = new User();
        }

        public event Action? OnChange;

        private void NotifyDataChanged() => OnChange?.Invoke();
    }
}
