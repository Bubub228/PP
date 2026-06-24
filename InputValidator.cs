using System;
using System.Collections.Generic;
using System.Text;

namespace PP
{
    // Модуль #3: Обработка ошибок и валидация данных
    public class InputValidator
    {
        public bool ValidateString(string input, out double result, string fieldName)
        {
            result = 0;

            // Проверка на пустоту
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentException($"Поле '{fieldName}' не должно быть пустым.");
            }

            // Проверка на числовое значение
            if (!double.TryParse(input, out result))
            {
                throw new FormatException($"Поле '{fieldName}' должно содержать только числовые значения.");
            }

            // Проверка на отрицательные числа
            if (result < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(input), $"Значение в поле '{fieldName}' не может быть отрицательным.");
            }

            return true;
        }
    }
}
