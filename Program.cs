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

using Accounts;

public class Program{

public static void Main(){
    SavingsAccount savingsAccount=new SavingsAccount(1001,5);
    savingsAccount.Deposit(1500);
    savingsAccount.DisplayAccountDetails();
    savingsAccount.CalculatedInterest();
    savingsAccount.DisplayAccountDetails();

    Console.WriteLine();

    CheckingAccount checkingAccount=new CheckingAccount(2001,500);
    checkingAccount.Deposit(1200);
    checkingAccount.DisplayAccountDetails();
    checkingAccount.Withdraw(1500);
    checkingAccount.DisplayAccountDetails();
}
}

 
namespace Accounts
{
    public class SavingsAccount : Account{
        public double Interestrate {get;}
        public SavingsAccount(int Accountnumber, double Interestrate) : base (Accountnumber)
        {
            this.Interestrate=Interestrate;
        }
        public void CalculatedInterest(){
             double interest = Balance*(Interestrate/80) ;
             double interest1 = interest+Balance;
             Balance=interest1;
             Console.WriteLine($"Interest Earned: {interest}");
        }
    }
}

namespace Accounts{
    public class CheckingAccount : Account{

        public double OverdraftLimit {
            get;
            }

        public CheckingAccount(int AccountNumber, double OverdraftLimit) : base(AccountNumber)
        {
            this.OverdraftLimit=OverdraftLimit;
        }
                public override void Withdraw(double amount){
                        if(amount>OverdraftLimit && Balance >= OverdraftLimit){
                Balance-=amount;
                Console.WriteLine($"Withdrawn ${amount}.\nNew Balance ${Balance}");
            }
            else{
                Console.WriteLine("Insufficient Balance or OverdraftLimit has been reached.");
            }
        }
    }
}
