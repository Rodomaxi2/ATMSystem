namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            string login, pin;
            do
            {
                System.Console.WriteLine("Type your Login: ");
                login = System.Console.ReadLine();
                
                System.Console.WriteLine("Type your Pin: ");
                pin = System.Console.ReadLine();
            }while(loginMenu != null && pin != null);
            

            void loginMenu()
            {
                
            }
        }
    }
}