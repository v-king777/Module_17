using System;

namespace Practices
{
    internal class NormalAccount : IAccount
    {
        public void CalculateInterest(double balance)
        {
            double interest;

            interest = balance * 0.4;

            if (balance < 1000)
            {
                interest -= balance * 0.2;
            }

            if (balance < 50000)
            {
                interest -= balance * 0.4;
            }

            // Странные расчёты. Что бы они не значили, они взяты из задания
            Console.WriteLine($"Процентная ставка для обычного аккаунта: {interest}");
        }
    }
}
