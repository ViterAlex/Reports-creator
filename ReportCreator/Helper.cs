namespace ReportCreator
{
    internal static class Helper
    {
        /// <summary>
        /// Строковое значение целого числа.
        /// <para>Пустая строка, если число равно нулю.</para>
        /// </summary>
        internal static string GetString(this int value)
        {
            return value == 0 ? string.Empty : value.ToString();
        }
    }
}
