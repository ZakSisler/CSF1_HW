using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF__HWLab
{
    class ATMproj
    {
        static void Main(string[] args)
        {

            Console.WriteLine();
            Console.Title = "----ACME ATM CO.----";
            Console.WriteLine("ACME ATM CO. \n ");



            int accountNumber = 12340987;
            int pinAccess = 3210;
            decimal accountBalance = 2034;
            bool authIs = false;

            do
            {
                #region Authorization Info
                Console.WriteLine("Enter Account Number: \n");
                int userAccount = Convert.ToInt32(Console.ReadLine());




                if (userAccount == accountNumber || userAccount == 0)
                {
                    //authIs = true;
                    Console.WriteLine("Account {0} Access has been granted\n\n", accountNumber);
                    //break;
                }
                else
                {
                    Console.WriteLine("\nInvalid Account Number");

                    for (int i = 3; i >= 1; i--)
                    {
                        Console.WriteLine("\nEnter your account number again. ({0} tries remaining). ", i);
                        userAccount = Convert.ToInt32(Console.ReadLine());
                        if (userAccount == accountNumber)
                        {
                            //authIs = true;
                            Console.WriteLine("Access Granted!");
                            break;

                        }
                        else
                        {
                            //authIs = false;
                            Console.Write("Permission Denied. ");


                            if (i == 1)
                            {
                                Console.WriteLine("Too many entry attempts; \nExiting to menu...'");
                                Environment.Exit(0);

                            }
                        }

                    }
                    //return;//??
                }


                #region Pin Auth
                Console.WriteLine("Enter your 4 digit pin ");
                int userPin = Convert.ToInt32(Console.ReadLine());



                if (userPin == pinAccess)
                {
                    //authIs = true;
                    Console.WriteLine("Access Granted! \n\nPress any key to continue...");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("ACCESS DENIED - you have 3 more tries remaining...");
                    for (int x = 1; x <= 3; x++)
                    {
                        Console.WriteLine("Enter your pin again. (Attempt: {0})", x );
                        userPin = Convert.ToInt16(Console.ReadLine());
                        if (userPin == pinAccess)
                        {

                            Console.WriteLine("Access Granted! \n\nPress Any key to continue");
                            Console.ReadKey();
                            break;
                        }
                        else
                        {

                            Console.WriteLine("Wrong user pin.");
                            if (x == 3)
                            {
                                Console.WriteLine("Too many pin attempts; Exiting to menu...'");
                                Environment.Exit(0);
                            }

                        }
                    }
                    //break;

                }
                #endregion


                #endregion
            } while (!authIs);


            bool accessTop = false;
            do
            {

                #region Menu Selection
                //Console.Clear();
                Console.WriteLine("--------ACME ATM CO. Menu Options\n");
                Console.WriteLine("1. Current Balance\n");
                Console.WriteLine("2. Withdraw \n");
                Console.WriteLine("3. Deposit \n");
                Console.WriteLine("4. Exit Menu \n");
                Console.WriteLine();
                Console.WriteLine("Please enter the number of your choice: ");


                pinAccess = Convert.ToInt16(Console.ReadLine());
                switch (pinAccess)
                {
                    case 1:
                        accessTop = true;
                        Console.WriteLine("\n Your current balance is: ${0} \nPress any key to continue...", accountBalance);
                        Console.ReadKey();
                        continue;
                    case 2:
                        Console.Write("\nPlease enter the amount you'd like to withdraw: $");
                        decimal withdraw = Convert.ToDecimal(Console.ReadLine());
                        if (withdraw > accountBalance)
                        {
                            Console.WriteLine("\n Withdrawal exceeds your available account balance.");
                            return;
                        }
                        else if (withdraw < 20)
                        {
                            Console.WriteLine("\n Sorry! Withdrawals have a minimum requirement of at least $20.00 ");
                            continue;
                        }
                        else
                        {
                            accountBalance = accountBalance - withdraw;
                            Console.WriteLine("\n\n Please collect your cash. Cash should equal ${0}\n ", withdraw);
                            Console.WriteLine("\n Current balance is: ${0} after withdrawal", accountBalance);
                            Console.WriteLine();
                            Console.WriteLine("Would you like to continue? (Y/N)");
                            ConsoleKey yes = Console.ReadKey(true).Key;
                            if (yes == ConsoleKey.Y)
                            {
                                continue;
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nPlease enter the deposit amount ");
                        decimal deposit = Convert.ToDecimal(Console.ReadLine());
                        accountBalance = accountBalance + deposit;
                        Console.WriteLine("Your deposit was successful... \nYour total balance is now: {0}", accountBalance);
                        continue;
                    case 4:
                        Console.WriteLine("\n Exiting your account...");
                        accessTop = false;
                        break;
                }

                Console.WriteLine("\n\n Thanks for using ACME ATM CO.!!\n\n-------------------------------------------");
                #endregion

            } while (accessTop);


        }//end Main()
    }//end class
}//end namespace

