namespace BankForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.InfoClient = new System.Windows.Forms.Label();
            this.GetInfoButtonClient = new System.Windows.Forms.Button();
            this.AddRequestBox = new System.Windows.Forms.ComboBox();
            this.ReqestButtonClient = new System.Windows.Forms.Button();
            this.FIOClientLable = new System.Windows.Forms.Label();
            this.LoginClientLable = new System.Windows.Forms.Label();
            this.ExitClient = new System.Windows.Forms.Button();
            this.FIOClient = new System.Windows.Forms.TextBox();
            this.LoginClient = new System.Windows.Forms.TextBox();
            this.EnterClient = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewCredits = new System.Windows.Forms.DataGridView();
            this.DeleteCMButton = new System.Windows.Forms.Button();
            this.DeleteRequestCMButton = new System.Windows.Forms.Button();
            this.TakeRequestCMButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.UpdateCMButton = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.UpdateCSButton = new System.Windows.Forms.Button();
            this.dataGridViewCashier = new System.Windows.Forms.DataGridView();
            this.PaymentCreditButton = new System.Windows.Forms.Button();
            this.moneyTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCredits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCashier)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1458, 609);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.InfoClient);
            this.tabPage1.Controls.Add(this.GetInfoButtonClient);
            this.tabPage1.Controls.Add(this.AddRequestBox);
            this.tabPage1.Controls.Add(this.ReqestButtonClient);
            this.tabPage1.Controls.Add(this.FIOClientLable);
            this.tabPage1.Controls.Add(this.LoginClientLable);
            this.tabPage1.Controls.Add(this.ExitClient);
            this.tabPage1.Controls.Add(this.FIOClient);
            this.tabPage1.Controls.Add(this.LoginClient);
            this.tabPage1.Controls.Add(this.EnterClient);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1450, 580);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // InfoClient
            // 
            this.InfoClient.Location = new System.Drawing.Point(558, 81);
            this.InfoClient.Name = "InfoClient";
            this.InfoClient.Size = new System.Drawing.Size(247, 402);
            this.InfoClient.TabIndex = 9;
            // 
            // GetInfoButtonClient
            // 
            this.GetInfoButtonClient.Location = new System.Drawing.Point(558, 45);
            this.GetInfoButtonClient.Name = "GetInfoButtonClient";
            this.GetInfoButtonClient.Size = new System.Drawing.Size(247, 23);
            this.GetInfoButtonClient.TabIndex = 8;
            this.GetInfoButtonClient.Text = "Получить информацию";
            this.GetInfoButtonClient.UseVisualStyleBackColor = true;
            this.GetInfoButtonClient.Click += new System.EventHandler(this.GetInfoButtonClient_Click);
            // 
            // AddRequestBox
            // 
            this.AddRequestBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddRequestBox.FormattingEnabled = true;
            this.AddRequestBox.Location = new System.Drawing.Point(388, 75);
            this.AddRequestBox.Name = "AddRequestBox";
            this.AddRequestBox.Size = new System.Drawing.Size(121, 24);
            this.AddRequestBox.TabIndex = 7;
            // 
            // ReqestButtonClient
            // 
            this.ReqestButtonClient.Location = new System.Drawing.Point(388, 45);
            this.ReqestButtonClient.Name = "ReqestButtonClient";
            this.ReqestButtonClient.Size = new System.Drawing.Size(141, 23);
            this.ReqestButtonClient.TabIndex = 6;
            this.ReqestButtonClient.Text = "Подать заявку";
            this.ReqestButtonClient.UseVisualStyleBackColor = true;
            this.ReqestButtonClient.Click += new System.EventHandler(this.ReqestButtonClient_Click);
            // 
            // FIOClientLable
            // 
            this.FIOClientLable.AutoSize = true;
            this.FIOClientLable.Location = new System.Drawing.Point(54, 134);
            this.FIOClientLable.Name = "FIOClientLable";
            this.FIOClientLable.Size = new System.Drawing.Size(42, 17);
            this.FIOClientLable.TabIndex = 5;
            this.FIOClientLable.Text = "ФИО";
            // 
            // LoginClientLable
            // 
            this.LoginClientLable.AutoSize = true;
            this.LoginClientLable.Location = new System.Drawing.Point(51, 93);
            this.LoginClientLable.Name = "LoginClientLable";
            this.LoginClientLable.Size = new System.Drawing.Size(47, 17);
            this.LoginClientLable.TabIndex = 4;
            this.LoginClientLable.Text = "Логин";
            // 
            // ExitClient
            // 
            this.ExitClient.Location = new System.Drawing.Point(136, 45);
            this.ExitClient.Name = "ExitClient";
            this.ExitClient.Size = new System.Drawing.Size(75, 23);
            this.ExitClient.TabIndex = 3;
            this.ExitClient.Text = "Выйти";
            this.ExitClient.UseVisualStyleBackColor = true;
            this.ExitClient.Click += new System.EventHandler(this.ExitClient_Click);
            // 
            // FIOClient
            // 
            this.FIOClient.Location = new System.Drawing.Point(104, 134);
            this.FIOClient.Name = "FIOClient";
            this.FIOClient.Size = new System.Drawing.Size(232, 22);
            this.FIOClient.TabIndex = 2;
            // 
            // LoginClient
            // 
            this.LoginClient.Location = new System.Drawing.Point(104, 93);
            this.LoginClient.Name = "LoginClient";
            this.LoginClient.Size = new System.Drawing.Size(232, 22);
            this.LoginClient.TabIndex = 1;
            // 
            // EnterClient
            // 
            this.EnterClient.Location = new System.Drawing.Point(54, 45);
            this.EnterClient.Name = "EnterClient";
            this.EnterClient.Size = new System.Drawing.Size(75, 23);
            this.EnterClient.TabIndex = 0;
            this.EnterClient.Text = "Войти";
            this.EnterClient.UseVisualStyleBackColor = true;
            this.EnterClient.Click += new System.EventHandler(this.EnterClient_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewCredits);
            this.tabPage2.Controls.Add(this.DeleteCMButton);
            this.tabPage2.Controls.Add(this.DeleteRequestCMButton);
            this.tabPage2.Controls.Add(this.TakeRequestCMButton);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.UpdateCMButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1450, 580);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCredits
            // 
            this.dataGridViewCredits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCredits.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCredits.Location = new System.Drawing.Point(746, 102);
            this.dataGridViewCredits.Name = "dataGridViewCredits";
            this.dataGridViewCredits.RowTemplate.Height = 24;
            this.dataGridViewCredits.Size = new System.Drawing.Size(697, 472);
            this.dataGridViewCredits.TabIndex = 7;
            // 
            // DeleteCMButton
            // 
            this.DeleteCMButton.Location = new System.Drawing.Point(747, 53);
            this.DeleteCMButton.Name = "DeleteCMButton";
            this.DeleteCMButton.Size = new System.Drawing.Size(696, 43);
            this.DeleteCMButton.TabIndex = 6;
            this.DeleteCMButton.Text = "Удалить кредит";
            this.DeleteCMButton.UseVisualStyleBackColor = true;
            this.DeleteCMButton.Click += new System.EventHandler(this.DeleteCMButton_Click);
            // 
            // DeleteRequestCMButton
            // 
            this.DeleteRequestCMButton.Location = new System.Drawing.Point(386, 53);
            this.DeleteRequestCMButton.Name = "DeleteRequestCMButton";
            this.DeleteRequestCMButton.Size = new System.Drawing.Size(354, 43);
            this.DeleteRequestCMButton.TabIndex = 3;
            this.DeleteRequestCMButton.Text = "Отклонить";
            this.DeleteRequestCMButton.UseVisualStyleBackColor = true;
            this.DeleteRequestCMButton.Click += new System.EventHandler(this.DeleteRequestCMButton_Click);
            // 
            // TakeRequestCMButton
            // 
            this.TakeRequestCMButton.Location = new System.Drawing.Point(7, 53);
            this.TakeRequestCMButton.Name = "TakeRequestCMButton";
            this.TakeRequestCMButton.Size = new System.Drawing.Size(373, 43);
            this.TakeRequestCMButton.TabIndex = 2;
            this.TakeRequestCMButton.Text = "Принять";
            this.TakeRequestCMButton.UseVisualStyleBackColor = true;
            this.TakeRequestCMButton.Click += new System.EventHandler(this.TakeRequestCMButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(733, 472);
            this.dataGridView1.TabIndex = 1;
            // 
            // UpdateCMButton
            // 
            this.UpdateCMButton.Location = new System.Drawing.Point(7, 7);
            this.UpdateCMButton.Name = "UpdateCMButton";
            this.UpdateCMButton.Size = new System.Drawing.Size(1436, 44);
            this.UpdateCMButton.TabIndex = 0;
            this.UpdateCMButton.Text = "Обновить";
            this.UpdateCMButton.UseVisualStyleBackColor = true;
            this.UpdateCMButton.Click += new System.EventHandler(this.UpdateCMButton_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1450, 580);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1450, 580);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1450, 580);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.moneyTextBox);
            this.tabPage6.Controls.Add(this.PaymentCreditButton);
            this.tabPage6.Controls.Add(this.dataGridViewCashier);
            this.tabPage6.Controls.Add(this.UpdateCSButton);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1450, 580);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "tabPage6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // UpdateCSButton
            // 
            this.UpdateCSButton.Location = new System.Drawing.Point(7, 7);
            this.UpdateCSButton.Name = "UpdateCSButton";
            this.UpdateCSButton.Size = new System.Drawing.Size(1437, 45);
            this.UpdateCSButton.TabIndex = 0;
            this.UpdateCSButton.Text = "Обновить";
            this.UpdateCSButton.UseVisualStyleBackColor = true;
            this.UpdateCSButton.Click += new System.EventHandler(this.UpdateCSButton_Click);
            // 
            // dataGridViewCashier
            // 
            this.dataGridViewCashier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCashier.Location = new System.Drawing.Point(7, 101);
            this.dataGridViewCashier.Name = "dataGridViewCashier";
            this.dataGridViewCashier.RowTemplate.Height = 24;
            this.dataGridViewCashier.Size = new System.Drawing.Size(1437, 473);
            this.dataGridViewCashier.TabIndex = 1;
            // 
            // PaymentCreditButton
            // 
            this.PaymentCreditButton.Location = new System.Drawing.Point(7, 59);
            this.PaymentCreditButton.Name = "PaymentCreditButton";
            this.PaymentCreditButton.Size = new System.Drawing.Size(137, 36);
            this.PaymentCreditButton.TabIndex = 2;
            this.PaymentCreditButton.Text = "Оплата кредита";
            this.PaymentCreditButton.UseVisualStyleBackColor = true;
            this.PaymentCreditButton.Click += new System.EventHandler(this.PaymentCreditButton_Click);
            // 
            // moneyTextBox
            // 
            this.moneyTextBox.Location = new System.Drawing.Point(150, 66);
            this.moneyTextBox.Name = "moneyTextBox";
            this.moneyTextBox.Size = new System.Drawing.Size(161, 22);
            this.moneyTextBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 633);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCredits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCashier)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.Button EnterClient;
        private System.Windows.Forms.TextBox LoginClient;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button UpdateCMButton;
        private System.Windows.Forms.Button TakeRequestCMButton;
        private System.Windows.Forms.Button DeleteRequestCMButton;
        private System.Windows.Forms.Button DeleteCMButton;
        private System.Windows.Forms.TextBox FIOClient;
        private System.Windows.Forms.Button ExitClient;
        private System.Windows.Forms.Label FIOClientLable;
        private System.Windows.Forms.Label LoginClientLable;
        private System.Windows.Forms.Button ReqestButtonClient;
        private System.Windows.Forms.ComboBox AddRequestBox;
        private System.Windows.Forms.Button GetInfoButtonClient;
        private System.Windows.Forms.Label InfoClient;
        private System.Windows.Forms.DataGridView dataGridViewCredits;
        private System.Windows.Forms.DataGridView dataGridViewCashier;
        private System.Windows.Forms.Button UpdateCSButton;
        private System.Windows.Forms.Button PaymentCreditButton;
        private System.Windows.Forms.TextBox moneyTextBox;
    }
}

