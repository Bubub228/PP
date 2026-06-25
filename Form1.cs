namespace PP
{
    // Модуль 1: Ввод/вывод данных 
    public partial class Form1 : Form
    {
        // Инициализируем Фасад интеграции модулей
        private readonly TaxServiceFacade _taxFacade;

        public Form1()
        {
            InitializeComponent();
            _taxFacade = new TaxServiceFacade();
            cmbUsnRate.SelectedIndex = 0;
        }

        // Действие при нажатии на кнопку "Рассчитать"
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Вызываем интеграционный фасад и передаем сырые данные из UI
                TaxResultSummary results = _taxFacade.ProcessCalculations(
                    txtIncome.Text,
                    txtExpenses.Text,
                    txtVatBase.Text,
                    cmbUsnRate.SelectedIndex
                );

                // Вывод результатов
                rtxResults.Clear();
                rtxResults.SelectionFont = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);
                rtxResults.AppendText("--- РЕЗУЛЬТАТЫ РАСЧЕТА НАЛОГОВОЙ НАГРУЗКИ ---\n\n");

                rtxResults.SelectionFont = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular);
                rtxResults.AppendText($" Налог на добавленную стоимость (НДС 20%): {results.VatResult:N2} руб.\n");
                rtxResults.AppendText($" Налог на прибыль (20% от базы): {results.ProfitTaxResult:N2} руб.\n");
                rtxResults.AppendText($" Налог по упрощенной системе (УСН): {results.UsnResult:N2} руб.\n");
                rtxResults.AppendText("-----------------------------------------------------------------------\n");

                rtxResults.SelectionFont = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);
                rtxResults.AppendText($" СУММАРНАЯ НАЛОГОВАЯ НАГРУЗКА: {results.TotalTaxBurden:N2} руб.\n");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка диапазона данных", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Неверный формат ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла непредвиденная ошибка: {ex.Message}", "Ошибка системы", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Действие при нажатии на кнопку "Очистить"
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtIncome.Clear();
            txtExpenses.Clear();
            txtVatBase.Clear();
            rtxResults.Clear();
            cmbUsnRate.SelectedIndex = 0;
        }

        private void cmbUsnRate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
