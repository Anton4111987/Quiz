namespace Quiz_Exam
{
    partial class PlayMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayMenuForm));
            this.buttonStartQuiz = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBoxQuiz = new System.Windows.Forms.ComboBox();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеДанныхПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.играToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьТОП20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрПрошлыхВикторинПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеВикториныToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.groupBoxRadioBTN = new System.Windows.Forms.GroupBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBoxRadioBTN.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStartQuiz
            // 
            this.buttonStartQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonStartQuiz.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartQuiz.Location = new System.Drawing.Point(404, 272);
            this.buttonStartQuiz.Name = "buttonStartQuiz";
            this.buttonStartQuiz.Size = new System.Drawing.Size(326, 47);
            this.buttonStartQuiz.TabIndex = 0;
            this.buttonStartQuiz.Text = "Стартовать новую викторину";
            this.buttonStartQuiz.UseVisualStyleBackColor = false;
            this.buttonStartQuiz.Click += new System.EventHandler(this.buttonStartQuiz_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonExit.Location = new System.Drawing.Point(882, 671);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(117, 46);
            this.buttonExit.TabIndex = 4;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click_1);
            // 
            // comboBoxQuiz
            // 
            this.comboBoxQuiz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxQuiz.ForeColor = System.Drawing.Color.Black;
            this.comboBoxQuiz.FormattingEnabled = true;
            this.comboBoxQuiz.Items.AddRange(new object[] {
            "Планеты",
            "География",
            "История",
            "Природа",
            "Смешанная"});
            this.comboBoxQuiz.Location = new System.Drawing.Point(404, 352);
            this.comboBoxQuiz.Name = "comboBoxQuiz";
            this.comboBoxQuiz.Size = new System.Drawing.Size(326, 37);
            this.comboBoxQuiz.TabIndex = 5;
            this.comboBoxQuiz.Text = "Выберите категорию";
            this.comboBoxQuiz.Visible = false;
            this.comboBoxQuiz.SelectedIndexChanged += new System.EventHandler(this.comboBoxQuiz_SelectedIndexChanged);
            // 
            // labelQuestion
            // 
            this.labelQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.BackColor = System.Drawing.Color.Transparent;
            this.labelQuestion.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.ForeColor = System.Drawing.Color.Navy;
            this.labelQuestion.Location = new System.Drawing.Point(498, 208);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(132, 38);
            this.labelQuestion.TabIndex = 7;
            this.labelQuestion.Text = "Вопросы";
            this.labelQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelQuestion.Visible = false;
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnswer.Location = new System.Drawing.Point(479, 656);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(161, 48);
            this.buttonAnswer.TabIndex = 8;
            this.buttonAnswer.Text = "Ответить";
            this.buttonAnswer.UseVisualStyleBackColor = true;
            this.buttonAnswer.Visible = false;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.играToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.справкаToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1132, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактированиеДанныхПользователяToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // редактированиеДанныхПользователяToolStripMenuItem
            // 
            this.редактированиеДанныхПользователяToolStripMenuItem.Name = "редактированиеДанныхПользователяToolStripMenuItem";
            this.редактированиеДанныхПользователяToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.редактированиеДанныхПользователяToolStripMenuItem.Text = "Редактирование данных пользователя";
            this.редактированиеДанныхПользователяToolStripMenuItem.Click += new System.EventHandler(this.редактированиеДанныхПользователяToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(285, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // играToolStripMenuItem
            // 
            this.играToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.посмотретьТОП20ToolStripMenuItem,
            this.просмотрПрошлыхВикторинПользователяToolStripMenuItem});
            this.играToolStripMenuItem.Name = "играToolStripMenuItem";
            this.играToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.играToolStripMenuItem.Text = "Игра";
            // 
            // посмотретьТОП20ToolStripMenuItem
            // 
            this.посмотретьТОП20ToolStripMenuItem.Name = "посмотретьТОП20ToolStripMenuItem";
            this.посмотретьТОП20ToolStripMenuItem.Size = new System.Drawing.Size(321, 22);
            this.посмотретьТОП20ToolStripMenuItem.Text = "Посмотреть ТОП-20";
            this.посмотретьТОП20ToolStripMenuItem.Click += new System.EventHandler(this.посмотретьТОП20ToolStripMenuItem_Click);
            // 
            // просмотрПрошлыхВикторинПользователяToolStripMenuItem
            // 
            this.просмотрПрошлыхВикторинПользователяToolStripMenuItem.Name = "просмотрПрошлыхВикторинПользователяToolStripMenuItem";
            this.просмотрПрошлыхВикторинПользователяToolStripMenuItem.Size = new System.Drawing.Size(321, 22);
            this.просмотрПрошлыхВикторинПользователяToolStripMenuItem.Text = "Просмотр прошлых викторин пользователя";
            this.просмотрПрошлыхВикторинПользователяToolStripMenuItem.Click += new System.EventHandler(this.просмотрПрошлыхВикторинПользователяToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.редактированиеВикториныToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.справкаToolStripMenuItem.Text = "Администратор";
            // 
            // редактированиеВикториныToolStripMenuItem
            // 
            this.редактированиеВикториныToolStripMenuItem.Name = "редактированиеВикториныToolStripMenuItem";
            this.редактированиеВикториныToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.редактированиеВикториныToolStripMenuItem.Text = "Редактирование викторины";
            this.редактированиеВикториныToolStripMenuItem.Click += new System.EventHandler(this.редактированиеВикториныToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem1
            // 
            this.справкаToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem1.Name = "справкаToolStripMenuItem1";
            this.справкаToolStripMenuItem1.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem1.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе...";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(57, 43);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(157, 33);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(57, 91);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(161, 33);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(57, 139);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(161, 33);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(57, 187);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(161, 33);
            this.radioButton4.TabIndex = 15;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // groupBoxRadioBTN
            // 
            this.groupBoxRadioBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxRadioBTN.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxRadioBTN.Controls.Add(this.radioButton1);
            this.groupBoxRadioBTN.Controls.Add(this.radioButton2);
            this.groupBoxRadioBTN.Controls.Add(this.radioButton3);
            this.groupBoxRadioBTN.Controls.Add(this.radioButton4);
            this.groupBoxRadioBTN.Location = new System.Drawing.Point(365, 395);
            this.groupBoxRadioBTN.Name = "groupBoxRadioBTN";
            this.groupBoxRadioBTN.Size = new System.Drawing.Size(404, 249);
            this.groupBoxRadioBTN.TabIndex = 18;
            this.groupBoxRadioBTN.TabStop = false;
            this.groupBoxRadioBTN.Text = "Варианты ответов:";
            this.groupBoxRadioBTN.Visible = false;
            // 
            // labelCategory
            // 
            this.labelCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCategory.AutoSize = true;
            this.labelCategory.BackColor = System.Drawing.Color.Transparent;
            this.labelCategory.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCategory.ForeColor = System.Drawing.Color.Lime;
            this.labelCategory.Location = new System.Drawing.Point(397, 72);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(325, 40);
            this.labelCategory.TabIndex = 19;
            this.labelCategory.Text = "Категория викторины";
            this.labelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCategory.Visible = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.BackColor = System.Drawing.Color.Transparent;
            this.labelLogin.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(61, 688);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(64, 30);
            this.labelLogin.TabIndex = 20;
            this.labelLogin.Text = "Login";
            // 
            // PlayMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1132, 769);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.groupBoxRadioBTN);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.buttonAnswer);
            this.Controls.Add(this.labelQuestion);
            this.Controls.Add(this.comboBoxQuiz);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonStartQuiz);
            this.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "PlayMenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Викторина (Quiz)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayMenuForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxRadioBTN.ResumeLayout(false);
            this.groupBoxRadioBTN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStartQuiz;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ComboBox comboBoxQuiz;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеДанныхПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem играToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьТОП20ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрПрошлыхВикторинПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеВикториныToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.GroupBox groupBoxRadioBTN;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}