using System;
using System.Collections.Generic;
using System.Text;

namespace PP
{
    // Паттерн интеграции "Фасад" для координации модулей
    public class TaxServiceFacade
    {
        private readonly TaxCalculator _calculator;
        private readonly InputValidator _validator;

        public TaxServiceFacade()
        {
            _calculator = new TaxCalculator();
            _validator = new InputValidator();
        }

        // Единая точка входа для выполнения бизнес-логики программы
        public TaxResultSummary ProcessCalculations(string rawIncome, string rawExpenses, string rawVatBase, int usnModeIndex)
        {
            // 1. Валидация данных (Модуль 3)
            _validator.ValidateString(rawIncome, out double income, "Доходы");
            _validator.ValidateString(rawExpenses, out double expenses, "Расходы");
            _validator.ValidateString(rawVatBase, out double vatBase, "Сумма без НДС");

            if (usnModeIndex < 0)
            {
                throw new Exception("Пожалуйста, выберите режим налогообложения УСН.");
            }

            // 2. Проведение расчетов (Модуль 2)
            double vat = _calculator.CalculateVat(vatBase);
            double profitTax = _calculator.CalculateProfitTax(income, expenses);

            bool isIncomeMinusExpenses = (usnModeIndex == 1);
            double usn = _calculator.CalculateUsn(income, expenses, isIncomeMinusExpenses);

            // 3. Формирование единого объекта ответа
            return new TaxResultSummary
            {
                VatResult = vat,
                ProfitTaxResult = profitTax,
                UsnResult = usn,
                TotalTaxBurden = vat + profitTax + usn
            };
        }
    }

    // Вспомогательный класс-структура для передачи результатов
    public class TaxResultSummary
    {
        public double VatResult { get; set; }
        public double ProfitTaxResult { get; set; }
        public double UsnResult { get; set; }
        public double TotalTaxBurden { get; set; }
    }
}
