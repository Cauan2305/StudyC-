namespace ClasseSelada.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account(){}

        public Account(int number,string holder, double balance )
        {
            Number=number;
            Holder=holder;
            Balance=balance;
        }
        // Usar o Virtual Para o metodo poder ser sobescrito 
        public virtual void Withdraw(double amount)
        {
            Balance-=amount+5.0;
        }

        public void Deposit(double amount)
        {
            Balance+=amount;
        }
    }
}