
namespace Bank
{
    partial class RegForm
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
            this.BankNameLabel = new System.Windows.Forms.Label();
            this.RegLogLabel = new System.Windows.Forms.Label();
            this.RegPassLabel = new System.Windows.Forms.Label();
            this.RegFNameLabel = new System.Windows.Forms.Label();
            this.RegLNameLabel = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.FNameTextbox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.LNameTextBox = new System.Windows.Forms.TextBox();
            this.LoginExists = new System.Windows.Forms.Label();
            this.EndRegButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BankNameLabel
            // 
            this.BankNameLabel.AutoSize = true;
            this.BankNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BankNameLabel.ForeColor = System.Drawing.Color.Red;
            this.BankNameLabel.Location = new System.Drawing.Point(556, 50);
            this.BankNameLabel.Name = "BankNameLabel";
            this.BankNameLabel.Size = new System.Drawing.Size(217, 37);
            this.BankNameLabel.TabIndex = 0;
            this.BankNameLabel.Text = "Лол Это Банк";
            // 
            // RegLogLabel
            // 
            this.RegLogLabel.AutoSize = true;
            this.RegLogLabel.Location = new System.Drawing.Point(80, 132);
            this.RegLogLabel.Name = "RegLogLabel";
            this.RegLogLabel.Size = new System.Drawing.Size(38, 13);
            this.RegLogLabel.TabIndex = 1;
            this.RegLogLabel.Text = "Логин";
            // 
            // RegPassLabel
            // 
            this.RegPassLabel.AutoSize = true;
            this.RegPassLabel.Location = new System.Drawing.Point(80, 211);
            this.RegPassLabel.Name = "RegPassLabel";
            this.RegPassLabel.Size = new System.Drawing.Size(45, 13);
            this.RegPassLabel.TabIndex = 2;
            this.RegPassLabel.Text = "Пароль";
            // 
            // RegFNameLabel
            // 
            this.RegFNameLabel.AutoSize = true;
            this.RegFNameLabel.Location = new System.Drawing.Point(488, 132);
            this.RegFNameLabel.Name = "RegFNameLabel";
            this.RegFNameLabel.Size = new System.Drawing.Size(56, 13);
            this.RegFNameLabel.TabIndex = 3;
            this.RegFNameLabel.Text = "Фамилия";
            // 
            // RegLNameLabel
            // 
            this.RegLNameLabel.AutoSize = true;
            this.RegLNameLabel.Location = new System.Drawing.Point(491, 210);
            this.RegLNameLabel.Name = "RegLNameLabel";
            this.RegLNameLabel.Size = new System.Drawing.Size(29, 13);
            this.RegLNameLabel.TabIndex = 4;
            this.RegLNameLabel.Text = "Имя";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Location = new System.Drawing.Point(80, 163);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(100, 20);
            this.LoginTextBox.TabIndex = 5;
            this.LoginTextBox.TextChanged += new System.EventHandler(this.CheckLogin);
            // 
            // FNameTextbox
            // 
            this.FNameTextbox.Location = new System.Drawing.Point(491, 162);
            this.FNameTextbox.Name = "FNameTextbox";
            this.FNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.FNameTextbox.TabIndex = 6;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(80, 242);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 20);
            this.PasswordTextBox.TabIndex = 7;
            // 
            // LNameTextBox
            // 
            this.LNameTextBox.Location = new System.Drawing.Point(491, 241);
            this.LNameTextBox.Name = "LNameTextBox";
            this.LNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LNameTextBox.TabIndex = 8;
            // 
            // LoginExists
            // 
            this.LoginExists.AutoSize = true;
            this.LoginExists.Font = new System.Drawing.Font("Microsoft Sans Serif", 10, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginExists.Location = new System.Drawing.Point(80, 149); 
            this.LoginExists.ForeColor = System.Drawing.Color.Red;
            this.LoginExists.Name = "LoginExists";
            this.LoginExists.Size = new System.Drawing.Size(0, 13);
            this.LoginExists.TabIndex = 9;
            // 
            // EndRegButton
            // 
            this.EndRegButton.Location = new System.Drawing.Point(270, 302);
            this.EndRegButton.Name = "EndRegButton";
            this.EndRegButton.Size = new System.Drawing.Size(253, 46);
            this.EndRegButton.TabIndex = 10;
            this.EndRegButton.Text = "Зарегистрироваться";
            this.EndRegButton.UseVisualStyleBackColor = true;
            this.EndRegButton.Click += new System.EventHandler(this.EndRegButton_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EndRegButton);
            this.Controls.Add(this.LoginExists);
            this.Controls.Add(this.LNameTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.FNameTextbox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.RegLNameLabel);
            this.Controls.Add(this.RegFNameLabel);
            this.Controls.Add(this.RegPassLabel);
            this.Controls.Add(this.RegLogLabel);
            this.Controls.Add(this.BankNameLabel);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BankNameLabel;
        private System.Windows.Forms.Label RegLogLabel;
        private System.Windows.Forms.Label RegPassLabel;
        private System.Windows.Forms.Label RegFNameLabel;
        private System.Windows.Forms.Label RegLNameLabel;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox FNameTextbox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox LNameTextBox;
        private System.Windows.Forms.Label LoginExists;
        private System.Windows.Forms.Button EndRegButton;
    }
}