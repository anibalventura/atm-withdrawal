using System;
using ATM_Withdrawal.Enum;

namespace ATM_Withdrawal.Menu
{
    public class DispenseMenu
    {
        public void ShowMenu()
        {
            try
            {
                Console.Clear();

                MainMenu mainMenu = new MainMenu();

                string[] options = { "200 and 1000", "100 and 500",
                    "Efficient Mode (Default) 100, 200, 500, 1000", "Back" };

                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine($"{i + 1} - {options[i]}");
                }

                Console.Write("\nSelect an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case (int)DispenseMenuOptions.FIRST_200_1000:
                        Console.WriteLine("FIRST Mode Selected");
                        Console.ReadKey();
                        ShowMenu();
                        break;
                    case (int)DispenseMenuOptions.SECOND_100_500:
                        Console.WriteLine("SECOND Mode Selected");
                        Console.ReadKey();
                        ShowMenu();
                        break;
                    case (int)DispenseMenuOptions.EFFICIENT_MODE:
                        Console.WriteLine("EFFICIENT Mode Selected");
                        Console.ReadKey();
                        ShowMenu();
                        break;
                    case (int)DispenseMenuOptions.BACK:
                        mainMenu.ShowMenu();
                        break;
                    default:
                        WrongOptionMsg();
                        break;
                }
            }
            catch (Exception ex)
            {
                WrongOptionMsg();
            }
        }

        private void WrongOptionMsg()
        {
            Console.WriteLine("Please select a valid option.");
            Console.ReadKey();
            ShowMenu();
        }
    }
}
