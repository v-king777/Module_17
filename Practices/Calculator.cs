namespace Practices
{
    internal class Calculator
    {
        public Calculator(IAccount account)
        {
            Account = account;
        }

        public IAccount Account { get; }

        public double Balance { get; set; }

        /// <summary>
        /// Метод для запуска расчёта
        /// </summary>
        public void Calculate()
        {
            Account.CalculateInterest(Balance);
        }
    }
}
