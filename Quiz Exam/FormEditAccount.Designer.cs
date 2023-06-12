namespace Quiz_Exam
{
    partial class FormEditAccount
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
            this.buttonEditAccount = new System.Windows.Forms.Button();
            this.textBoxEditBirthday = new System.Windows.Forms.TextBox();
            this.textBoxEditPass = new System.Windows.Forms.TextBox();
            this.textBoxEditLog = new System.Windows.Forms.TextBox();
            this.labelEditLogin = new System.Windows.Forms.Label();
            this.labelEditPass = new System.Windows.Forms.Label();
            this.labelEditDateBirthday = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEditAccount
            // 
            this.buttonEditAccount.BackColor = System.Drawing.Color.Blue;
            this.buttonEditAccount.FlatAppearance.BorderSize = 0;
            this.buttonEditAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditAccount.ForeColor = System.Drawing.Color.White;
            this.buttonEditAccount.Location = new System.Drawing.Point(372, 273);
            this.buttonEditAccount.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.buttonEditAccount.Name = "buttonEditAccount";
            this.buttonEditAccount.Size = new System.Drawing.Size(414, 60);
            this.buttonEditAccount.TabIndex = 14;
            this.buttonEditAccount.Text = "Обновить данные";
            this.buttonEditAccount.UseVisualStyleBackColor = false;
            this.buttonEditAccount.Click += new System.EventHandler(this.buttonEditAccount_Click);
            // 
            // textBoxEditBirthday
            // 
            this.textBoxEditBirthday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxEditBirthday.Location = new System.Drawing.Point(372, 197);
            this.textBoxEditBirthday.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.textBoxEditBirthday.Name = "textBoxEditBirthday";
            this.textBoxEditBirthday.Size = new System.Drawing.Size(414, 31);
            this.textBoxEditBirthday.TabIndex = 12;
            this.textBoxEditBirthday.Text = "Введите Дату Рождения";
            this.textBoxEditBirthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEditPass
            // 
            this.textBoxEditPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxEditPass.Location = new System.Drawing.Point(372, 114);
            this.textBoxEditPass.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.textBoxEditPass.Name = "textBoxEditPass";
            this.textBoxEditPass.Size = new System.Drawing.Size(414, 31);
            this.textBoxEditPass.TabIndex = 13;
            this.textBoxEditPass.Text = "Введите пароль";
            this.textBoxEditPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxEditLog
            // 
            this.textBoxEditLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxEditLog.Location = new System.Drawing.Point(372, 31);
            this.textBoxEditLog.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.textBoxEditLog.Name = "textBoxEditLog";
            this.textBoxEditLog.Size = new System.Drawing.Size(414, 31);
            this.textBoxEditLog.TabIndex = 11;
            this.textBoxEditLog.Text = "Введите логин";
            this.textBoxEditLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelEditLogin
            // 
            this.labelEditLogin.AutoSize = true;
            this.labelEditLogin.Location = new System.Drawing.Point(26, 37);
            this.labelEditLogin.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEditLogin.Name = "labelEditLogin";
            this.labelEditLogin.Size = new System.Drawing.Size(252, 25);
            this.labelEditLogin.TabIndex = 15;
            this.labelEditLogin.Text = "Редактирование логина";
            // 
            // labelEditPass
            // 
            this.labelEditPass.AutoSize = true;
            this.labelEditPass.Location = new System.Drawing.Point(20, 122);
            this.labelEditPass.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEditPass.Name = "labelEditPass";
            this.labelEditPass.Size = new System.Drawing.Size(255, 25);
            this.labelEditPass.TabIndex = 16;
            this.labelEditPass.Text = "Редактирование пароля";
            // 
            // labelEditDateBirthday
            // 
            this.labelEditDateBirthday.AutoSize = true;
            this.labelEditDateBirthday.Location = new System.Drawing.Point(16, 202);
            this.labelEditDateBirthday.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelEditDateBirthday.Name = "labelEditDateBirthday";
            this.labelEditDateBirthday.Size = new System.Drawing.Size(337, 25);
            this.labelEditDateBirthday.TabIndex = 17;
            this.labelEditDateBirthday.Text = "Редактирование даты рождения";
            // 
            // FormEditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 382);
            this.Controls.Add(this.labelEditDateBirthday);
            this.Controls.Add(this.labelEditPass);
            this.Controls.Add(this.labelEditLogin);
            this.Controls.Add(this.buttonEditAccount);
            this.Controls.Add(this.textBoxEditBirthday);
            this.Controls.Add(this.textBoxEditPass);
            this.Controls.Add(this.textBoxEditLog);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormEditAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование Аккаунта";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEditAccount;
        private System.Windows.Forms.TextBox textBoxEditBirthday;
        private System.Windows.Forms.TextBox textBoxEditPass;
        private System.Windows.Forms.TextBox textBoxEditLog;
        private System.Windows.Forms.Label labelEditLogin;
        private System.Windows.Forms.Label labelEditPass;
        private System.Windows.Forms.Label labelEditDateBirthday;
    }
}