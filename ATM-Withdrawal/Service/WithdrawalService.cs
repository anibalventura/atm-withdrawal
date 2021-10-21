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
                case (int)DispenseMenuOptions.EFFICIENT_MODE:
                    EfficientMode();
                    break;
                default:
                    EfficientMode();
                    break;
            }

            Console.Write("\nWant to do another transaction? Y/N: ");
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
            int[] denominations = { 1000, 200 };
            int[] cashCounter = new int[denominations.Length];

            for (int i = 0; i < cashCounter.Length; i++)
            {
                if (mainRepository.withdrawalAmount >= denominations[i])
                {
                    cashCounter[i] = mainRepository.withdrawalAmount / denominations[i];
                    mainRepository.withdrawalAmount -= cashCounter[i] * denominations[i];
                }
            }

            Console.WriteLine("Currency Count ->");

            for (int i = 0; i < cashCounter.Length; i++)
            {
                if (cashCounter[i] != 0)
                {
                    Console.WriteLine(denominations[i] + " : "
                        + cashCounter[i]);
                }
            }
        }

        private void SecondMode()
        {
            int[] denominations = { 500, 100 };
            int[] cashCounter = new int[denominations.Length];

            for (int i = 0; i < cashCounter.Length; i++)
            {
                if (mainRepository.withdrawalAmount >= denominations[i])
                {
                    cashCounter[i] = mainRepository.withdrawalAmount / denominations[i];
                    mainRepository.withdrawalAmount -= cashCounter[i] * denominations[i];
                }
            }

            Console.WriteLine("Currency Count ->");

            for (int i = 0; i < cashCounter.Length; i++)
            {
                if (cashCounter[i] != 0)
                {
                    Console.WriteLine(denominations[i] + " : "
                        + cashCounter[i]);
                }
            }
        }

        private void EfficientMode()
        {
            int[] denominations = { 1000, 500, 200, 100 };
            int[] cashCounter = new int[denominations.Length];

            for (int i = 0; i < cashCounter.Length; i++)
            {
                if (mainRepository.withdrawalAmount >= denominations[i])
                {
                    cashCounter[i] = mainRepository.withdrawalAmount / denominations[i];
                    mainRepository.withdrawalAmount -= cashCounter[i] * denominations[i];
                }
            }

            Console.WriteLine("Currency Count ->");

            for (int i = 0; i < cashCounter.Length; i++)
            {
                if (cashCounter[i] != 0)
                {
                    Console.WriteLine(denominations[i] + " : "
                        + cashCounter[i]);
                }
            }
        }
    }
}
