﻿using System;
using ATM_Withdrawal.Enum;
using ATM_Withdrawal.Service;

namespace ATM_Withdrawal.Menu
{
    public class DispenseModeMenu
    {
        public void ShowMenu()
        {
            try
            {
                Console.Clear();

                MainMenu mainMenu = new MainMenu();
                DispenseModeService dispenseModeService = new DispenseModeService();

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
                    case (int)DispenseMenuOptions.FIRST_MODE:
                        dispenseModeService.SetMode((int)DispenseMenuOptions.FIRST_MODE);
                        Console.WriteLine("Now this ATM will dispense cash of 200 and 1000.");
                        Console.ReadKey();
                        ShowMenu();
                        break;
                    case (int)DispenseMenuOptions.SECOND_MODE:
                        dispenseModeService.SetMode((int)DispenseMenuOptions.SECOND_MODE);
                        Console.WriteLine("Now this ATM will dispense cash of 100 and 500.");
                        Console.ReadKey();
                        ShowMenu();
                        break;
                    case (int)DispenseMenuOptions.EFFICIENT_MODE:
                        dispenseModeService.SetMode((int)DispenseMenuOptions.EFFICIENT_MODE);
                        Console.WriteLine("Now this ATM will dispense in Efficient Mode with " +
                            "\ncash of 100, 200, 500 and 1000.");
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