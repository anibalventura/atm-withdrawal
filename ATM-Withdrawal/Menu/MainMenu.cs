﻿using System;
using ATM_Withdrawal.Enum;

namespace ATM_Withdrawal.Menu
{
    public class MainMenu
    {
        public void ShowMenu()
        {
            try
            {
                Console.Clear();

                DispenseMenu dispenseMenu = new DispenseMenu();

                Console.WriteLine("Welcome to ATM Withdrawal!\n");

                string[] options = { "Dispense Mode", "Withdrawal", "Exit" };

                for (int i = 0; i < options.Length; i++)
                {
                    Console.WriteLine($"{i + 1} - {options[i]}");
                }

                Console.Write("\nSelect an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case (int)MainMenuOptions.DISPENSE_MODE:
                        dispenseMenu.ShowMenu();
                        ShowMenu();
                        break;
                    case (int)MainMenuOptions.WITHDRAWAL:
                        Console.WriteLine("Withdrawal Menu Selected");
                        Console.ReadKey();
                        ShowMenu();
                        break;
                    case (int)MainMenuOptions.EXIT:
                        Console.WriteLine("\nThanks for using ATM Withdrawal!");
                        Console.WriteLine("Made by Anibal Ventura");
                        Console.ReadKey();
                        Environment.Exit(0);
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
