using System;
using System.Windows.Forms;

namespace CurrencyConverterApp
{
    public partial class Form1 : Form
    {
        private readonly decimal usdBuyRate = 39.50m;
        private readonly decimal usdSellRate = 40.00m;
        private readonly decimal eurBuyRate = 42.50m;
        private readonly decimal eurSellRate = 42.95m;

        // Конструктор класу
        public Form1()
        {
            InitializeComponent();
            DisplayExchangeRates(); // Вивід курсів валют на формі
            CustomizeUI(); // Налаштування вигляду інтерфейсу користувача
            LoadCurrencies(); // Завантаження валют до ComboBox
        }

        // Метод для відображення курсів валют
        private void DisplayExchangeRates()
        {
            usdBuyLabel.Text = $"Покупка: {usdBuyRate} грн";
            usdSellLabel.Text = $"Продажа: {usdSellRate} грн";
            eurBuyLabel.Text = $"Покупка: {eurBuyRate} грн"; // Відображення курсів покупки і продажу для EUR
            eurSellLabel.Text = $"Продажа: {eurSellRate} грн";
        }

        // Метод для налаштування вигляду інтерфейсу користувача
        private void CustomizeUI()
        {
            ConvertButton.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            ConvertButton.ForeColor = System.Drawing.Color.White;
            ConvertButton.BackColor = System.Drawing.Color.Green;
            ConvertButton.Text = "Конвертувати";

            amountTextBox.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Regular);

            purchaseRadioButton.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold); // Зроблено жирний шрифт для радіокнопок
            purchaseRadioButton.Text = "Покупка валюти";
            purchaseRadioButton.Checked = true;

            saleRadioButton.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold); // Зроблено жирний шрифт для радіокнопок
            saleRadioButton.Text = "Продаж валюти";
        }


        // Метод для завантаження валют до ComboBox
        private void LoadCurrencies()
        {
            currencyComboBox.Items.AddRange(new string[] { "USD", "EUR" });
            currencyComboBox.SelectedIndex = 0;
        }

        // Обробник події кліку на кнопці "Конвертувати"
        private void ConvertButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount = decimal.Parse(amountTextBox.Text);
                decimal selectedRate = 0;

                if (currencyComboBox.SelectedItem.ToString() == "USD")
                {
                    selectedRate = purchaseRadioButton.Checked ? usdBuyRate : usdSellRate;
                }
                else if (currencyComboBox.SelectedItem.ToString() == "EUR")
                {
                    selectedRate = purchaseRadioButton.Checked ? eurBuyRate : eurSellRate;
                }

                decimal convertedAmount = amount * selectedRate;
                resultLabel.Text = $"Результат: {convertedAmount} грн";

                

            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректну суму.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Виникла помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
