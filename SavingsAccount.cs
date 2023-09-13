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
