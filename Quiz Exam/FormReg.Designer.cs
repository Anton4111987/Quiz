namespace Quiz_Exam
{
    partial class FormReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReg));
            this.buttonReg = new System.Windows.Forms.Button();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxBirthday = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.Blue;
            this.buttonReg.FlatAppearance.BorderSize = 0;
            this.buttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReg.ForeColor = System.Drawing.Color.White;
            this.buttonReg.Location = new System.Drawing.Point(182, 234);
            this.buttonReg.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(377, 58);
            this.buttonReg.TabIndex = 10;
            this.buttonReg.Text = "Регистрация";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxPass.Location = new System.Drawing.Point(182, 132);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(377, 37);
            this.textBoxPass.TabIndex = 9;
            this.textBoxPass.Text = "Введите пароль";
            this.textBoxPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPass.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxPass_MouseClick);
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBoxPass_TextChanged);
            // 
            // textBoxLog
            // 
            this.textBoxLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxLog.Location = new System.Drawing.Point(182, 81);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(377, 37);
            this.textBoxLog.TabIndex = 8;
            this.textBoxLog.Text = "Введите логин";
            this.textBoxLog.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLog.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxLog_MouseClick);
            this.textBoxLog.TextChanged += new System.EventHandler(this.textBoxLog_TextChanged);
            // 
            // textBoxBirthday
            // 
            this.textBoxBirthday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBoxBirthday.Location = new System.Drawing.Point(182, 183);
            this.textBoxBirthday.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.textBoxBirthday.Name = "textBoxBirthday";
            this.textBoxBirthday.Size = new System.Drawing.Size(377, 37);
            this.textBoxBirthday.TabIndex = 9;
            this.textBoxBirthday.Text = "Введите Дату Рождения";
            this.textBoxBirthday.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxBirthday.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBoxBithdday_MouseClick);
            this.textBoxBirthday.TextChanged += new System.EventHandler(this.textBoxBirthday_TextChanged);
            // 
            // FormReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Quiz_Exam.Properties.Resources._5000;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 336);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.textBoxBirthday);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxLog);
            this.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "FormReg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.FormReg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxBirthday;
    }
}