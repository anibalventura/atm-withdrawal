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
            try
            {
                Console.Write("Enter amount to withdraw: ");
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
                }

                AnotherTransaction();
            }
            catch(Exception ex)
            {
                Console.WriteLine("! - Please enter an amount.\n");
                Console.ReadKey();
                StartTransaction();
            }
        }

        private void AnotherTransaction()
        {
            Console.Write("\nWant to do another transaction? Y/N: ");
            string anotherTansaction = Console.ReadLine().ToUpper();

            switch (anotherTansaction)
            {
                case "Y":
                    Console.WriteLine();
                    StartTransaction();
                    break;
                case "N":
                    mainMenu.ShowMenu();
                    break;
                default:
                    Console.WriteLine("! - Please enter a valid answer.");
                    Console.ReadKey();
                    AnotherTransaction();
                    break;
            }
        }

        private void FirstMode()
        {
            int[] denominations = { 1000, 200 };

            DispenseCash(denominations);
        }

        private void SecondMode()
        {
            int[] denominations = { 500, 100 };

            DispenseCash(denominations);
        }

        private void EfficientMode()
        {
            int[] denominations = { 1000, 500, 200, 100 };

            DispenseCash(denominations);
        }

        private void DispenseCash(int[] denominations)
        {
            int[] cashCounter = new int[denominations.Length];

            for (int i = 0; i < cashCounter.Length; i++)
            {
                if (mainRepository.withdrawalAmount >= denominations[i])
                {
                    cashCounter[i] = mainRepository.withdrawalAmount / denominations[i];
                    mainRepository.withdrawalAmount -= cashCounter[i] * denominations[i];
                }
            }

            if (mainRepository.withdrawalAmount == 0)
            {
                Console.WriteLine("\n* - The ATM have dispensed: ");

                for (int i = 0; i < cashCounter.Length; i++)
                {
                    if (cashCounter[i] != 0)
                    {
                        Console.WriteLine($"    {cashCounter[i]} x {denominations[i]}");
                    }
                }
            }
            else
            {
                Console.WriteLine("\n! - Sorry only this denominations can be dispense: ");
                Console.Write("! - ");

                for (int i = 0; i < denominations.Length; i++)
                {
                    Console.Write($"{denominations[i]} - ");
                }

                Console.WriteLine("\n! - Please enter a correct amount.\n");
                Console.ReadKey();
                StartTransaction();
            }
        }
    }
}
