namespace CurrencyConverterApp
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ConvertButton = new System.Windows.Forms.Button();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.eurSellLabel = new System.Windows.Forms.Label();
            this.usdSellLabel = new System.Windows.Forms.Label();
            this.eurBuyLabel = new System.Windows.Forms.Label();
            this.usdBuyLabel = new System.Windows.Forms.Label();
            this.purchaseRadioButton = new System.Windows.Forms.RadioButton();
            this.saleRadioButton = new System.Windows.Forms.RadioButton();
            this.currencyComboBox = new System.Windows.Forms.ComboBox();
            this.resultLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(128, 287);
            this.ConvertButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(190, 34);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Конвертувати";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click);
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(128, 259);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(190, 20);
            this.amountTextBox.TabIndex = 4;
            // 
            // eurSellLabel
            // 
            this.eurSellLabel.AutoSize = true;
            this.eurSellLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eurSellLabel.Location = new System.Drawing.Point(401, 200);
            this.eurSellLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eurSellLabel.Name = "eurSellLabel";
            this.eurSellLabel.Size = new System.Drawing.Size(39, 14);
            this.eurSellLabel.TabIndex = 7;
            this.eurSellLabel.Text = "label2";
            // 
            // usdSellLabel
            // 
            this.usdSellLabel.AutoSize = true;
            this.usdSellLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usdSellLabel.Location = new System.Drawing.Point(151, 200);
            this.usdSellLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usdSellLabel.Name = "usdSellLabel";
            this.usdSellLabel.Size = new System.Drawing.Size(39, 14);
            this.usdSellLabel.TabIndex = 8;
            this.usdSellLabel.Text = "label2";
            // 
            // eurBuyLabel
            // 
            this.eurBuyLabel.AutoSize = true;
            this.eurBuyLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.eurBuyLabel.Location = new System.Drawing.Point(401, 176);
            this.eurBuyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eurBuyLabel.Name = "eurBuyLabel";
            this.eurBuyLabel.Size = new System.Drawing.Size(39, 14);
            this.eurBuyLabel.TabIndex = 11;
            this.eurBuyLabel.Text = "label2";
            // 
            // usdBuyLabel
            // 
            this.usdBuyLabel.AutoSize = true;
            this.usdBuyLabel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usdBuyLabel.Location = new System.Drawing.Point(151, 176);
            this.usdBuyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usdBuyLabel.Name = "usdBuyLabel";
            this.usdBuyLabel.Size = new System.Drawing.Size(39, 14);
            this.usdBuyLabel.TabIndex = 12;
            this.usdBuyLabel.Text = "label2";
            // 
            // purchaseRadioButton
            // 
            this.purchaseRadioButton.AutoSize = true;
            this.purchaseRadioButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.purchaseRadioButton.Location = new System.Drawing.Point(95, 70);
            this.purchaseRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.purchaseRadioButton.Name = "purchaseRadioButton";
            this.purchaseRadioButton.Size = new System.Drawing.Size(95, 18);
            this.purchaseRadioButton.TabIndex = 13;
            this.purchaseRadioButton.TabStop = true;
            this.purchaseRadioButton.Text = "radioButton1";
            this.purchaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // saleRadioButton
            // 
            this.saleRadioButton.AutoSize = true;
            this.saleRadioButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saleRadioButton.Location = new System.Drawing.Point(248, 70);
            this.saleRadioButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.saleRadioButton.Name = "saleRadioButton";
            this.saleRadioButton.Size = new System.Drawing.Size(114, 18);
            this.saleRadioButton.TabIndex = 14;
            this.saleRadioButton.TabStop = true;
            this.saleRadioButton.Text = "saleRadioButton";
            this.saleRadioButton.UseVisualStyleBackColor = true;
            // 
            // currencyComboBox
            // 
            this.currencyComboBox.FormattingEnabled = true;
            this.currencyComboBox.Location = new System.Drawing.Point(156, 107);
            this.currencyComboBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.currencyComboBox.Name = "currencyComboBox";
            this.currencyComboBox.Size = new System.Drawing.Size(140, 22);
            this.currencyComboBox.TabIndex = 15;
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resultLabel.Location = new System.Drawing.Point(335, 108);
            this.resultLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(46, 16);
            this.resultLabel.TabIndex = 16;
            this.resultLabel.Text = "label2";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::CurrencyConverterApp.Properties.Resources.Евро1;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(281, 162);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 81);
            this.button2.TabIndex = 18;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::CurrencyConverterApp.Properties.Resources.Доллар1;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(33, 159);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 84);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(155, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Конвертер валют";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.currencyComboBox);
            this.Controls.Add(this.saleRadioButton);
            this.Controls.Add(this.purchaseRadioButton);
            this.Controls.Add(this.usdBuyLabel);
            this.Controls.Add(this.eurBuyLabel);
            this.Controls.Add(this.usdSellLabel);
            this.Controls.Add(this.eurSellLabel);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.ConvertButton);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Конвертер валют";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.Label eurSellLabel;
        private System.Windows.Forms.Label usdSellLabel;
        private System.Windows.Forms.Label eurBuyLabel;
        private System.Windows.Forms.Label usdBuyLabel;
        private System.Windows.Forms.RadioButton purchaseRadioButton;
        private System.Windows.Forms.RadioButton saleRadioButton;
        private System.Windows.Forms.ComboBox currencyComboBox;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

