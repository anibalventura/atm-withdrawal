using System;
using ATM_Withdrawal.Enum;
using ATM_Withdrawal.Repository;

namespace ATM_Withdrawal.Service
{
    public class DispenseModeService
    {
        MainRepository mainRepository = MainRepository.Instance;

        public void SetMode(int mode)
        {
            mainRepository.dispenseMode = mode;

            switch(mode)
            {
                case (int)DispenseMenuOptions.FIRST_MODE:
                    Console.WriteLine("\n* - Dispense denominations set to 200 and 1,000.");
                    break;
                case (int)DispenseMenuOptions.SECOND_MODE:
                    Console.WriteLine("\n* - Dispense denominations set to 100 and 500.");
                    break;
                case (int)DispenseMenuOptions.EFFICIENT_MODE:
                    Console.WriteLine("\n* - Dispense denominations set to 100, 200, 500 and 1,000.");
                    break;
            }

            Console.ReadKey();
        }
    }
}
