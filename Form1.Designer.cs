namespace PP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtIncome = new TextBox();
            label1 = new Label();
            txtExpenses = new TextBox();
            label3 = new Label();
            txtVatBase = new TextBox();
            cmbUsnRate = new ComboBox();
            label4 = new Label();
            btnCalculate = new Button();
            btnClear = new Button();
            label2 = new Label();
            rtxResults = new RichTextBox();
            SuspendLayout();
            // 
            // txtIncome
            // 
            txtIncome.Location = new Point(70, 92);
            txtIncome.Name = "txtIncome";
            txtIncome.Size = new Size(100, 23);
            txtIncome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 74);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Доходы (руб)";
            // 
            // txtExpenses
            // 
            txtExpenses.Location = new Point(237, 92);
            txtExpenses.Name = "txtExpenses";
            txtExpenses.Size = new Size(113, 23);
            txtExpenses.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(436, 74);
            label3.Name = "label3";
            label3.Size = new Size(125, 15);
            label3.TabIndex = 5;
            label3.Text = "Сумма без НДС (руб)";
            // 
            // txtVatBase
            // 
            txtVatBase.Location = new Point(436, 92);
            txtVatBase.Name = "txtVatBase";
            txtVatBase.Size = new Size(125, 23);
            txtVatBase.TabIndex = 4;
            // 
            // cmbUsnRate
            // 
            cmbUsnRate.FormattingEnabled = true;
            cmbUsnRate.Items.AddRange(new object[] { "УСН Доходы (6%)", "УСН Доходы минус Расходы (15%)" });
            cmbUsnRate.Location = new Point(209, 208);
            cmbUsnRate.Name = "cmbUsnRate";
            cmbUsnRate.Size = new Size(161, 23);
            cmbUsnRate.TabIndex = 6;
            cmbUsnRate.SelectedIndexChanged += cmbUsnRate_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(255, 190);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 7;
            label4.Text = "Ставка УСН";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(209, 267);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(161, 23);
            btnCalculate.TabIndex = 8;
            btnCalculate.Text = "Рассчитать нагрузку";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(209, 296);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(161, 23);
            btnClear.TabIndex = 9;
            btnClear.Text = "Очистить";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(242, 74);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 10;
            label2.Text = "Расходы (руб)";
            // 
            // rtxResults
            // 
            rtxResults.Location = new Point(404, 187);
            rtxResults.Name = "rtxResults";
            rtxResults.Size = new Size(202, 197);
            rtxResults.TabIndex = 11;
            rtxResults.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(614, 450);
            Controls.Add(rtxResults);
            Controls.Add(label2);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(label4);
            Controls.Add(cmbUsnRate);
            Controls.Add(label3);
            Controls.Add(txtVatBase);
            Controls.Add(txtExpenses);
            Controls.Add(label1);
            Controls.Add(txtIncome);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIncome;
        private Label label1;
        private TextBox txtExpenses;
        private Label label3;
        private TextBox txtVatBase;
        private ComboBox cmbUsnRate;
        private Label label4;
        private Button btnCalculate;
        private Button btnClear;
        private Label label2;
        private RichTextBox rtxResults;
    }
}
