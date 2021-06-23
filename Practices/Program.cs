namespace Practices
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            IAccount account = new NormalAccount(); // Создаём аккаунт нужного типа
            Calculator calculator = new Calculator(account); // Загоняем его в калькулятор

            calculator.Balance = 100000;
            calculator.Calculate();
        }
    }
}
