using System;

namespace Practices
{
    internal class SalaryAccount : IAccount
    {
        public void CalculateInterest(double balance)
        {
            // Странные расчёты. Что бы они не значили, они взяты из задания
            Console.WriteLine($"Процентная ставка для зарплатного аккаунта: {balance * 0.5}");
        }
    }
}
