using ATM.Util;

namespace ATM.Entities
{
    public abstract class User
    {
        public string UserId { get; private set; }
        public string Login { get; set; }
        private string pin;
        public string pin
        {
            get { return pin; }
            set { pin = value; }
        }
        

        public UserTypes userTypes { get; set; }

        
    }
}