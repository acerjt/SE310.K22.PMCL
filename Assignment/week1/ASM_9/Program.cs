using System;

namespace ASM_9
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1, "David", 1000);
            int accChoice = 0;
            Console.WriteLine("******Welcome to ATM banking*******");
            while(true) {
                do {
                    Console.WriteLine("----What do you want to do?----");
                    Console.WriteLine("1. Get cash");
                    Console.WriteLine("2. Deposit cash");
                    Console.WriteLine("3. Deposit check");
                    Console.WriteLine("4. Balance statement");
                    Console.WriteLine("5. Transfer");
                    Console.WriteLine("6. Exit");
                    Console.Write("Enter your choice: ");
                    accChoice = Convert.ToInt32(Console.ReadLine());

                    if(accChoice < 1 || accChoice > 6) {
                        Console.WriteLine("You have enterd the wrong choice");
                    }
                }while(accChoice < 1 || accChoice > 6);
                switch (accChoice) {
                    case 1:
                        Console.WriteLine("Input the cash you wan to get: ");
                        int getCash = Convert.ToInt32(Console.ReadLine());
                        acc.GetCash = getCash;
                        break;
                    case 2:
                        Console.WriteLine("Input the cash you wan to deposit: ");
                        int depositCash = Convert.ToInt32(Console.ReadLine());
                        acc.DepositCash = depositCash;
                        break;
                    case 3:
                        Console.WriteLine("Input the check you wan to deposit: ");
                        int depositCheck = Convert.ToInt32(Console.ReadLine());
                        acc.DepositCheck = depositCheck;
                        break;
                    case 4:
                        Console.WriteLine("The current balance of this account: " + acc.BalancesStatment);
                        break;
                    case 5:
                        Console.WriteLine("ENter the amount that you want to transfer: ");
                        int transfer = Convert.ToInt32(Console.ReadLine());
                        acc.Transfer = transfer;
                        break;
                    case 6:
                        Console.WriteLine("Thank you for using our ATM.");
                        return;
                    
                }
            }

        }
    }
}
