using ATM_Withdrawal.Menu;

namespace ATM_Withdrawal
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowMenu();
        }
    }
}
