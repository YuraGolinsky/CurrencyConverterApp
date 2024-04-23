Запуск программы: После запуска программы откроется окно с пользовательским интерфейсом.
Выбор валюты: Выберите валюту, которую хотите конвертировать. Для этого используйте выпадающий список "Валюта".
Ввод суммы: Введите сумму в поле "Сумма", которую необходимо конвертировать.
Выбор типа операции: Выберите, хотите ли вы купить валюту или продать. Для этого используйте радиокнопки "Покупка валюты" и "Продажа валюты".
Конвертация: После ввода суммы и выбора валюты и типа операции нажмите кнопку "Конвертировать". Результат конвертации будет отображен в поле "Результат".
Обработка ошибок: Если вы введете неверные данные или возникнет ошибка, приложение уведомит вас об этом с помощью окна с сообщением.
Закрытие программы: После завершения работы с программой вы можете закрыть ее, нажав кнопку закрытия в окне программы или используя стандартные методы закрытия окна.


О коде:
Класс Form1 является основным окном программы.

Конструкторы Form1 вызывают методы для отображения курсов валют, настройки интерфейса и загрузки валют в ComboBox.

Отображение курсов валют:
Метод DisplayExchangeRates устанавливает тексты для меток, показывающие курсы покупки и продажи валют.

Настройка интерфейса:
Метод CustomizeUI настраивает вид элементов интерфейса, таких как кнопка, текстовое поле и радиокнопки.

Загрузка валют:
Метод LoadCurrencies добавляет валюты в выпадающий список ComboBox.

Обработка клика на кнопке "Конвертировать":
При нажатии кнопки будет вызван метод ConvertButton_Click.

Код в этом методе конвертирует введенную сумму в выбранную валюту по текущему курсу.
После конвертации результат выводится на экран в виде строки.


Обработка ошибок:
При вводе неправильных данных выводится сообщение об ошибке.

![image](https://github.com/YuraGolinsky/CurrencyConverterApp/assets/134283897/88874807-e30c-43a2-b13f-44b7ddbba5c3)


translation into English


Launching the program: After launching the program, a window with a user interface will open.
Currency Selection: Select the currency you want to convert. To do this, use the "Currency" drop-down list.
Entering Amount: Enter the amount in the Amount field that you want to convert.
Selecting a transaction type: Select whether you want to buy or sell currency. To do this, use the “Buy currency” and “Sell currency” radio buttons.
Conversion: After entering the amount and selecting the currency and transaction type, click the "Convert" button. The conversion result will be displayed in the "Result" field.
Error Handling: If you enter incorrect data or an error occurs, the application will notify you with a message box.
Closing a program: After you finish working with a program, you can close it by clicking the close button in the program window or using standard methods for closing a window.






About the code:
Class Form1 is the main window of the program.

Form1 constructors call methods to display currency rates, customize the interface, and load currencies into the ComboBox.

Displaying exchange rates:
The DisplayExchangeRates method sets texts for labels showing the buying and selling rates of currencies.

Interface setup:
The CustomizeUI method customizes the appearance of interface elements such as button, text field, and radio buttons.

Loading currencies:
The LoadCurrencies method adds currencies to the ComboBox dropdown list.

Processing a click on the "Convert" button:
When the button is clicked, the ConvertButton_Click method will be called.

The code in this method converts the entered amount into the selected currency at the current rate.
After conversion, the result is displayed on the screen as a string.


Error processing:
If you enter incorrect data, an error message is displayed.
