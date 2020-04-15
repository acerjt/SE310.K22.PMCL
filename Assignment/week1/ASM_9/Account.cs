using System;

namespace ASM_9
{
    public class Account
    {
        private int mCode;
        private string mName;
        private int mBalance;

        public Account() {
            mCode = 0;
            mName = null;
            mBalance = 0;
        }

        public Account(int code, string name, int balance) {
            mCode = code;
            mName  = name;
            mBalance = balance;
        }

        public int GetCash {
            set {
                if(value > mBalance)
                    Console.WriteLine("The value cannot be greater than the current balance");
                else {
                    mBalance = mBalance - value;
                    Console.WriteLine("Succeed to withdraw " + value + " by cash");
                }
            }
        }

        public int DepositCash {
            set {
                if(value <= 0)
                    Console.WriteLine("The value cannot be smaller than 0");
                else {
                    mBalance = mBalance + value;
                    Console.WriteLine("Succeed to deposit " + value + " by cash");
                }
            }

        }

        public int DepositCheck {
            set {
                if(value <= 0)
                    Console.WriteLine("The value cannot be smaller than 0");
                else {
                    mBalance = mBalance + value;
                    Console.WriteLine("Succeed to deposit " + value + " by check");
                }
            }
        }

        public int BalancesStatment {
            get {
                return mBalance;
            }
        }

        public int Transfer {
            set {
                if(value <= 0) {
                    Console.WriteLine("The value cannot be smaller than 0");
                }
                else if(value > mBalance) {
                    Console.WriteLine("Your account is insufficient");
                }
                else {
                    mBalance = mBalance - value;
                    Console.WriteLine("Succeed to transfer " + value + " to received account");
                }
            }
        }
    }
}
