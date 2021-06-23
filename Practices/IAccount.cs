namespace Practices
{
    internal interface IAccount
    {
        /// <summary>
        /// Метод для расчёта процентной ставки
        /// </summary>
        /// <param name="balance"></param>
        void CalculateInterest(double balance);
    }
}
