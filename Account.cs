namespace Accounts
{
    public abstract class Account
    {
        public int AccountNumber{
            get;
            set;
        }
        public double Balance{
            get;
            set;
        }
        public Account(int AccountNumber)
        {
            this.AccountNumber = AccountNumber;
            //set initial value to zero
            Balance=0;
        }
    
        //Deposit method
        public void Deposit(double amount){
            //deposit algo
            if(amount>0){

                Balance+=amount;
                Console.WriteLine($"Deposited ${amount} into Account {AccountNumber}");
            }
            else{
                Console.WriteLine("Invalid Deposit Amount.");
            }
        }
        //Withdraw method
        public virtual void Withdraw(double amount){

            //withdraw algo

            if(amount>0 && Balance>=amount){

                Balance-=amount;
                Console.WriteLine($"Withdrawn ${amount} into Account {AccountNumber}");
            }
            else{

                Console.WriteLine("Insufficient Balance");
            }
        }

        
            public void DisplayAccountDetails(){

        Console.WriteLine($"Account Number :{AccountNumber}");

        Console.WriteLine($"Current Balance :${Balance}");
    }
    }
}
