using System;
using System.Collections.Generic;
using System.Text;

namespace PP
{
    // Модуль #2: Математические и логические расчеты
    public class TaxCalculator
    {
        // Функция 1: Расчет НДС (20%)
        public double CalculateVat(double vatBase)
        {
            return vatBase * 0.20;
        }

        // Функция 2: Расчет налога на прибыль (20%)
        public double CalculateProfitTax(double income, double expenses)
        {
            double profit = income - expenses;
            // Если бизнес сработал в убыток, налог равен 0
            return profit > 0 ? profit * 0.20 : 0;
        }

        // Функция 3: Расчет УСН (6% или 15%)
        public double CalculateUsn(double income, double expenses, bool isIncomeMinusExpenses)
        {
            if (isIncomeMinusExpenses)
            {
                double profit = income - expenses;
                return profit > 0 ? profit * 0.15 : 0;
            }
            else
            {
                return income * 0.06;
            }
        }
    }
}
