
namespace Bank
{
    partial class Account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AccountTabControl = new System.Windows.Forms.TabControl();
            this.AccountControlPage = new System.Windows.Forms.TabPage();
            this.TransferLabel = new System.Windows.Forms.Label();
            this.CurrentBalanceLabel = new System.Windows.Forms.Label();
            this.TransferTextBox = new System.Windows.Forms.TextBox();
            this.RemoveTextBox = new System.Windows.Forms.TextBox();
            this.TransferButton = new System.Windows.Forms.Button();
            this.TransferComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.CloseAccontButton = new System.Windows.Forms.Button();
            this.SelectAccountCombobox = new System.Windows.Forms.ComboBox();
            this.BankLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NewAccountPage = new System.Windows.Forms.TabPage();
            this.AccountNameTextBox = new System.Windows.Forms.TextBox();
            this.AccountName = new System.Windows.Forms.Label();
            this.CreateAccountButton = new System.Windows.Forms.Button();
            this.HistoryPage = new System.Windows.Forms.TabPage();
            this.HistoryRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AccountTabControl.SuspendLayout();
            this.AccountControlPage.SuspendLayout();
            this.NewAccountPage.SuspendLayout();
            this.HistoryPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccountTabControl
            // 
            this.AccountTabControl.Controls.Add(this.AccountControlPage);
            this.AccountTabControl.Controls.Add(this.NewAccountPage);
            this.AccountTabControl.Controls.Add(this.HistoryPage);
            this.AccountTabControl.Location = new System.Drawing.Point(0, 0);
            this.AccountTabControl.Name = "AccountTabControl";
            this.AccountTabControl.SelectedIndex = 0;
            this.AccountTabControl.Size = new System.Drawing.Size(802, 454);
            this.AccountTabControl.TabIndex = 0;
            // 
            // AccountControlPage
            // 
            this.AccountControlPage.Controls.Add(this.TransferLabel);
            this.AccountControlPage.Controls.Add(this.CurrentBalanceLabel);
            this.AccountControlPage.Controls.Add(this.TransferTextBox);
            this.AccountControlPage.Controls.Add(this.RemoveTextBox);
            this.AccountControlPage.Controls.Add(this.TransferButton);
            this.AccountControlPage.Controls.Add(this.TransferComboBox);
            this.AccountControlPage.Controls.Add(this.AddButton);
            this.AccountControlPage.Controls.Add(this.RemoveButton);
            this.AccountControlPage.Controls.Add(this.AddTextBox);
            this.AccountControlPage.Controls.Add(this.CloseAccontButton);
            this.AccountControlPage.Controls.Add(this.SelectAccountCombobox);
            this.AccountControlPage.Controls.Add(this.BankLabel);
            this.AccountControlPage.Controls.Add(this.NameLabel);
            this.AccountControlPage.Location = new System.Drawing.Point(4, 22);
            this.AccountControlPage.Name = "AccountControlPage";
            this.AccountControlPage.Padding = new System.Windows.Forms.Padding(3);
            this.AccountControlPage.Size = new System.Drawing.Size(794, 428);
            this.AccountControlPage.TabIndex = 0;
            this.AccountControlPage.Text = "Управление счетами";
            this.AccountControlPage.UseVisualStyleBackColor = true;
            // 
            // TransferLabel
            // 
            this.TransferLabel.AutoSize = true;
            this.TransferLabel.Location = new System.Drawing.Point(403, 297);
            this.TransferLabel.Name = "TransferLabel";
            this.TransferLabel.Size = new System.Drawing.Size(0, 13);
            this.TransferLabel.TabIndex = 12;
            // 
            // CurrentBalanceLabel
            // 
            this.CurrentBalanceLabel.AutoSize = true;
            this.CurrentBalanceLabel.Location = new System.Drawing.Point(290, 92);
            this.CurrentBalanceLabel.Name = "CurrentBalanceLabel";
            this.CurrentBalanceLabel.Size = new System.Drawing.Size(0, 13);
            this.CurrentBalanceLabel.TabIndex = 11;
            // 
            // TransferTextBox
            // 
            this.TransferTextBox.Location = new System.Drawing.Point(39, 316);
            this.TransferTextBox.Name = "TransferTextBox";
            this.TransferTextBox.Size = new System.Drawing.Size(184, 20);
            this.TransferTextBox.TabIndex = 10;
            // 
            // RemoveTextBox
            // 
            this.RemoveTextBox.Location = new System.Drawing.Point(39, 262);
            this.RemoveTextBox.Name = "RemoveTextBox";
            this.RemoveTextBox.Size = new System.Drawing.Size(184, 20);
            this.RemoveTextBox.TabIndex = 9;
            // 
            // TransferButton
            // 
            this.TransferButton.Location = new System.Drawing.Point(595, 313);
            this.TransferButton.Name = "TransferButton";
            this.TransferButton.Size = new System.Drawing.Size(132, 23);
            this.TransferButton.TabIndex = 8;
            this.TransferButton.Text = "Перевести";
            this.TransferButton.UseVisualStyleBackColor = true;
            this.TransferButton.Click += new System.EventHandler(this.TransferButton_Click);
            // 
            // TransferComboBox
            // 
            this.TransferComboBox.FormattingEnabled = true;
            this.TransferComboBox.Location = new System.Drawing.Point(403, 316);
            this.TransferComboBox.Name = "TransferComboBox";
            this.TransferComboBox.Size = new System.Drawing.Size(121, 21);
            this.TransferComboBox.TabIndex = 7;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(403, 191);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 23);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(403, 260);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(121, 23);
            this.RemoveButton.TabIndex = 5;
            this.RemoveButton.Text = "Убавить";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(39, 195);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(184, 20);
            this.AddTextBox.TabIndex = 4;
            // 
            // CloseAccontButton
            // 
            this.CloseAccontButton.Location = new System.Drawing.Point(403, 92);
            this.CloseAccontButton.Name = "CloseAccontButton";
            this.CloseAccontButton.Size = new System.Drawing.Size(121, 23);
            this.CloseAccontButton.TabIndex = 3;
            this.CloseAccontButton.Text = "Закрыть счёт";
            this.CloseAccontButton.UseVisualStyleBackColor = true;
            this.CloseAccontButton.Click += new System.EventHandler(this.CloseAccontButton_Click);
            // 
            // SelectAccountCombobox
            // 
            this.SelectAccountCombobox.FormattingEnabled = true;
            this.SelectAccountCombobox.Location = new System.Drawing.Point(39, 92);
            this.SelectAccountCombobox.Name = "SelectAccountCombobox";
            this.SelectAccountCombobox.Size = new System.Drawing.Size(184, 21);
            this.SelectAccountCombobox.TabIndex = 2;
            // 
            // BankLabel
            // 
            this.BankLabel.AutoSize = true;
            this.BankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankLabel.ForeColor = System.Drawing.Color.Red;
            this.BankLabel.Location = new System.Drawing.Point(556, 29);
            this.BankLabel.Name = "BankLabel";
            this.BankLabel.Size = new System.Drawing.Size(211, 35);
            this.BankLabel.TabIndex = 1;
            this.BankLabel.Text = "Лол Это Банк";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(36, 29);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(0, 13);
            this.NameLabel.TabIndex = 0;
            // 
            // NewAccountPage
            // 
            this.NewAccountPage.Controls.Add(this.AccountNameTextBox);
            this.NewAccountPage.Controls.Add(this.AccountName);
            this.NewAccountPage.Controls.Add(this.CreateAccountButton);
            this.NewAccountPage.Location = new System.Drawing.Point(4, 22);
            this.NewAccountPage.Name = "NewAccountPage";
            this.NewAccountPage.Padding = new System.Windows.Forms.Padding(3);
            this.NewAccountPage.Size = new System.Drawing.Size(794, 428);
            this.NewAccountPage.TabIndex = 2;
            this.NewAccountPage.Text = "Создание счёта";
            this.NewAccountPage.UseVisualStyleBackColor = true;
            // 
            // AccountNameTextBox
            // 
            this.AccountNameTextBox.Location = new System.Drawing.Point(59, 129);
            this.AccountNameTextBox.Name = "AccountNameTextBox";
            this.AccountNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.AccountNameTextBox.TabIndex = 2;
            // 
            // AccountName
            // 
            this.AccountName.AutoSize = true;
            this.AccountName.Location = new System.Drawing.Point(56, 90);
            this.AccountName.Name = "AccountName";
            this.AccountName.Size = new System.Drawing.Size(88, 13);
            this.AccountName.TabIndex = 1;
            this.AccountName.Text = "Название счёта";
            // 
            // CreateAccountButton
            // 
            this.CreateAccountButton.Location = new System.Drawing.Point(380, 129);
            this.CreateAccountButton.Name = "CreateAccountButton";
            this.CreateAccountButton.Size = new System.Drawing.Size(75, 23);
            this.CreateAccountButton.TabIndex = 0;
            this.CreateAccountButton.Text = "Создать счёт";
            this.CreateAccountButton.UseVisualStyleBackColor = true;
            this.CreateAccountButton.Click += new System.EventHandler(this.CreateAccountButton_Click);
            // 
            // HistoryPage
            // 
            this.HistoryPage.Controls.Add(this.HistoryRichTextBox);
            this.HistoryPage.Location = new System.Drawing.Point(4, 22);
            this.HistoryPage.Name = "HistoryPage";
            this.HistoryPage.Padding = new System.Windows.Forms.Padding(3);
            this.HistoryPage.Size = new System.Drawing.Size(794, 428);
            this.HistoryPage.TabIndex = 1;
            this.HistoryPage.Text = "История операций";
            this.HistoryPage.UseVisualStyleBackColor = true;
            // 
            // HistoryRichTextBox
            // 
            this.HistoryRichTextBox.Location = new System.Drawing.Point(4, 7);
            this.HistoryRichTextBox.Name = "HistoryRichTextBox";
            this.HistoryRichTextBox.Size = new System.Drawing.Size(790, 418);
            this.HistoryRichTextBox.TabIndex = 0;
            this.HistoryRichTextBox.Text = "";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AccountTabControl);
            this.Name = "Account";
            this.Text = "Account";
            this.AccountTabControl.ResumeLayout(false);
            this.AccountControlPage.ResumeLayout(false);
            this.AccountControlPage.PerformLayout();
            this.NewAccountPage.ResumeLayout(false);
            this.NewAccountPage.PerformLayout();
            this.HistoryPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AccountTabControl;
        private System.Windows.Forms.TabPage AccountControlPage;
        private System.Windows.Forms.TabPage HistoryPage;
        private System.Windows.Forms.Label BankLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label TransferLabel;
        private System.Windows.Forms.Label CurrentBalanceLabel;
        private System.Windows.Forms.TextBox TransferTextBox;
        private System.Windows.Forms.TextBox RemoveTextBox;
        private System.Windows.Forms.Button TransferButton;
        private System.Windows.Forms.ComboBox TransferComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Button CloseAccontButton;
        private System.Windows.Forms.ComboBox SelectAccountCombobox;
        private System.Windows.Forms.TabPage NewAccountPage;
        private System.Windows.Forms.TextBox AccountNameTextBox;
        private System.Windows.Forms.Label AccountName;
        private System.Windows.Forms.Button CreateAccountButton;
        private System.Windows.Forms.RichTextBox HistoryRichTextBox;
    }
}