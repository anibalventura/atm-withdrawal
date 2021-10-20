using System;
using ATM_Withdrawal.Enum;
using ATM_Withdrawal.Menu;
using ATM_Withdrawal.Repository;

namespace ATM_Withdrawal.Service
{
    public class WithdrawalService
    {
        MainRepository mainRepository = MainRepository.Instance;
        MainMenu mainMenu = new MainMenu();

        public void StartTransaction()
        {
            Console.Write("How much do you want to withdraw: ");
            mainRepository.withdrawalAmount = int.Parse(Console.ReadLine());

            switch (mainRepository.dispenseMode)
            {
                case (int)DispenseMenuOptions.FIRST_MODE:
                    FirstMode();
                    break;
                case (int)DispenseMenuOptions.SECOND_MODE:
                    SecondMode();
                    break;
                default:
                    EfficientMode();
                    break;
            }

            Console.Write("Want to do another transaction? Y/N: ");
            string anotherTansaction = Console.ReadLine().ToUpper();

            if (anotherTansaction == "Y")
            {
                StartTransaction();
            }
            else
            {
                mainMenu.ShowMenu();
            }
        }

        private void FirstMode()
        {
            Console.WriteLine("First mode withdrawal");
        }

        private void SecondMode()
        {
            Console.WriteLine("Second mode withdrawal");
        }

        private void EfficientMode()
        {
            Console.WriteLine("Efficient mode withdrawal");
        }
    }
}
